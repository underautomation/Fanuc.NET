using System;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.RemoteCommands;

public partial class RemoteCommandsControl : UserControl, IUserControl
{
    FanucRobot _robot;

    public RemoteCommandsControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        cbPorts.Items.AddRange(Enum.GetValues(typeof(KCLPorts)).OfType<object>().ToArray());
        cbPorts.SelectedItem = cbPorts.Items[0];

        _robot.RemoteCommands.CommandReceived += CommandReceived;
    }

    private void CommandReceived(object sender, KclCommandReceived e)
    {
        LogCommand(e.Result?.ToString());
    }

    private void LogCommand(string text)
    {
        if (this.InvokeRequired)
        {
            this.Invoke(new Action(() => LogCommand(text)));
            return;
        }
        txtConsole.AppendText("\r\n");
        txtConsole.AppendText(text);
        txtConsole.AppendText("\r\n");
        txtConsole.ScrollToCaret();
    }

    #region IUserControl
    public string Title => "Remote control";

    public bool FeatureEnabled => _robot.RemoteCommands.Connected;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion

    private void btnRun_Click(object sender, System.EventArgs e)
    {
        _robot.RemoteCommands.Run("MyPrg");
    }

    private void btnAbort_Click(object sender, System.EventArgs e)
    {
        _robot.RemoteCommands.Abort(cbPrograms.Text, force: true);
    }

    private void btnPause_Click(object sender, System.EventArgs e)
    {
        _robot.RemoteCommands.Pause(cbPrograms.Text, force: true);
    }

    private void btnContinue_Click(object sender, System.EventArgs e)
    {
        _robot.RemoteCommands.Continue(cbPrograms.Text);
    }

    private void btnHold_Click(object sender, System.EventArgs e)
    {
        _robot.RemoteCommands.Hold(cbPrograms.Text);
    }
    private void btnGetProgramInfo_Click(object sender, EventArgs e)
    {
        _robot.RemoteCommands.GetProgramInformation(cbPrograms.Text);
    }

    private void btnClearProgram_Click(object sender, System.EventArgs e)
    {
        _robot.RemoteCommands.ClearProgram(cbPrograms.Text);
    }

    private void btnClearVariables_Click(object sender, System.EventArgs e)
    {
        _robot.RemoteCommands.ClearVars(cbPrograms.Text);
    }

    private void btnAbortAll_Click(object sender, System.EventArgs e)
    {
        _robot.RemoteCommands.AbortAll(force: true);
    }

    private void btnReset_Click(object sender, System.EventArgs e)
    {
        _robot.RemoteCommands.Reset();
    }

    private void btnSetPort_Click(object sender, System.EventArgs e)
    {
        _robot.RemoteCommands.SetPort((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value, (int)udNewValue.Value);
    }
    private void btnSimulate_Click(object sender, EventArgs e)
    {
        _robot.RemoteCommands.Simulate((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value, (int)udNewValue.Value);
    }

    private void btnUnsimulatePort_Click(object sender, EventArgs e)
    {
        _robot.RemoteCommands.Unsimulate((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value);
    }
    private void btnUnsimulate_Click(object sender, EventArgs e)
    {
        _robot.RemoteCommands.UnsimulateAll();
    }

    private void btnGetCurrentPose_Click(object sender, EventArgs e)
    {
        _robot.RemoteCommands.GetCurrentPose();
    }

    private void btnSetVariable_Click(object sender, EventArgs e)
    {
        _robot.RemoteCommands.SetVariable(txtVariableName.Text, txtVariableNewValue.Text, txtVariableProgram.Text);
    }

    private void btnGetVariable_Click(object sender, EventArgs e)
    {
        _robot.RemoteCommands.GetVariable(txtVariableName.Text, txtVariableProgram.Text);
    }
}
