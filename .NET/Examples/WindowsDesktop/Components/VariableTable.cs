using Equin.ApplicationFramework;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UnderAutomation.Fanuc.MemoryAccess.Files;
using System.Linq;

public partial class VariableTable : UserControl
{
    public VariableTable()
    {
        InitializeComponent();
    }


    private IGenericVariableType _root;
    private IGenericVariableType _current;


    public void Show(IGenericVariableType root)
    {
        _root = root;
        InternalShow(root);
    }


    public void InternalShow(IGenericVariableType element)
    {
        _current = element;
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
                    var rootLink = new LinkLabel() { Text = parent.Name, AutoSize = true, Margin=Padding.Empty, Padding=Padding.Empty };

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

    private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex > 1) return; // only consider Name column for simple click
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

}
