using System;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.TelnetKcl;

public partial class TelnetKclControl : UserControl, IUserControl
{
    FanucRobot _robot;

    public TelnetKclControl(FanucRobot robot)
    {
        _robot = robot;
        InitializeComponent();

        cbPorts.Items.AddRange(Enum.GetValues(typeof(KCLPorts)).OfType<object>().ToArray());
        cbPorts.SelectedItem = cbPorts.Items[0];

        _robot.TelnetKcl.CommandReceived += TelnetKcl_CommandReceived;
    }

    private void TelnetKcl_CommandReceived(object sender, KclCommandReceived e)
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
    public string Title => "Telnet KCL";

    public bool FeatureEnabled => _robot.TelnetKcl.Connected;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion

    private void btnRun_Click(object sender, System.EventArgs e)
    {
        _robot.TelnetKcl.Run(cbPrograms.Text);
    }

    private void btnAbort_Click(object sender, System.EventArgs e)
    {
        _robot.TelnetKcl.Abort(cbPrograms.Text, force: true);
    }

    private void btnPause_Click(object sender, System.EventArgs e)
    {
        _robot.TelnetKcl.Pause(cbPrograms.Text, force: true);
    }

    private void btnContinue_Click(object sender, System.EventArgs e)
    {
        _robot.TelnetKcl.Continue(cbPrograms.Text);
    }

    private void btnHold_Click(object sender, System.EventArgs e)
    {
        _robot.TelnetKcl.Hold(cbPrograms.Text);
    }
    private void btnGetProgramInfo_Click(object sender, EventArgs e)
    {
        _robot.TelnetKcl.GetProgramInformation(cbPrograms.Text);
    }

    private void btnClearProgram_Click(object sender, System.EventArgs e)
    {
        _robot.TelnetKcl.ClearProgram(cbPrograms.Text);
    }

    private void btnClearVariables_Click(object sender, System.EventArgs e)
    {
        _robot.TelnetKcl.ClearVars(cbPrograms.Text);
    }

    private void btnAbortAll_Click(object sender, System.EventArgs e)
    {
        _robot.TelnetKcl.AbortAll(force: true);
    }

    private void btnReset_Click(object sender, System.EventArgs e)
    {
        _robot.TelnetKcl.Reset();
    }

    private void btnSetPort_Click(object sender, System.EventArgs e)
    {
        _robot.TelnetKcl.SetPort((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value, (int)udNewValue.Value);
    }
    private void btnSimulate_Click(object sender, EventArgs e)
    {
        _robot.TelnetKcl.Simulate((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value, (int)udNewValue.Value);
    }

    private void btnUnsimulatePort_Click(object sender, EventArgs e)
    {
        _robot.TelnetKcl.Unsimulate((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value);
    }
    private void btnUnsimulate_Click(object sender, EventArgs e)
    {
        _robot.TelnetKcl.UnsimulateAll();
    }

    private void btnGetCurrentPose_Click(object sender, EventArgs e)
    {
         _robot.TelnetKcl.GetCurrentPose();
    }

    private void btnSetVariable_Click(object sender, EventArgs e)
    {
        _robot.TelnetKcl.SetVariable(txtVariableName.Text, txtVariableNewValue.Text, txtVariableProgram.Text);
    }

}
