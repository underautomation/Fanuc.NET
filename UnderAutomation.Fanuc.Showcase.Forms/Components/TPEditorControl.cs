using System.Text.RegularExpressions;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Ftp.Diagnosis;
using UnderAutomation.Fanuc.Showcase.Forms.TPSyntaxEditor;

public partial class TPEditorControl : UserControl, IUserControl
{
    private FanucRobot _robot;
    public TPEditorControl(FanucRobot robot)
    {

        _robot = robot;
        InitializeComponent();

        var syntaxHighlighter = new SyntaxHighlighter(editor.Editor);

        // 1. support.class : colorer uniquement "/PROG" suivi d'un reste jusqu'au saut de ligne
        syntaxHighlighter.AddPattern(
            new PatternDefinition(new Regex(@"(\/PROG).*\n", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Orange, false, false));

        // 2. support.variable : P?V?A?S?R[...] (aucun groupe, tout est coloré)
        syntaxHighlighter.AddPattern(
            new PatternDefinition("P?V?A?S?R\\[.*?\\]\\]*"),
            new SyntaxStyle(Color.Brown, false, false));

        // 3. support.variable : D?R?A?G?U?S?(I|O)[...] 
        // Ici, seul le (I|O) sera coloré – si l'intention est de colorer tout, il faudrait englober tout le motif
        syntaxHighlighter.AddPattern(
            new PatternDefinition("D?R?A?G?U?S?(I|O)\\[.*?\\]\\]*"),
            new SyntaxStyle(Color.Brown, false, false));

        // 4. support.variable : P?F?[...]
        syntaxHighlighter.AddPattern(
            new PatternDefinition("P?F?\\[.*?\\]\\]*"),
            new SyntaxStyle(Color.Brown, false, false));

        // 5. keyword.control : (TIMER)[...]
        // Seul "TIMER" (premier groupe) sera coloré
        syntaxHighlighter.AddPattern(
            new PatternDefinition("(TIMER)\\[.*?\\]\\]*"),
            new SyntaxStyle(Color.Blue, false, false));

        // 6. constant.numeric : on souhaite colorer le nombre entierement, 
        // donc on convertit les groupes internes en groupes non capturants.
        syntaxHighlighter.AddPattern(
            new PatternDefinition("\\d+(?:\\s)*(?:\\.)?(?:\\s)*(?:(?:%|mm|deg|cm|m|mm|sec))?(?:\\/(?:min|sec))?"),
            new SyntaxStyle(Color.Purple, false, false));

        // 7. constant.language : (?<=\=)\s*(ON|OFF) => seul le mot ON/OFF (premier groupe) sera coloré
        syntaxHighlighter.AddPattern(
            new PatternDefinition("(?<=\\=)\\s*(ON|OFF)"),
            new SyntaxStyle(Color.Red, false, false));

        // 8. invalid.illegal : (?<=:)\s*(J|L|C|A)\s
        syntaxHighlighter.AddPattern(
            new PatternDefinition("(?<=:)\\s*(J|L|C|A)\\s"),
            new SyntaxStyle(Color.DarkRed, true, false));

        // 9. invalid.illegal : Pour colorer l'intégralité, on remplace les groupes capturants par des groupes non capturants.
        syntaxHighlighter.AddPattern(
            new PatternDefinition("(?:FINE|CNT\\d*)\\s*(?:INC)?(?=;)"),
            new SyntaxStyle(Color.DarkRed, true, false));

        // 10. invalid.illegal : Idem, conversion en groupes non capturants
        syntaxHighlighter.AddPattern(
            new PatternDefinition("(?:FINE|CNT\\d*(?:\\s*INC)?)\\s*(?:(?:OFFSET|VOFFSET|TOOL_OFFSET))?\\s*(?=,)"),
            new SyntaxStyle(Color.DarkRed, true, false));

        // 11. comment.line : tout le motif est coloré (pas de groupe)
        syntaxHighlighter.AddPattern(
            new PatternDefinition("\\s*:\\s*!.*;"),
            new SyntaxStyle(Color.Green, false, true));

        // 12. comment.block : fusion du début et de la fin en une seule regex multiline sans groupe capturant
        syntaxHighlighter.AddPattern(
            new PatternDefinition(new Regex("\\s*:\\s*--[\\s\\S]*?;", RegexOptions.Multiline | RegexOptions.Compiled)),
            new SyntaxStyle(Color.Green, false, true));

        // 13. string.quoted (apostrophes) : tout est coloré
        syntaxHighlighter.AddPattern(
            new PatternDefinition("\\'.*?\\'"),
            new SyntaxStyle(Color.Salmon, false, false));

        // 14. string.quoted (guillemets) : tout est coloré
        syntaxHighlighter.AddPattern(
            new PatternDefinition("\".*?\""),
            new SyntaxStyle(Color.Red, false, false));

        // 15. constant.other : lignes commençant par ':'
        syntaxHighlighter.AddPattern(
            new PatternDefinition("^\\s*:"),
            new SyntaxStyle(Color.Magenta, false, false));

        // 16. keyword.control : (?<=:)\s*(IF|FOR)(?=(\s|\())
        // Seul le groupe (IF|FOR) sera coloré
        syntaxHighlighter.AddPattern(
            new PatternDefinition("(?<=:)\\s*(IF|FOR)(?=(\\s|\\())"),
            new SyntaxStyle(Color.Blue, false, false));

        // 17. keyword.control : \b(TO)\b
        syntaxHighlighter.AddPattern(
            new PatternDefinition("\\b(TO)\\b"),
            new SyntaxStyle(Color.Blue, false, false));

        // 18. keyword.control : (?<=:)\s*(ELSE|ENDIF|ENDFOR|END|ABORT)(?=;)
        syntaxHighlighter.AddPattern(
            new PatternDefinition("(?<=:)\\s*(ELSE|ENDIF|ENDFOR|END|ABORT)\\s*(?=;)"),
            new SyntaxStyle(Color.Blue, false, false));

        // 19. keyword.control : THEN avant ';'
        syntaxHighlighter.AddPattern(
            new PatternDefinition("THEN\\s*(?=;)"),
            new SyntaxStyle(Color.Blue, false, false));

        // 20. keyword.control : (JMP\s*)?LBL[.+](?=;)
        // Pour colorer l'intégralité, on remplace le groupe optionnel par un groupe non capturant.
        syntaxHighlighter.AddPattern(
            new PatternDefinition("(?<=:)(JMP\\s*)?LBL[.+](?=;)"),
            new SyntaxStyle(Color.Blue, false, false));

        // 21. support.function : (?<=:)\s*(WAIT|VISION(\s*)(\S*)|FORCE(\s*)(\S*))
        // Pour colorer l'ensemble de l'instruction, conversion en non-capturant
        syntaxHighlighter.AddPattern(
            new PatternDefinition("(?<=:)\\s*(?:(?:WAIT)|(?:VISION(?:\\s*\\S*)?)|(?:FORCE(?:\\s*\\S*)?))"),
            new SyntaxStyle(Color.Teal, false, false));

        // 22. support.function : (CALL|RUN)\s+[a-zA-Z0-9_]*\(?
        // Seul le mot CALL ou RUN sera coloré (premier groupe)
        syntaxHighlighter.AddPattern(
            new PatternDefinition("(CALL|RUN)\\s+[a-zA-Z0-9_]*\\(?"),
            new SyntaxStyle(Color.Teal, false, false));

        // 23. support.function : (?<=:)\s*(MESSAGE|UALM)\[.*\](?=;)
        // Seul le groupe MESSAGE ou UALM sera coloré
        syntaxHighlighter.AddPattern(
            new PatternDefinition("(?<=:)\\s*(MESSAGE|UALM)\\[.*\\]\\s*(?=;)"),
            new SyntaxStyle(Color.Teal, false, false));



        editor.SetCurrentExecutionLine(3);

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

        var list = _robot.Ftp.DirectFileHandling.GetListing("/md:/");

    }
    #endregion


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

        if(states is null) return;
      
    }
}