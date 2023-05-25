
partial class RemoteCommandsControl
{
    /// <summary> 
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.btnAbortAll = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearProgram = new System.Windows.Forms.Button();
            this.btnClearVariables = new System.Windows.Forms.Button();
            this.btnGetProgramInfo = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGetCurrentPose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSetVariable = new System.Windows.Forms.Button();
            this.txtVariableNewValue = new System.Windows.Forms.TextBox();
            this.txtVariableName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUnsimulateAll = new System.Windows.Forms.Button();
            this.btnUnsimulatePort = new System.Windows.Forms.Button();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.btnSetPort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.udNewValue = new System.Windows.Forms.NumericUpDown();
            this.udIndex = new System.Windows.Forms.NumericUpDown();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGetVariable = new System.Windows.Forms.Button();
            this.txtVariableProgram = new CueTextBox();
            this.cbPrograms = new CueTextBox();
            this.GroupBox3.SuspendLayout();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNewValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udIndex)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbortAll
            // 
            this.btnAbortAll.Location = new System.Drawing.Point(6, 292);
            this.btnAbortAll.Name = "btnAbortAll";
            this.btnAbortAll.Size = new System.Drawing.Size(156, 23);
            this.btnAbortAll.TabIndex = 0;
            this.btnAbortAll.Text = "Abort all programs";
            this.btnAbortAll.UseVisualStyleBackColor = true;
            this.btnAbortAll.Click += new System.EventHandler(this.btnAbortAll_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnAbortAll);
            this.GroupBox3.Controls.Add(this.btnClearProgram);
            this.GroupBox3.Controls.Add(this.btnClearVariables);
            this.GroupBox3.Controls.Add(this.btnGetProgramInfo);
            this.GroupBox3.Controls.Add(this.btnHold);
            this.GroupBox3.Controls.Add(this.btnContinue);
            this.GroupBox3.Controls.Add(this.btnPause);
            this.GroupBox3.Controls.Add(this.btnAbort);
            this.GroupBox3.Controls.Add(this.btnRun);
            this.GroupBox3.Controls.Add(this.cbPrograms);
            this.GroupBox3.Location = new System.Drawing.Point(3, 3);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(168, 368);
            this.GroupBox3.TabIndex = 5;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Programs";
            // 
            // btnClearProgram
            // 
            this.btnClearProgram.Location = new System.Drawing.Point(33, 220);
            this.btnClearProgram.Name = "btnClearProgram";
            this.btnClearProgram.Size = new System.Drawing.Size(129, 23);
            this.btnClearProgram.TabIndex = 0;
            this.btnClearProgram.Text = "Clear program";
            this.btnClearProgram.UseVisualStyleBackColor = true;
            this.btnClearProgram.Click += new System.EventHandler(this.btnClearProgram_Click);
            // 
            // btnClearVariables
            // 
            this.btnClearVariables.Location = new System.Drawing.Point(33, 249);
            this.btnClearVariables.Name = "btnClearVariables";
            this.btnClearVariables.Size = new System.Drawing.Size(129, 23);
            this.btnClearVariables.TabIndex = 0;
            this.btnClearVariables.Text = "Clear variables";
            this.btnClearVariables.UseVisualStyleBackColor = true;
            this.btnClearVariables.Click += new System.EventHandler(this.btnClearVariables_Click);
            // 
            // btnGetProgramInfo
            // 
            this.btnGetProgramInfo.Location = new System.Drawing.Point(33, 191);
            this.btnGetProgramInfo.Name = "btnGetProgramInfo";
            this.btnGetProgramInfo.Size = new System.Drawing.Size(129, 23);
            this.btnGetProgramInfo.TabIndex = 0;
            this.btnGetProgramInfo.Text = "Get info";
            this.btnGetProgramInfo.UseVisualStyleBackColor = true;
            this.btnGetProgramInfo.Click += new System.EventHandler(this.btnGetProgramInfo_Click);
            // 
            // btnHold
            // 
            this.btnHold.Location = new System.Drawing.Point(33, 162);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(129, 23);
            this.btnHold.TabIndex = 0;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(33, 133);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(129, 23);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(33, 104);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(129, 23);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(33, 75);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(129, 23);
            this.btnAbort.TabIndex = 0;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(33, 46);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(129, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // splitMain
            // 
            this.splitMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.txtConsole);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.AutoScroll = true;
            this.splitMain.Panel2.Controls.Add(this.pnlMain);
            this.splitMain.Size = new System.Drawing.Size(820, 628);
            this.splitMain.SplitterDistance = 273;
            this.splitMain.TabIndex = 2;
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.ForeColor = System.Drawing.Color.White;
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(269, 624);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "Please use commands on the right panel.\n\n> ";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox5);
            this.pnlMain.Controls.Add(this.groupBox4);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.GroupBox3);
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(436, 612);
            this.pnlMain.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGetCurrentPose);
            this.groupBox5.Location = new System.Drawing.Point(186, 257);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 71);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current pose";
            // 
            // btnGetCurrentPose
            // 
            this.btnGetCurrentPose.Location = new System.Drawing.Point(34, 19);
            this.btnGetCurrentPose.Name = "btnGetCurrentPose";
            this.btnGetCurrentPose.Size = new System.Drawing.Size(156, 23);
            this.btnGetCurrentPose.TabIndex = 0;
            this.btnGetCurrentPose.Text = "Get current pose";
            this.btnGetCurrentPose.UseVisualStyleBackColor = true;
            this.btnGetCurrentPose.Click += new System.EventHandler(this.btnGetCurrentPose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGetVariable);
            this.groupBox4.Controls.Add(this.btnSetVariable);
            this.groupBox4.Controls.Add(this.txtVariableNewValue);
            this.groupBox4.Controls.Add(this.txtVariableName);
            this.groupBox4.Controls.Add(this.txtVariableProgram);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(9, 469);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 154);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Variables";
            // 
            // btnSetVariable
            // 
            this.btnSetVariable.Location = new System.Drawing.Point(44, 100);
            this.btnSetVariable.Name = "btnSetVariable";
            this.btnSetVariable.Size = new System.Drawing.Size(156, 23);
            this.btnSetVariable.TabIndex = 0;
            this.btnSetVariable.Text = "Set variable value";
            this.btnSetVariable.UseVisualStyleBackColor = true;
            this.btnSetVariable.Click += new System.EventHandler(this.btnSetVariable_Click);
            // 
            // txtVariableNewValue
            // 
            this.txtVariableNewValue.Location = new System.Drawing.Point(76, 74);
            this.txtVariableNewValue.Name = "txtVariableNewValue";
            this.txtVariableNewValue.Size = new System.Drawing.Size(149, 20);
            this.txtVariableNewValue.TabIndex = 2;
            // 
            // txtVariableName
            // 
            this.txtVariableName.Location = new System.Drawing.Point(76, 22);
            this.txtVariableName.Name = "txtVariableName";
            this.txtVariableName.Size = new System.Drawing.Size(149, 20);
            this.txtVariableName.TabIndex = 2;
            this.txtVariableName.Text = "$RMT_MASTER";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "New value :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Program :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Variable :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUnsimulateAll);
            this.groupBox2.Controls.Add(this.btnUnsimulatePort);
            this.groupBox2.Controls.Add(this.btnSimulate);
            this.groupBox2.Controls.Add(this.btnSetPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.udNewValue);
            this.groupBox2.Controls.Add(this.udIndex);
            this.groupBox2.Controls.Add(this.cbPorts);
            this.groupBox2.Location = new System.Drawing.Point(186, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 248);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ports";
            // 
            // btnUnsimulateAll
            // 
            this.btnUnsimulateAll.Location = new System.Drawing.Point(46, 210);
            this.btnUnsimulateAll.Name = "btnUnsimulateAll";
            this.btnUnsimulateAll.Size = new System.Drawing.Size(126, 23);
            this.btnUnsimulateAll.TabIndex = 0;
            this.btnUnsimulateAll.Text = "Unsimulate all";
            this.btnUnsimulateAll.UseVisualStyleBackColor = true;
            this.btnUnsimulateAll.Click += new System.EventHandler(this.btnUnsimulate_Click);
            // 
            // btnUnsimulatePort
            // 
            this.btnUnsimulatePort.Location = new System.Drawing.Point(19, 181);
            this.btnUnsimulatePort.Name = "btnUnsimulatePort";
            this.btnUnsimulatePort.Size = new System.Drawing.Size(173, 23);
            this.btnUnsimulatePort.TabIndex = 0;
            this.btnUnsimulatePort.Text = "Unsimulate this port";
            this.btnUnsimulatePort.UseVisualStyleBackColor = true;
            this.btnUnsimulatePort.Click += new System.EventHandler(this.btnUnsimulatePort_Click);
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(19, 152);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(173, 23);
            this.btnSimulate.TabIndex = 0;
            this.btnSimulate.Text = "Simulate this port with this value";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // btnSetPort
            // 
            this.btnSetPort.Location = new System.Drawing.Point(19, 109);
            this.btnSetPort.Name = "btnSetPort";
            this.btnSetPort.Size = new System.Drawing.Size(171, 23);
            this.btnSetPort.TabIndex = 0;
            this.btnSetPort.Text = "Set port value";
            this.btnSetPort.UseVisualStyleBackColor = true;
            this.btnSetPort.Click += new System.EventHandler(this.btnSetPort_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "New value :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Index :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // udNewValue
            // 
            this.udNewValue.Location = new System.Drawing.Point(76, 80);
            this.udNewValue.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.udNewValue.Minimum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            -2147483648});
            this.udNewValue.Name = "udNewValue";
            this.udNewValue.Size = new System.Drawing.Size(74, 20);
            this.udNewValue.TabIndex = 1;
            // 
            // udIndex
            // 
            this.udIndex.Location = new System.Drawing.Point(76, 51);
            this.udIndex.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.udIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udIndex.Name = "udIndex";
            this.udIndex.Size = new System.Drawing.Size(74, 20);
            this.udIndex.TabIndex = 1;
            this.udIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(76, 24);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(74, 21);
            this.cbPorts.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Location = new System.Drawing.Point(3, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 56);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarms";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGetVariable
            // 
            this.btnGetVariable.Location = new System.Drawing.Point(231, 33);
            this.btnGetVariable.Name = "btnGetVariable";
            this.btnGetVariable.Size = new System.Drawing.Size(156, 23);
            this.btnGetVariable.TabIndex = 0;
            this.btnGetVariable.Text = "Get variable value";
            this.btnGetVariable.UseVisualStyleBackColor = true;
            this.btnGetVariable.Click += new System.EventHandler(this.btnGetVariable_Click);
            // 
            // txtVariableProgram
            // 
            this.txtVariableProgram.Cue = "Optional";
            this.txtVariableProgram.Location = new System.Drawing.Point(76, 48);
            this.txtVariableProgram.Name = "txtVariableProgram";
            this.txtVariableProgram.Size = new System.Drawing.Size(149, 20);
            this.txtVariableProgram.TabIndex = 1;
            // 
            // cbPrograms
            // 
            this.cbPrograms.Cue = "Program name";
            this.cbPrograms.Location = new System.Drawing.Point(16, 20);
            this.cbPrograms.Name = "cbPrograms";
            this.cbPrograms.Size = new System.Drawing.Size(146, 20);
            this.cbPrograms.TabIndex = 2;
            // 
            // TelnetKclControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitMain);
            this.Name = "TelnetKclControl";
            this.Size = new System.Drawing.Size(820, 628);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            this.splitMain.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udNewValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udIndex)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    internal System.Windows.Forms.Button btnAbortAll;
    internal System.Windows.Forms.GroupBox GroupBox3;
    internal System.Windows.Forms.Button btnRun;
    internal System.Windows.Forms.SplitContainer splitMain;
    internal System.Windows.Forms.RichTextBox txtConsole;
    private System.Windows.Forms.Panel pnlMain;
    internal System.Windows.Forms.Button btnAbort;
    internal System.Windows.Forms.Button btnClearProgram;
    internal System.Windows.Forms.Button btnPause;
    internal System.Windows.Forms.Button btnClearVariables;
    internal System.Windows.Forms.Button btnHold;
    internal System.Windows.Forms.Button btnContinue;
    private System.Windows.Forms.GroupBox groupBox1;
    internal System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.GroupBox groupBox2;
    internal System.Windows.Forms.Button btnSetPort;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown udNewValue;
    private System.Windows.Forms.NumericUpDown udIndex;
    private System.Windows.Forms.ComboBox cbPorts;
    private System.Windows.Forms.GroupBox groupBox5;
    internal System.Windows.Forms.Button btnGetCurrentPose;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.TextBox txtVariableNewValue;
    private System.Windows.Forms.TextBox txtVariableName;
    internal CueTextBox txtVariableProgram;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    internal System.Windows.Forms.Button btnSetVariable;
    internal System.Windows.Forms.Button btnGetProgramInfo;
    internal System.Windows.Forms.Button btnUnsimulateAll;
    internal System.Windows.Forms.Button btnSimulate;
    internal System.Windows.Forms.Button btnUnsimulatePort;
    private CueTextBox cbPrograms;
    internal System.Windows.Forms.Button btnGetVariable;
}
