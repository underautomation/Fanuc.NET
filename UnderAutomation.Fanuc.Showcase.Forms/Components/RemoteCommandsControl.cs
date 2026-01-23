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

    }

    private void AppendTextWithColorAndStyle(string text, Color color, bool bold)
    {
        txtConsole.SelectionStart = txtConsole.TextLength;
        txtConsole.SelectionLength = 0;
        txtConsole.SelectionColor = color;

        if (bold)
        {
            txtConsole.SelectionFont = new Font(txtConsole.Font, FontStyle.Bold);
        }
        else
        {
            txtConsole.SelectionFont = new Font(txtConsole.Font, FontStyle.Regular);
        }

        txtConsole.AppendText(text);
        txtConsole.AppendText("\r\n");
        txtConsole.SelectionColor = txtConsole.ForeColor;
    }


    private void LogCommand(string name, Result command)
    {
        if (Application.OpenForms[0].InvokeRequired) // Invoke required on form because the component may never have been displayed
        {
            Application.OpenForms[0].Invoke(new Action(() => LogCommand(name, command)));
            return;
        }

        txtConsole.SuspendLayout();

        AppendTextWithColorAndStyle($"> {name} :", Color.White, true);
        AppendTextWithColorAndStyle(command.ToString(), command.Succeed ? Color.Green : Color.Red, true);

        txtConsole.AppendText("\r\n");
        txtConsole.ScrollToCaret();

        txtConsole.ResumeLayout();
    }

    #region IUserControl
    public string Title => "Remote control";

    public bool FeatureEnabled => _robot.Telnet.PollAndGetUpdatedConnectedState();

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion

    private void btnRun_Click(object sender, System.EventArgs e)
    {
        var result = _robot.Telnet.Run(cbPrograms.Text);
        LogCommand(nameof(_robot.Telnet.Run), result);
    }

    private void btnAbort_Click(object sender, System.EventArgs e)
    {
        var result = _robot.Telnet.Abort(cbPrograms.Text, force: true);
        LogCommand(nameof(_robot.Telnet.Abort), result);
    }

    private void btnPause_Click(object sender, System.EventArgs e)
    {
        var result = _robot.Telnet.Pause(cbPrograms.Text, force: true);
        LogCommand(nameof(_robot.Telnet.Pause), result);
    }

    private void btnContinue_Click(object sender, System.EventArgs e)
    {
        var result = _robot.Telnet.Continue(cbPrograms.Text);
        LogCommand(nameof(_robot.Telnet.Continue), result);
    }

    private void btnHold_Click(object sender, System.EventArgs e)
    {
        var result = _robot.Telnet.Hold(cbPrograms.Text);
        LogCommand(nameof(_robot.Telnet.Hold), result);
    }

    private void btnClearProgram_Click(object sender, System.EventArgs e)
    {
        var result = _robot.Telnet.ClearProgram(cbPrograms.Text);
        LogCommand(nameof(_robot.Telnet.ClearProgram), result);
    }

    private void btnClearVariables_Click(object sender, System.EventArgs e)
    {
        var result = _robot.Telnet.ClearVars(cbPrograms.Text);
        LogCommand(nameof(_robot.Telnet.ClearVars), result);
    }

    private void btnAbortAll_Click(object sender, System.EventArgs e)
    {
        var result = _robot.Telnet.AbortAll(force: true);
        LogCommand(nameof(_robot.Telnet.AbortAll), result);
    }

    private void btnReset_Click(object sender, System.EventArgs e)
    {
        var result = _robot.Telnet.Reset();
        LogCommand(nameof(_robot.Telnet.Reset), result);
    }

    private void btnSetPort_Click(object sender, System.EventArgs e)
    {
        var result = _robot.Telnet.SetPort((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value, (int)udNewValue.Value);
        LogCommand(nameof(_robot.Telnet.SetPort), result);
    }
    private void btnSimulate_Click(object sender, EventArgs e)
    {
        var result = _robot.Telnet.Simulate((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value, (int)udNewValue.Value);
        LogCommand(nameof(_robot.Telnet.Simulate), result);
    }

    private void btnUnsimulatePort_Click(object sender, EventArgs e)
    {
        var result = _robot.Telnet.Unsimulate((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value);
        LogCommand(nameof(_robot.Telnet.Unsimulate), result);
    }
    private void btnUnsimulate_Click(object sender, EventArgs e)
    {
        var result = _robot.Telnet.UnsimulateAll();
        LogCommand(nameof(_robot.Telnet.UnsimulateAll), result);
    }

    private void btnGetCurrentPose_Click(object sender, EventArgs e)
    {
        var result = _robot.Telnet.GetCurrentPose();
        LogCommand(nameof(_robot.Telnet.GetCurrentPose), result);
    }

    private void btnSetVariable_Click(object sender, EventArgs e)
    {
        var result = _robot.Telnet.SetVariable(txtVariableName.Text, txtVariableNewValue.Text, txtVariableProgram.Text);
        LogCommand(nameof(_robot.Telnet.SetVariable), result);
    }

    private void btnGetVariable_Click(object sender, EventArgs e)
    {
        var result = _robot.Telnet.GetVariable(txtVariableName.Text, txtVariableProgram.Text);
        LogCommand(nameof(_robot.Telnet.GetVariable), result);
    }

    private void btnGetTask_Click(object sender, EventArgs e)
    {
        var result = _robot.Telnet.GetTaskInformation(cbPrograms.Text);
        LogCommand(nameof(_robot.Telnet.GetTaskInformation), result);
    }

    private void btnSendCommand_Click(object sender, EventArgs e)
    {
        var result = _robot.Telnet.SendCustomCommand<TelnetControl.CustomCommandResult>(txtCommand.Text);
        LogCommand(nameof(_robot.Telnet.SendCustomCommand), result);
    }

    public class CustomCommandResult : BaseResult
    {
        public string Data { get; private set; }
        protected override bool FromResult(string data)
        {
            Data = data;
            return true;
        }

        public override string ToString()
        {
            return $"{KclCommand} :\r\n{Data}\r\n{ErrorText}";
        }
    }
}
