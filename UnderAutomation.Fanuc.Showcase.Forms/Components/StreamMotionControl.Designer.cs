using System.Drawing;
using System.Windows.Forms;

partial class StreamMotionControl
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableMain = new TableLayoutPanel();
        flowActions = new FlowLayoutPanel();
        lblHelp = new Label();
        grpSession = new GroupBox();
        btnStartMonitoring = new Button();
        btnStopMonitoring = new Button();
        btnFinish = new Button();
        grpJoint = new GroupBox();
        lblJointAmplitude = new Label();
        numJointAmplitude = new NumericUpDown();
        lblJointSpeed = new Label();
        numJointSpeed = new NumericUpDown();
        btnJointDemo = new Button();
        lblJointFormatNote = new Label();
        grpCartesian = new GroupBox();
        lblCircleRadius = new Label();
        numCircleRadius = new NumericUpDown();
        lblCircleSpeed = new Label();
        numCircleSpeed = new NumericUpDown();
        btnCartesianDemo = new Button();
        lblCartesianNote = new Label();
        lblCartesianFormatNote = new Label();
        grpControl = new GroupBox();
        btnPause = new Button();
        btnResume = new Button();
        btnAbort = new Button();
        lblOverride = new Label();
        trackOverride = new TrackBar();
        propertyGridStatus = new PropertyGrid();
        pnlLog = new Panel();
        txtLog = new TextBox();
        btnClearLog = new Button();
        tableMain.SuspendLayout();
        flowActions.SuspendLayout();
        grpSession.SuspendLayout();
        grpJoint.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numJointAmplitude).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numJointSpeed).BeginInit();
        grpCartesian.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numCircleRadius).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numCircleSpeed).BeginInit();
        grpControl.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)trackOverride).BeginInit();
        pnlLog.SuspendLayout();
        SuspendLayout();
        //
        // tableMain
        //
        tableMain.ColumnCount = 2;
        tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 440F));
        tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableMain.Controls.Add(flowActions, 0, 0);
        tableMain.Controls.Add(propertyGridStatus, 1, 0);
        tableMain.Controls.Add(pnlLog, 0, 1);
        tableMain.Dock = DockStyle.Fill;
        tableMain.Location = new Point(0, 0);
        tableMain.Name = "tableMain";
        tableMain.RowCount = 2;
        tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
        tableMain.SetColumnSpan(pnlLog, 2);
        tableMain.Size = new Size(900, 700);
        tableMain.TabIndex = 0;
        //
        // flowActions
        //
        flowActions.AutoScroll = true;
        flowActions.Controls.Add(lblHelp);
        flowActions.Controls.Add(grpSession);
        flowActions.Controls.Add(grpJoint);
        flowActions.Controls.Add(grpCartesian);
        flowActions.Controls.Add(grpControl);
        flowActions.Dock = DockStyle.Fill;
        flowActions.FlowDirection = FlowDirection.TopDown;
        flowActions.Location = new Point(3, 3);
        flowActions.Name = "flowActions";
        flowActions.Size = new Size(434, 449);
        flowActions.TabIndex = 0;
        flowActions.WrapContents = false;
        //
        // lblHelp
        //
        lblHelp.AutoSize = true;
        lblHelp.Location = new Point(3, 0);
        lblHelp.MaximumSize = new Size(410, 0);
        lblHelp.Name = "lblHelp";
        lblHelp.Padding = new Padding(0, 4, 0, 4);
        lblHelp.Size = new Size(405, 53);
        lblHelp.TabIndex = 0;
        lblHelp.Text = "Enable Stream Motion on the connection page. Start the monitoring, then run on the robot a TP program with IBGN start[1] and IBGN end[1], in AUTO mode at 100% override. The demo motions start when the program reaches IBGN start.";
        //
        // grpSession
        //
        grpSession.Controls.Add(btnStartMonitoring);
        grpSession.Controls.Add(btnStopMonitoring);
        grpSession.Controls.Add(btnFinish);
        grpSession.Location = new Point(3, 56);
        grpSession.Name = "grpSession";
        grpSession.Size = new Size(410, 62);
        grpSession.TabIndex = 1;
        grpSession.TabStop = false;
        grpSession.Text = "Session";
        //
        // btnStartMonitoring
        //
        btnStartMonitoring.Location = new Point(10, 22);
        btnStartMonitoring.Name = "btnStartMonitoring";
        btnStartMonitoring.Size = new Size(125, 30);
        btnStartMonitoring.TabIndex = 0;
        btnStartMonitoring.Text = "Start monitoring";
        btnStartMonitoring.UseVisualStyleBackColor = true;
        btnStartMonitoring.Click += btnStartMonitoring_Click;
        //
        // btnStopMonitoring
        //
        btnStopMonitoring.Location = new Point(141, 22);
        btnStopMonitoring.Name = "btnStopMonitoring";
        btnStopMonitoring.Size = new Size(125, 30);
        btnStopMonitoring.TabIndex = 1;
        btnStopMonitoring.Text = "Stop monitoring";
        btnStopMonitoring.UseVisualStyleBackColor = true;
        btnStopMonitoring.Click += btnStopMonitoring_Click;
        //
        // btnFinish
        //
        btnFinish.Location = new Point(272, 22);
        btnFinish.Name = "btnFinish";
        btnFinish.Size = new Size(125, 30);
        btnFinish.TabIndex = 2;
        btnFinish.Text = "Finish session";
        btnFinish.UseVisualStyleBackColor = true;
        btnFinish.Click += btnFinish_Click;
        //
        // grpJoint
        //
        grpJoint.Controls.Add(lblJointAmplitude);
        grpJoint.Controls.Add(numJointAmplitude);
        grpJoint.Controls.Add(lblJointSpeed);
        grpJoint.Controls.Add(numJointSpeed);
        grpJoint.Controls.Add(btnJointDemo);
        grpJoint.Controls.Add(lblJointFormatNote);
        grpJoint.Location = new Point(3, 124);
        grpJoint.Name = "grpJoint";
        grpJoint.Size = new Size(410, 122);
        grpJoint.TabIndex = 2;
        grpJoint.TabStop = false;
        grpJoint.Text = "Joint demo: J1 goes +A, -A, then back";
        //
        // lblJointAmplitude
        //
        lblJointAmplitude.AutoSize = true;
        lblJointAmplitude.Location = new Point(10, 26);
        lblJointAmplitude.Name = "lblJointAmplitude";
        lblJointAmplitude.Size = new Size(99, 15);
        lblJointAmplitude.TabIndex = 0;
        lblJointAmplitude.Text = "Amplitude A (deg)";
        //
        // numJointAmplitude
        //
        numJointAmplitude.DecimalPlaces = 1;
        numJointAmplitude.Location = new Point(150, 23);
        numJointAmplitude.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
        numJointAmplitude.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
        numJointAmplitude.Name = "numJointAmplitude";
        numJointAmplitude.Size = new Size(80, 23);
        numJointAmplitude.TabIndex = 1;
        numJointAmplitude.Value = new decimal(new int[] { 5, 0, 0, 0 });
        //
        // lblJointSpeed
        //
        lblJointSpeed.AutoSize = true;
        lblJointSpeed.Location = new Point(10, 58);
        lblJointSpeed.Name = "lblJointSpeed";
        lblJointSpeed.Size = new Size(59, 15);
        lblJointSpeed.TabIndex = 2;
        lblJointSpeed.Text = "Speed (%)";
        //
        // numJointSpeed
        //
        numJointSpeed.Location = new Point(150, 55);
        numJointSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numJointSpeed.Name = "numJointSpeed";
        numJointSpeed.Size = new Size(80, 23);
        numJointSpeed.TabIndex = 3;
        numJointSpeed.Value = new decimal(new int[] { 20, 0, 0, 0 });
        //
        // btnJointDemo
        //
        btnJointDemo.Location = new Point(272, 22);
        btnJointDemo.Name = "btnJointDemo";
        btnJointDemo.Size = new Size(125, 56);
        btnJointDemo.TabIndex = 4;
        btnJointDemo.Text = "Send joint demo";
        btnJointDemo.UseVisualStyleBackColor = true;
        btnJointDemo.Click += btnJointDemo_Click;
        //
        // lblJointFormatNote
        //
        lblJointFormatNote.ForeColor = SystemColors.GrayText;
        lblJointFormatNote.Location = new Point(10, 86);
        lblJointFormatNote.MaximumSize = new Size(390, 0);
        lblJointFormatNote.Name = "lblJointFormatNote";
        lblJointFormatNote.Size = new Size(390, 30);
        lblJointFormatNote.TabIndex = 5;
        lblJointFormatNote.Visible = false;
        //
        // grpCartesian
        //
        grpCartesian.Controls.Add(lblCircleRadius);
        grpCartesian.Controls.Add(numCircleRadius);
        grpCartesian.Controls.Add(lblCircleSpeed);
        grpCartesian.Controls.Add(numCircleSpeed);
        grpCartesian.Controls.Add(btnCartesianDemo);
        grpCartesian.Controls.Add(lblCartesianNote);
        grpCartesian.Controls.Add(lblCartesianFormatNote);
        grpCartesian.Location = new Point(3, 222);
        grpCartesian.Name = "grpCartesian";
        grpCartesian.Size = new Size(410, 172);
        grpCartesian.TabIndex = 3;
        grpCartesian.TabStop = false;
        grpCartesian.Text = "Cartesian demo: horizontal circle from the current position";
        //
        // lblCircleRadius
        //
        lblCircleRadius.AutoSize = true;
        lblCircleRadius.Location = new Point(10, 26);
        lblCircleRadius.Name = "lblCircleRadius";
        lblCircleRadius.Size = new Size(74, 15);
        lblCircleRadius.TabIndex = 0;
        lblCircleRadius.Text = "Radius (mm)";
        //
        // numCircleRadius
        //
        numCircleRadius.Location = new Point(150, 23);
        numCircleRadius.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
        numCircleRadius.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numCircleRadius.Name = "numCircleRadius";
        numCircleRadius.Size = new Size(80, 23);
        numCircleRadius.TabIndex = 1;
        numCircleRadius.Value = new decimal(new int[] { 20, 0, 0, 0 });
        //
        // lblCircleSpeed
        //
        lblCircleSpeed.AutoSize = true;
        lblCircleSpeed.Location = new Point(10, 58);
        lblCircleSpeed.Name = "lblCircleSpeed";
        lblCircleSpeed.Size = new Size(83, 15);
        lblCircleSpeed.TabIndex = 2;
        lblCircleSpeed.Text = "Speed (mm/s)";
        //
        // numCircleSpeed
        //
        numCircleSpeed.Location = new Point(150, 55);
        numCircleSpeed.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
        numCircleSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numCircleSpeed.Name = "numCircleSpeed";
        numCircleSpeed.Size = new Size(80, 23);
        numCircleSpeed.TabIndex = 3;
        numCircleSpeed.Value = new decimal(new int[] { 50, 0, 0, 0 });
        //
        // btnCartesianDemo
        //
        btnCartesianDemo.Location = new Point(272, 22);
        btnCartesianDemo.Name = "btnCartesianDemo";
        btnCartesianDemo.Size = new Size(125, 56);
        btnCartesianDemo.TabIndex = 4;
        btnCartesianDemo.Text = "Send circle demo";
        btnCartesianDemo.UseVisualStyleBackColor = true;
        btnCartesianDemo.Click += btnCartesianDemo_Click;
        //
        // lblCartesianNote
        //
        lblCartesianNote.AutoSize = true;
        lblCartesianNote.ForeColor = SystemColors.GrayText;
        lblCartesianNote.Location = new Point(10, 86);
        lblCartesianNote.MaximumSize = new Size(390, 0);
        lblCartesianNote.Name = "lblCartesianNote";
        lblCartesianNote.Size = new Size(388, 45);
        lblCartesianNote.TabIndex = 5;
        lblCartesianNote.Text = "Positions of the flange in the world frame. Some controllers expect the position of the active tool: select a tool frame equal to zero for this demo.";
        //
        // lblCartesianFormatNote
        //
        lblCartesianFormatNote.ForeColor = SystemColors.GrayText;
        lblCartesianFormatNote.Location = new Point(10, 131);
        lblCartesianFormatNote.MaximumSize = new Size(390, 0);
        lblCartesianFormatNote.Name = "lblCartesianFormatNote";
        lblCartesianFormatNote.Size = new Size(390, 30);
        lblCartesianFormatNote.TabIndex = 6;
        lblCartesianFormatNote.Visible = false;
        //
        // grpControl
        //
        grpControl.Controls.Add(btnPause);
        grpControl.Controls.Add(btnResume);
        grpControl.Controls.Add(btnAbort);
        grpControl.Controls.Add(lblOverride);
        grpControl.Controls.Add(trackOverride);
        grpControl.Location = new Point(3, 370);
        grpControl.Name = "grpControl";
        grpControl.Size = new Size(410, 116);
        grpControl.TabIndex = 4;
        grpControl.TabStop = false;
        grpControl.Text = "Motion control";
        //
        // btnPause
        //
        btnPause.Location = new Point(10, 22);
        btnPause.Name = "btnPause";
        btnPause.Size = new Size(125, 30);
        btnPause.TabIndex = 0;
        btnPause.Text = "Pause";
        btnPause.UseVisualStyleBackColor = true;
        btnPause.Click += btnPause_Click;
        //
        // btnResume
        //
        btnResume.Location = new Point(141, 22);
        btnResume.Name = "btnResume";
        btnResume.Size = new Size(125, 30);
        btnResume.TabIndex = 1;
        btnResume.Text = "Resume";
        btnResume.UseVisualStyleBackColor = true;
        btnResume.Click += btnResume_Click;
        //
        // btnAbort
        //
        btnAbort.Location = new Point(272, 22);
        btnAbort.Name = "btnAbort";
        btnAbort.Size = new Size(125, 30);
        btnAbort.TabIndex = 2;
        btnAbort.Text = "Abort";
        btnAbort.UseVisualStyleBackColor = true;
        btnAbort.Click += btnAbort_Click;
        //
        // lblOverride
        //
        lblOverride.AutoSize = true;
        lblOverride.Location = new Point(10, 70);
        lblOverride.Name = "lblOverride";
        lblOverride.Size = new Size(94, 15);
        lblOverride.TabIndex = 3;
        lblOverride.Text = "Override: 100 %";
        //
        // trackOverride
        //
        trackOverride.LargeChange = 10;
        trackOverride.Location = new Point(141, 62);
        trackOverride.Maximum = 100;
        trackOverride.Minimum = 1;
        trackOverride.Name = "trackOverride";
        trackOverride.Size = new Size(256, 45);
        trackOverride.TabIndex = 4;
        trackOverride.TickFrequency = 10;
        trackOverride.Value = 100;
        trackOverride.Scroll += trackOverride_Scroll;
        //
        // propertyGridStatus
        //
        propertyGridStatus.Dock = DockStyle.Fill;
        propertyGridStatus.HelpVisible = false;
        propertyGridStatus.Location = new Point(443, 3);
        propertyGridStatus.Name = "propertyGridStatus";
        propertyGridStatus.PropertySort = PropertySort.Categorized;
        propertyGridStatus.Size = new Size(454, 449);
        propertyGridStatus.TabIndex = 1;
        propertyGridStatus.ToolbarVisible = false;
        //
        // pnlLog
        //
        pnlLog.Controls.Add(txtLog);
        pnlLog.Controls.Add(btnClearLog);
        pnlLog.Dock = DockStyle.Fill;
        pnlLog.Location = new Point(3, 458);
        pnlLog.Name = "pnlLog";
        pnlLog.Size = new Size(894, 239);
        pnlLog.TabIndex = 2;
        //
        // txtLog
        //
        txtLog.Dock = DockStyle.Fill;
        txtLog.Font = new Font("Consolas", 9F);
        txtLog.Location = new Point(0, 0);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ReadOnly = true;
        txtLog.ScrollBars = ScrollBars.Both;
        txtLog.Size = new Size(894, 209);
        txtLog.TabIndex = 0;
        //
        // btnClearLog
        //
        btnClearLog.Dock = DockStyle.Bottom;
        btnClearLog.Location = new Point(0, 209);
        btnClearLog.Name = "btnClearLog";
        btnClearLog.Size = new Size(894, 30);
        btnClearLog.TabIndex = 1;
        btnClearLog.Text = "Clear log";
        btnClearLog.UseVisualStyleBackColor = true;
        btnClearLog.Click += btnClearLog_Click;
        //
        // StreamMotionControl
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tableMain);
        Name = "StreamMotionControl";
        Size = new Size(900, 700);
        tableMain.ResumeLayout(false);
        flowActions.ResumeLayout(false);
        flowActions.PerformLayout();
        grpSession.ResumeLayout(false);
        grpJoint.ResumeLayout(false);
        grpJoint.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numJointAmplitude).EndInit();
        ((System.ComponentModel.ISupportInitialize)numJointSpeed).EndInit();
        grpCartesian.ResumeLayout(false);
        grpCartesian.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numCircleRadius).EndInit();
        ((System.ComponentModel.ISupportInitialize)numCircleSpeed).EndInit();
        grpControl.ResumeLayout(false);
        grpControl.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)trackOverride).EndInit();
        pnlLog.ResumeLayout(false);
        pnlLog.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableMain;
    private FlowLayoutPanel flowActions;
    private Label lblHelp;
    private GroupBox grpSession;
    private Button btnStartMonitoring;
    private Button btnStopMonitoring;
    private Button btnFinish;
    private GroupBox grpJoint;
    private Label lblJointAmplitude;
    private NumericUpDown numJointAmplitude;
    private Label lblJointSpeed;
    private NumericUpDown numJointSpeed;
    private Button btnJointDemo;
    private Label lblJointFormatNote;
    private GroupBox grpCartesian;
    private Label lblCircleRadius;
    private NumericUpDown numCircleRadius;
    private Label lblCircleSpeed;
    private NumericUpDown numCircleSpeed;
    private Button btnCartesianDemo;
    private Label lblCartesianNote;
    private Label lblCartesianFormatNote;
    private GroupBox grpControl;
    private Button btnPause;
    private Button btnResume;
    private Button btnAbort;
    private Label lblOverride;
    private TrackBar trackOverride;
    private PropertyGrid propertyGridStatus;
    private Panel pnlLog;
    private TextBox txtLog;
    private Button btnClearLog;
}
