using Equin.ApplicationFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.MemoryAccess.Files;

public partial class VariableTableControl : UserControl
{

    public VariableTableControl()
    {
        InitializeComponent();
        Show(null);
    }

    private FanucRobot _robot;
    public void SetRobot(FanucRobot robot)
    {
        TypeDescriptor.AddAttributes(typeof(object), new TypeConverterAttribute(typeof(ObjectConverter)));
        _robot = robot;
    }

    private IGenericVariableType _current;

    public void Show(IGenericVariableType root)
    {
        InternalShow(root);
    }


    public void InternalShow(IGenericVariableType element)
    {
        _current = element;
        propertyGrid.SelectedObject = element;

        HandleWritePanel(element as GenericValue);
        bindingSource.DataSource = new BindingListView<GenericField>(element?.Fields);

        txtSearch.SuspendLayout();
        txtSearch.Enabled = false;
        txtSearch.Text = "";
        txtSearch.Enabled = true;
        txtSearch.ResumeLayout();

        try
        {
            pnlNav.SuspendLayout();
            pnlNav.Controls.Clear();

            if (element is object)
            {
                var hierarchy = new List<IGenericVariableType>();

                var current = element.Parent;

                while (current is object)
                {
                    hierarchy.Add(current);
                    current = current.Parent;
                }

                hierarchy.Reverse();

                foreach (var parent in hierarchy)
                {
                    var rootLink = new LinkLabel() { Text = parent.Name, AutoSize = true, Margin = Padding.Empty, Padding = Padding.Empty };

                    rootLink.Click += (o, e) => Show(parent);
                    pnlNav.Controls.Add(rootLink);
                    pnlNav.Controls.Add(new Label() { Text = ">", AutoSize = true, Margin = Padding.Empty, Padding = Padding.Empty });
                }

                pnlNav.Controls.Add(new Label() { Text = element.Name, AutoSize = true, Margin = Padding.Empty, Padding = Padding.Empty });
            }

        }
        finally
        {
            pnlNav.ResumeLayout();
        }
    }

    public void PeriodicUpdate()
    {
        btnWrite.Enabled = _robot.RemoteCommands.Connected;
    }

    private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex > 0) return; // only consider Name column for simple click
        SelectRow(e.RowIndex);
    }

    private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        SelectRow(e.RowIndex);
    }

    private void SelectRow(int rowIndex)
    {
        if (_current?.Fields is null) return;

        if (rowIndex < 0 || rowIndex >= grid.Rows.Count) return;

        var cellContent = grid.Rows[rowIndex].Cells[0].Value?.ToString();

        if (string.IsNullOrEmpty(cellContent)) return;

        Show(_current.Fields.FirstOrDefault(x => string.Equals(x.Name, cellContent, StringComparison.InvariantCultureIgnoreCase)));
    }

    private void txtSearch_TextChanged(object sender, System.EventArgs e)
    {
        if (!txtSearch.Enabled) return;
        (bindingSource.DataSource as BindingListView<GenericField>)?.ApplyFilter(x => x.Name.IndexOf(txtSearch.Text, StringComparison.InvariantCultureIgnoreCase) >= 0);
    }

    private void grid_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
        if (_current?.Fields is null) return;

        if (e.RowIndex < 0 || e.RowIndex >= grid.Rows.Count) return;

        var cellContent = grid.Rows[e.RowIndex].Cells[0].Value?.ToString();

        if (string.IsNullOrEmpty(cellContent)) return;

        propertyGrid.SelectedObject = _current.Fields.FirstOrDefault(x => string.Equals(x.Name, cellContent, StringComparison.InvariantCultureIgnoreCase)); ;

    }


    private void HandleWritePanel(GenericValue genericValue)
    {
        pnlWrite.Visible = genericValue is object && genericValue.Kind == ValueKind.Value;
        txtValue.Text = genericValue?.Value;
        txtNewValue.Text = (genericValue?.IsUninitialized).GetValueOrDefault() ? "" : txtValue.Text;
        txtVariableName.Text = genericValue?.FullName;
    }

    private void btnWrite_Click(object sender, EventArgs e)
    {
        _robot?.RemoteCommands.SetVariable(txtVariableName.Text, txtNewValue.Text);
    }
}
