using System.Drawing;
using System.Windows.Forms;

partial class RmiControl
{
    /// <summary> 
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private TabControl tabMain;

    // Commands
    private TabPage tabCommands;
    private TableLayoutPanel tlpCommands;
    private GroupBox gbCmdButtons;
    private FlowLayoutPanel flpCmdButtons;
    private Button btnInitialize;
    private Button btnAbort;
    private Button btnPause;
    private Button btnContinue;
    private Button btnReset;
    private Button btnGetStatus;
    private Button btnReadError;
    private Button btnGetUFrameUTool;
    private GroupBox gbSetUFrameUTool;
    private PropertyGrid pgSetUFrameUTool;
    private Button btnSetUFrameUTool;
    private GroupBox gbCmdOutput;
    private TextBox txtCommands;

    // I/O
    private TabPage tabIO;
    private TableLayoutPanel tlpIO;
    private GroupBox gbReadDIN;
    private PropertyGrid pgReadDIN;
    private Button btnReadDIN;
    private GroupBox gbWriteDOUT;
    private PropertyGrid pgWriteDOUT;
    private Button btnWriteDOUT;
    private GroupBox gbIOOutput;
    private TextBox txtIO;

    // Frames & Tools
    private TabPage tabFrames;
    private TableLayoutPanel tlpFrames;
    private GroupBox gbReadUFrame;
    private PropertyGrid pgReadUFrame;
    private Button btnReadUFrameData;
    private GroupBox gbWriteUFrame;
    private PropertyGrid pgWriteUFrame;
    private Button btnWriteUFrameData;
    private GroupBox gbReadUTool;
    private PropertyGrid pgReadUTool;
    private Button btnReadUToolData;
    private GroupBox gbWriteUTool;
    private PropertyGrid pgWriteUTool;
    private Button btnWriteUToolData;
    private GroupBox gbFramesOutput;
    private TextBox txtFrames;

    // Positions
    private TabPage tabPositions;
    private TableLayoutPanel tlpPositions;
    private GroupBox gbPosButtons;
    private FlowLayoutPanel flpPosButtons;
    private Button btnReadCartesianPosition;
    private Button btnReadJointAngles;
    private Button btnReadTCPSpeed;
    private GroupBox gbPosOutput;
    private TextBox txtPositions;

    // Registers
    private TabPage tabRegisters;
    private TableLayoutPanel tlpRegisters;
    private GroupBox gbReadPR;
    private PropertyGrid pgReadPR;
    private Button btnReadPositionRegister;
    private GroupBox gbWritePR;
    private PropertyGrid pgWritePR;
    private Button btnWritePositionRegister;
    private GroupBox gbRegOutput;
    private TextBox txtRegisters;

    // Instructions
    private TabPage tabInstructions;
    private TableLayoutPanel tlpInstr;
    private GroupBox gbWaitDin;
    private PropertyGrid pgWaitDin;
    private Button btnWaitDin;
    private GroupBox gbWaitTime;
    private PropertyGrid pgWaitTime;
    private Button btnWaitTime;
    private GroupBox gbSetUFrameInstr;
    private PropertyGrid pgSetUFrameInstr;
    private Button btnSetUFrame;
    private GroupBox gbSetUToolInstr;
    private PropertyGrid pgSetUToolInstr;
    private Button btnSetUTool;
    private GroupBox gbPayLoad;
    private PropertyGrid pgPayLoad;
    private Button btnPayLoad;
    private GroupBox gbLinearMotion;
    private PropertyGrid pgLinearMotion;
    private Button btnLinearMotion;
    private GroupBox gbLinearRelative;
    private PropertyGrid pgLinearRelative;
    private Button btnLinearRelative;
    private GroupBox gbJointMotion;
    private PropertyGrid pgJointMotion;
    private Button btnJointMotion;
    private GroupBox gbJointRelative;
    private PropertyGrid pgJointRelative;
    private Button btnJointRelative;
    private GroupBox gbCircularMotion;
    private PropertyGrid pgCircularMotion;
    private Button btnCircularMotion;
    private GroupBox gbCircularRelative;
    private PropertyGrid pgCircularRelative;
    private Button btnCircularRelative;
    private GroupBox gbJointMotionJRep;
    private PropertyGrid pgJointMotionJRep;
    private Button btnJointMotionJRep;
    private GroupBox gbJointRelativeJRep;
    private PropertyGrid pgJointRelativeJRep;
    private Button btnJointRelativeJRep;
    private GroupBox gbInstrOutput;
    private TextBox txtInstructions;

