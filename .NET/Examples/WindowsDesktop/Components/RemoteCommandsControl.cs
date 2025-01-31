using System;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Telnet;

public partial class TelnetControl : UserControl, IUserControl
{
    FanucRobot _robot;

    public TelnetControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        cbPorts.Items.AddRange(Enum.GetValues(typeof(KCLPorts)).OfType<object>().ToArray());
        cbPorts.SelectedItem = cbPorts.Items[0];

        _robot.Telnet.CommandReceived += CommandReceived;
    }

    private void CommandReceived(object sender, KclCommandReceived e)
    {
        LogCommand(e.Result?.ToString());
    }

    private void LogCommand(string text)
    {
        if (Application.OpenForms[0].InvokeRequired) // Invoke required on form because the component may never have been displayed
        {
            Application.OpenForms[0].Invoke(new Action(() => LogCommand(text)));
            return;
        }
        txtConsole.AppendText("\r\n");
        txtConsole.AppendText(text);
        txtConsole.AppendText("\r\n");
        txtConsole.ScrollToCaret();
    }

    #region IUserControl
    public string Title => "Remote control";

    public bool FeatureEnabled => _robot.Telnet.Connected;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion

    private void btnRun_Click(object sender, System.EventArgs e)
    {
        _robot.Telnet.Run(cbPrograms.Text);
    }

    private void btnAbort_Click(object sender, System.EventArgs e)
    {
        _robot.Telnet.Abort(cbPrograms.Text, force: true);
    }

    private void btnPause_Click(object sender, System.EventArgs e)
    {
        _robot.Telnet.Pause(cbPrograms.Text, force: true);
    }

    private void btnContinue_Click(object sender, System.EventArgs e)
    {
        _robot.Telnet.Continue(cbPrograms.Text);
    }

    private void btnHold_Click(object sender, System.EventArgs e)
    {
        _robot.Telnet.Hold(cbPrograms.Text);
    }
    private void btnGetProgramInfo_Click(object sender, EventArgs e)
    {
        _robot.Telnet.GetProgramInformation(cbPrograms.Text);
    }

    private void btnClearProgram_Click(object sender, System.EventArgs e)
    {
        _robot.Telnet.ClearProgram(cbPrograms.Text);
    }

    private void btnClearVariables_Click(object sender, System.EventArgs e)
    {
        _robot.Telnet.ClearVars(cbPrograms.Text);
    }

    private void btnAbortAll_Click(object sender, System.EventArgs e)
    {
        _robot.Telnet.AbortAll(force: true);
    }

    private void btnReset_Click(object sender, System.EventArgs e)
    {
        _robot.Telnet.Reset();
    }

    private void btnSetPort_Click(object sender, System.EventArgs e)
    {
        _robot.Telnet.SetPort((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value, (int)udNewValue.Value);
    }
    private void btnSimulate_Click(object sender, EventArgs e)
    {
        _robot.Telnet.Simulate((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value, (int)udNewValue.Value);
    }

    private void btnUnsimulatePort_Click(object sender, EventArgs e)
    {
        _robot.Telnet.Unsimulate((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value);
    }
    private void btnUnsimulate_Click(object sender, EventArgs e)
    {
        _robot.Telnet.UnsimulateAll();
    }

    private void btnGetCurrentPose_Click(object sender, EventArgs e)
    {
        _robot.Telnet.GetCurrentPose();
    }

    private void btnSetVariable_Click(object sender, EventArgs e)
    {
        _robot.Telnet.SetVariable(txtVariableName.Text, txtVariableNewValue.Text, txtVariableProgram.Text);
    }

    private void btnGetVariable_Click(object sender, EventArgs e)
    {
        _robot.Telnet.GetVariable(txtVariableName.Text, txtVariableProgram.Text);
    }

    private void btnGetTask_Click(object sender, EventArgs e)
    {
        _robot.Telnet.GetTaskInformation(cbPrograms.Text);
    }
}
