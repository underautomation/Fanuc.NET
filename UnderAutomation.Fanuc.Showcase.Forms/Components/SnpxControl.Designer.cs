partial class SnpxControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPosition = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.udNumericValue = new System.Windows.Forms.NumericUpDown();
            this.udNumericRegister = new System.Windows.Forms.NumericUpDown();
            this.txtIntegerVariable = new System.Windows.Forms.TextBox();
            this.btnWriteNumericRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWriteIntegerVariable = new System.Windows.Forms.Button();
            this.btnReadNumericRegister = new System.Windows.Forms.Button();
            this.btnReadIntegerVariable = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.udStringRegister = new System.Windows.Forms.NumericUpDown();
            this.txtStringValue = new System.Windows.Forms.TextBox();
            this.txtStringVariable = new System.Windows.Forms.TextBox();
            this.btnWriteStringRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWriteStringVariable = new System.Windows.Forms.Button();
            this.btnReadStringRegister = new System.Windows.Forms.Button();
            this.btnReadStringVariable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridPR = new System.Windows.Forms.PropertyGrid();
            this.txtPositionVariable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWritePositionVariable = new System.Windows.Forms.Button();
            this.udPositionRegister = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReadPositionVariable = new System.Windows.Forms.Button();
            this.btnReadPR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResetPosition = new System.Windows.Forms.Button();
            this.btnResetPositionCartesian = new System.Windows.Forms.Button();
            this.btnResetPositionJoint = new System.Windows.Forms.Button();
            this.btnWritePR = new System.Windows.Forms.Button();
            this.tabSignals = new System.Windows.Forms.TabPage();
            this.snpxSignalControlNumericIOs = new SnpxSignalControl();
            this.snpxSignalControlDigitals = new SnpxSignalControl();
            this.tabAssignments = new System.Windows.Forms.TabPage();
            this.lstAssignments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearAssignments = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPosition.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumericValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumericRegister)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udStringRegister)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPositionRegister)).BeginInit();
            this.tabSignals.SuspendLayout();
            this.tabAssignments.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPosition);
            this.tabControl1.Controls.Add(this.tabSignals);
            this.tabControl1.Controls.Add(this.tabAssignments);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPosition
            // 
            this.tabPosition.Controls.Add(this.groupBox3);
            this.tabPosition.Controls.Add(this.groupBox2);
            this.tabPosition.Controls.Add(this.groupBox1);
            this.tabPosition.Location = new System.Drawing.Point(4, 22);
            this.tabPosition.Name = "tabPosition";
            this.tabPosition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPosition.Size = new System.Drawing.Size(850, 474);
            this.tabPosition.TabIndex = 1;
            this.tabPosition.Text = "Variables and registers";
            this.tabPosition.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.udNumericValue);
            this.groupBox3.Controls.Add(this.udNumericRegister);
            this.groupBox3.Controls.Add(this.txtIntegerVariable);
            this.groupBox3.Controls.Add(this.btnWriteNumericRegister);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnWriteIntegerVariable);
            this.groupBox3.Controls.Add(this.btnReadNumericRegister);
            this.groupBox3.Controls.Add(this.btnReadIntegerVariable);
            this.groupBox3.Location = new System.Drawing.Point(364, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 179);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Numerics";
            // 
            // udNumericValue
            // 
            this.udNumericValue.Location = new System.Drawing.Point(6, 138);
            this.udNumericValue.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.udNumericValue.Minimum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            -2147483648});
            this.udNumericValue.Name = "udNumericValue";
            this.udNumericValue.Size = new System.Drawing.Size(331, 20);
            this.udNumericValue.TabIndex = 0;
            this.udNumericValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udNumericRegister
            // 
            this.udNumericRegister.Location = new System.Drawing.Point(6, 34);
            this.udNumericRegister.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.udNumericRegister.Name = "udNumericRegister";
            this.udNumericRegister.Size = new System.Drawing.Size(120, 20);
            this.udNumericRegister.TabIndex = 0;
            this.udNumericRegister.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtIntegerVariable
            // 
            this.txtIntegerVariable.Location = new System.Drawing.Point(153, 34);
            this.txtIntegerVariable.Name = "txtIntegerVariable";
            this.txtIntegerVariable.Size = new System.Drawing.Size(184, 20);
            this.txtIntegerVariable.TabIndex = 4;
            this.txtIntegerVariable.Text = "$RMT_MASTER";
            // 
            // btnWriteNumericRegister
            // 
            this.btnWriteNumericRegister.Location = new System.Drawing.Point(6, 89);
            this.btnWriteNumericRegister.Name = "btnWriteNumericRegister";
            this.btnWriteNumericRegister.Size = new System.Drawing.Size(120, 23);
            this.btnWriteNumericRegister.TabIndex = 2;
            this.btnWriteNumericRegister.Text = "Write";
            this.btnWriteNumericRegister.UseVisualStyleBackColor = true;
            this.btnWriteNumericRegister.Click += new System.EventHandler(this.btnWriteNumericRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Registers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Value :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Integer variable";
            // 
            // btnWriteIntegerVariable
            // 
            this.btnWriteIntegerVariable.Location = new System.Drawing.Point(153, 89);
            this.btnWriteIntegerVariable.Name = "btnWriteIntegerVariable";
            this.btnWriteIntegerVariable.Size = new System.Drawing.Size(120, 23);
            this.btnWriteIntegerVariable.TabIndex = 2;
            this.btnWriteIntegerVariable.Text = "Write";
            this.btnWriteIntegerVariable.UseVisualStyleBackColor = true;
            this.btnWriteIntegerVariable.Click += new System.EventHandler(this.btnWriteIntegerVariable_Click);
            // 
            // btnReadNumericRegister
            // 
            this.btnReadNumericRegister.Location = new System.Drawing.Point(6, 60);
            this.btnReadNumericRegister.Name = "btnReadNumericRegister";
            this.btnReadNumericRegister.Size = new System.Drawing.Size(120, 23);
            this.btnReadNumericRegister.TabIndex = 2;
            this.btnReadNumericRegister.Text = "Read";
            this.btnReadNumericRegister.UseVisualStyleBackColor = true;
            this.btnReadNumericRegister.Click += new System.EventHandler(this.btnReadNumericRegister_Click);
            // 
            // btnReadIntegerVariable
            // 
            this.btnReadIntegerVariable.Location = new System.Drawing.Point(153, 60);
            this.btnReadIntegerVariable.Name = "btnReadIntegerVariable";
            this.btnReadIntegerVariable.Size = new System.Drawing.Size(120, 23);
            this.btnReadIntegerVariable.TabIndex = 2;
            this.btnReadIntegerVariable.Text = "Read";
            this.btnReadIntegerVariable.UseVisualStyleBackColor = true;
            this.btnReadIntegerVariable.Click += new System.EventHandler(this.btnReadIntegerVariable_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.udStringRegister);
            this.groupBox2.Controls.Add(this.txtStringValue);
            this.groupBox2.Controls.Add(this.txtStringVariable);
            this.groupBox2.Controls.Add(this.btnWriteStringRegister);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnWriteStringVariable);
            this.groupBox2.Controls.Add(this.btnReadStringRegister);
            this.groupBox2.Controls.Add(this.btnReadStringVariable);
            this.groupBox2.Location = new System.Drawing.Point(364, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 201);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Strings";
            // 
            // udStringRegister
            // 
            this.udStringRegister.Location = new System.Drawing.Point(6, 34);
            this.udStringRegister.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.udStringRegister.Name = "udStringRegister";
            this.udStringRegister.Size = new System.Drawing.Size(120, 20);
            this.udStringRegister.TabIndex = 0;
            this.udStringRegister.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtStringValue
            // 
            this.txtStringValue.Location = new System.Drawing.Point(9, 134);
            this.txtStringValue.Multiline = true;
            this.txtStringValue.Name = "txtStringValue";
            this.txtStringValue.Size = new System.Drawing.Size(328, 61);
            this.txtStringValue.TabIndex = 4;
            // 
            // txtStringVariable
            // 
            this.txtStringVariable.Location = new System.Drawing.Point(153, 34);
            this.txtStringVariable.Name = "txtStringVariable";
            this.txtStringVariable.Size = new System.Drawing.Size(184, 20);
            this.txtStringVariable.TabIndex = 4;
            this.txtStringVariable.Text = "$BACKUP_NAME";
            // 
            // btnWriteStringRegister
            // 
            this.btnWriteStringRegister.Location = new System.Drawing.Point(6, 89);
            this.btnWriteStringRegister.Name = "btnWriteStringRegister";
            this.btnWriteStringRegister.Size = new System.Drawing.Size(120, 23);
            this.btnWriteStringRegister.TabIndex = 2;
            this.btnWriteStringRegister.Text = "Write";
            this.btnWriteStringRegister.UseVisualStyleBackColor = true;
            this.btnWriteStringRegister.Click += new System.EventHandler(this.btnWriteStringRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "String register";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Value :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "String variable";
            // 
            // btnWriteStringVariable
            // 
            this.btnWriteStringVariable.Location = new System.Drawing.Point(153, 89);
            this.btnWriteStringVariable.Name = "btnWriteStringVariable";
            this.btnWriteStringVariable.Size = new System.Drawing.Size(120, 23);
            this.btnWriteStringVariable.TabIndex = 2;
            this.btnWriteStringVariable.Text = "Write";
            this.btnWriteStringVariable.UseVisualStyleBackColor = true;
            this.btnWriteStringVariable.Click += new System.EventHandler(this.btnWriteStringVariable_Click);
            // 
            // btnReadStringRegister
            // 
            this.btnReadStringRegister.Location = new System.Drawing.Point(6, 60);
            this.btnReadStringRegister.Name = "btnReadStringRegister";
            this.btnReadStringRegister.Size = new System.Drawing.Size(120, 23);
            this.btnReadStringRegister.TabIndex = 2;
            this.btnReadStringRegister.Text = "Read";
            this.btnReadStringRegister.UseVisualStyleBackColor = true;
            this.btnReadStringRegister.Click += new System.EventHandler(this.btnReadStringRegister_Click);
            // 
            // btnReadStringVariable
            // 
            this.btnReadStringVariable.Location = new System.Drawing.Point(153, 60);
            this.btnReadStringVariable.Name = "btnReadStringVariable";
            this.btnReadStringVariable.Size = new System.Drawing.Size(120, 23);
            this.btnReadStringVariable.TabIndex = 2;
            this.btnReadStringVariable.Text = "Read";
            this.btnReadStringVariable.UseVisualStyleBackColor = true;
            this.btnReadStringVariable.Click += new System.EventHandler(this.btnReadStringVariable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.gridPR);
            this.groupBox1.Controls.Add(this.txtPositionVariable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnWritePositionVariable);
            this.groupBox1.Controls.Add(this.udPositionRegister);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnReadPositionVariable);
            this.groupBox1.Controls.Add(this.btnReadPR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnResetPosition);
            this.groupBox1.Controls.Add(this.btnResetPositionCartesian);
            this.groupBox1.Controls.Add(this.btnResetPositionJoint);
            this.groupBox1.Controls.Add(this.btnWritePR);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 465);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Positions";
            // 
            // gridPR
            // 
            this.gridPR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridPR.HelpVisible = false;
            this.gridPR.Location = new System.Drawing.Point(6, 134);
            this.gridPR.Name = "gridPR";
            this.gridPR.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.gridPR.Size = new System.Drawing.Size(331, 301);
            this.gridPR.TabIndex = 3;
            this.gridPR.ToolbarVisible = false;
            // 
            // txtPositionVariable
            // 
            this.txtPositionVariable.Location = new System.Drawing.Point(153, 34);
            this.txtPositionVariable.Name = "txtPositionVariable";
            this.txtPositionVariable.Size = new System.Drawing.Size(184, 20);
            this.txtPositionVariable.TabIndex = 4;
            this.txtPositionVariable.Text = "$MNUTOOL[1,1]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position register";
            // 
            // btnWritePositionVariable
            // 
            this.btnWritePositionVariable.Location = new System.Drawing.Point(153, 89);
            this.btnWritePositionVariable.Name = "btnWritePositionVariable";
            this.btnWritePositionVariable.Size = new System.Drawing.Size(120, 23);
            this.btnWritePositionVariable.TabIndex = 2;
            this.btnWritePositionVariable.Text = "Write";
            this.btnWritePositionVariable.UseVisualStyleBackColor = true;
            this.btnWritePositionVariable.Click += new System.EventHandler(this.btnWritePositionVariable_Click);
            // 
            // udPositionRegister
            // 
            this.udPositionRegister.Location = new System.Drawing.Point(6, 34);
            this.udPositionRegister.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.udPositionRegister.Name = "udPositionRegister";
            this.udPositionRegister.Size = new System.Drawing.Size(120, 20);
            this.udPositionRegister.TabIndex = 0;
            this.udPositionRegister.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Value :";
            // 
            // btnReadPositionVariable
            // 
            this.btnReadPositionVariable.Location = new System.Drawing.Point(153, 60);
            this.btnReadPositionVariable.Name = "btnReadPositionVariable";
            this.btnReadPositionVariable.Size = new System.Drawing.Size(120, 23);
            this.btnReadPositionVariable.TabIndex = 2;
            this.btnReadPositionVariable.Text = "Read";
            this.btnReadPositionVariable.UseVisualStyleBackColor = true;
            this.btnReadPositionVariable.Click += new System.EventHandler(this.btnReadPositionVariable_Click);
            // 
            // btnReadPR
            // 
            this.btnReadPR.Location = new System.Drawing.Point(6, 60);
            this.btnReadPR.Name = "btnReadPR";
            this.btnReadPR.Size = new System.Drawing.Size(120, 23);
            this.btnReadPR.TabIndex = 2;
            this.btnReadPR.Text = "Read";
            this.btnReadPR.UseVisualStyleBackColor = true;
            this.btnReadPR.Click += new System.EventHandler(this.btnReadPR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Position variable";
            // 
            // btnResetPosition
            // 
            this.btnResetPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetPosition.Location = new System.Drawing.Point(258, 439);
            this.btnResetPosition.Name = "btnResetPosition";
            this.btnResetPosition.Size = new System.Drawing.Size(79, 21);
            this.btnResetPosition.TabIndex = 2;
            this.btnResetPosition.Text = "Reset";
            this.btnResetPosition.UseVisualStyleBackColor = true;
            this.btnResetPosition.Click += new System.EventHandler(this.btnResetPosition_Click);
            // 
            // btnResetPositionCartesian
            // 
            this.btnResetPositionCartesian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetPositionCartesian.Location = new System.Drawing.Point(132, 439);
            this.btnResetPositionCartesian.Name = "btnResetPositionCartesian";
            this.btnResetPositionCartesian.Size = new System.Drawing.Size(120, 21);
            this.btnResetPositionCartesian.TabIndex = 2;
            this.btnResetPositionCartesian.Text = "Reset to cartesian position";
            this.btnResetPositionCartesian.UseVisualStyleBackColor = true;
            this.btnResetPositionCartesian.Click += new System.EventHandler(this.btnResetPositionCartesian_Click);
            // 
            // btnResetPositionJoint
            // 
            this.btnResetPositionJoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetPositionJoint.Location = new System.Drawing.Point(6, 439);
            this.btnResetPositionJoint.Name = "btnResetPositionJoint";
            this.btnResetPositionJoint.Size = new System.Drawing.Size(120, 21);
            this.btnResetPositionJoint.TabIndex = 2;
            this.btnResetPositionJoint.Text = "Reset to joint position";
            this.btnResetPositionJoint.UseVisualStyleBackColor = true;
            this.btnResetPositionJoint.Click += new System.EventHandler(this.btnResetPositionJoint_Click);
            // 
            // btnWritePR
            // 
            this.btnWritePR.Location = new System.Drawing.Point(6, 89);
            this.btnWritePR.Name = "btnWritePR";
            this.btnWritePR.Size = new System.Drawing.Size(120, 23);
            this.btnWritePR.TabIndex = 2;
            this.btnWritePR.Text = "Write";
            this.btnWritePR.UseVisualStyleBackColor = true;
            this.btnWritePR.Click += new System.EventHandler(this.btnWritePR_Click);
            // 
            // tabSignals
            // 
            this.tabSignals.Controls.Add(this.snpxSignalControlNumericIOs);
            this.tabSignals.Controls.Add(this.snpxSignalControlDigitals);
            this.tabSignals.Location = new System.Drawing.Point(4, 22);
            this.tabSignals.Name = "tabSignals";
            this.tabSignals.Padding = new System.Windows.Forms.Padding(3);
            this.tabSignals.Size = new System.Drawing.Size(850, 474);
            this.tabSignals.TabIndex = 3;
            this.tabSignals.Text = "Signals";
            this.tabSignals.UseVisualStyleBackColor = true;
            // 
            // snpxSignalControlNumericIOs
            // 
            this.snpxSignalControlNumericIOs.Dock = System.Windows.Forms.DockStyle.Left;
            this.snpxSignalControlNumericIOs.Location = new System.Drawing.Point(229, 3);
            this.snpxSignalControlNumericIOs.Name = "snpxSignalControlNumericIOs";
            this.snpxSignalControlNumericIOs.Size = new System.Drawing.Size(226, 468);
            this.snpxSignalControlNumericIOs.TabIndex = 1;
            // 
            // snpxSignalControlDigitals
            // 
            this.snpxSignalControlDigitals.Dock = System.Windows.Forms.DockStyle.Left;
            this.snpxSignalControlDigitals.Location = new System.Drawing.Point(3, 3);
            this.snpxSignalControlDigitals.Name = "snpxSignalControlDigitals";
            this.snpxSignalControlDigitals.Size = new System.Drawing.Size(226, 468);
            this.snpxSignalControlDigitals.TabIndex = 0;
            // 
            // tabAssignments
            // 
            this.tabAssignments.Controls.Add(this.lstAssignments);
            this.tabAssignments.Controls.Add(this.panel1);
            this.tabAssignments.Location = new System.Drawing.Point(4, 22);
            this.tabAssignments.Name = "tabAssignments";
            this.tabAssignments.Size = new System.Drawing.Size(850, 474);
            this.tabAssignments.TabIndex = 2;
            this.tabAssignments.Text = "Assignements";
            this.tabAssignments.UseVisualStyleBackColor = true;
            // 
            // lstAssignments
            // 
            this.lstAssignments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAssignments.HideSelection = false;
            this.lstAssignments.Location = new System.Drawing.Point(0, 36);
            this.lstAssignments.Name = "lstAssignments";
            this.lstAssignments.Size = new System.Drawing.Size(850, 438);
            this.lstAssignments.TabIndex = 0;
            this.lstAssignments.UseCompatibleStateImageBehavior = false;
            this.lstAssignments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 209;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Offset";
            this.columnHeader2.Width = 93;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearAssignments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 36);
            this.panel1.TabIndex = 1;
            // 
            // btnClearAssignments
            // 
            this.btnClearAssignments.Location = new System.Drawing.Point(3, 7);
            this.btnClearAssignments.Name = "btnClearAssignments";
            this.btnClearAssignments.Size = new System.Drawing.Size(134, 23);
            this.btnClearAssignments.TabIndex = 0;
            this.btnClearAssignments.Text = "Clear assignments";
            this.btnClearAssignments.UseVisualStyleBackColor = true;
            this.btnClearAssignments.Click += new System.EventHandler(this.btnClearAssignments_Click);
            // 
            // SnpxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "SnpxControl";
            this.Size = new System.Drawing.Size(858, 500);
            this.tabControl1.ResumeLayout(false);
            this.tabPosition.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumericValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumericRegister)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udStringRegister)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPositionRegister)).EndInit();
            this.tabSignals.ResumeLayout(false);
            this.tabAssignments.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPosition;
    private System.Windows.Forms.PropertyGrid gridPR;
    private System.Windows.Forms.Button btnWritePR;
    private System.Windows.Forms.Button btnReadPR;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown udPositionRegister;
    private System.Windows.Forms.TabPage tabAssignments;
    private System.Windows.Forms.ListView lstAssignments;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.TextBox txtPositionVariable;
    private System.Windows.Forms.Button btnWritePositionVariable;
    private System.Windows.Forms.Button btnReadPositionVariable;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.NumericUpDown udStringRegister;
    private System.Windows.Forms.TextBox txtStringValue;
    private System.Windows.Forms.TextBox txtStringVariable;
    private System.Windows.Forms.Button btnWriteStringRegister;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnWriteStringVariable;
    private System.Windows.Forms.Button btnReadStringRegister;
    private System.Windows.Forms.Button btnReadStringVariable;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.NumericUpDown udNumericRegister;
    private System.Windows.Forms.TextBox txtIntegerVariable;
    private System.Windows.Forms.Button btnWriteNumericRegister;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnWriteIntegerVariable;
    private System.Windows.Forms.Button btnReadNumericRegister;
    private System.Windows.Forms.Button btnReadIntegerVariable;
    private System.Windows.Forms.NumericUpDown udNumericValue;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnClearAssignments;
    private System.Windows.Forms.TabPage tabSignals;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Button btnResetPositionCartesian;
    private System.Windows.Forms.Button btnResetPositionJoint;
    private System.Windows.Forms.Button btnResetPosition;
    private SnpxSignalControl snpxSignalControlNumericIOs;
    private SnpxSignalControl snpxSignalControlDigitals;
}
