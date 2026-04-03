using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common.Files;
using UnderAutomation.Fanuc.Common.Files.Variables;

public partial class VariablesControl : UserControl, IUserControl
{
    FanucRobot _robot;

    private const int PROTOCOL_CGTP = 0;
    private const int PROTOCOL_FTP = 1;


    public VariablesControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();
        tsProtocol.SelectedIndex = PROTOCOL_CGTP;
    }

    bool CgtpSelected => tsProtocol.SelectedIndex == PROTOCOL_CGTP;

    #region IUserControl
    public string Title => "Variables (CGTP or FTP)";

    public bool FeatureEnabled => _robot.Ftp.Connected || _robot.Cgtp.Enabled;

    public void PeriodicUpdate()
    {
        tsReadAll.Enabled = FeatureEnabled;
        variableTable.PeriodicUpdate();
    }

    public void OnClose()
    {
    }

    public void OnOpen()
    {
        if (_robot.Ftp.Connected && !_robot.Cgtp.Enabled)
            tsProtocol.SelectedIndex = PROTOCOL_FTP;
        else if (_robot.Cgtp.Enabled && !_robot.Ftp.Connected)
            tsProtocol.SelectedIndex = PROTOCOL_CGTP;
    }

    #endregion

    private void tsOpenFileFromDisc_Click(object sender, System.EventArgs e)
    {
        dlgOpenFile.InitialDirectory = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), "Files");

        if (dlgOpenFile.ShowDialog() != DialogResult.OK || dlgOpenFile.FileNames.Length == 0) return;

        if (dlgOpenFile.FileNames.Length == 1)
        {
            variableTable.Show(FanucFileReaders.VariableReader.ReadFile(dlgOpenFile.FileNames[0], ConnectControl.GetSelectedLanguage()));
        }
        else
        {
            var variableFileList = new VariableFileList() { Name = "Files" };

            foreach (var file in dlgOpenFile.FileNames)
            {
                var fileContent = FanucFileReaders.VariableReader.ReadFile(file, ConnectControl.GetSelectedLanguage());
                variableFileList.Add(fileContent);
            }

            variableTable.Show(variableFileList);
        }
    }

    private void tsOpenFolderFromDisc_Click(object sender, System.EventArgs e)
    {
        dlgOpenFolder.SelectedPath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), "Files");

        if (dlgOpenFolder.ShowDialog() != DialogResult.OK) return;

        var variableFileList = new VariableFileList() { Name = Path.GetFileName(dlgOpenFolder.SelectedPath) };

        foreach (var file in Directory.GetFiles(dlgOpenFolder.SelectedPath, "*.va"))
        {
            var fileContent = FanucFileReaders.VariableReader.ReadFile(file, ConnectControl.GetSelectedLanguage());
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
            FileClientBase client = CgtpSelected ? _robot.Cgtp.Http : _robot.Ftp;

            variableTable.Show(client.GetAllVariables(p => frm.OnProgress(p)));
        }
        finally
        {
            frm.Close();
        }
    }

    private void tsReadSelected_Click(object sender, System.EventArgs e)
    {
        string[] files;

        if (CgtpSelected)
            files = _robot.Cgtp.Http.ListVariableFiles().Select(f => f.AsciiFile).Where(n => !string.IsNullOrEmpty(n)).ToArray();
        else
            files = _robot.Ftp.EnumerateVariableFiles().Select(f => f.Name).ToArray();

        var frmSelct = new SelectVariablesForm(files);
        if (frmSelct.ShowDialog() == DialogResult.OK)
        {
            var fileList = new VariableFileList() { Name = "Selected variables" };
            var frm = new LoadVariableProgressForm();
            frm.Show(this);
            try
            {
                FileClientBase client = CgtpSelected ? _robot.Cgtp.Http : _robot.Ftp;

                for (var i = 0; i < frmSelct.SelectedItems.Length; i++)
                {
                    var progress = i * 100.0 / frmSelct.SelectedItems.Length;
                    frm.OnProgress(progress);
                    fileList.Add(client.GetVariablesFromFile(frmSelct.SelectedItems[i]));
                }
                variableTable.Show(fileList);
            }
            finally
            {
                frm.Close();
            }
        }

    }

    private void tsProtocol_SelectedIndexChanged(object sender, EventArgs e)
    {
        variableTable.SetRobot(_robot, CgtpSelected ? _robot.Cgtp.Http : _robot.Ftp);
    }
}

