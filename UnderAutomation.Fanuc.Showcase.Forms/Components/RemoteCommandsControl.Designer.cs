
partial class TelnetControl
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
        btnAbortAll = new Button();
        GroupBox3 = new GroupBox();
        btnClearProgram = new Button();
        btnGetTask = new Button();
        btnClearVariables = new Button();
        btnHold = new Button();
        btnContinue = new Button();
        btnPause = new Button();
        btnAbort = new Button();
        btnRun = new Button();
        cbPrograms = new CueTextBox();
        splitMain = new SplitContainer();
        txtConsole = new RichTextBox();
        pnlMain = new Panel();
        groupBox5 = new GroupBox();
        btnGetCurrentPose = new Button();
        groupBox4 = new GroupBox();
        btnGetVariable = new Button();
        btnSetVariable = new Button();
        txtVariableNewValue = new TextBox();
        txtVariableName = new TextBox();
        txtVariableProgram = new CueTextBox();
        label7 = new Label();
        label6 = new Label();
        label5 = new Label();
        groupBox2 = new GroupBox();
        btnUnsimulateAll = new Button();
        btnUnsimulatePort = new Button();
        btnSimulate = new Button();
        btnSetPort = new Button();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        udNewValue = new NumericUpDown();
        udIndex = new NumericUpDown();
        cbPorts = new ComboBox();
        groupBox1 = new GroupBox();
        btnReset = new Button();
        GroupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
        splitMain.Panel1.SuspendLayout();
        splitMain.Panel2.SuspendLayout();
        splitMain.SuspendLayout();
        pnlMain.SuspendLayout();
        groupBox5.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udNewValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize)udIndex).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // btnAbortAll
        // 
        btnAbortAll.Location = new Point(7, 380);
        btnAbortAll.Margin = new Padding(4, 3, 4, 3);
        btnAbortAll.Name = "btnAbortAll";
        btnAbortAll.Size = new Size(182, 27);
        btnAbortAll.TabIndex = 0;
        btnAbortAll.Text = "Abort all programs";
        btnAbortAll.UseVisualStyleBackColor = true;
        btnAbortAll.Click += btnAbortAll_Click;
        // 
        // GroupBox3
        // 
        GroupBox3.Controls.Add(btnAbortAll);
        GroupBox3.Controls.Add(btnClearProgram);
        GroupBox3.Controls.Add(btnGetTask);
        GroupBox3.Controls.Add(btnClearVariables);
        GroupBox3.Controls.Add(btnHold);
        GroupBox3.Controls.Add(btnContinue);
        GroupBox3.Controls.Add(btnPause);
        GroupBox3.Controls.Add(btnAbort);
        GroupBox3.Controls.Add(btnRun);
        GroupBox3.Controls.Add(cbPrograms);
        GroupBox3.Location = new Point(4, 3);
        GroupBox3.Margin = new Padding(4, 3, 4, 3);
        GroupBox3.Name = "GroupBox3";
        GroupBox3.Padding = new Padding(4, 3, 4, 3);
        GroupBox3.Size = new Size(196, 425);
        GroupBox3.TabIndex = 5;
        GroupBox3.TabStop = false;
        GroupBox3.Text = "Programs";
        // 
        // btnClearProgram
        // 
        btnClearProgram.Location = new Point(38, 220);
        btnClearProgram.Margin = new Padding(4, 3, 4, 3);
        btnClearProgram.Name = "btnClearProgram";
        btnClearProgram.Size = new Size(150, 27);
        btnClearProgram.TabIndex = 0;
        btnClearProgram.Text = "Clear program";
        btnClearProgram.UseVisualStyleBackColor = true;
        btnClearProgram.Click += btnClearProgram_Click;
        // 
        // btnGetTask
        // 
        btnGetTask.Location = new Point(38, 316);
        btnGetTask.Margin = new Padding(4, 3, 4, 3);
        btnGetTask.Name = "btnGetTask";
        btnGetTask.Size = new Size(150, 27);
        btnGetTask.TabIndex = 0;
        btnGetTask.Text = "Get task info";
        btnGetTask.UseVisualStyleBackColor = true;
        btnGetTask.Click += btnGetTask_Click;
        // 
        // btnClearVariables
        // 
        btnClearVariables.Location = new Point(38, 254);
        btnClearVariables.Margin = new Padding(4, 3, 4, 3);
        btnClearVariables.Name = "btnClearVariables";
        btnClearVariables.Size = new Size(150, 27);
        btnClearVariables.TabIndex = 0;
        btnClearVariables.Text = "Clear variables";
        btnClearVariables.UseVisualStyleBackColor = true;
        btnClearVariables.Click += btnClearVariables_Click;
        // 
        // btnHold
        // 
        btnHold.Location = new Point(38, 187);
        btnHold.Margin = new Padding(4, 3, 4, 3);
        btnHold.Name = "btnHold";
        btnHold.Size = new Size(150, 27);
        btnHold.TabIndex = 0;
        btnHold.Text = "Hold";
        btnHold.UseVisualStyleBackColor = true;
        btnHold.Click += btnHold_Click;
        // 
        // btnContinue
        // 
        btnContinue.Location = new Point(38, 153);
        btnContinue.Margin = new Padding(4, 3, 4, 3);
        btnContinue.Name = "btnContinue";
        btnContinue.Size = new Size(150, 27);
        btnContinue.TabIndex = 0;
        btnContinue.Text = "Continue";
        btnContinue.UseVisualStyleBackColor = true;
        btnContinue.Click += btnContinue_Click;
        // 
        // btnPause
        // 
        btnPause.Location = new Point(38, 120);
        btnPause.Margin = new Padding(4, 3, 4, 3);
        btnPause.Name = "btnPause";
        btnPause.Size = new Size(150, 27);
        btnPause.TabIndex = 0;
        btnPause.Text = "Pause";
        btnPause.UseVisualStyleBackColor = true;
        btnPause.Click += btnPause_Click;
        // 
        // btnAbort
        // 
        btnAbort.Location = new Point(38, 87);
        btnAbort.Margin = new Padding(4, 3, 4, 3);
        btnAbort.Name = "btnAbort";
        btnAbort.Size = new Size(150, 27);
        btnAbort.TabIndex = 0;
        btnAbort.Text = "Abort";
        btnAbort.UseVisualStyleBackColor = true;
        btnAbort.Click += btnAbort_Click;
        // 
        // btnRun
        // 
        btnRun.Location = new Point(38, 53);
        btnRun.Margin = new Padding(4, 3, 4, 3);
        btnRun.Name = "btnRun";
        btnRun.Size = new Size(150, 27);
        btnRun.TabIndex = 0;
        btnRun.Text = "Run";
        btnRun.UseVisualStyleBackColor = true;
        btnRun.Click += btnRun_Click;
        // 
        // cbPrograms
        // 
        cbPrograms.Cue = "Program name";
        cbPrograms.Location = new Point(19, 23);
        cbPrograms.Margin = new Padding(4, 3, 4, 3);
        cbPrograms.Name = "cbPrograms";
        cbPrograms.Size = new Size(170, 23);
        cbPrograms.TabIndex = 2;
        // 
        // splitMain
        // 
        splitMain.BorderStyle = BorderStyle.Fixed3D;
        splitMain.Dock = DockStyle.Fill;
        splitMain.Location = new Point(0, 0);
        splitMain.Margin = new Padding(4, 3, 4, 3);
        splitMain.Name = "splitMain";
        // 
        // splitMain.Panel1
        // 
        splitMain.Panel1.Controls.Add(txtConsole);
        // 
        // splitMain.Panel2
        // 
        splitMain.Panel2.AutoScroll = true;
        splitMain.Panel2.Controls.Add(pnlMain);
        splitMain.Size = new Size(957, 725);
        splitMain.SplitterDistance = 318;
        splitMain.SplitterWidth = 5;
        splitMain.TabIndex = 2;
        // 
        // txtConsole
        // 
        txtConsole.BackColor = Color.Black;
        txtConsole.BorderStyle = BorderStyle.None;
        txtConsole.Dock = DockStyle.Fill;
        txtConsole.ForeColor = Color.White;
        txtConsole.Location = new Point(0, 0);
        txtConsole.Margin = new Padding(4, 3, 4, 3);
        txtConsole.Name = "txtConsole";
        txtConsole.ReadOnly = true;
        txtConsole.Size = new Size(314, 721);
        txtConsole.TabIndex = 0;
        txtConsole.Text = "Please use commands on the right panel.\n\n> ";
        // 
        // pnlMain
        // 
        pnlMain.Controls.Add(groupBox5);
        pnlMain.Controls.Add(groupBox4);
        pnlMain.Controls.Add(groupBox2);
        pnlMain.Controls.Add(groupBox1);
        pnlMain.Controls.Add(GroupBox3);
        pnlMain.Location = new Point(4, 3);
        pnlMain.Margin = new Padding(4, 3, 4, 3);
        pnlMain.Name = "pnlMain";
        pnlMain.Size = new Size(509, 706);
        pnlMain.TabIndex = 9;
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(btnGetCurrentPose);
        groupBox5.Location = new Point(217, 297);
        groupBox5.Margin = new Padding(4, 3, 4, 3);
        groupBox5.Name = "groupBox5";
        groupBox5.Padding = new Padding(4, 3, 4, 3);
        groupBox5.Size = new Size(276, 82);
        groupBox5.TabIndex = 8;
        groupBox5.TabStop = false;
        groupBox5.Text = "Current pose";
        // 
        // btnGetCurrentPose
        // 
        btnGetCurrentPose.Location = new Point(40, 22);
        btnGetCurrentPose.Margin = new Padding(4, 3, 4, 3);
        btnGetCurrentPose.Name = "btnGetCurrentPose";
        btnGetCurrentPose.Size = new Size(182, 27);
        btnGetCurrentPose.TabIndex = 0;
        btnGetCurrentPose.Text = "Get current pose";
        btnGetCurrentPose.UseVisualStyleBackColor = true;
        btnGetCurrentPose.Click += btnGetCurrentPose_Click;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(btnGetVariable);
        groupBox4.Controls.Add(btnSetVariable);
        groupBox4.Controls.Add(txtVariableNewValue);
        groupBox4.Controls.Add(txtVariableName);
        groupBox4.Controls.Add(txtVariableProgram);
        groupBox4.Controls.Add(label7);
        groupBox4.Controls.Add(label6);
        groupBox4.Controls.Add(label5);
        groupBox4.Location = new Point(10, 541);
        groupBox4.Margin = new Padding(4, 3, 4, 3);
        groupBox4.Name = "groupBox4";
        groupBox4.Padding = new Padding(4, 3, 4, 3);
        groupBox4.Size = new Size(479, 178);
        groupBox4.TabIndex = 8;
        groupBox4.TabStop = false;
        groupBox4.Text = "Variables";
        // 
        // btnGetVariable
        // 
        btnGetVariable.Location = new Point(270, 38);
        btnGetVariable.Margin = new Padding(4, 3, 4, 3);
        btnGetVariable.Name = "btnGetVariable";
        btnGetVariable.Size = new Size(182, 27);
        btnGetVariable.TabIndex = 0;
        btnGetVariable.Text = "Get variable value";
        btnGetVariable.UseVisualStyleBackColor = true;
        btnGetVariable.Click += btnGetVariable_Click;
        // 
        // btnSetVariable
        // 
        btnSetVariable.Location = new Point(51, 115);
        btnSetVariable.Margin = new Padding(4, 3, 4, 3);
        btnSetVariable.Name = "btnSetVariable";
        btnSetVariable.Size = new Size(182, 27);
        btnSetVariable.TabIndex = 0;
        btnSetVariable.Text = "Set variable value";
        btnSetVariable.UseVisualStyleBackColor = true;
        btnSetVariable.Click += btnSetVariable_Click;
        // 
        // txtVariableNewValue
        // 
        txtVariableNewValue.Location = new Point(89, 85);
        txtVariableNewValue.Margin = new Padding(4, 3, 4, 3);
        txtVariableNewValue.Name = "txtVariableNewValue";
        txtVariableNewValue.Size = new Size(173, 23);
        txtVariableNewValue.TabIndex = 2;
        // 
        // txtVariableName
        // 
        txtVariableName.Location = new Point(89, 25);
        txtVariableName.Margin = new Padding(4, 3, 4, 3);
        txtVariableName.Name = "txtVariableName";
        txtVariableName.Size = new Size(173, 23);
        txtVariableName.TabIndex = 2;
        txtVariableName.Text = "$RMT_MASTER";
        // 
        // txtVariableProgram
        // 
        txtVariableProgram.Cue = "Optional";
        txtVariableProgram.Location = new Point(89, 55);
        txtVariableProgram.Margin = new Padding(4, 3, 4, 3);
        txtVariableProgram.Name = "txtVariableProgram";
        txtVariableProgram.Size = new Size(173, 23);
        txtVariableProgram.TabIndex = 1;
        // 
        // label7
        // 
        label7.Location = new Point(7, 89);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(75, 15);
        label7.TabIndex = 2;
        label7.Text = "New value :";
        label7.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label6
        // 
        label6.Location = new Point(8, 59);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(74, 15);
        label6.TabIndex = 2;
        label6.Text = "Program :";
        label6.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label5
        // 
        label5.Location = new Point(7, 29);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(75, 15);
        label5.TabIndex = 2;
        label5.Text = "Variable :";
        label5.TextAlign = ContentAlignment.MiddleRight;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnUnsimulateAll);
        groupBox2.Controls.Add(btnUnsimulatePort);
        groupBox2.Controls.Add(btnSimulate);
        groupBox2.Controls.Add(btnSetPort);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(label1);
        groupBox2.Controls.Add(udNewValue);
        groupBox2.Controls.Add(udIndex);
        groupBox2.Controls.Add(cbPorts);
        groupBox2.Location = new Point(217, 3);
        groupBox2.Margin = new Padding(4, 3, 4, 3);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(4, 3, 4, 3);
        groupBox2.Size = new Size(276, 286);
        groupBox2.TabIndex = 7;
        groupBox2.TabStop = false;
        groupBox2.Text = "Ports";
        // 
        // btnUnsimulateAll
        // 
        btnUnsimulateAll.Location = new Point(54, 242);
        btnUnsimulateAll.Margin = new Padding(4, 3, 4, 3);
        btnUnsimulateAll.Name = "btnUnsimulateAll";
        btnUnsimulateAll.Size = new Size(147, 27);
        btnUnsimulateAll.TabIndex = 0;
        btnUnsimulateAll.Text = "Unsimulate all";
        btnUnsimulateAll.UseVisualStyleBackColor = true;
        btnUnsimulateAll.Click += btnUnsimulate_Click;
        // 
        // btnUnsimulatePort
        // 
        btnUnsimulatePort.Location = new Point(22, 209);
        btnUnsimulatePort.Margin = new Padding(4, 3, 4, 3);
        btnUnsimulatePort.Name = "btnUnsimulatePort";
        btnUnsimulatePort.Size = new Size(202, 27);
        btnUnsimulatePort.TabIndex = 0;
        btnUnsimulatePort.Text = "Unsimulate this port";
        btnUnsimulatePort.UseVisualStyleBackColor = true;
        btnUnsimulatePort.Click += btnUnsimulatePort_Click;
        // 
        // btnSimulate
        // 
        btnSimulate.Location = new Point(22, 175);
        btnSimulate.Margin = new Padding(4, 3, 4, 3);
        btnSimulate.Name = "btnSimulate";
        btnSimulate.Size = new Size(202, 27);
        btnSimulate.TabIndex = 0;
        btnSimulate.Text = "Simulate this port with this value";
        btnSimulate.UseVisualStyleBackColor = true;
        btnSimulate.Click += btnSimulate_Click;
        // 
        // btnSetPort
        // 
        btnSetPort.Location = new Point(22, 126);
        btnSetPort.Margin = new Padding(4, 3, 4, 3);
        btnSetPort.Name = "btnSetPort";
        btnSetPort.Size = new Size(200, 27);
        btnSetPort.TabIndex = 0;
        btnSetPort.Text = "Set port value";
        btnSetPort.UseVisualStyleBackColor = true;
        btnSetPort.Click += btnSetPort_Click;
        // 
        // label3
        // 
        label3.Location = new Point(7, 92);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(75, 23);
        label3.TabIndex = 2;
        label3.Text = "New value :";
        label3.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        label2.Location = new Point(10, 59);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(71, 23);
        label2.TabIndex = 2;
        label2.Text = "Index :";
        label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label1
        // 
        label1.Location = new Point(7, 31);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(75, 21);
        label1.TabIndex = 2;
        label1.Text = "Port :";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // udNewValue
        // 
        udNewValue.Location = new Point(89, 92);
        udNewValue.Margin = new Padding(4, 3, 4, 3);
        udNewValue.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
        udNewValue.Minimum = new decimal(new int[] { -1486618625, 232830643, 0, int.MinValue });
        udNewValue.Name = "udNewValue";
        udNewValue.Size = new Size(86, 23);
        udNewValue.TabIndex = 1;
        // 
        // udIndex
        // 
        udIndex.Location = new Point(89, 59);
        udIndex.Margin = new Padding(4, 3, 4, 3);
        udIndex.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
        udIndex.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        udIndex.Name = "udIndex";
        udIndex.Size = new Size(86, 23);
        udIndex.TabIndex = 1;
        udIndex.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // cbPorts
        // 
        cbPorts.FormattingEnabled = true;
        cbPorts.Location = new Point(89, 28);
        cbPorts.Margin = new Padding(4, 3, 4, 3);
        cbPorts.Name = "cbPorts";
        cbPorts.Size = new Size(86, 23);
        cbPorts.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnReset);
        groupBox1.Location = new Point(4, 452);
        groupBox1.Margin = new Padding(4, 3, 4, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4, 3, 4, 3);
        groupBox1.Size = new Size(196, 65);
        groupBox1.TabIndex = 6;
        groupBox1.TabStop = false;
        groupBox1.Text = "Alarms";
        // 
        // btnReset
        // 
        btnReset.Location = new Point(7, 22);
        btnReset.Margin = new Padding(4, 3, 4, 3);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(182, 27);
        btnReset.TabIndex = 0;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;
        // 
        // TelnetControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(splitMain);
        Margin = new Padding(4, 3, 4, 3);
        Name = "TelnetControl";
        Size = new Size(957, 725);
        GroupBox3.ResumeLayout(false);
        GroupBox3.PerformLayout();
        splitMain.Panel1.ResumeLayout(false);
        splitMain.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
        splitMain.ResumeLayout(false);
        pnlMain.ResumeLayout(false);
        groupBox5.ResumeLayout(false);
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)udNewValue).EndInit();
        ((System.ComponentModel.ISupportInitialize)udIndex).EndInit();
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
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
    internal System.Windows.Forms.Button btnUnsimulateAll;
    internal System.Windows.Forms.Button btnSimulate;
    internal System.Windows.Forms.Button btnUnsimulatePort;
    private CueTextBox cbPrograms;
    internal System.Windows.Forms.Button btnGetVariable;
    internal System.Windows.Forms.Button btnGetTask;
}
