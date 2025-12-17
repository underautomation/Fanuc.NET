using System.Text;
using System.Text.RegularExpressions;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common;
using UnderAutomation.Fanuc.Ftp.Diagnosis;
using UnderAutomation.Fanuc.Showcase.Forms.TPSyntaxEditor;
using UnderAutomation.Fanuc.Telnet;
using static System.ComponentModel.Design.ObjectSelectorEditor;

public partial class TPEditorControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public TPEditorControl(FanucRobot robot)
    {

        _robot = robot;
        InitializeComponent();

        var syntaxHighlighter = new SyntaxHighlighter(editor.Editor);

        // Exemple de patterns inspirés du JSON VSCode pour Fanuc TP

        // 1) support.class => /PROG sur toute la ligne
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"/PROG.*", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Blue)
        );

        // 2) support.variable => P?V?A?S?R[...] , D?R?A?G?U?S?(I|O)[...] , P?F?[...]
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"P?V?A?S?R\[.*?\]\]*", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.SteelBlue)
        );
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"D?R?A?G?U?S?(I|O)\[.*?\]\]*", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.SteelBlue)
        );
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"P?F?\[.*?\]\]*", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.SteelBlue)
        );

        // 3) keyword.control => TIMER[...] et divers IF, FOR, ELSE...
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"TIMER\[.*?\]\]*", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Navy, true, false)
        );
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"(?<=:) * (IF|FOR|ELSE|ENDIF|ENDFOR|END|ABORT|THEN) (?=(\s|;|\())", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Navy, true, false)
        );
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"\b(TO)\b", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Navy, true, false)
        );
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"(JMP\s*)?LBL\[.+\](?=;)", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Navy, true, false)
        );

        // 4) constant.numeric => nombre + éventuellement unité (mm, deg, etc.)
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"\d(\s)*(\.)?(\s)*(%|mm|deg|cm|m|sec)?(\/(min|sec))?", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Purple)
        );

        // 5) constant.language => ON / OFF après un '='
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"(?<=\=)\s*(ON|OFF)", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.OrangeRed)
        );

        // 6) invalid.illegal => (J|L|C|A) après un ':', FINE/CNT..., etc.
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"(?<=:) * (J|L|C|A)\s", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Red)
        );
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"(FINE|CNT\d*)\s*(INC)?(?=;)", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Red)
        );
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"(FINE|CNT\d*\s*(INC)?)\s*(OFFSET|VOFFSET|TOOL_OFFSET)?\s*(?=,)", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Red)
        );

        // 7) comment.line => : ! ... ;
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"\s*:\s*!.*;", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Green)
        );

        // 8) comment.block => : -- ... ;
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"\s*:\s*--.*?;", RegexOptions.Singleline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Green)
        );

        // 9) string.quoted => '...' et "..."
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"'.*?'", RegexOptions.Singleline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Brown)
        );
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"""(.*?)""", RegexOptions.Singleline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Brown)
        );

        // 10) constant.other => ^\s*:
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"^[\t ]*:", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.DarkCyan)
        );

        // 11) support.function => WAIT, VISION, FORCE, CALL, RUN, MESSAGE, UALM...
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"(?<=:) * (WAIT|VISION\s+\S+|FORCE\s+\S+)", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.DarkMagenta)
        );
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"(CALL|RUN)\s+[a-zA-Z0-9_]*\(?", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.DarkMagenta)
        );
        syntaxHighlighter.AddPattern(
            new PatternDefinition(
                new Regex(@"(?<=:) * (MESSAGE|UALM)\[.*?\]\s*(?=;)", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.DarkMagenta)
        );
    }

    #region IUserControl
    public string Title => "TP Editor (LIVE / BREAKPOINTS)";

    public bool FeatureEnabled => _robot.Ftp.Connected && _robot.Telnet.Connected;

    public void PeriodicUpdate()
    {
        if (!FeatureEnabled) return;


    }

    public void Resume()
    {
        // clear break program xxx break_no
        // step on xxx
        // hold xxx
        // continue xxx
        // step off
        // set break program xxx break_no line_no
        // continue xxx

        // OU, AU RISQUE DE LOUPER LE PROCHAIN BREAKPOINT (ne pas passer par step on)
        // clear break program xxx break_no
        // hold xxx
        // continue xxx
        // set break program xxx break_no line_no

    }

    public void OnClose() { bw.CancelAsync(); }

    public void OnOpen()
    {
        if (!_robot.Ftp.Connected) return;

        bw.RunWorkerAsync();

        var files = _robot.Ftp.DirectFileHandling.GetListing("/md:/");

        var tpItems = files.Where(x => files.Any(y => y.Name.Equals($"{Path.GetFileNameWithoutExtension(x.Name)}.tp", StringComparison.InvariantCultureIgnoreCase)) && Path.GetExtension(x.Name).Equals(".ls", StringComparison.InvariantCultureIgnoreCase)).Select(x => x.Name).ToArray();

        treeFile.SetItems(tpItems);
    }
    #endregion

    private string GetSelectedProgramName()
    {
        var name = treeFile.SelectedNode?.Text;
        if (name is null) return null;
        return Path.GetFileNameWithoutExtension(name);
    }
    private void bw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        while (!bw.CancellationPending)
        {
            try
            {
                var states = _robot.Ftp.GetProgramStates();

                bw.ReportProgress(0, states);

            }
            catch
            {

            }
        }
        e.Cancel = true;
    }

    private void bw_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
        var states = e.UserState as ProgramStates;

        if (states is null) return;


        foreach (var item in states.TaskStates)
        {
            treeFile.SetProgramState($"{item.Name}.ls", item.Status);
        }

        var selected = treeFile.SelectedNode?.Text;

        TaskHistoryData? data = null;

        if (selected != null)
        {
            data = states.TaskStates.Where(x => x.Status != UnderAutomation.Fanuc.Common.TaskStatus.Aborted).SelectMany(x => x.History).FirstOrDefault(x => x.ProgramName.Equals(Path.GetFileNameWithoutExtension(selected), StringComparison.InvariantCultureIgnoreCase));
            if (data != null)
            {
                editor.SetCurrentExecutionLineNumber(data.LineNumber);
            }
        }

        if (data is null)
        {
            editor.SetCurrentExecutionLineNumber(-1);
        }
    }

    private void treeFile_ItemRenamed(object sender, ItemRenamedEventArgs e)
    {
        _robot.Ftp.DirectFileHandling.Rename($"/md:/{e.OldName}", $"/md:/{e.NewName}");
    }

    private void treeFile_ItemSelected(object sender, ItemSelectedEventArgs e)
    {
        byte[] content;
        _robot.Ftp.DirectFileHandling.DownloadFileFromController(out content, $"/md:/{e.SelectedItem}");

        var fileContent = StringUtils.GetEncoding(_robot.Ftp.Language).GetString(content);

        editor.Editor.Text = fileContent;

        var breakpoints = _robot.Telnet.GetBreakpoints(GetSelectedProgramName());

        editor.InitializeBreakpoints(breakpoints.Breakpoints.Select(x=>x.Line));
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        _robot.Telnet.SetVariable("$RMT_MASTER", 1); // Set master device to KCL
        _robot.Telnet.StepOff();
        var selected = GetSelectedProgramName();
        var result = _robot.Telnet.Run(selected);
        HandleCommandResult(result);
    }

    private void btnPause_Click(object sender, EventArgs e)
    {
        var selected = GetSelectedProgramName();
        var result = _robot.Telnet.Pause(selected);
        HandleCommandResult(result);
    }

    private void btnAbort_Click(object sender, EventArgs e)
    {
        var selected = GetSelectedProgramName();
        var result = _robot.Telnet.Abort(selected);
        HandleCommandResult(result);
    }

    private void HandleCommandResult(Result result)
    {
        if (result.Succeed) return;

        MessageBox.Show(result.ErrorText, "Error occured while sending command", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void btnStep_Click(object sender, EventArgs e)
    {
        var selected = GetSelectedProgramName();
        _robot.Telnet.RemoveAllBreakpoints(selected);
        editor.InitializeBreakpoints(new int[0]);
        _robot.Telnet.StepOn(selected);
        _robot.Telnet.Continue(selected);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        _robot.Ftp.DirectFileHandling.UploadFileToController(StringUtils.GetEncoding(_robot.Ftp.Language).GetBytes(editor.Editor.Text), $"/md:/{GetSelectedProgramName()}.ls");


        byte[] content;
        _robot.Ftp.DirectFileHandling.DownloadFileFromController(out content, $"/md:/{GetSelectedProgramName()}.ls");

        var fileContent = StringUtils.GetEncoding(_robot.Ftp.Language).GetString(content);

        editor.Editor.Text = fileContent;
    
    }

    private void editor_BreakpointAdded(object sender, int e)
    {
        var selected = GetSelectedProgramName();
        _robot.Telnet.Pause(selected);
        _robot.Telnet.AddBreakpoint(selected, e);
    }

    private void editor_BreakpointRemoved(object sender, int e)
    {
        _robot.Telnet.RemoveBreakpoint(GetSelectedProgramName(), e);
    }
}

