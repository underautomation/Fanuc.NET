using UnderAutomation.Fanuc.Common.Kcl;

public partial class KclControl : UserControl
{
    private bool _supportVariableParse;
    /// <summary>
    /// Indicates if the protocol supports variable parsing
    /// </summary>
    public bool SupportVariableParse
    {
        get => _supportVariableParse;
        set
        {
            _supportVariableParse = value;
            gridVariableValue.Visible = value;
        }
    }


    public KclClientBase KclClient;

    public KclControl()
    {
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

    private void btnRun_Click(object sender, System.EventArgs e)
    {
        var result = KclClient.Run(cbPrograms.Text);
        LogCommand(nameof(KclClient.Run), result);
    }

    private void btnAbort_Click(object sender, System.EventArgs e)
    {
        var result = KclClient.Abort(cbPrograms.Text, force: true);
        LogCommand(nameof(KclClient.Abort), result);
    }

    private void btnPause_Click(object sender, System.EventArgs e)
    {
        var result = KclClient.Pause(cbPrograms.Text, force: true);
        LogCommand(nameof(KclClient.Pause), result);
    }

    private void btnContinue_Click(object sender, System.EventArgs e)
    {
        var result = KclClient.Continue(cbPrograms.Text);
        LogCommand(nameof(KclClient.Continue), result);
    }

    private void btnHold_Click(object sender, System.EventArgs e)
    {
        var result = KclClient.Hold(cbPrograms.Text);
        LogCommand(nameof(KclClient.Hold), result);
    }

    private void btnClearProgram_Click(object sender, System.EventArgs e)
    {
        var result = KclClient.ClearProgram(cbPrograms.Text);
        LogCommand(nameof(KclClient.ClearProgram), result);
    }

    private void btnClearVariables_Click(object sender, System.EventArgs e)
    {
        var result = KclClient.ClearVars(cbPrograms.Text);
        LogCommand(nameof(KclClient.ClearVars), result);
    }

    private void btnAbortAll_Click(object sender, System.EventArgs e)
    {
        var result = KclClient.AbortAll(force: true);
        LogCommand(nameof(KclClient.AbortAll), result);
    }

    private void btnReset_Click(object sender, System.EventArgs e)
    {
        var result = KclClient.Reset();
        LogCommand(nameof(KclClient.Reset), result);
    }

    private void btnSetPort_Click(object sender, System.EventArgs e)
    {
        var result = KclClient.SetPort((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value, (int)udNewValue.Value);
        LogCommand(nameof(KclClient.SetPort), result);
    }
    private void btnSimulate_Click(object sender, EventArgs e)
    {
        var result = KclClient.Simulate((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value, (int)udNewValue.Value);
        LogCommand(nameof(KclClient.Simulate), result);
    }

    private void btnUnsimulatePort_Click(object sender, EventArgs e)
    {
        var result = KclClient.Unsimulate((KCLPorts)cbPorts.SelectedItem, (int)udIndex.Value);
        LogCommand(nameof(KclClient.Unsimulate), result);
    }
    private void btnUnsimulate_Click(object sender, EventArgs e)
    {
        var result = KclClient.UnsimulateAll();
        LogCommand(nameof(KclClient.UnsimulateAll), result);
    }

    private void btnGetCurrentPose_Click(object sender, EventArgs e)
    {
        var result = KclClient.GetCurrentPose();
        LogCommand(nameof(KclClient.GetCurrentPose), result);
    }

    private void btnSetVariable_Click(object sender, EventArgs e)
    {
        var result = KclClient.SetVariable(txtVariableName.Text, txtVariableNewValue.Text, txtVariableProgram.Text);
        LogCommand(nameof(KclClient.SetVariable), result);
    }

    private void btnGetVariable_Click(object sender, EventArgs e)
    {
        var result = KclClient.GetVariable(txtVariableName.Text, txtVariableProgram.Text);
        LogCommand(nameof(KclClient.GetVariable), result);

        if (_supportVariableParse) gridVariableValue.SelectedObject = result.ParseResult();
    }

    private void btnGetTask_Click(object sender, EventArgs e)
    {
        var result = KclClient.GetTaskInformation(cbPrograms.Text);
        LogCommand(nameof(KclClient.GetTaskInformation), result);
    }

    private void btnSendCommand_Click(object sender, EventArgs e)
    {
        var result = KclClient.SendCustomCommand(txtCommand.Text);
        LogCommand(nameof(KclClient.SendCustomCommand), result);
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
