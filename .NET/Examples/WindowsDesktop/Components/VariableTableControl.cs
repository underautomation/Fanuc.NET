using Equin.ApplicationFramework;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.MemoryAccess;
using UnderAutomation.Fanuc.MemoryAccess.Variables;

public partial class VariableTableControl : UserControl
{

    public VariableTableControl()
    {
        TypeDescriptor.AddAttributes(typeof(IGenericVariableType), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(IGenericVariableType), new ReadOnlyAttribute(true));

        InitializeComponent();
        Show(null);
    }

    private FanucRobot _robot;
    public void SetRobot(FanucRobot robot)
    {
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
                var hierarchy = element.GetAncestors();

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
        var connected = _robot.RemoteCommands.Connected;
        btnWrite.Enabled = connected;
        txtWriteInfo.Visible = !connected;
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
        var result = _robot?.RemoteCommands.SetVariable(txtVariableName.Text, txtNewValue.Text);

        if (_current is null) return;

        var ancestors = _current.GetAncestors();

        GenericVariableFile updatedFile = null;

        IGenericVariableType updatedElement = null;


        foreach (var ancestor in ancestors.Concat(new[] { _current }))
        {
            if (ancestor is GenericVariableFile)
            {
                var formerFile = (GenericVariableFile)ancestor;
                updatedFile = _robot.MemoryAccess.GetVariablesFromFile(formerFile.Name);

                // replace former file with the new one
                var fileList = formerFile.Parent as VariableFileList;
                if (fileList is object)
                {
                    fileList.Remove(formerFile);
                    fileList.Add(updatedFile);
                }

                updatedElement = updatedFile;
            }
            else if(updatedElement is object)
            {
                // once updatedFile has been set, continue hierarchy to find displayed value
                updatedElement = updatedElement.GetField(ancestor.Name);
            }
        }

        if(updatedElement is object)
        {
            InternalShow(updatedElement);
        }


    }
}
