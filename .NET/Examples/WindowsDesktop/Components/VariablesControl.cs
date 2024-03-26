using System.IO;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.MemoryAccess;
using UnderAutomation.Fanuc.MemoryAccess.Variables;

public partial class VariablesControl : UserControl, IUserControl
{
    FanucRobot _robot;


    public VariablesControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();
        variableTable.SetRobot(robot);
    }

    #region IUserControl
    public string Title => "Variables";

    public bool FeatureEnabled => _robot.MemoryAccess.Connected;

    public void PeriodicUpdate()
    {
        tsReadAll.Enabled = _robot.MemoryAccess.Connected;
        variableTable.PeriodicUpdate();
    }

    public void OnClose()
    {
    }

    public void OnOpen()
    {
    }

    #endregion

    private void tsOpenFileFromDisc_Click(object sender, System.EventArgs e)
    {
        dlgOpenFile.InitialDirectory = Path.Combine(Path.GetDirectoryName(this.GetType().Assembly.Location), "Files");

        if (dlgOpenFile.ShowDialog() != DialogResult.OK || dlgOpenFile.FileNames.Length == 0) return;

        if (dlgOpenFile.FileNames.Length == 1)
        {
            variableTable.Show(FanucFileReaders.VariableReader.ReadFile(dlgOpenFile.FileNames[0]));
        }
        else
        {
            var variableFileList = new VariableFileList() { Name = "Files" };

            foreach (var file in dlgOpenFile.FileNames)
            {
                var fileContent = FanucFileReaders.VariableReader.ReadFile(file);
                variableFileList.Add(fileContent);
            }

            variableTable.Show(variableFileList);
        }
    }

    private void tsOpenFolderFromDisc_Click(object sender, System.EventArgs e)
    {
        dlgOpenFolder.SelectedPath = Path.Combine(Path.GetDirectoryName(this.GetType().Assembly.Location), "Files");

        if (dlgOpenFolder.ShowDialog() != DialogResult.OK) return;

        var variableFileList = new VariableFileList() { Name = Path.GetFileName(dlgOpenFolder.SelectedPath) };

        foreach (var file in Directory.GetFiles(dlgOpenFolder.SelectedPath, "*.va"))
        {
            var fileContent = FanucFileReaders.VariableReader.ReadFile(file);
            variableFileList.Add(fileContent);
        }

        variableTable.Show(variableFileList);
    }

    private void tsReadAll_ButtonClick(object sender, System.EventArgs e)
    {
        var frm = new LoadVariableProgressForm();
        frm.Show(this);
        try
        {
            variableTable.Show(_robot.MemoryAccess.GetAllVariables(p => frm.OnProgress(p)));
        }
        finally
        {
            frm.Close();
        }
    }

    private void tsReadSelected_Click(object sender, System.EventArgs e)
    {
        var files = _robot.MemoryAccess.EnumerateVariableFiles();
        var frmSelct = new SelectVariablesForm(files);
        if (frmSelct.ShowDialog() == DialogResult.OK)
        {
            var fileList = new VariableFileList() { Name = "Selected variables" };
            var frm = new LoadVariableProgressForm();
            frm.Show(this);
            try
            {
                for (var i = 0; i < frmSelct.SelectedItems.Length; i++)
                {
                    var progress = i * 100.0 / frmSelct.SelectedItems.Length;
                    frm.OnProgress(progress);
                    fileList.Add(_robot.MemoryAccess.GetVariablesFromFile(frmSelct.SelectedItems[i]));
                }
                variableTable.Show(fileList);
            }
            finally
            {
                frm.Close();
            }
        }

    }
}