    /// <summary> 
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    /// <summary> 
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        tabMain = new TabControl();
        tabCommands = new TabPage();
        tlpCommands = new TableLayoutPanel();
        gbCmdButtons = new GroupBox();
        flpCmdButtons = new FlowLayoutPanel();
        btnInitialize = new Button();
        btnAbort = new Button();
        btnPause = new Button();
        btnContinue = new Button();
        btnReset = new Button();
        btnGetStatus = new Button();
        btnReadError = new Button();
        btnGetUFrameUTool = new Button();
        gbSetUFrameUTool = new GroupBox();
        pgSetUFrameUTool = new PropertyGrid();
        btnSetUFrameUTool = new Button();
        gbCmdOutput = new GroupBox();
        txtCommands = new TextBox();
        tabIO = new TabPage();
        tlpIO = new TableLayoutPanel();
        gbReadDIN = new GroupBox();
        pgReadDIN = new PropertyGrid();
        btnReadDIN = new Button();
        gbWriteDOUT = new GroupBox();
        pgWriteDOUT = new PropertyGrid();
        btnWriteDOUT = new Button();
        gbIOOutput = new GroupBox();
        txtIO = new TextBox();
        tabFrames = new TabPage();
        tlpFrames = new TableLayoutPanel();
        gbReadUFrame = new GroupBox();
        pgReadUFrame = new PropertyGrid();
        btnReadUFrameData = new Button();
        gbWriteUFrame = new GroupBox();
        pgWriteUFrame = new PropertyGrid();
        btnWriteUFrameData = new Button();
        gbReadUTool = new GroupBox();
        pgReadUTool = new PropertyGrid();
        btnReadUToolData = new Button();
        gbWriteUTool = new GroupBox();
        pgWriteUTool = new PropertyGrid();
        btnWriteUToolData = new Button();
        gbFramesOutput = new GroupBox();
        txtFrames = new TextBox();
        tabPositions = new TabPage();
        tlpPositions = new TableLayoutPanel();
        gbPosButtons = new GroupBox();
        flpPosButtons = new FlowLayoutPanel();
        btnReadCartesianPosition = new Button();
        btnReadJointAngles = new Button();
        btnReadTCPSpeed = new Button();
        gbPosOutput = new GroupBox();
        txtPositions = new TextBox();
        tabRegisters = new TabPage();
        tlpRegisters = new TableLayoutPanel();
        gbReadPR = new GroupBox();
        pgReadPR = new PropertyGrid();
        btnReadPositionRegister = new Button();
        gbWritePR = new GroupBox();
        pgWritePR = new PropertyGrid();
        btnWritePositionRegister = new Button();
        gbRegOutput = new GroupBox();
        txtRegisters = new TextBox();
        tabInstructions = new TabPage();
        tlpInstr = new TableLayoutPanel();
        gbWaitDin = new GroupBox();
        pgWaitDin = new PropertyGrid();
        btnWaitDin = new Button();
        gbWaitTime = new GroupBox();
        pgWaitTime = new PropertyGrid();
        btnWaitTime = new Button();
        gbSetUFrameInstr = new GroupBox();
        pgSetUFrameInstr = new PropertyGrid();
        btnSetUFrame = new Button();
        gbSetUToolInstr = new GroupBox();
        pgSetUToolInstr = new PropertyGrid();
        btnSetUTool = new Button();
        gbPayLoad = new GroupBox();
        pgPayLoad = new PropertyGrid();
        btnPayLoad = new Button();
        gbLinearMotion = new GroupBox();
        pgLinearMotion = new PropertyGrid();
        btnLinearMotion = new Button();
        gbLinearRelative = new GroupBox();
        pgLinearRelative = new PropertyGrid();
        btnLinearRelative = new Button();
        gbJointMotion = new GroupBox();
        pgJointMotion = new PropertyGrid();
        btnJointMotion = new Button();
        gbJointRelative = new GroupBox();
        pgJointRelative = new PropertyGrid();
        btnJointRelative = new Button();
        gbCircularMotion = new GroupBox();
        pgCircularMotion = new PropertyGrid();
        btnCircularMotion = new Button();
        gbCircularRelative = new GroupBox();
        pgCircularRelative = new PropertyGrid();
        btnCircularRelative = new Button();
        gbJointMotionJRep = new GroupBox();
        pgJointMotionJRep = new PropertyGrid();
        btnJointMotionJRep = new Button();
        gbJointRelativeJRep = new GroupBox();
        pgJointRelativeJRep = new PropertyGrid();
        btnJointRelativeJRep = new Button();
        gbInstrOutput = new GroupBox();
        txtInstructions = new TextBox();
        tabMain.SuspendLayout();
        tabCommands.SuspendLayout();
        tlpCommands.SuspendLayout();
        gbCmdButtons.SuspendLayout();
        flpCmdButtons.SuspendLayout();
        gbSetUFrameUTool.SuspendLayout();
        gbCmdOutput.SuspendLayout();
        tabIO.SuspendLayout();
        tlpIO.SuspendLayout();
        gbReadDIN.SuspendLayout();
        gbWriteDOUT.SuspendLayout();
        gbIOOutput.SuspendLayout();
        tabFrames.SuspendLayout();
        tlpFrames.SuspendLayout();
        gbReadUFrame.SuspendLayout();
        gbWriteUFrame.SuspendLayout();
        gbReadUTool.SuspendLayout();
        gbWriteUTool.SuspendLayout();
        gbFramesOutput.SuspendLayout();
        tabPositions.SuspendLayout();
        tlpPositions.SuspendLayout();
        gbPosButtons.SuspendLayout();
        flpPosButtons.SuspendLayout();
        gbPosOutput.SuspendLayout();
        tabRegisters.SuspendLayout();
        tlpRegisters.SuspendLayout();
        gbReadPR.SuspendLayout();
        gbWritePR.SuspendLayout();
        gbRegOutput.SuspendLayout();
        tabInstructions.SuspendLayout();
        tlpInstr.SuspendLayout();
        gbWaitDin.SuspendLayout();
        gbWaitTime.SuspendLayout();
        gbSetUFrameInstr.SuspendLayout();
        gbSetUToolInstr.SuspendLayout();
        gbPayLoad.SuspendLayout();
        gbLinearMotion.SuspendLayout();
        gbLinearRelative.SuspendLayout();
        gbJointMotion.SuspendLayout();
        gbJointRelative.SuspendLayout();
        gbCircularMotion.SuspendLayout();
        gbCircularRelative.SuspendLayout();
        gbJointMotionJRep.SuspendLayout();
        gbJointRelativeJRep.SuspendLayout();
        gbInstrOutput.SuspendLayout();
        SuspendLayout();
        // 
        // tabMain
        // 
        tabMain.Controls.Add(tabCommands);
        tabMain.Controls.Add(tabIO);
        tabMain.Controls.Add(tabFrames);
        tabMain.Controls.Add(tabPositions);
        tabMain.Controls.Add(tabRegisters);
        tabMain.Controls.Add(tabInstructions);
        tabMain.Dock = DockStyle.Fill;
        tabMain.Location = new Point(0, 0);
        tabMain.Name = "tabMain";
        tabMain.SelectedIndex = 0;
        tabMain.Size = new Size(712, 431);
        tabMain.TabIndex = 0;
        // 
        // tabCommands
        // 
        tabCommands.Controls.Add(tlpCommands);
        tabCommands.Location = new Point(4, 24);
        tabCommands.Name = "tabCommands";
        tabCommands.Padding = new Padding(3);
        tabCommands.Size = new Size(704, 403);
        tabCommands.TabIndex = 0;
        tabCommands.Text = "Commands";
        tabCommands.UseVisualStyleBackColor = true;
        // 
        // tlpCommands
        // 
        tlpCommands.ColumnCount = 2;
        tlpCommands.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpCommands.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpCommands.Controls.Add(gbCmdButtons, 0, 0);
        tlpCommands.Controls.Add(gbSetUFrameUTool, 0, 1);
        tlpCommands.Controls.Add(gbCmdOutput, 1, 1);
        tlpCommands.Dock = DockStyle.Fill;
        tlpCommands.Location = new Point(3, 3);
        tlpCommands.Name = "tlpCommands";
        tlpCommands.RowCount = 2;
        tlpCommands.RowStyles.Add(new RowStyle());
        tlpCommands.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpCommands.Size = new Size(698, 397);
        tlpCommands.TabIndex = 0;
        // 
        // gbCmdButtons
        // 
        tlpCommands.SetColumnSpan(gbCmdButtons, 2);
        gbCmdButtons.Controls.Add(flpCmdButtons);
        gbCmdButtons.Dock = DockStyle.Fill;
        gbCmdButtons.Location = new Point(6, 6);
        gbCmdButtons.Margin = new Padding(6);
        gbCmdButtons.Name = "gbCmdButtons";
        gbCmdButtons.Size = new Size(686, 100);
        gbCmdButtons.TabIndex = 0;
        gbCmdButtons.TabStop = false;
        gbCmdButtons.Text = "Admin";
        // 
        // flpCmdButtons
        // 
        flpCmdButtons.AutoScroll = true;
        flpCmdButtons.Controls.Add(btnInitialize);
        flpCmdButtons.Controls.Add(btnAbort);
        flpCmdButtons.Controls.Add(btnPause);
        flpCmdButtons.Controls.Add(btnContinue);
        flpCmdButtons.Controls.Add(btnReset);
        flpCmdButtons.Controls.Add(btnGetStatus);
        flpCmdButtons.Controls.Add(btnReadError);
        flpCmdButtons.Controls.Add(btnGetUFrameUTool);
        flpCmdButtons.Dock = DockStyle.Fill;
        flpCmdButtons.Location = new Point(3, 19);
        flpCmdButtons.Name = "flpCmdButtons";
        flpCmdButtons.Padding = new Padding(6);
        flpCmdButtons.Size = new Size(680, 78);
        flpCmdButtons.TabIndex = 0;
        // 
        // btnInitialize
        // 
        btnInitialize.AutoSize = true;
        btnInitialize.Location = new Point(9, 9);
        btnInitialize.Name = "btnInitialize";
        btnInitialize.Size = new Size(75, 25);
        btnInitialize.TabIndex = 0;
        btnInitialize.Text = "Initialize";
        btnInitialize.Click += btnInitialize_Click;
        // 
        // btnAbort
        // 
        btnAbort.AutoSize = true;
        btnAbort.Location = new Point(90, 9);
        btnAbort.Name = "btnAbort";
        btnAbort.Size = new Size(75, 25);
        btnAbort.TabIndex = 1;
        btnAbort.Text = "Abort";
        btnAbort.Click += btnAbort_Click;
        // 
        // btnPause
        // 
        btnPause.AutoSize = true;
        btnPause.Location = new Point(171, 9);
        btnPause.Name = "btnPause";
        btnPause.Size = new Size(75, 25);
        btnPause.TabIndex = 2;
        btnPause.Text = "Pause";
        btnPause.Click += btnPause_Click;
        // 
        // btnContinue
        // 
        btnContinue.AutoSize = true;
        btnContinue.Location = new Point(252, 9);
        btnContinue.Name = "btnContinue";
        btnContinue.Size = new Size(75, 25);
        btnContinue.TabIndex = 3;
        btnContinue.Text = "Continue";
        btnContinue.Click += btnContinue_Click;
        // 
        // btnReset
        // 
        btnReset.AutoSize = true;
        btnReset.Location = new Point(333, 9);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(75, 25);
        btnReset.TabIndex = 4;
        btnReset.Text = "Reset";
        btnReset.Click += btnReset_Click;
        // 
        // btnGetStatus
        // 
        btnGetStatus.AutoSize = true;
        btnGetStatus.Location = new Point(414, 9);
        btnGetStatus.Name = "btnGetStatus";
        btnGetStatus.Size = new Size(75, 25);
        btnGetStatus.TabIndex = 5;
        btnGetStatus.Text = "GetStatus";
        btnGetStatus.Click += btnGetStatus_Click;
        // 
        // btnReadError
        // 
        btnReadError.AutoSize = true;
        btnReadError.Location = new Point(495, 9);
        btnReadError.Name = "btnReadError";
        btnReadError.Size = new Size(75, 25);
        btnReadError.TabIndex = 6;
        btnReadError.Text = "ReadError";
        btnReadError.Click += btnReadError_Click;
        // 
        // btnGetUFrameUTool
        // 
        btnGetUFrameUTool.AutoSize = true;
        btnGetUFrameUTool.Location = new Point(9, 40);
        btnGetUFrameUTool.Name = "btnGetUFrameUTool";
        btnGetUFrameUTool.Size = new Size(107, 25);
        btnGetUFrameUTool.TabIndex = 7;
        btnGetUFrameUTool.Text = "GetUFrameUTool";
        btnGetUFrameUTool.Click += btnGetUFrameUTool_Click;
        // 
        // gbSetUFrameUTool
        // 
        gbSetUFrameUTool.Controls.Add(pgSetUFrameUTool);
        gbSetUFrameUTool.Controls.Add(btnSetUFrameUTool);
        gbSetUFrameUTool.Dock = DockStyle.Fill;
        gbSetUFrameUTool.Location = new Point(6, 118);
        gbSetUFrameUTool.Margin = new Padding(6);
        gbSetUFrameUTool.Name = "gbSetUFrameUTool";
        gbSetUFrameUTool.Size = new Size(337, 273);
        gbSetUFrameUTool.TabIndex = 1;
        gbSetUFrameUTool.TabStop = false;
        gbSetUFrameUTool.Text = "SetUFrameUTool";
        // 
        // pgSetUFrameUTool
        // 
        pgSetUFrameUTool.Dock = DockStyle.Fill;
        pgSetUFrameUTool.HelpVisible = false;
        pgSetUFrameUTool.Location = new Point(3, 19);
        pgSetUFrameUTool.Name = "pgSetUFrameUTool";
        pgSetUFrameUTool.PropertySort = PropertySort.NoSort;
        pgSetUFrameUTool.Size = new Size(331, 223);
        pgSetUFrameUTool.TabIndex = 0;
        pgSetUFrameUTool.ToolbarVisible = false;
        // 
        // btnSetUFrameUTool
        // 
        btnSetUFrameUTool.Dock = DockStyle.Bottom;
        btnSetUFrameUTool.Location = new Point(3, 242);
        btnSetUFrameUTool.Name = "btnSetUFrameUTool";
        btnSetUFrameUTool.Size = new Size(331, 28);
        btnSetUFrameUTool.TabIndex = 1;
        btnSetUFrameUTool.Text = "SetUFrameUTool";
        btnSetUFrameUTool.Click += btnSetUFrameUTool_Click;
        // 
        // gbCmdOutput
        // 
        gbCmdOutput.Controls.Add(txtCommands);
        gbCmdOutput.Dock = DockStyle.Fill;
        gbCmdOutput.Location = new Point(355, 118);
        gbCmdOutput.Margin = new Padding(6);
        gbCmdOutput.Name = "gbCmdOutput";
        gbCmdOutput.Size = new Size(337, 273);
        gbCmdOutput.TabIndex = 2;
        gbCmdOutput.TabStop = false;
        gbCmdOutput.Text = "Output";
        // 
        // txtCommands
        // 
        txtCommands.Dock = DockStyle.Fill;
        txtCommands.Location = new Point(3, 19);
        txtCommands.Multiline = true;
        txtCommands.Name = "txtCommands";
        txtCommands.ReadOnly = true;
        txtCommands.ScrollBars = ScrollBars.Both;
        txtCommands.Size = new Size(331, 251);
        txtCommands.TabIndex = 0;
        // 
        // tabIO
        // 
        tabIO.Controls.Add(tlpIO);
        tabIO.Location = new Point(4, 24);
        tabIO.Name = "tabIO";
        tabIO.Padding = new Padding(3);
        tabIO.Size = new Size(704, 403);
        tabIO.TabIndex = 1;
        tabIO.Text = "I/O";
        tabIO.UseVisualStyleBackColor = true;
        // 
        // tlpIO
        // 
        tlpIO.ColumnCount = 2;
        tlpIO.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpIO.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpIO.Controls.Add(gbReadDIN, 0, 0);
        tlpIO.Controls.Add(gbWriteDOUT, 1, 0);
        tlpIO.Controls.Add(gbIOOutput, 0, 1);
        tlpIO.Dock = DockStyle.Fill;
        tlpIO.Location = new Point(3, 3);
        tlpIO.Name = "tlpIO";
        tlpIO.RowCount = 2;
        tlpIO.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpIO.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpIO.Size = new Size(698, 397);
        tlpIO.TabIndex = 0;
        // 
        // gbReadDIN
        // 
        gbReadDIN.Controls.Add(pgReadDIN);
        gbReadDIN.Controls.Add(btnReadDIN);
        gbReadDIN.Dock = DockStyle.Fill;
        gbReadDIN.Location = new Point(6, 6);
        gbReadDIN.Margin = new Padding(6);
        gbReadDIN.Name = "gbReadDIN";
        gbReadDIN.Size = new Size(337, 186);
        gbReadDIN.TabIndex = 0;
        gbReadDIN.TabStop = false;
        gbReadDIN.Text = "ReadDIN";
        // 
        // pgReadDIN
        // 
        pgReadDIN.Dock = DockStyle.Fill;
        pgReadDIN.HelpVisible = false;
        pgReadDIN.Location = new Point(3, 19);
        pgReadDIN.Name = "pgReadDIN";
        pgReadDIN.PropertySort = PropertySort.NoSort;
        pgReadDIN.Size = new Size(331, 136);
        pgReadDIN.TabIndex = 0;
        pgReadDIN.ToolbarVisible = false;
        // 
        // btnReadDIN
        // 
        btnReadDIN.Dock = DockStyle.Bottom;
        btnReadDIN.Location = new Point(3, 155);
        btnReadDIN.Name = "btnReadDIN";
        btnReadDIN.Size = new Size(331, 28);
        btnReadDIN.TabIndex = 1;
        btnReadDIN.Text = "ReadDIN";
        btnReadDIN.Click += btnReadDIN_Click;
        // 
        // gbWriteDOUT
        // 
        gbWriteDOUT.Controls.Add(pgWriteDOUT);
        gbWriteDOUT.Controls.Add(btnWriteDOUT);
        gbWriteDOUT.Dock = DockStyle.Fill;
        gbWriteDOUT.Location = new Point(355, 6);
        gbWriteDOUT.Margin = new Padding(6);
        gbWriteDOUT.Name = "gbWriteDOUT";
        gbWriteDOUT.Size = new Size(337, 186);
        gbWriteDOUT.TabIndex = 1;
        gbWriteDOUT.TabStop = false;
        gbWriteDOUT.Text = "WriteDOUT";
        // 
        // pgWriteDOUT
        // 
        pgWriteDOUT.Dock = DockStyle.Fill;
        pgWriteDOUT.HelpVisible = false;
        pgWriteDOUT.Location = new Point(3, 19);
        pgWriteDOUT.Name = "pgWriteDOUT";
        pgWriteDOUT.PropertySort = PropertySort.NoSort;
        pgWriteDOUT.Size = new Size(331, 136);
        pgWriteDOUT.TabIndex = 0;
        pgWriteDOUT.ToolbarVisible = false;
        // 
        // btnWriteDOUT
        // 
        btnWriteDOUT.Dock = DockStyle.Bottom;
        btnWriteDOUT.Location = new Point(3, 155);
        btnWriteDOUT.Name = "btnWriteDOUT";
        btnWriteDOUT.Size = new Size(331, 28);
        btnWriteDOUT.TabIndex = 1;
        btnWriteDOUT.Text = "WriteDOUT";
        btnWriteDOUT.Click += btnWriteDOUT_Click;
        // 
        // gbIOOutput
        // 
        tlpIO.SetColumnSpan(gbIOOutput, 2);
        gbIOOutput.Controls.Add(txtIO);
        gbIOOutput.Dock = DockStyle.Fill;
        gbIOOutput.Location = new Point(6, 204);
        gbIOOutput.Margin = new Padding(6);
        gbIOOutput.Name = "gbIOOutput";
        gbIOOutput.Size = new Size(686, 187);
        gbIOOutput.TabIndex = 2;
        gbIOOutput.TabStop = false;
        gbIOOutput.Text = "Output";
        // 
        // txtIO
        // 
        txtIO.Dock = DockStyle.Fill;
        txtIO.Location = new Point(3, 19);
        txtIO.Multiline = true;
        txtIO.Name = "txtIO";
        txtIO.ReadOnly = true;
        txtIO.ScrollBars = ScrollBars.Both;
        txtIO.Size = new Size(680, 165);
        txtIO.TabIndex = 0;
        // 
        // tabFrames
        // 
        tabFrames.Controls.Add(tlpFrames);
        tabFrames.Location = new Point(4, 24);
        tabFrames.Name = "tabFrames";
        tabFrames.Padding = new Padding(3);
        tabFrames.Size = new Size(704, 403);
        tabFrames.TabIndex = 2;
        tabFrames.Text = "Frames & Tools";
        tabFrames.UseVisualStyleBackColor = true;
        // 
        // tlpFrames
        // 
        tlpFrames.ColumnCount = 2;
        tlpFrames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpFrames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpFrames.Controls.Add(gbReadUFrame, 0, 0);
        tlpFrames.Controls.Add(gbWriteUFrame, 1, 0);
        tlpFrames.Controls.Add(gbReadUTool, 0, 1);
        tlpFrames.Controls.Add(gbWriteUTool, 1, 1);
        tlpFrames.Controls.Add(gbFramesOutput, 0, 2);
        tlpFrames.Dock = DockStyle.Fill;
        tlpFrames.Location = new Point(3, 3);
        tlpFrames.Name = "tlpFrames";
        tlpFrames.RowCount = 3;
        tlpFrames.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
        tlpFrames.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
        tlpFrames.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
        tlpFrames.Size = new Size(698, 397);
        tlpFrames.TabIndex = 0;
        // 
        // gbReadUFrame
        // 
        gbReadUFrame.Controls.Add(pgReadUFrame);
        gbReadUFrame.Controls.Add(btnReadUFrameData);
        gbReadUFrame.Dock = DockStyle.Fill;
        gbReadUFrame.Location = new Point(6, 6);
        gbReadUFrame.Margin = new Padding(6);
        gbReadUFrame.Name = "gbReadUFrame";
        gbReadUFrame.Size = new Size(337, 120);
        gbReadUFrame.TabIndex = 0;
        gbReadUFrame.TabStop = false;
        gbReadUFrame.Text = "ReadUFrameData";
        // 
        // pgReadUFrame
        // 
        pgReadUFrame.Dock = DockStyle.Fill;
        pgReadUFrame.HelpVisible = false;
        pgReadUFrame.Location = new Point(3, 19);
        pgReadUFrame.Name = "pgReadUFrame";
        pgReadUFrame.PropertySort = PropertySort.NoSort;
        pgReadUFrame.Size = new Size(331, 70);
        pgReadUFrame.TabIndex = 0;
        pgReadUFrame.ToolbarVisible = false;
        // 
        // btnReadUFrameData
        // 
        btnReadUFrameData.Dock = DockStyle.Bottom;
        btnReadUFrameData.Location = new Point(3, 89);
        btnReadUFrameData.Name = "btnReadUFrameData";
        btnReadUFrameData.Size = new Size(331, 28);
        btnReadUFrameData.TabIndex = 1;
        btnReadUFrameData.Text = "ReadUFrameData";
        btnReadUFrameData.Click += btnReadUFrameData_Click;
        // 
        // gbWriteUFrame
        // 
        gbWriteUFrame.Controls.Add(pgWriteUFrame);
        gbWriteUFrame.Controls.Add(btnWriteUFrameData);
        gbWriteUFrame.Dock = DockStyle.Fill;
        gbWriteUFrame.Location = new Point(355, 6);
        gbWriteUFrame.Margin = new Padding(6);
        gbWriteUFrame.Name = "gbWriteUFrame";
        gbWriteUFrame.Size = new Size(337, 120);
        gbWriteUFrame.TabIndex = 1;
        gbWriteUFrame.TabStop = false;
        gbWriteUFrame.Text = "WriteUFrameData";
        // 
        // pgWriteUFrame
        // 
        pgWriteUFrame.Dock = DockStyle.Fill;
        pgWriteUFrame.HelpVisible = false;
        pgWriteUFrame.Location = new Point(3, 19);
        pgWriteUFrame.Name = "pgWriteUFrame";
        pgWriteUFrame.PropertySort = PropertySort.NoSort;
        pgWriteUFrame.Size = new Size(331, 70);
        pgWriteUFrame.TabIndex = 0;
        pgWriteUFrame.ToolbarVisible = false;
        // 
        // btnWriteUFrameData
        // 
        btnWriteUFrameData.Dock = DockStyle.Bottom;
        btnWriteUFrameData.Location = new Point(3, 89);
        btnWriteUFrameData.Name = "btnWriteUFrameData";
        btnWriteUFrameData.Size = new Size(331, 28);
        btnWriteUFrameData.TabIndex = 1;
        btnWriteUFrameData.Text = "WriteUFrameData";
        btnWriteUFrameData.Click += btnWriteUFrameData_Click;
        // 
        // gbReadUTool
        // 
        gbReadUTool.Controls.Add(pgReadUTool);
        gbReadUTool.Controls.Add(btnReadUToolData);
        gbReadUTool.Dock = DockStyle.Fill;
        gbReadUTool.Location = new Point(6, 138);
        gbReadUTool.Margin = new Padding(6);
        gbReadUTool.Name = "gbReadUTool";
        gbReadUTool.Size = new Size(337, 120);
        gbReadUTool.TabIndex = 2;
        gbReadUTool.TabStop = false;
        gbReadUTool.Text = "ReadUToolData";
        // 
        // pgReadUTool
        // 
        pgReadUTool.Dock = DockStyle.Fill;
        pgReadUTool.HelpVisible = false;
        pgReadUTool.Location = new Point(3, 19);
        pgReadUTool.Name = "pgReadUTool";
        pgReadUTool.PropertySort = PropertySort.NoSort;
        pgReadUTool.Size = new Size(331, 70);
        pgReadUTool.TabIndex = 0;
        pgReadUTool.ToolbarVisible = false;
        // 
        // btnReadUToolData
        // 
        btnReadUToolData.Dock = DockStyle.Bottom;
        btnReadUToolData.Location = new Point(3, 89);
        btnReadUToolData.Name = "btnReadUToolData";
        btnReadUToolData.Size = new Size(331, 28);
        btnReadUToolData.TabIndex = 1;
        btnReadUToolData.Text = "ReadUToolData";
        btnReadUToolData.Click += btnReadUToolData_Click;
        // 
        // gbWriteUTool
        // 
        gbWriteUTool.Controls.Add(pgWriteUTool);
        gbWriteUTool.Controls.Add(btnWriteUToolData);
        gbWriteUTool.Dock = DockStyle.Fill;
        gbWriteUTool.Location = new Point(355, 138);
        gbWriteUTool.Margin = new Padding(6);
        gbWriteUTool.Name = "gbWriteUTool";
        gbWriteUTool.Size = new Size(337, 120);
        gbWriteUTool.TabIndex = 3;
        gbWriteUTool.TabStop = false;
        gbWriteUTool.Text = "WriteUToolData";
        // 
        // pgWriteUTool
        // 
        pgWriteUTool.Dock = DockStyle.Fill;
        pgWriteUTool.HelpVisible = false;
        pgWriteUTool.Location = new Point(3, 19);
        pgWriteUTool.Name = "pgWriteUTool";
        pgWriteUTool.PropertySort = PropertySort.NoSort;
        pgWriteUTool.Size = new Size(331, 70);
        pgWriteUTool.TabIndex = 0;
        pgWriteUTool.ToolbarVisible = false;
        // 
        // btnWriteUToolData
        // 
        btnWriteUToolData.Dock = DockStyle.Bottom;
        btnWriteUToolData.Location = new Point(3, 89);
        btnWriteUToolData.Name = "btnWriteUToolData";
        btnWriteUToolData.Size = new Size(331, 28);
        btnWriteUToolData.TabIndex = 1;
        btnWriteUToolData.Text = "WriteUToolData";
        btnWriteUToolData.Click += btnWriteUToolData_Click;
        // 
        // gbFramesOutput
        // 
        tlpFrames.SetColumnSpan(gbFramesOutput, 2);
        gbFramesOutput.Controls.Add(txtFrames);
        gbFramesOutput.Dock = DockStyle.Fill;
        gbFramesOutput.Location = new Point(6, 270);
        gbFramesOutput.Margin = new Padding(6);
        gbFramesOutput.Name = "gbFramesOutput";
        gbFramesOutput.Size = new Size(686, 121);
        gbFramesOutput.TabIndex = 4;
        gbFramesOutput.TabStop = false;
        gbFramesOutput.Text = "Output";
        // 
        // txtFrames
        // 
        txtFrames.Dock = DockStyle.Fill;
        txtFrames.Location = new Point(3, 19);
        txtFrames.Multiline = true;
        txtFrames.Name = "txtFrames";
        txtFrames.ReadOnly = true;
        txtFrames.ScrollBars = ScrollBars.Both;
        txtFrames.Size = new Size(680, 99);
        txtFrames.TabIndex = 0;
        // 
        // tabPositions
        // 
        tabPositions.Controls.Add(tlpPositions);
        tabPositions.Location = new Point(4, 24);
        tabPositions.Name = "tabPositions";
        tabPositions.Padding = new Padding(3);
        tabPositions.Size = new Size(704, 403);
        tabPositions.TabIndex = 3;
        tabPositions.Text = "Positions";
        tabPositions.UseVisualStyleBackColor = true;
        // 
        // tlpPositions
        // 
        tlpPositions.ColumnCount = 1;
        tlpPositions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpPositions.Controls.Add(gbPosButtons, 0, 0);
        tlpPositions.Controls.Add(gbPosOutput, 0, 1);
        tlpPositions.Dock = DockStyle.Fill;
        tlpPositions.Location = new Point(3, 3);
        tlpPositions.Name = "tlpPositions";
        tlpPositions.RowCount = 2;
        tlpPositions.RowStyles.Add(new RowStyle());
        tlpPositions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpPositions.Size = new Size(698, 397);
        tlpPositions.TabIndex = 0;
        // 
        // gbPosButtons
        // 
        gbPosButtons.Controls.Add(flpPosButtons);
        gbPosButtons.Dock = DockStyle.Top;
        gbPosButtons.Location = new Point(3, 3);
        gbPosButtons.Name = "gbPosButtons";
        gbPosButtons.Size = new Size(692, 70);
        gbPosButtons.TabIndex = 0;
        gbPosButtons.TabStop = false;
        gbPosButtons.Text = "Queries";
        // 
        // flpPosButtons
        // 
        flpPosButtons.AutoScroll = true;
        flpPosButtons.Controls.Add(btnReadCartesianPosition);
        flpPosButtons.Controls.Add(btnReadJointAngles);
        flpPosButtons.Controls.Add(btnReadTCPSpeed);
        flpPosButtons.Dock = DockStyle.Fill;
        flpPosButtons.Location = new Point(3, 19);
        flpPosButtons.Name = "flpPosButtons";
        flpPosButtons.Padding = new Padding(6);
        flpPosButtons.Size = new Size(686, 48);
        flpPosButtons.TabIndex = 0;
        // 
        // btnReadCartesianPosition
        // 
        btnReadCartesianPosition.AutoSize = true;
        btnReadCartesianPosition.Location = new Point(9, 9);
        btnReadCartesianPosition.Name = "btnReadCartesianPosition";
        btnReadCartesianPosition.Size = new Size(135, 25);
        btnReadCartesianPosition.TabIndex = 0;
        btnReadCartesianPosition.Text = "ReadCartesianPosition";
        btnReadCartesianPosition.Click += btnReadCartesianPosition_Click;
        // 
        // btnReadJointAngles
        // 
        btnReadJointAngles.AutoSize = true;
        btnReadJointAngles.Location = new Point(150, 9);
        btnReadJointAngles.Name = "btnReadJointAngles";
        btnReadJointAngles.Size = new Size(104, 25);
        btnReadJointAngles.TabIndex = 1;
        btnReadJointAngles.Text = "ReadJointAngles";
        btnReadJointAngles.Click += btnReadJointAngles_Click;
        // 
        // btnReadTCPSpeed
        // 
        btnReadTCPSpeed.AutoSize = true;
        btnReadTCPSpeed.Location = new Point(260, 9);
        btnReadTCPSpeed.Name = "btnReadTCPSpeed";
        btnReadTCPSpeed.Size = new Size(96, 25);
        btnReadTCPSpeed.TabIndex = 2;
        btnReadTCPSpeed.Text = "ReadTCPSpeed";
        btnReadTCPSpeed.Click += btnReadTCPSpeed_Click;
        // 
        // gbPosOutput
        // 
        gbPosOutput.Controls.Add(txtPositions);
        gbPosOutput.Dock = DockStyle.Fill;
        gbPosOutput.Location = new Point(3, 79);
        gbPosOutput.Name = "gbPosOutput";
        gbPosOutput.Size = new Size(692, 315);
        gbPosOutput.TabIndex = 1;
        gbPosOutput.TabStop = false;
        gbPosOutput.Text = "Output";
        // 
        // txtPositions
        // 
        txtPositions.Dock = DockStyle.Fill;
        txtPositions.Location = new Point(3, 19);
        txtPositions.Multiline = true;
        txtPositions.Name = "txtPositions";
        txtPositions.ReadOnly = true;
        txtPositions.ScrollBars = ScrollBars.Both;
        txtPositions.Size = new Size(686, 293);
        txtPositions.TabIndex = 0;
        // 
        // tabRegisters
        // 
        tabRegisters.Controls.Add(tlpRegisters);
        tabRegisters.Location = new Point(4, 24);
        tabRegisters.Name = "tabRegisters";
        tabRegisters.Padding = new Padding(3);
        tabRegisters.Size = new Size(704, 403);
        tabRegisters.TabIndex = 4;
        tabRegisters.Text = "Registers";
        tabRegisters.UseVisualStyleBackColor = true;
        // 
        // tlpRegisters
        // 
        tlpRegisters.ColumnCount = 2;
        tlpRegisters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpRegisters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpRegisters.Controls.Add(gbReadPR, 0, 0);
        tlpRegisters.Controls.Add(gbWritePR, 1, 0);
        tlpRegisters.Controls.Add(gbRegOutput, 0, 1);
        tlpRegisters.Dock = DockStyle.Fill;
        tlpRegisters.Location = new Point(3, 3);
        tlpRegisters.Name = "tlpRegisters";
        tlpRegisters.RowCount = 2;
        tlpRegisters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpRegisters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpRegisters.Size = new Size(698, 397);
        tlpRegisters.TabIndex = 0;
        // 
        // gbReadPR
        // 
        gbReadPR.Controls.Add(pgReadPR);
        gbReadPR.Controls.Add(btnReadPositionRegister);
        gbReadPR.Dock = DockStyle.Fill;
        gbReadPR.Location = new Point(6, 6);
        gbReadPR.Margin = new Padding(6);
        gbReadPR.Name = "gbReadPR";
        gbReadPR.Size = new Size(337, 186);
        gbReadPR.TabIndex = 0;
        gbReadPR.TabStop = false;
        gbReadPR.Text = "ReadPositionRegister";
        // 
        // pgReadPR
        // 
        pgReadPR.Dock = DockStyle.Fill;
        pgReadPR.HelpVisible = false;
        pgReadPR.Location = new Point(3, 19);
        pgReadPR.Name = "pgReadPR";
        pgReadPR.PropertySort = PropertySort.NoSort;
        pgReadPR.Size = new Size(331, 136);
        pgReadPR.TabIndex = 0;
        pgReadPR.ToolbarVisible = false;
        // 
        // btnReadPositionRegister
        // 
        btnReadPositionRegister.Dock = DockStyle.Bottom;
        btnReadPositionRegister.Location = new Point(3, 155);
        btnReadPositionRegister.Name = "btnReadPositionRegister";
        btnReadPositionRegister.Size = new Size(331, 28);
        btnReadPositionRegister.TabIndex = 1;
        btnReadPositionRegister.Text = "ReadPositionRegister";
        btnReadPositionRegister.Click += btnReadPositionRegister_Click;
        // 
        // gbWritePR
        // 
        gbWritePR.Controls.Add(pgWritePR);
        gbWritePR.Controls.Add(btnWritePositionRegister);
        gbWritePR.Dock = DockStyle.Fill;
        gbWritePR.Location = new Point(355, 6);
        gbWritePR.Margin = new Padding(6);
        gbWritePR.Name = "gbWritePR";
        gbWritePR.Size = new Size(337, 186);
        gbWritePR.TabIndex = 1;
        gbWritePR.TabStop = false;
        gbWritePR.Text = "WritePositionRegister";
        // 
        // pgWritePR
        // 
        pgWritePR.Dock = DockStyle.Fill;
        pgWritePR.HelpVisible = false;
        pgWritePR.Location = new Point(3, 19);
        pgWritePR.Name = "pgWritePR";
        pgWritePR.PropertySort = PropertySort.NoSort;
        pgWritePR.Size = new Size(331, 136);
        pgWritePR.TabIndex = 0;
        pgWritePR.ToolbarVisible = false;
        // 
        // btnWritePositionRegister
        // 
        btnWritePositionRegister.Dock = DockStyle.Bottom;
        btnWritePositionRegister.Location = new Point(3, 155);
        btnWritePositionRegister.Name = "btnWritePositionRegister";
        btnWritePositionRegister.Size = new Size(331, 28);
        btnWritePositionRegister.TabIndex = 1;
        btnWritePositionRegister.Text = "WritePositionRegister";
        btnWritePositionRegister.Click += btnWritePositionRegister_Click;
        // 
        // gbRegOutput
        // 
        tlpRegisters.SetColumnSpan(gbRegOutput, 2);
        gbRegOutput.Controls.Add(txtRegisters);
        gbRegOutput.Dock = DockStyle.Fill;
        gbRegOutput.Location = new Point(6, 204);
        gbRegOutput.Margin = new Padding(6);
        gbRegOutput.Name = "gbRegOutput";
        gbRegOutput.Size = new Size(686, 187);
        gbRegOutput.TabIndex = 2;
        gbRegOutput.TabStop = false;
        gbRegOutput.Text = "Output";
        // 
        // txtRegisters
        // 
        txtRegisters.Dock = DockStyle.Fill;
        txtRegisters.Location = new Point(3, 19);
        txtRegisters.Multiline = true;
        txtRegisters.Name = "txtRegisters";
        txtRegisters.ReadOnly = true;
        txtRegisters.ScrollBars = ScrollBars.Both;
        txtRegisters.Size = new Size(680, 165);
        txtRegisters.TabIndex = 0;
        // 
        // tabInstructions
        // 
        tabInstructions.Controls.Add(tlpInstr);
        tabInstructions.Location = new Point(4, 24);
        tabInstructions.Name = "tabInstructions";
        tabInstructions.Padding = new Padding(3);
        tabInstructions.Size = new Size(704, 403);
        tabInstructions.TabIndex = 5;
        tabInstructions.Text = "Instructions";
        tabInstructions.UseVisualStyleBackColor = true;
        // 
        // tlpInstr
        // 
        tlpInstr.ColumnCount = 4;
        tlpInstr.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tlpInstr.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tlpInstr.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tlpInstr.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tlpInstr.Controls.Add(gbWaitDin, 0, 0);
        tlpInstr.Controls.Add(gbWaitTime, 1, 0);
        tlpInstr.Controls.Add(gbSetUFrameInstr, 2, 0);
        tlpInstr.Controls.Add(gbSetUToolInstr, 3, 0);
        tlpInstr.Controls.Add(gbPayLoad, 0, 1);
        tlpInstr.Controls.Add(gbLinearMotion, 1, 1);
        tlpInstr.Controls.Add(gbLinearRelative, 2, 1);
        tlpInstr.Controls.Add(gbJointMotion, 3, 1);
        tlpInstr.Controls.Add(gbJointRelative, 0, 2);
        tlpInstr.Controls.Add(gbCircularMotion, 1, 2);
        tlpInstr.Controls.Add(gbCircularRelative, 2, 2);
        tlpInstr.Controls.Add(gbJointMotionJRep, 3, 2);
        tlpInstr.Controls.Add(gbJointRelativeJRep, 0, 3);
        tlpInstr.Controls.Add(gbInstrOutput, 1, 3);
        tlpInstr.Dock = DockStyle.Fill;
        tlpInstr.Location = new Point(3, 3);
        tlpInstr.Name = "tlpInstr";
        tlpInstr.RowCount = 4;
        tlpInstr.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tlpInstr.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tlpInstr.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tlpInstr.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tlpInstr.Size = new Size(698, 397);
        tlpInstr.TabIndex = 0;
        // 
        // gbWaitDin
        // 
        gbWaitDin.Controls.Add(pgWaitDin);
        gbWaitDin.Controls.Add(btnWaitDin);
        gbWaitDin.Dock = DockStyle.Fill;
        gbWaitDin.Location = new Point(6, 6);
        gbWaitDin.Margin = new Padding(6);
        gbWaitDin.Name = "gbWaitDin";
        gbWaitDin.Size = new Size(162, 87);
        gbWaitDin.TabIndex = 0;
        gbWaitDin.TabStop = false;
        gbWaitDin.Text = "WaitDin";
        // 
        // pgWaitDin
        // 
        pgWaitDin.Dock = DockStyle.Fill;
        pgWaitDin.HelpVisible = false;
        pgWaitDin.Location = new Point(3, 19);
        pgWaitDin.Name = "pgWaitDin";
        pgWaitDin.PropertySort = PropertySort.NoSort;
        pgWaitDin.Size = new Size(156, 37);
        pgWaitDin.TabIndex = 0;
        pgWaitDin.ToolbarVisible = false;
        // 
        // btnWaitDin
        // 
        btnWaitDin.Dock = DockStyle.Bottom;
        btnWaitDin.Location = new Point(3, 56);
        btnWaitDin.Name = "btnWaitDin";
        btnWaitDin.Size = new Size(156, 28);
        btnWaitDin.TabIndex = 1;
        btnWaitDin.Text = "WaitDin";
        btnWaitDin.Click += btnWaitDin_Click;
        // 
        // gbWaitTime
        // 
        gbWaitTime.Controls.Add(pgWaitTime);
        gbWaitTime.Controls.Add(btnWaitTime);
        gbWaitTime.Dock = DockStyle.Fill;
        gbWaitTime.Location = new Point(180, 6);
        gbWaitTime.Margin = new Padding(6);
        gbWaitTime.Name = "gbWaitTime";
        gbWaitTime.Size = new Size(162, 87);
        gbWaitTime.TabIndex = 1;
        gbWaitTime.TabStop = false;
        gbWaitTime.Text = "WaitTime";
        // 
        // pgWaitTime
        // 
        pgWaitTime.Dock = DockStyle.Fill;
        pgWaitTime.HelpVisible = false;
        pgWaitTime.Location = new Point(3, 19);
        pgWaitTime.Name = "pgWaitTime";
        pgWaitTime.PropertySort = PropertySort.NoSort;
        pgWaitTime.Size = new Size(156, 37);
        pgWaitTime.TabIndex = 0;
        pgWaitTime.ToolbarVisible = false;
        // 
        // btnWaitTime
        // 
        btnWaitTime.Dock = DockStyle.Bottom;
        btnWaitTime.Location = new Point(3, 56);
        btnWaitTime.Name = "btnWaitTime";
        btnWaitTime.Size = new Size(156, 28);
        btnWaitTime.TabIndex = 1;
        btnWaitTime.Text = "WaitTime";
        btnWaitTime.Click += btnWaitTime_Click;
        // 
        // gbSetUFrameInstr
        // 
        gbSetUFrameInstr.Controls.Add(pgSetUFrameInstr);
        gbSetUFrameInstr.Controls.Add(btnSetUFrame);
        gbSetUFrameInstr.Dock = DockStyle.Fill;
        gbSetUFrameInstr.Location = new Point(354, 6);
        gbSetUFrameInstr.Margin = new Padding(6);
        gbSetUFrameInstr.Name = "gbSetUFrameInstr";
        gbSetUFrameInstr.Size = new Size(162, 87);
        gbSetUFrameInstr.TabIndex = 2;
        gbSetUFrameInstr.TabStop = false;
        gbSetUFrameInstr.Text = "SetUFrame";
        // 
        // pgSetUFrameInstr
        // 
        pgSetUFrameInstr.Dock = DockStyle.Fill;
        pgSetUFrameInstr.HelpVisible = false;
        pgSetUFrameInstr.Location = new Point(3, 19);
        pgSetUFrameInstr.Name = "pgSetUFrameInstr";
        pgSetUFrameInstr.PropertySort = PropertySort.NoSort;
        pgSetUFrameInstr.Size = new Size(156, 37);
        pgSetUFrameInstr.TabIndex = 0;
        pgSetUFrameInstr.ToolbarVisible = false;
        // 
        // btnSetUFrame
        // 
        btnSetUFrame.Dock = DockStyle.Bottom;
        btnSetUFrame.Location = new Point(3, 56);
        btnSetUFrame.Name = "btnSetUFrame";
        btnSetUFrame.Size = new Size(156, 28);
        btnSetUFrame.TabIndex = 1;
        btnSetUFrame.Text = "SetUFrame";
        btnSetUFrame.Click += btnSetUFrame_Click;
        // 
        // gbSetUToolInstr
        // 
        gbSetUToolInstr.Controls.Add(pgSetUToolInstr);
        gbSetUToolInstr.Controls.Add(btnSetUTool);
        gbSetUToolInstr.Dock = DockStyle.Fill;
        gbSetUToolInstr.Location = new Point(528, 6);
        gbSetUToolInstr.Margin = new Padding(6);
        gbSetUToolInstr.Name = "gbSetUToolInstr";
        gbSetUToolInstr.Size = new Size(164, 87);
        gbSetUToolInstr.TabIndex = 3;
        gbSetUToolInstr.TabStop = false;
        gbSetUToolInstr.Text = "SetUTool";
        // 
        // pgSetUToolInstr
        // 
        pgSetUToolInstr.Dock = DockStyle.Fill;
        pgSetUToolInstr.HelpVisible = false;
        pgSetUToolInstr.Location = new Point(3, 19);
        pgSetUToolInstr.Name = "pgSetUToolInstr";
        pgSetUToolInstr.PropertySort = PropertySort.NoSort;
        pgSetUToolInstr.Size = new Size(158, 37);
        pgSetUToolInstr.TabIndex = 0;
        pgSetUToolInstr.ToolbarVisible = false;
        // 
        // btnSetUTool
        // 
        btnSetUTool.Dock = DockStyle.Bottom;
        btnSetUTool.Location = new Point(3, 56);
        btnSetUTool.Name = "btnSetUTool";
        btnSetUTool.Size = new Size(158, 28);
        btnSetUTool.TabIndex = 1;
        btnSetUTool.Text = "SetUTool";
        btnSetUTool.Click += btnSetUTool_Click;
        // 
        // gbPayLoad
        // 
        gbPayLoad.Controls.Add(pgPayLoad);
        gbPayLoad.Controls.Add(btnPayLoad);
        gbPayLoad.Dock = DockStyle.Fill;
        gbPayLoad.Location = new Point(6, 105);
        gbPayLoad.Margin = new Padding(6);
        gbPayLoad.Name = "gbPayLoad";
        gbPayLoad.Size = new Size(162, 87);
        gbPayLoad.TabIndex = 4;
        gbPayLoad.TabStop = false;
        gbPayLoad.Text = "PayLoad";
        // 
        // pgPayLoad
        // 
        pgPayLoad.Dock = DockStyle.Fill;
        pgPayLoad.HelpVisible = false;
        pgPayLoad.Location = new Point(3, 19);
        pgPayLoad.Name = "pgPayLoad";
        pgPayLoad.PropertySort = PropertySort.NoSort;
        pgPayLoad.Size = new Size(156, 37);
        pgPayLoad.TabIndex = 0;
        pgPayLoad.ToolbarVisible = false;
        // 
        // btnPayLoad
        // 
        btnPayLoad.Dock = DockStyle.Bottom;
        btnPayLoad.Location = new Point(3, 56);
        btnPayLoad.Name = "btnPayLoad";
        btnPayLoad.Size = new Size(156, 28);
        btnPayLoad.TabIndex = 1;
        btnPayLoad.Text = "PayLoad";
        btnPayLoad.Click += btnPayLoad_Click;
        // 
        // gbLinearMotion
        // 
        gbLinearMotion.Controls.Add(pgLinearMotion);
        gbLinearMotion.Controls.Add(btnLinearMotion);
        gbLinearMotion.Dock = DockStyle.Fill;
        gbLinearMotion.Location = new Point(180, 105);
        gbLinearMotion.Margin = new Padding(6);
        gbLinearMotion.Name = "gbLinearMotion";
        gbLinearMotion.Size = new Size(162, 87);
        gbLinearMotion.TabIndex = 5;
        gbLinearMotion.TabStop = false;
        gbLinearMotion.Text = "LinearMotion";
        // 
        // pgLinearMotion
        // 
        pgLinearMotion.Dock = DockStyle.Fill;
        pgLinearMotion.HelpVisible = false;
        pgLinearMotion.Location = new Point(3, 19);
        pgLinearMotion.Name = "pgLinearMotion";
        pgLinearMotion.PropertySort = PropertySort.NoSort;
        pgLinearMotion.Size = new Size(156, 37);
        pgLinearMotion.TabIndex = 0;
        pgLinearMotion.ToolbarVisible = false;
        // 
        // btnLinearMotion
        // 
        btnLinearMotion.Dock = DockStyle.Bottom;
        btnLinearMotion.Location = new Point(3, 56);
        btnLinearMotion.Name = "btnLinearMotion";
        btnLinearMotion.Size = new Size(156, 28);
        btnLinearMotion.TabIndex = 1;
        btnLinearMotion.Text = "LinearMotion";
        btnLinearMotion.Click += btnLinearMotion_Click;
        // 
        // gbLinearRelative
        // 
        gbLinearRelative.Controls.Add(pgLinearRelative);
        gbLinearRelative.Controls.Add(btnLinearRelative);
        gbLinearRelative.Dock = DockStyle.Fill;
        gbLinearRelative.Location = new Point(354, 105);
        gbLinearRelative.Margin = new Padding(6);
        gbLinearRelative.Name = "gbLinearRelative";
        gbLinearRelative.Size = new Size(162, 87);
        gbLinearRelative.TabIndex = 6;
        gbLinearRelative.TabStop = false;
        gbLinearRelative.Text = "LinearRelative";
        // 
        // pgLinearRelative
        // 
        pgLinearRelative.Dock = DockStyle.Fill;
        pgLinearRelative.HelpVisible = false;
        pgLinearRelative.Location = new Point(3, 19);
        pgLinearRelative.Name = "pgLinearRelative";
        pgLinearRelative.PropertySort = PropertySort.NoSort;
        pgLinearRelative.Size = new Size(156, 37);
        pgLinearRelative.TabIndex = 0;
        pgLinearRelative.ToolbarVisible = false;
        // 
        // btnLinearRelative
        // 
        btnLinearRelative.Dock = DockStyle.Bottom;
        btnLinearRelative.Location = new Point(3, 56);
        btnLinearRelative.Name = "btnLinearRelative";
        btnLinearRelative.Size = new Size(156, 28);
        btnLinearRelative.TabIndex = 1;
        btnLinearRelative.Text = "LinearRelative";
        btnLinearRelative.Click += btnLinearRelative_Click;
        // 
        // gbJointMotion
        // 
        gbJointMotion.Controls.Add(pgJointMotion);
        gbJointMotion.Controls.Add(btnJointMotion);
        gbJointMotion.Dock = DockStyle.Fill;
        gbJointMotion.Location = new Point(528, 105);
        gbJointMotion.Margin = new Padding(6);
        gbJointMotion.Name = "gbJointMotion";
        gbJointMotion.Size = new Size(164, 87);
        gbJointMotion.TabIndex = 7;
        gbJointMotion.TabStop = false;
        gbJointMotion.Text = "JointMotion";
        // 
        // pgJointMotion
        // 
        pgJointMotion.Dock = DockStyle.Fill;
        pgJointMotion.HelpVisible = false;
        pgJointMotion.Location = new Point(3, 19);
        pgJointMotion.Name = "pgJointMotion";
        pgJointMotion.PropertySort = PropertySort.NoSort;
        pgJointMotion.Size = new Size(158, 37);
        pgJointMotion.TabIndex = 0;
        pgJointMotion.ToolbarVisible = false;
        // 
        // btnJointMotion
        // 
        btnJointMotion.Dock = DockStyle.Bottom;
        btnJointMotion.Location = new Point(3, 56);
        btnJointMotion.Name = "btnJointMotion";
        btnJointMotion.Size = new Size(158, 28);
        btnJointMotion.TabIndex = 1;
        btnJointMotion.Text = "JointMotion";
        btnJointMotion.Click += btnJointMotion_Click;
        // 
        // gbJointRelative
        // 
        gbJointRelative.Controls.Add(pgJointRelative);
        gbJointRelative.Controls.Add(btnJointRelative);
        gbJointRelative.Dock = DockStyle.Fill;
        gbJointRelative.Location = new Point(6, 204);
        gbJointRelative.Margin = new Padding(6);
        gbJointRelative.Name = "gbJointRelative";
        gbJointRelative.Size = new Size(162, 87);
        gbJointRelative.TabIndex = 8;
        gbJointRelative.TabStop = false;
        gbJointRelative.Text = "JointRelative";
        // 
        // pgJointRelative
        // 
        pgJointRelative.Dock = DockStyle.Fill;
        pgJointRelative.HelpVisible = false;
        pgJointRelative.Location = new Point(3, 19);
        pgJointRelative.Name = "pgJointRelative";
        pgJointRelative.PropertySort = PropertySort.NoSort;
        pgJointRelative.Size = new Size(156, 37);
        pgJointRelative.TabIndex = 0;
        pgJointRelative.ToolbarVisible = false;
        // 
        // btnJointRelative
        // 
        btnJointRelative.Dock = DockStyle.Bottom;
        btnJointRelative.Location = new Point(3, 56);
        btnJointRelative.Name = "btnJointRelative";
        btnJointRelative.Size = new Size(156, 28);
        btnJointRelative.TabIndex = 1;
        btnJointRelative.Text = "JointRelative";
        btnJointRelative.Click += btnJointRelative_Click;
        // 
        // gbCircularMotion
        // 
        gbCircularMotion.Controls.Add(pgCircularMotion);
        gbCircularMotion.Controls.Add(btnCircularMotion);
        gbCircularMotion.Dock = DockStyle.Fill;
        gbCircularMotion.Location = new Point(180, 204);
        gbCircularMotion.Margin = new Padding(6);
        gbCircularMotion.Name = "gbCircularMotion";
        gbCircularMotion.Size = new Size(162, 87);
        gbCircularMotion.TabIndex = 9;
        gbCircularMotion.TabStop = false;
        gbCircularMotion.Text = "CircularMotion";
        // 
        // pgCircularMotion
        // 
        pgCircularMotion.Dock = DockStyle.Fill;
        pgCircularMotion.HelpVisible = false;
        pgCircularMotion.Location = new Point(3, 19);
        pgCircularMotion.Name = "pgCircularMotion";
        pgCircularMotion.PropertySort = PropertySort.NoSort;
        pgCircularMotion.Size = new Size(156, 37);
        pgCircularMotion.TabIndex = 0;
        pgCircularMotion.ToolbarVisible = false;
        // 
        // btnCircularMotion
        // 
        btnCircularMotion.Dock = DockStyle.Bottom;
        btnCircularMotion.Location = new Point(3, 56);
        btnCircularMotion.Name = "btnCircularMotion";
        btnCircularMotion.Size = new Size(156, 28);
        btnCircularMotion.TabIndex = 1;
        btnCircularMotion.Text = "CircularMotion";
        btnCircularMotion.Click += btnCircularMotion_Click;
        // 
        // gbCircularRelative
        // 
        gbCircularRelative.Controls.Add(pgCircularRelative);
        gbCircularRelative.Controls.Add(btnCircularRelative);
        gbCircularRelative.Dock = DockStyle.Fill;
        gbCircularRelative.Location = new Point(354, 204);
        gbCircularRelative.Margin = new Padding(6);
        gbCircularRelative.Name = "gbCircularRelative";
        gbCircularRelative.Size = new Size(162, 87);
        gbCircularRelative.TabIndex = 10;
        gbCircularRelative.TabStop = false;
        gbCircularRelative.Text = "CircularRelative";
        // 
        // pgCircularRelative
        // 
        pgCircularRelative.Dock = DockStyle.Fill;
        pgCircularRelative.HelpVisible = false;
        pgCircularRelative.Location = new Point(3, 19);
        pgCircularRelative.Name = "pgCircularRelative";
        pgCircularRelative.PropertySort = PropertySort.NoSort;
        pgCircularRelative.Size = new Size(156, 37);
        pgCircularRelative.TabIndex = 0;
        pgCircularRelative.ToolbarVisible = false;
        // 
        // btnCircularRelative
        // 
        btnCircularRelative.Dock = DockStyle.Bottom;
        btnCircularRelative.Location = new Point(3, 56);
        btnCircularRelative.Name = "btnCircularRelative";
        btnCircularRelative.Size = new Size(156, 28);
        btnCircularRelative.TabIndex = 1;
        btnCircularRelative.Text = "CircularRelative";
        btnCircularRelative.Click += btnCircularRelative_Click;
        // 
        // gbJointMotionJRep
        // 
        gbJointMotionJRep.Controls.Add(pgJointMotionJRep);
        gbJointMotionJRep.Controls.Add(btnJointMotionJRep);
        gbJointMotionJRep.Dock = DockStyle.Fill;
        gbJointMotionJRep.Location = new Point(528, 204);
        gbJointMotionJRep.Margin = new Padding(6);
        gbJointMotionJRep.Name = "gbJointMotionJRep";
        gbJointMotionJRep.Size = new Size(164, 87);
        gbJointMotionJRep.TabIndex = 11;
        gbJointMotionJRep.TabStop = false;
        gbJointMotionJRep.Text = "JointMotionJRep";
        // 
        // pgJointMotionJRep
        // 
        pgJointMotionJRep.Dock = DockStyle.Fill;
        pgJointMotionJRep.HelpVisible = false;
        pgJointMotionJRep.Location = new Point(3, 19);
        pgJointMotionJRep.Name = "pgJointMotionJRep";
        pgJointMotionJRep.PropertySort = PropertySort.NoSort;
        pgJointMotionJRep.Size = new Size(158, 37);
        pgJointMotionJRep.TabIndex = 0;
        pgJointMotionJRep.ToolbarVisible = false;
        // 
        // btnJointMotionJRep
        // 
        btnJointMotionJRep.Dock = DockStyle.Bottom;
        btnJointMotionJRep.Location = new Point(3, 56);
        btnJointMotionJRep.Name = "btnJointMotionJRep";
        btnJointMotionJRep.Size = new Size(158, 28);
        btnJointMotionJRep.TabIndex = 1;
        btnJointMotionJRep.Text = "JointMotionJRep";
        btnJointMotionJRep.Click += btnJointMotionJRep_Click;
        // 
        // gbJointRelativeJRep
        // 
        gbJointRelativeJRep.Controls.Add(pgJointRelativeJRep);
        gbJointRelativeJRep.Controls.Add(btnJointRelativeJRep);
        gbJointRelativeJRep.Dock = DockStyle.Fill;
        gbJointRelativeJRep.Location = new Point(6, 303);
        gbJointRelativeJRep.Margin = new Padding(6);
        gbJointRelativeJRep.Name = "gbJointRelativeJRep";
        gbJointRelativeJRep.Size = new Size(162, 88);
        gbJointRelativeJRep.TabIndex = 12;
        gbJointRelativeJRep.TabStop = false;
        gbJointRelativeJRep.Text = "JointRelativeJRep";
        // 
        // pgJointRelativeJRep
        // 
        pgJointRelativeJRep.Dock = DockStyle.Fill;
        pgJointRelativeJRep.HelpVisible = false;
        pgJointRelativeJRep.Location = new Point(3, 19);
        pgJointRelativeJRep.Name = "pgJointRelativeJRep";
        pgJointRelativeJRep.PropertySort = PropertySort.NoSort;
        pgJointRelativeJRep.Size = new Size(156, 38);
        pgJointRelativeJRep.TabIndex = 0;
        pgJointRelativeJRep.ToolbarVisible = false;
        // 
        // btnJointRelativeJRep
        // 
        btnJointRelativeJRep.Dock = DockStyle.Bottom;
        btnJointRelativeJRep.Location = new Point(3, 57);
        btnJointRelativeJRep.Name = "btnJointRelativeJRep";
        btnJointRelativeJRep.Size = new Size(156, 28);
        btnJointRelativeJRep.TabIndex = 1;
        btnJointRelativeJRep.Text = "JointRelativeJRep";
        btnJointRelativeJRep.Click += btnJointRelativeJRep_Click;
        // 
        // gbInstrOutput
        // 
        tlpInstr.SetColumnSpan(gbInstrOutput, 3);
        gbInstrOutput.Controls.Add(txtInstructions);
        gbInstrOutput.Dock = DockStyle.Fill;
        gbInstrOutput.Location = new Point(180, 303);
        gbInstrOutput.Margin = new Padding(6);
        gbInstrOutput.Name = "gbInstrOutput";
        gbInstrOutput.Size = new Size(512, 88);
        gbInstrOutput.TabIndex = 13;
        gbInstrOutput.TabStop = false;
        gbInstrOutput.Text = "Output";
        // 
        // txtInstructions
        // 
        txtInstructions.Dock = DockStyle.Fill;
        txtInstructions.Location = new Point(3, 19);
        txtInstructions.Multiline = true;
        txtInstructions.Name = "txtInstructions";
        txtInstructions.ReadOnly = true;
        txtInstructions.ScrollBars = ScrollBars.Both;
        txtInstructions.Size = new Size(506, 66);
        txtInstructions.TabIndex = 0;
        // 
        // RmiControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(tabMain);
        Margin = new Padding(4, 3, 4, 3);
        Name = "RmiControl";
        Size = new Size(712, 431);
        tabMain.ResumeLayout(false);
        tabCommands.ResumeLayout(false);
        tlpCommands.ResumeLayout(false);
        gbCmdButtons.ResumeLayout(false);
        flpCmdButtons.ResumeLayout(false);
        flpCmdButtons.PerformLayout();
        gbSetUFrameUTool.ResumeLayout(false);
        gbCmdOutput.ResumeLayout(false);
        gbCmdOutput.PerformLayout();
        tabIO.ResumeLayout(false);
        tlpIO.ResumeLayout(false);
        gbReadDIN.ResumeLayout(false);
        gbWriteDOUT.ResumeLayout(false);
        gbIOOutput.ResumeLayout(false);
        gbIOOutput.PerformLayout();
        tabFrames.ResumeLayout(false);
        tlpFrames.ResumeLayout(false);
        gbReadUFrame.ResumeLayout(false);
        gbWriteUFrame.ResumeLayout(false);
        gbReadUTool.ResumeLayout(false);
        gbWriteUTool.ResumeLayout(false);
        gbFramesOutput.ResumeLayout(false);
        gbFramesOutput.PerformLayout();
        tabPositions.ResumeLayout(false);
        tlpPositions.ResumeLayout(false);
        gbPosButtons.ResumeLayout(false);
        flpPosButtons.ResumeLayout(false);
        flpPosButtons.PerformLayout();
        gbPosOutput.ResumeLayout(false);
        gbPosOutput.PerformLayout();
        tabRegisters.ResumeLayout(false);
        tlpRegisters.ResumeLayout(false);
        gbReadPR.ResumeLayout(false);
        gbWritePR.ResumeLayout(false);
        gbRegOutput.ResumeLayout(false);
        gbRegOutput.PerformLayout();
        tabInstructions.ResumeLayout(false);
        tlpInstr.ResumeLayout(false);
        gbWaitDin.ResumeLayout(false);
        gbWaitTime.ResumeLayout(false);
        gbSetUFrameInstr.ResumeLayout(false);
        gbSetUToolInstr.ResumeLayout(false);
        gbPayLoad.ResumeLayout(false);
        gbLinearMotion.ResumeLayout(false);
        gbLinearRelative.ResumeLayout(false);
        gbJointMotion.ResumeLayout(false);
        gbJointRelative.ResumeLayout(false);
        gbCircularMotion.ResumeLayout(false);
        gbCircularRelative.ResumeLayout(false);
        gbJointMotionJRep.ResumeLayout(false);
        gbJointRelativeJRep.ResumeLayout(false);
        gbInstrOutput.ResumeLayout(false);
        gbInstrOutput.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
}
