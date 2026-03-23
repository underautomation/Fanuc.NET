using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Cgtp;

public partial class CgtpControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public CgtpControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        cbProgramType.Items.Add(ProgramSubType.None);
        cbProgramType.Items.Add(ProgramSubType.Macro);

        cbNewProgramType.Items.Add(ProgramSubType.None);
        cbNewProgramType.Items.Add(ProgramSubType.Macro);
        cbNewProgramType.SelectedIndex = 0;

    }

    #region IUserControl
    public string Title => "CGTP";

    public bool FeatureEnabled => _robot.Cgtp.Enabled;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen()
    {

    }

    #endregion

    #region Programs

    private void btnSelectProgramLine_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SelectProgram(txtProgram.Text, (int)udProgramLine.Value);
    }

    private void btnStartProgram_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.RunProgram(txtProgram.Text, (int)udProgramLine.Value);
    }

    private void btnDeleteProgram_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show($"Are you sure you want to delete program {txtProgram.Text}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            _robot.Cgtp.DeleteProgram(txtProgram.Text);
    }

    private void btnCreateProgram_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.CreateProgram(txtNewProgramName.Text, txtNewProgramOwner.Text, txtNewProgramComment.Text, (int)udNEwProgramGroup.Value, (ProgramSubType)cbNewProgramType.SelectedItem);
    }

    private void btnRenameProgram_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show($"Are you sure you want to rename program {txtProgram.Text} to {txtProgramNewName.Text}?", "Confirm Rename", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            _robot.Cgtp.RenameProgram(txtProgram.Text, txtProgramNewName.Text);
            txtProgram.Text = txtProgramNewName.Text;
        }
    }

    private void btnGetProgramComment_Click(object sender, EventArgs e)
    {
        txtProgramComment.Text = _robot.Cgtp.GetProgramComment(txtProgram.Text);
    }

    private void btnSetProgramComment_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetProgramComment(txtProgram.Text, txtProgramComment.Text);
    }

    private void btnGetProgramStackSize_Click(object sender, EventArgs e)
    {
        udProgramStackSize.Value = _robot.Cgtp.GetProgramStackSize(txtProgram.Text);
    }

    private void btnSetProgramStackSize_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetProgramStackSize(txtProgram.Text, (int)udProgramStackSize.Value);
    }

    private void btnGetProgramIgnorePause_Click(object sender, EventArgs e)
    {
        chkProgramIgnorePause.Checked = _robot.Cgtp.GetProgramIgnorePause(txtProgram.Text);
    }

    private void btnSetProgramIgnorePause_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetProgramIgnorePause(txtProgram.Text, chkProgramIgnorePause.Checked);
    }

    private void btnGetProgramWriteProtect_Click(object sender, EventArgs e)
    {
        chkWriteProtect.Checked = _robot.Cgtp.GetProgramWriteProtect(txtProgram.Text);
    }

    private void btnSetProgramWriteProtect_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetProgramWriteProtect(txtProgram.Text, chkWriteProtect.Checked);
    }

    private void btnGetProgramType_Click(object sender, EventArgs e)
    {
        cbProgramType.SelectedItem = _robot.Cgtp.GetProgramSubType(txtProgram.Text);
    }

    private void btnSetProgramType_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetProgramSubType(txtProgram.Text, (ProgramSubType)cbProgramType.SelectedItem);
    }

    private void btnGetProgramOwner_Click(object sender, EventArgs e)
    {
        txtProgramOwner.Text = _robot.Cgtp.GetProgramOwner(txtProgram.Text);
    }

    private void btnSetProgramOwner_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.SetProgramOwner(txtProgram.Text, txtProgramOwner.Text);
    }

    private void btnSelectProgram_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.ChangeActiveProgram(txtProgram.Text);
    }

    private void btnAbort_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.AbortTask(txtProgram.Text);
    }

    private void BtnPause_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.PauseAllPrograms();
    }

    #endregion

    private void btnListFiles_Click(object sender, EventArgs e)
    {
        string[] files = _robot.Cgtp.ListFiles(txtPath.Text);

        treeFiles.Nodes.Clear();

        foreach (string file in files)
        {
            treeFiles.Nodes.Add(file);
        }

    }

    private void btnReadContent_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtFile.Text))
        {
            txtContent.Text = "";
            return;
        }
        txtContent.Text = _robot.Cgtp.GetFileAsString(Path.Combine(txtPath.Text, txtFile.Text));
    }

    private void treeFiles_AfterSelect(object sender, TreeViewEventArgs e)
    {
        txtFile.Text = e.Node?.Text;
        btnReadContent_Click(sender, e);
    }

    private void btnReadVariable_Click(object sender, EventArgs e)
    {
        txtVariableValue.Text = _robot.Cgtp.ReadVariableAsString(txtVariableName.Text);
    }

    private void btnWriteVariable_Click(object sender, EventArgs e)
    {
        _robot.Cgtp.WriteVariable(txtVariableName.Text, txtVariableValue.Text);
    }
}
