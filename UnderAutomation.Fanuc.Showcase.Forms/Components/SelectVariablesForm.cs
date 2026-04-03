using UnderAutomation.Fanuc.Ftp;

public partial class SelectVariablesForm : Form
{
    public SelectVariablesForm(string[] items)
    {
        InitializeComponent();

        lst.Items.Clear();

        var CheckedVariableFiles = Config.Current.CheckedVariableFiles ?? new string[0];

        foreach (var item in items)
        {
            lst.Items.Add(item, CheckedVariableFiles.Contains(item));
        }
    }

    public string[] SelectedItems => lst.SelectedItems.OfType<string>().ToArray();

    private void btnOK_Click(object sender, EventArgs e)
    {
        Config.Current.CheckedVariableFiles = SelectedItems;
        Config.Save();
    }
}
