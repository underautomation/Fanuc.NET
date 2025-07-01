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
        tabControl1 = new TabControl();
        tabVariablesRegisters = new TabPage();
        groupBox4 = new GroupBox();
        textBox1 = new TextBox();
        groupBox3 = new GroupBox();
        udNumericValue = new NumericUpDown();
        udNumericRegister = new NumericUpDown();
        txtRealVariable = new TextBox();
        txtIntegerVariable = new TextBox();
        btnWriteNumericRegister = new Button();
        label5 = new Label();
        label11 = new Label();
        label7 = new Label();
        btnWriteRealVariable = new Button();
        label6 = new Label();
        btnWriteIntegerVariable = new Button();
        btnReadRealVariable = new Button();
        btnReadNumericRegister = new Button();
        btnReadIntegerVariable = new Button();
        groupBox2 = new GroupBox();
        udStringRegister = new NumericUpDown();
        txtStringValue = new TextBox();
        txtStringVariable = new TextBox();
        btnWriteStringRegister = new Button();
        label4 = new Label();
        label8 = new Label();
        label3 = new Label();
        btnWriteStringVariable = new Button();
        btnReadStringRegister = new Button();
        btnReadStringVariable = new Button();
        groupBox1 = new GroupBox();
        btnPositionUserFrame = new Button();
        btnPositionWorld = new Button();
        gridPR = new PropertyGrid();
        txtPositionVariable = new TextBox();
        label10 = new Label();
        label1 = new Label();
        btnWritePositionVariable = new Button();
        udFrame = new NumericUpDown();
        udPositionRegister = new NumericUpDown();
        label9 = new Label();
        btnReadPositionVariable = new Button();
        btnReadPR = new Button();
        label2 = new Label();
        btnWritePR = new Button();
        tabSignals = new TabPage();
        snpxSignalControlNumericIOs = new SnpxSignalControl();
        snpxSignalControlDigitals = new SnpxSignalControl();
        tabBatch = new TabPage();
        groupBox11 = new GroupBox();
        gridFloatVariablesAssignment = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        btnReadFloatVariablesAssignment = new Button();
        btnCreateFloatVariablesAssignment = new Button();
        groupBox10 = new GroupBox();
        gridStringVariablesAssignment = new DataGridView();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        btnReadStringVariablesAssignment = new Button();
        btnCreateStringVariablesAssignment = new Button();
        groupBox7 = new GroupBox();
        btnReadStringRegisterAssignment = new Button();
        btnCreateStringRegisterAssignment = new Button();
        groupBox9 = new GroupBox();
        gridPositionVariablesAssignment = new DataGridView();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        btnReadPositionVariablesAssignment = new Button();
        btnCreatePositionVariablesAssignment = new Button();
        groupBox6 = new GroupBox();
        btnReadPositionRegisterAssignment = new Button();
        btnCreatePositionRegisterAssignment = new Button();
        groupBox8 = new GroupBox();
        gridIntegerVariablesAssignment = new DataGridView();
        Column1 = new DataGridViewTextBoxColumn();
        btnReadIntegerVariablesAssignment = new Button();
        btnCreateIntegerVariablesAssignment = new Button();
        groupBox5 = new GroupBox();
        btnReadNumericRegisterAssignment = new Button();
        btnCreateNumericRegisterAssignment = new Button();
        lblBatchStats = new Label();
        label13 = new Label();
        label12 = new Label();
        udBatchCount = new NumericUpDown();
        udBatchStart = new NumericUpDown();
        gridBatchValue = new PropertyGrid();
        tabAssignments = new TabPage();
        lstAssignments = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        panel1 = new Panel();
        btnClearAlarms = new Button();
        btnClearAssignments = new Button();
        tabControl1.SuspendLayout();
        tabVariablesRegisters.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udNumericValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize)udNumericRegister).BeginInit();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udStringRegister).BeginInit();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udFrame).BeginInit();
        ((System.ComponentModel.ISupportInitialize)udPositionRegister).BeginInit();
        tabSignals.SuspendLayout();
        tabBatch.SuspendLayout();
        groupBox11.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridFloatVariablesAssignment).BeginInit();
        groupBox10.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridStringVariablesAssignment).BeginInit();
        groupBox7.SuspendLayout();
        groupBox9.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridPositionVariablesAssignment).BeginInit();
        groupBox6.SuspendLayout();
        groupBox8.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridIntegerVariablesAssignment).BeginInit();
        groupBox5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udBatchCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)udBatchStart).BeginInit();
        tabAssignments.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabVariablesRegisters);
        tabControl1.Controls.Add(tabSignals);
        tabControl1.Controls.Add(tabBatch);
        tabControl1.Controls.Add(tabAssignments);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 0);
        tabControl1.Margin = new Padding(4, 3, 4, 3);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1183, 577);
        tabControl1.TabIndex = 0;
        // 
        // tabVariablesRegisters
        // 
        tabVariablesRegisters.Controls.Add(groupBox4);
        tabVariablesRegisters.Controls.Add(groupBox3);
        tabVariablesRegisters.Controls.Add(groupBox2);
        tabVariablesRegisters.Controls.Add(groupBox1);
        tabVariablesRegisters.Location = new Point(4, 24);
        tabVariablesRegisters.Margin = new Padding(4, 3, 4, 3);
        tabVariablesRegisters.Name = "tabVariablesRegisters";
        tabVariablesRegisters.Padding = new Padding(4, 3, 4, 3);
        tabVariablesRegisters.Size = new Size(1175, 549);
        tabVariablesRegisters.TabIndex = 1;
        tabVariablesRegisters.Text = "Variables and registers";
        tabVariablesRegisters.UseVisualStyleBackColor = true;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(textBox1);
        groupBox4.Location = new Point(425, 461);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(496, 68);
        groupBox4.TabIndex = 7;
        groupBox4.TabStop = false;
        groupBox4.Text = "Karel program variables";
        // 
        // textBox1
        // 
        textBox1.Dock = DockStyle.Fill;
        textBox1.Location = new Point(3, 19);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(490, 46);
        textBox1.TabIndex = 0;
        textBox1.Text = "To read & write karel variables, just use the variable name : $[KarelProgram]KarelVariable";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(udNumericValue);
        groupBox3.Controls.Add(udNumericRegister);
        groupBox3.Controls.Add(txtRealVariable);
        groupBox3.Controls.Add(txtIntegerVariable);
        groupBox3.Controls.Add(btnWriteNumericRegister);
        groupBox3.Controls.Add(label5);
        groupBox3.Controls.Add(label11);
        groupBox3.Controls.Add(label7);
        groupBox3.Controls.Add(btnWriteRealVariable);
        groupBox3.Controls.Add(label6);
        groupBox3.Controls.Add(btnWriteIntegerVariable);
        groupBox3.Controls.Add(btnReadRealVariable);
        groupBox3.Controls.Add(btnReadNumericRegister);
        groupBox3.Controls.Add(btnReadIntegerVariable);
        groupBox3.Location = new Point(425, 246);
        groupBox3.Margin = new Padding(4, 3, 4, 3);
        groupBox3.Name = "groupBox3";
        groupBox3.Padding = new Padding(4, 3, 4, 3);
        groupBox3.Size = new Size(496, 207);
        groupBox3.TabIndex = 6;
        groupBox3.TabStop = false;
        groupBox3.Text = "Numerics";
        // 
        // udNumericValue
        // 
        udNumericValue.DecimalPlaces = 3;
        udNumericValue.Location = new Point(7, 159);
        udNumericValue.Margin = new Padding(4, 3, 4, 3);
        udNumericValue.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
        udNumericValue.Minimum = new decimal(new int[] { 1661992959, 1808227885, 5, int.MinValue });
        udNumericValue.Name = "udNumericValue";
        udNumericValue.Size = new Size(479, 23);
        udNumericValue.TabIndex = 0;
        udNumericValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // udNumericRegister
        // 
        udNumericRegister.Location = new Point(7, 39);
        udNumericRegister.Margin = new Padding(4, 3, 4, 3);
        udNumericRegister.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
        udNumericRegister.Name = "udNumericRegister";
        udNumericRegister.Size = new Size(140, 23);
        udNumericRegister.TabIndex = 0;
        udNumericRegister.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // txtRealVariable
        // 
        txtRealVariable.Location = new Point(346, 39);
        txtRealVariable.Margin = new Padding(4, 3, 4, 3);
        txtRealVariable.Name = "txtRealVariable";
        txtRealVariable.Size = new Size(140, 23);
        txtRealVariable.TabIndex = 4;
        txtRealVariable.Text = "$ARGDISPMMCK";
        // 
        // txtIntegerVariable
        // 
        txtIntegerVariable.Location = new Point(178, 39);
        txtIntegerVariable.Margin = new Padding(4, 3, 4, 3);
        txtIntegerVariable.Name = "txtIntegerVariable";
        txtIntegerVariable.Size = new Size(140, 23);
        txtIntegerVariable.TabIndex = 4;
        txtIntegerVariable.Text = "$RMT_MASTER";
        // 
        // btnWriteNumericRegister
        // 
        btnWriteNumericRegister.Location = new Point(7, 103);
        btnWriteNumericRegister.Margin = new Padding(4, 3, 4, 3);
        btnWriteNumericRegister.Name = "btnWriteNumericRegister";
        btnWriteNumericRegister.Size = new Size(140, 27);
        btnWriteNumericRegister.TabIndex = 2;
        btnWriteNumericRegister.Text = "Write";
        btnWriteNumericRegister.UseVisualStyleBackColor = true;
        btnWriteNumericRegister.Click += btnWriteNumericRegister_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(7, 21);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(54, 15);
        label5.TabIndex = 1;
        label5.Text = "Registers";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(346, 21);
        label11.Margin = new Padding(4, 0, 4, 0);
        label11.Name = "label11";
        label11.Size = new Size(73, 15);
        label11.TabIndex = 1;
        label11.Text = "Real variable";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(7, 141);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(41, 15);
        label7.TabIndex = 1;
        label7.Text = "Value :";
        // 
        // btnWriteRealVariable
        // 
        btnWriteRealVariable.Location = new Point(346, 103);
        btnWriteRealVariable.Margin = new Padding(4, 3, 4, 3);
        btnWriteRealVariable.Name = "btnWriteRealVariable";
        btnWriteRealVariable.Size = new Size(140, 27);
        btnWriteRealVariable.TabIndex = 2;
        btnWriteRealVariable.Text = "Write";
        btnWriteRealVariable.UseVisualStyleBackColor = true;
        btnWriteRealVariable.Click += btnWriteRealVariable_Click;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(178, 21);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(88, 15);
        label6.TabIndex = 1;
        label6.Text = "Integer variable";
        // 
        // btnWriteIntegerVariable
        // 
        btnWriteIntegerVariable.Location = new Point(178, 103);
        btnWriteIntegerVariable.Margin = new Padding(4, 3, 4, 3);
        btnWriteIntegerVariable.Name = "btnWriteIntegerVariable";
        btnWriteIntegerVariable.Size = new Size(140, 27);
        btnWriteIntegerVariable.TabIndex = 2;
        btnWriteIntegerVariable.Text = "Write";
        btnWriteIntegerVariable.UseVisualStyleBackColor = true;
        btnWriteIntegerVariable.Click += btnWriteIntegerVariable_Click;
        // 
        // btnReadRealVariable
        // 
        btnReadRealVariable.Location = new Point(346, 69);
        btnReadRealVariable.Margin = new Padding(4, 3, 4, 3);
        btnReadRealVariable.Name = "btnReadRealVariable";
        btnReadRealVariable.Size = new Size(140, 27);
        btnReadRealVariable.TabIndex = 2;
        btnReadRealVariable.Text = "Read";
        btnReadRealVariable.UseVisualStyleBackColor = true;
        btnReadRealVariable.Click += btnReadRealVariable_Click;
        // 
        // btnReadNumericRegister
        // 
        btnReadNumericRegister.Location = new Point(7, 69);
        btnReadNumericRegister.Margin = new Padding(4, 3, 4, 3);
        btnReadNumericRegister.Name = "btnReadNumericRegister";
        btnReadNumericRegister.Size = new Size(140, 27);
        btnReadNumericRegister.TabIndex = 2;
        btnReadNumericRegister.Text = "Read";
        btnReadNumericRegister.UseVisualStyleBackColor = true;
        btnReadNumericRegister.Click += btnReadNumericRegister_Click;
        // 
        // btnReadIntegerVariable
        // 
        btnReadIntegerVariable.Location = new Point(178, 69);
        btnReadIntegerVariable.Margin = new Padding(4, 3, 4, 3);
        btnReadIntegerVariable.Name = "btnReadIntegerVariable";
        btnReadIntegerVariable.Size = new Size(140, 27);
        btnReadIntegerVariable.TabIndex = 2;
        btnReadIntegerVariable.Text = "Read";
        btnReadIntegerVariable.UseVisualStyleBackColor = true;
        btnReadIntegerVariable.Click += btnReadIntegerVariable_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(udStringRegister);
        groupBox2.Controls.Add(txtStringValue);
        groupBox2.Controls.Add(txtStringVariable);
        groupBox2.Controls.Add(btnWriteStringRegister);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(btnWriteStringVariable);
        groupBox2.Controls.Add(btnReadStringRegister);
        groupBox2.Controls.Add(btnReadStringVariable);
        groupBox2.Location = new Point(425, 7);
        groupBox2.Margin = new Padding(4, 3, 4, 3);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(4, 3, 4, 3);
        groupBox2.Size = new Size(496, 232);
        groupBox2.TabIndex = 6;
        groupBox2.TabStop = false;
        groupBox2.Text = "Strings";
        // 
        // udStringRegister
        // 
        udStringRegister.Location = new Point(7, 39);
        udStringRegister.Margin = new Padding(4, 3, 4, 3);
        udStringRegister.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
        udStringRegister.Name = "udStringRegister";
        udStringRegister.Size = new Size(140, 23);
        udStringRegister.TabIndex = 0;
        udStringRegister.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // txtStringValue
        // 
        txtStringValue.Location = new Point(10, 155);
        txtStringValue.Margin = new Padding(4, 3, 4, 3);
        txtStringValue.Multiline = true;
        txtStringValue.Name = "txtStringValue";
        txtStringValue.Size = new Size(382, 70);
        txtStringValue.TabIndex = 4;
        // 
        // txtStringVariable
        // 
        txtStringVariable.Location = new Point(178, 39);
        txtStringVariable.Margin = new Padding(4, 3, 4, 3);
        txtStringVariable.Name = "txtStringVariable";
        txtStringVariable.Size = new Size(214, 23);
        txtStringVariable.TabIndex = 4;
        txtStringVariable.Text = "$BACKUP_NAME";
        // 
        // btnWriteStringRegister
        // 
        btnWriteStringRegister.Location = new Point(7, 103);
        btnWriteStringRegister.Margin = new Padding(4, 3, 4, 3);
        btnWriteStringRegister.Name = "btnWriteStringRegister";
        btnWriteStringRegister.Size = new Size(140, 27);
        btnWriteStringRegister.TabIndex = 2;
        btnWriteStringRegister.Text = "Write";
        btnWriteStringRegister.UseVisualStyleBackColor = true;
        btnWriteStringRegister.Click += btnWriteStringRegister_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(7, 21);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(80, 15);
        label4.TabIndex = 1;
        label4.Text = "String register";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(7, 136);
        label8.Margin = new Padding(4, 0, 4, 0);
        label8.Name = "label8";
        label8.Size = new Size(41, 15);
        label8.TabIndex = 1;
        label8.Text = "Value :";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(178, 21);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(82, 15);
        label3.TabIndex = 1;
        label3.Text = "String variable";
        // 
        // btnWriteStringVariable
        // 
        btnWriteStringVariable.Location = new Point(178, 103);
        btnWriteStringVariable.Margin = new Padding(4, 3, 4, 3);
        btnWriteStringVariable.Name = "btnWriteStringVariable";
        btnWriteStringVariable.Size = new Size(140, 27);
        btnWriteStringVariable.TabIndex = 2;
        btnWriteStringVariable.Text = "Write";
        btnWriteStringVariable.UseVisualStyleBackColor = true;
        btnWriteStringVariable.Click += btnWriteStringVariable_Click;
        // 
        // btnReadStringRegister
        // 
        btnReadStringRegister.Location = new Point(7, 69);
        btnReadStringRegister.Margin = new Padding(4, 3, 4, 3);
        btnReadStringRegister.Name = "btnReadStringRegister";
        btnReadStringRegister.Size = new Size(140, 27);
        btnReadStringRegister.TabIndex = 2;
        btnReadStringRegister.Text = "Read";
        btnReadStringRegister.UseVisualStyleBackColor = true;
        btnReadStringRegister.Click += btnReadStringRegister_Click;
        // 
        // btnReadStringVariable
        // 
        btnReadStringVariable.Location = new Point(178, 69);
        btnReadStringVariable.Margin = new Padding(4, 3, 4, 3);
        btnReadStringVariable.Name = "btnReadStringVariable";
        btnReadStringVariable.Size = new Size(140, 27);
        btnReadStringVariable.TabIndex = 2;
        btnReadStringVariable.Text = "Read";
        btnReadStringVariable.UseVisualStyleBackColor = true;
        btnReadStringVariable.Click += btnReadStringVariable_Click;
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        groupBox1.Controls.Add(btnPositionUserFrame);
        groupBox1.Controls.Add(btnPositionWorld);
        groupBox1.Controls.Add(gridPR);
        groupBox1.Controls.Add(txtPositionVariable);
        groupBox1.Controls.Add(label10);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(btnWritePositionVariable);
        groupBox1.Controls.Add(udFrame);
        groupBox1.Controls.Add(udPositionRegister);
        groupBox1.Controls.Add(label9);
        groupBox1.Controls.Add(btnReadPositionVariable);
        groupBox1.Controls.Add(btnReadPR);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(btnWritePR);
        groupBox1.Location = new Point(7, 7);
        groupBox1.Margin = new Padding(4, 3, 4, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4, 3, 4, 3);
        groupBox1.Size = new Size(411, 537);
        groupBox1.TabIndex = 5;
        groupBox1.TabStop = false;
        groupBox1.Text = "Positions";
        // 
        // btnPositionUserFrame
        // 
        btnPositionUserFrame.Location = new Point(204, 184);
        btnPositionUserFrame.Name = "btnPositionUserFrame";
        btnPositionUserFrame.Size = new Size(199, 25);
        btnPositionUserFrame.TabIndex = 5;
        btnPositionUserFrame.Text = "Read current user frame position";
        btnPositionUserFrame.UseVisualStyleBackColor = true;
        btnPositionUserFrame.Click += btnPositionUserFrame_Click;
        // 
        // btnPositionWorld
        // 
        btnPositionWorld.Location = new Point(8, 155);
        btnPositionWorld.Name = "btnPositionWorld";
        btnPositionWorld.Size = new Size(164, 54);
        btnPositionWorld.TabIndex = 5;
        btnPositionWorld.Text = "Read current world position";
        btnPositionWorld.UseVisualStyleBackColor = true;
        btnPositionWorld.Click += btnPositionWorld_Click;
        // 
        // gridPR
        // 
        gridPR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridPR.HelpVisible = false;
        gridPR.Location = new Point(6, 226);
        gridPR.Margin = new Padding(4, 3, 4, 3);
        gridPR.Name = "gridPR";
        gridPR.PropertySort = PropertySort.NoSort;
        gridPR.Size = new Size(397, 305);
        gridPR.TabIndex = 3;
        gridPR.ToolbarVisible = false;
        // 
        // txtPositionVariable
        // 
        txtPositionVariable.Location = new Point(229, 39);
        txtPositionVariable.Margin = new Padding(4, 3, 4, 3);
        txtPositionVariable.Name = "txtPositionVariable";
        txtPositionVariable.Size = new Size(174, 23);
        txtPositionVariable.TabIndex = 4;
        txtPositionVariable.Text = "$MNUTOOL[1,1]";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(204, 159);
        label10.Margin = new Padding(4, 0, 4, 0);
        label10.Name = "label10";
        label10.Size = new Size(70, 15);
        label10.TabIndex = 1;
        label10.Text = "User frame :";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(7, 21);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(92, 15);
        label1.TabIndex = 1;
        label1.Text = "Position register";
        // 
        // btnWritePositionVariable
        // 
        btnWritePositionVariable.Location = new Point(229, 103);
        btnWritePositionVariable.Margin = new Padding(4, 3, 4, 3);
        btnWritePositionVariable.Name = "btnWritePositionVariable";
        btnWritePositionVariable.Size = new Size(140, 27);
        btnWritePositionVariable.TabIndex = 2;
        btnWritePositionVariable.Text = "Write";
        btnWritePositionVariable.UseVisualStyleBackColor = true;
        btnWritePositionVariable.Click += btnWritePositionVariable_Click;
        // 
        // udFrame
        // 
        udFrame.Location = new Point(282, 155);
        udFrame.Margin = new Padding(4, 3, 4, 3);
        udFrame.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
        udFrame.Name = "udFrame";
        udFrame.Size = new Size(41, 23);
        udFrame.TabIndex = 0;
        udFrame.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // udPositionRegister
        // 
        udPositionRegister.Location = new Point(7, 39);
        udPositionRegister.Margin = new Padding(4, 3, 4, 3);
        udPositionRegister.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
        udPositionRegister.Name = "udPositionRegister";
        udPositionRegister.Size = new Size(140, 23);
        udPositionRegister.TabIndex = 0;
        udPositionRegister.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(8, 212);
        label9.Margin = new Padding(4, 0, 4, 0);
        label9.Name = "label9";
        label9.Size = new Size(41, 15);
        label9.TabIndex = 1;
        label9.Text = "Value :";
        // 
        // btnReadPositionVariable
        // 
        btnReadPositionVariable.Location = new Point(229, 69);
        btnReadPositionVariable.Margin = new Padding(4, 3, 4, 3);
        btnReadPositionVariable.Name = "btnReadPositionVariable";
        btnReadPositionVariable.Size = new Size(140, 27);
        btnReadPositionVariable.TabIndex = 2;
        btnReadPositionVariable.Text = "Read";
        btnReadPositionVariable.UseVisualStyleBackColor = true;
        btnReadPositionVariable.Click += btnReadPositionVariable_Click;
        // 
        // btnReadPR
        // 
        btnReadPR.Location = new Point(7, 69);
        btnReadPR.Margin = new Padding(4, 3, 4, 3);
        btnReadPR.Name = "btnReadPR";
        btnReadPR.Size = new Size(140, 27);
        btnReadPR.TabIndex = 2;
        btnReadPR.Text = "Read";
        btnReadPR.UseVisualStyleBackColor = true;
        btnReadPR.Click += btnReadPR_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(229, 21);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(94, 15);
        label2.TabIndex = 1;
        label2.Text = "Position variable";
        // 
        // btnWritePR
        // 
        btnWritePR.Location = new Point(7, 103);
        btnWritePR.Margin = new Padding(4, 3, 4, 3);
        btnWritePR.Name = "btnWritePR";
        btnWritePR.Size = new Size(140, 27);
        btnWritePR.TabIndex = 2;
        btnWritePR.Text = "Write";
        btnWritePR.UseVisualStyleBackColor = true;
        btnWritePR.Click += btnWritePR_Click;
        // 
        // tabSignals
        // 
        tabSignals.Controls.Add(snpxSignalControlNumericIOs);
        tabSignals.Controls.Add(snpxSignalControlDigitals);
        tabSignals.Location = new Point(4, 24);
        tabSignals.Margin = new Padding(4, 3, 4, 3);
        tabSignals.Name = "tabSignals";
        tabSignals.Padding = new Padding(4, 3, 4, 3);
        tabSignals.Size = new Size(1175, 549);
        tabSignals.TabIndex = 3;
        tabSignals.Text = "Signals";
        tabSignals.UseVisualStyleBackColor = true;
        // 
        // snpxSignalControlNumericIOs
        // 
        snpxSignalControlNumericIOs.Dock = DockStyle.Left;
        snpxSignalControlNumericIOs.Location = new Point(268, 3);
        snpxSignalControlNumericIOs.Margin = new Padding(5, 3, 5, 3);
        snpxSignalControlNumericIOs.Name = "snpxSignalControlNumericIOs";
        snpxSignalControlNumericIOs.Size = new Size(264, 543);
        snpxSignalControlNumericIOs.TabIndex = 1;
        // 
        // snpxSignalControlDigitals
        // 
        snpxSignalControlDigitals.Dock = DockStyle.Left;
        snpxSignalControlDigitals.Location = new Point(4, 3);
        snpxSignalControlDigitals.Margin = new Padding(5, 3, 5, 3);
        snpxSignalControlDigitals.Name = "snpxSignalControlDigitals";
        snpxSignalControlDigitals.Size = new Size(264, 543);
        snpxSignalControlDigitals.TabIndex = 0;
        // 
        // tabBatch
        // 
        tabBatch.Controls.Add(groupBox11);
        tabBatch.Controls.Add(groupBox10);
        tabBatch.Controls.Add(groupBox7);
        tabBatch.Controls.Add(groupBox9);
        tabBatch.Controls.Add(groupBox6);
        tabBatch.Controls.Add(groupBox8);
        tabBatch.Controls.Add(groupBox5);
        tabBatch.Controls.Add(lblBatchStats);
        tabBatch.Controls.Add(label13);
        tabBatch.Controls.Add(label12);
        tabBatch.Controls.Add(udBatchCount);
        tabBatch.Controls.Add(udBatchStart);
        tabBatch.Controls.Add(gridBatchValue);
        tabBatch.Location = new Point(4, 24);
        tabBatch.Name = "tabBatch";
        tabBatch.Padding = new Padding(3);
        tabBatch.Size = new Size(1175, 549);
        tabBatch.TabIndex = 4;
        tabBatch.Text = "Batch reading";
        tabBatch.UseVisualStyleBackColor = true;
        // 
        // groupBox11
        // 
        groupBox11.Controls.Add(gridFloatVariablesAssignment);
        groupBox11.Controls.Add(btnReadFloatVariablesAssignment);
        groupBox11.Controls.Add(btnCreateFloatVariablesAssignment);
        groupBox11.Location = new Point(696, 24);
        groupBox11.Name = "groupBox11";
        groupBox11.Size = new Size(141, 197);
        groupBox11.TabIndex = 7;
        groupBox11.TabStop = false;
        groupBox11.Text = "Float variables";
        // 
        // gridFloatVariablesAssignment
        // 
        gridFloatVariablesAssignment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridFloatVariablesAssignment.ColumnHeadersVisible = false;
        gridFloatVariablesAssignment.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
        gridFloatVariablesAssignment.Location = new Point(6, 22);
        gridFloatVariablesAssignment.Name = "gridFloatVariablesAssignment";
        gridFloatVariablesAssignment.RowHeadersVisible = false;
        gridFloatVariablesAssignment.Size = new Size(126, 103);
        gridFloatVariablesAssignment.TabIndex = 8;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewTextBoxColumn1.HeaderText = "Column1";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        // 
        // btnReadFloatVariablesAssignment
        // 
        btnReadFloatVariablesAssignment.Location = new Point(6, 167);
        btnReadFloatVariablesAssignment.Name = "btnReadFloatVariablesAssignment";
        btnReadFloatVariablesAssignment.Size = new Size(126, 23);
        btnReadFloatVariablesAssignment.TabIndex = 0;
        btnReadFloatVariablesAssignment.Text = "Read";
        btnReadFloatVariablesAssignment.UseVisualStyleBackColor = true;
        btnReadFloatVariablesAssignment.Click += btnReadFloatVariablesAssignment_Click;
        // 
        // btnCreateFloatVariablesAssignment
        // 
        btnCreateFloatVariablesAssignment.Location = new Point(6, 131);
        btnCreateFloatVariablesAssignment.Name = "btnCreateFloatVariablesAssignment";
        btnCreateFloatVariablesAssignment.Size = new Size(126, 23);
        btnCreateFloatVariablesAssignment.TabIndex = 0;
        btnCreateFloatVariablesAssignment.Text = "Create assignment";
        btnCreateFloatVariablesAssignment.UseVisualStyleBackColor = true;
        btnCreateFloatVariablesAssignment.Click += btnCreateFloatVariablesAssignment_Click;
        // 
        // groupBox10
        // 
        groupBox10.Controls.Add(gridStringVariablesAssignment);
        groupBox10.Controls.Add(btnReadStringVariablesAssignment);
        groupBox10.Controls.Add(btnCreateStringVariablesAssignment);
        groupBox10.Location = new Point(990, 24);
        groupBox10.Name = "groupBox10";
        groupBox10.Size = new Size(141, 197);
        groupBox10.TabIndex = 7;
        groupBox10.TabStop = false;
        groupBox10.Text = "String variables";
        // 
        // gridStringVariablesAssignment
        // 
        gridStringVariablesAssignment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridStringVariablesAssignment.ColumnHeadersVisible = false;
        gridStringVariablesAssignment.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3 });
        gridStringVariablesAssignment.Location = new Point(6, 22);
        gridStringVariablesAssignment.Name = "gridStringVariablesAssignment";
        gridStringVariablesAssignment.RowHeadersVisible = false;
        gridStringVariablesAssignment.Size = new Size(126, 103);
        gridStringVariablesAssignment.TabIndex = 10;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewTextBoxColumn3.HeaderText = "Column1";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        // 
        // btnReadStringVariablesAssignment
        // 
        btnReadStringVariablesAssignment.Location = new Point(6, 167);
        btnReadStringVariablesAssignment.Name = "btnReadStringVariablesAssignment";
        btnReadStringVariablesAssignment.Size = new Size(126, 23);
        btnReadStringVariablesAssignment.TabIndex = 0;
        btnReadStringVariablesAssignment.Text = "Read";
        btnReadStringVariablesAssignment.UseVisualStyleBackColor = true;
        btnReadStringVariablesAssignment.Click += btnReadStringVariablesAssignment_Click;
        // 
        // btnCreateStringVariablesAssignment
        // 
        btnCreateStringVariablesAssignment.Location = new Point(6, 131);
        btnCreateStringVariablesAssignment.Name = "btnCreateStringVariablesAssignment";
        btnCreateStringVariablesAssignment.Size = new Size(126, 23);
        btnCreateStringVariablesAssignment.TabIndex = 0;
        btnCreateStringVariablesAssignment.Text = "Create assignment";
        btnCreateStringVariablesAssignment.UseVisualStyleBackColor = true;
        btnCreateStringVariablesAssignment.Click += btnCreateStringVariablesAssignment_Click;
        // 
        // groupBox7
        // 
        groupBox7.Controls.Add(btnReadStringRegisterAssignment);
        groupBox7.Controls.Add(btnCreateStringRegisterAssignment);
        groupBox7.Location = new Point(323, 134);
        groupBox7.Name = "groupBox7";
        groupBox7.Size = new Size(141, 87);
        groupBox7.TabIndex = 7;
        groupBox7.TabStop = false;
        groupBox7.Text = "String registers";
        // 
        // btnReadStringRegisterAssignment
        // 
        btnReadStringRegisterAssignment.Location = new Point(6, 58);
        btnReadStringRegisterAssignment.Name = "btnReadStringRegisterAssignment";
        btnReadStringRegisterAssignment.Size = new Size(126, 23);
        btnReadStringRegisterAssignment.TabIndex = 0;
        btnReadStringRegisterAssignment.Text = "Read";
        btnReadStringRegisterAssignment.UseVisualStyleBackColor = true;
        btnReadStringRegisterAssignment.Click += btnReadStringRegisterAssignment_Click;
        // 
        // btnCreateStringRegisterAssignment
        // 
        btnCreateStringRegisterAssignment.Location = new Point(6, 22);
        btnCreateStringRegisterAssignment.Name = "btnCreateStringRegisterAssignment";
        btnCreateStringRegisterAssignment.Size = new Size(126, 23);
        btnCreateStringRegisterAssignment.TabIndex = 0;
        btnCreateStringRegisterAssignment.Text = "Create assignment";
        btnCreateStringRegisterAssignment.UseVisualStyleBackColor = true;
        btnCreateStringRegisterAssignment.Click += btnCreateStringRegisterAssignment_Click;
        // 
        // groupBox9
        // 
        groupBox9.Controls.Add(gridPositionVariablesAssignment);
        groupBox9.Controls.Add(btnReadPositionVariablesAssignment);
        groupBox9.Controls.Add(btnCreatePositionVariablesAssignment);
        groupBox9.Location = new Point(843, 24);
        groupBox9.Name = "groupBox9";
        groupBox9.Size = new Size(141, 197);
        groupBox9.TabIndex = 7;
        groupBox9.TabStop = false;
        groupBox9.Text = "Position variables";
        // 
        // gridPositionVariablesAssignment
        // 
        gridPositionVariablesAssignment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridPositionVariablesAssignment.ColumnHeadersVisible = false;
        gridPositionVariablesAssignment.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2 });
        gridPositionVariablesAssignment.Location = new Point(6, 22);
        gridPositionVariablesAssignment.Name = "gridPositionVariablesAssignment";
        gridPositionVariablesAssignment.RowHeadersVisible = false;
        gridPositionVariablesAssignment.Size = new Size(126, 103);
        gridPositionVariablesAssignment.TabIndex = 9;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewTextBoxColumn2.HeaderText = "Column1";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        // 
        // btnReadPositionVariablesAssignment
        // 
        btnReadPositionVariablesAssignment.Location = new Point(6, 167);
        btnReadPositionVariablesAssignment.Name = "btnReadPositionVariablesAssignment";
        btnReadPositionVariablesAssignment.Size = new Size(126, 23);
        btnReadPositionVariablesAssignment.TabIndex = 0;
        btnReadPositionVariablesAssignment.Text = "Read";
        btnReadPositionVariablesAssignment.UseVisualStyleBackColor = true;
        btnReadPositionVariablesAssignment.Click += btnReadPositionVariablesAssignment_Click;
        // 
        // btnCreatePositionVariablesAssignment
        // 
        btnCreatePositionVariablesAssignment.Location = new Point(6, 131);
        btnCreatePositionVariablesAssignment.Name = "btnCreatePositionVariablesAssignment";
        btnCreatePositionVariablesAssignment.Size = new Size(126, 23);
        btnCreatePositionVariablesAssignment.TabIndex = 0;
        btnCreatePositionVariablesAssignment.Text = "Create assignment";
        btnCreatePositionVariablesAssignment.UseVisualStyleBackColor = true;
        btnCreatePositionVariablesAssignment.Click += btnCreatePositionVariablesAssignment_Click;
        // 
        // groupBox6
        // 
        groupBox6.Controls.Add(btnReadPositionRegisterAssignment);
        groupBox6.Controls.Add(btnCreatePositionRegisterAssignment);
        groupBox6.Location = new Point(176, 134);
        groupBox6.Name = "groupBox6";
        groupBox6.Size = new Size(141, 87);
        groupBox6.TabIndex = 7;
        groupBox6.TabStop = false;
        groupBox6.Text = "Position registers";
        // 
        // btnReadPositionRegisterAssignment
        // 
        btnReadPositionRegisterAssignment.Location = new Point(6, 58);
        btnReadPositionRegisterAssignment.Name = "btnReadPositionRegisterAssignment";
        btnReadPositionRegisterAssignment.Size = new Size(126, 23);
        btnReadPositionRegisterAssignment.TabIndex = 0;
        btnReadPositionRegisterAssignment.Text = "Read";
        btnReadPositionRegisterAssignment.UseVisualStyleBackColor = true;
        btnReadPositionRegisterAssignment.Click += btnReadPositionRegisterAssignment_Click;
        // 
        // btnCreatePositionRegisterAssignment
        // 
        btnCreatePositionRegisterAssignment.Location = new Point(6, 22);
        btnCreatePositionRegisterAssignment.Name = "btnCreatePositionRegisterAssignment";
        btnCreatePositionRegisterAssignment.Size = new Size(126, 23);
        btnCreatePositionRegisterAssignment.TabIndex = 0;
        btnCreatePositionRegisterAssignment.Text = "Create assignment";
        btnCreatePositionRegisterAssignment.UseVisualStyleBackColor = true;
        btnCreatePositionRegisterAssignment.Click += btnCreatePositionRegisterAssignment_Click;
        // 
        // groupBox8
        // 
        groupBox8.Controls.Add(gridIntegerVariablesAssignment);
        groupBox8.Controls.Add(btnReadIntegerVariablesAssignment);
        groupBox8.Controls.Add(btnCreateIntegerVariablesAssignment);
        groupBox8.Location = new Point(549, 24);
        groupBox8.Name = "groupBox8";
        groupBox8.Size = new Size(141, 197);
        groupBox8.TabIndex = 7;
        groupBox8.TabStop = false;
        groupBox8.Text = "Integer variables";
        // 
        // gridIntegerVariablesAssignment
        // 
        gridIntegerVariablesAssignment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridIntegerVariablesAssignment.ColumnHeadersVisible = false;
        gridIntegerVariablesAssignment.Columns.AddRange(new DataGridViewColumn[] { Column1 });
        gridIntegerVariablesAssignment.Location = new Point(6, 22);
        gridIntegerVariablesAssignment.Name = "gridIntegerVariablesAssignment";
        gridIntegerVariablesAssignment.RowHeadersVisible = false;
        gridIntegerVariablesAssignment.Size = new Size(126, 103);
        gridIntegerVariablesAssignment.TabIndex = 1;
        // 
        // Column1
        // 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Column1.HeaderText = "Column1";
        Column1.Name = "Column1";
        // 
        // btnReadIntegerVariablesAssignment
        // 
        btnReadIntegerVariablesAssignment.Location = new Point(6, 167);
        btnReadIntegerVariablesAssignment.Name = "btnReadIntegerVariablesAssignment";
        btnReadIntegerVariablesAssignment.Size = new Size(126, 23);
        btnReadIntegerVariablesAssignment.TabIndex = 0;
        btnReadIntegerVariablesAssignment.Text = "Read";
        btnReadIntegerVariablesAssignment.UseVisualStyleBackColor = true;
        btnReadIntegerVariablesAssignment.Click += btnReadIntegerVariablesAssignment_Click;
        // 
        // btnCreateIntegerVariablesAssignment
        // 
        btnCreateIntegerVariablesAssignment.Location = new Point(6, 131);
        btnCreateIntegerVariablesAssignment.Name = "btnCreateIntegerVariablesAssignment";
        btnCreateIntegerVariablesAssignment.Size = new Size(126, 23);
        btnCreateIntegerVariablesAssignment.TabIndex = 0;
        btnCreateIntegerVariablesAssignment.Text = "Create assignment";
        btnCreateIntegerVariablesAssignment.UseVisualStyleBackColor = true;
        btnCreateIntegerVariablesAssignment.Click += btnCreateIntegerVariablesAssignment_Click;
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(btnReadNumericRegisterAssignment);
        groupBox5.Controls.Add(btnCreateNumericRegisterAssignment);
        groupBox5.Location = new Point(29, 134);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new Size(141, 87);
        groupBox5.TabIndex = 7;
        groupBox5.TabStop = false;
        groupBox5.Text = "Numeric registers";
        // 
        // btnReadNumericRegisterAssignment
        // 
        btnReadNumericRegisterAssignment.Location = new Point(6, 58);
        btnReadNumericRegisterAssignment.Name = "btnReadNumericRegisterAssignment";
        btnReadNumericRegisterAssignment.Size = new Size(126, 23);
        btnReadNumericRegisterAssignment.TabIndex = 0;
        btnReadNumericRegisterAssignment.Text = "Read";
        btnReadNumericRegisterAssignment.UseVisualStyleBackColor = true;
        btnReadNumericRegisterAssignment.Click += btnReadNumericRegisterAssignment_Click;
        // 
        // btnCreateNumericRegisterAssignment
        // 
        btnCreateNumericRegisterAssignment.Location = new Point(6, 22);
        btnCreateNumericRegisterAssignment.Name = "btnCreateNumericRegisterAssignment";
        btnCreateNumericRegisterAssignment.Size = new Size(126, 23);
        btnCreateNumericRegisterAssignment.TabIndex = 0;
        btnCreateNumericRegisterAssignment.Text = "Create assignment";
        btnCreateNumericRegisterAssignment.UseVisualStyleBackColor = true;
        btnCreateNumericRegisterAssignment.Click += btnCreateNumericRegisterAssignment_Click;
        // 
        // lblBatchStats
        // 
        lblBatchStats.AutoSize = true;
        lblBatchStats.Location = new Point(306, 239);
        lblBatchStats.Name = "lblBatchStats";
        lblBatchStats.Size = new Size(41, 15);
        lblBatchStats.TabIndex = 6;
        lblBatchStats.Text = "Value :";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(29, 68);
        label13.Name = "label13";
        label13.Size = new Size(94, 15);
        label13.TabIndex = 6;
        label13.Text = "Registers count :";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(29, 14);
        label12.Name = "label12";
        label12.Size = new Size(112, 15);
        label12.TabIndex = 6;
        label12.Text = "Register start index :";
        // 
        // udBatchCount
        // 
        udBatchCount.Location = new Point(29, 86);
        udBatchCount.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
        udBatchCount.Name = "udBatchCount";
        udBatchCount.Size = new Size(435, 23);
        udBatchCount.TabIndex = 5;
        udBatchCount.Value = new decimal(new int[] { 80, 0, 0, 0 });
        // 
        // udBatchStart
        // 
        udBatchStart.Location = new Point(29, 32);
        udBatchStart.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
        udBatchStart.Name = "udBatchStart";
        udBatchStart.Size = new Size(435, 23);
        udBatchStart.TabIndex = 5;
        udBatchStart.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // gridBatchValue
        // 
        gridBatchValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridBatchValue.HelpVisible = false;
        gridBatchValue.Location = new Point(306, 257);
        gridBatchValue.Margin = new Padding(4, 3, 4, 3);
        gridBatchValue.Name = "gridBatchValue";
        gridBatchValue.PropertySort = PropertySort.NoSort;
        gridBatchValue.Size = new Size(470, 289);
        gridBatchValue.TabIndex = 4;
        gridBatchValue.ToolbarVisible = false;
        // 
        // tabAssignments
        // 
        tabAssignments.Controls.Add(lstAssignments);
        tabAssignments.Controls.Add(panel1);
        tabAssignments.Location = new Point(4, 24);
        tabAssignments.Margin = new Padding(4, 3, 4, 3);
        tabAssignments.Name = "tabAssignments";
        tabAssignments.Size = new Size(1175, 549);
        tabAssignments.TabIndex = 2;
        tabAssignments.Text = "Assignements";
        tabAssignments.UseVisualStyleBackColor = true;
        // 
        // lstAssignments
        // 
        lstAssignments.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
        lstAssignments.Dock = DockStyle.Fill;
        lstAssignments.Location = new Point(0, 42);
        lstAssignments.Margin = new Padding(4, 3, 4, 3);
        lstAssignments.Name = "lstAssignments";
        lstAssignments.Size = new Size(1175, 507);
        lstAssignments.TabIndex = 0;
        lstAssignments.UseCompatibleStateImageBehavior = false;
        lstAssignments.View = View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "Name";
        columnHeader1.Width = 209;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Offset";
        columnHeader2.Width = 93;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnClearAlarms);
        panel1.Controls.Add(btnClearAssignments);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Margin = new Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(1175, 42);
        panel1.TabIndex = 1;
        // 
        // btnClearAlarms
        // 
        btnClearAlarms.Location = new Point(218, 8);
        btnClearAlarms.Name = "btnClearAlarms";
        btnClearAlarms.Size = new Size(154, 27);
        btnClearAlarms.TabIndex = 1;
        btnClearAlarms.Text = "Clear alarms";
        btnClearAlarms.UseVisualStyleBackColor = true;
        btnClearAlarms.Click += btnClearAlarms_Click;
        // 
        // btnClearAssignments
        // 
        btnClearAssignments.Location = new Point(4, 8);
        btnClearAssignments.Margin = new Padding(4, 3, 4, 3);
        btnClearAssignments.Name = "btnClearAssignments";
        btnClearAssignments.Size = new Size(156, 27);
        btnClearAssignments.TabIndex = 0;
        btnClearAssignments.Text = "Clear assignments";
        btnClearAssignments.UseVisualStyleBackColor = true;
        btnClearAssignments.Click += btnClearAssignments_Click;
        // 
        // SnpxControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tabControl1);
        Margin = new Padding(4, 3, 4, 3);
        Name = "SnpxControl";
        Size = new Size(1183, 577);
        tabControl1.ResumeLayout(false);
        tabVariablesRegisters.ResumeLayout(false);
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)udNumericValue).EndInit();
        ((System.ComponentModel.ISupportInitialize)udNumericRegister).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)udStringRegister).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)udFrame).EndInit();
        ((System.ComponentModel.ISupportInitialize)udPositionRegister).EndInit();
        tabSignals.ResumeLayout(false);
        tabBatch.ResumeLayout(false);
        tabBatch.PerformLayout();
        groupBox11.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridFloatVariablesAssignment).EndInit();
        groupBox10.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridStringVariablesAssignment).EndInit();
        groupBox7.ResumeLayout(false);
        groupBox9.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridPositionVariablesAssignment).EndInit();
        groupBox6.ResumeLayout(false);
        groupBox8.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridIntegerVariablesAssignment).EndInit();
        groupBox5.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)udBatchCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)udBatchStart).EndInit();
        tabAssignments.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabVariablesRegisters;
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
    private SnpxSignalControl snpxSignalControlNumericIOs;
    private SnpxSignalControl snpxSignalControlDigitals;
    private Button btnPositionWorld;
    private Button btnPositionUserFrame;
    private NumericUpDown udFrame;
    private Label label10;
    private Button btnClearAlarms;
    private TextBox txtRealVariable;
    private Label label11;
    private Button btnWriteRealVariable;
    private Button btnReadRealVariable;
    private GroupBox groupBox4;
    private TextBox textBox1;
    private TabPage tabBatch;
    private Label label12;
    private NumericUpDown udBatchStart;
    private PropertyGrid gridBatchValue;
    private Button btnCreateNumericRegisterAssignment;
    private GroupBox groupBox5;
    private Button btnReadNumericRegisterAssignment;
    private Label label13;
    private NumericUpDown udBatchCount;
    private GroupBox groupBox7;
    private Button btnReadStringRegisterAssignment;
    private Button btnCreateStringRegisterAssignment;
    private GroupBox groupBox6;
    private Button btnReadPositionRegisterAssignment;
    private Button btnCreatePositionRegisterAssignment;
    private Label lblBatchStats;
    private GroupBox groupBox11;
    private Button btnReadFloatVariablesAssignment;
    private Button btnCreateFloatVariablesAssignment;
    private GroupBox groupBox10;
    private Button btnReadStringVariablesAssignment;
    private Button btnCreateStringVariablesAssignment;
    private GroupBox groupBox9;
    private Button btnReadPositionVariablesAssignment;
    private Button btnCreatePositionVariablesAssignment;
    private GroupBox groupBox8;
    private Button btnReadIntegerVariablesAssignment;
    private Button btnCreateIntegerVariablesAssignment;
    private DataGridView gridIntegerVariablesAssignment;
    private DataGridViewTextBoxColumn Column1;
    private DataGridView gridFloatVariablesAssignment;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridView gridStringVariablesAssignment;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridView gridPositionVariablesAssignment;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
}
