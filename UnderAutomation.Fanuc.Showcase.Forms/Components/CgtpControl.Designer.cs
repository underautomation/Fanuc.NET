
    partial class CgtpControl
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
        txtProgram = new TextBox();
        label2 = new Label();
        btnSelectProgramLine = new Button();
        udProgramLine = new NumericUpDown();
        label3 = new Label();
        btnStartProgram = new Button();
        TabIo = new TabControl();
        tabProgram = new TabPage();
        groupBox5 = new GroupBox();
        cbNewProgramType = new ComboBox();
        udNEwProgramGroup = new NumericUpDown();
        btnCreateProgram = new Button();
        txtNewProgramComment = new TextBox();
        label9 = new Label();
        label8 = new Label();
        txtNewProgramOwner = new TextBox();
        label7 = new Label();
        txtNewProgramName = new TextBox();
        label6 = new Label();
        label5 = new Label();
        groupBox4 = new GroupBox();
        btnDeleteProgram = new Button();
        groupBox3 = new GroupBox();
        btnRenameProgram = new Button();
        txtProgramNewName = new TextBox();
        label4 = new Label();
        groupBox2 = new GroupBox();
        BtnPause = new Button();
        btnAbort = new Button();
        btnSelectProgram = new Button();
        groupBox1 = new GroupBox();
        cbProgramType = new ComboBox();
        chkWriteProtect = new CheckBox();
        chkProgramIgnorePause = new CheckBox();
        udProgramStackSize = new NumericUpDown();
        txtProgramOwner = new TextBox();
        txtProgramComment = new TextBox();
        btnSetProgramType = new Button();
        btnSetProgramWriteProtect = new Button();
        btnSetProgramIgnorePause = new Button();
        btnSetProgramStackSize = new Button();
        btnSetProgramOwner = new Button();
        btnSetProgramComment = new Button();
        btnGetProgramType = new Button();
        btnGetProgramWriteProtect = new Button();
        btnGetProgramIgnorePause = new Button();
        btnGetProgramStackSize = new Button();
        btnGetProgramOwner = new Button();
        btnGetProgramComment = new Button();
        tabFiles = new TabPage();
        label11 = new Label();
        label10 = new Label();
        txtContent = new RichTextBox();
        treeFiles = new TreeView();
        btnReadContent = new Button();
        btnListFiles = new Button();
        txtFile = new TextBox();
        txtPath = new TextBox();
        tabPageIo = new TabPage();
        txtSimulationStatus = new TextBox();
        udIoValue = new NumericUpDown();
        udIoIndex = new NumericUpDown();
        cbIoTypes = new ComboBox();
        label13 = new Label();
        label26 = new Label();
        label27 = new Label();
        btnWriteIo = new Button();
        btnUnsimulate = new Button();
        btnReadIo = new Button();
        btnSimulate = new Button();
        btnReadSimulation = new Button();
        tabKinematics = new TabPage();
        btnInverseKinematics = new Button();
        btnForwardKinematics = new Button();
        gridJointPosition = new PropertyGrid();
        gridCartesianPosition = new PropertyGrid();
        label14 = new Label();
        btnReadJointsPosition = new Button();
        udGroup = new NumericUpDown();
        btnReadCartesian = new Button();
        tabVariables = new TabPage();
        txtVariableProgram = new CueTextBox();
        label17 = new Label();
        gridVariableCartesianValue = new PropertyGrid();
        label16 = new Label();
        gridVariableJointValue = new PropertyGrid();
        label15 = new Label();
        label12 = new Label();
        label1 = new Label();
        txtVariableValue = new TextBox();
        btnWriteCartesianVariableValue = new Button();
        txtVariableName = new TextBox();
        btnWriteJointPositionVariable = new Button();
        btnWriteVariable = new Button();
        btnReadVariableAsPosition = new Button();
        btnReadVariableAsString = new Button();
        tabBatchVariables = new TabPage();
        txtBatchVariableProgram = new CueTextBox();
        label28 = new Label();
        label25 = new Label();
        txtBatchVariableName = new TextBox();
        gridSelectedBatchVariable = new PropertyGrid();
        btnWriteBatchVariable = new Button();
        btnReadBatchVariable = new Button();
        btnBatchPositionCartesian = new Button();
        btnBatchPositionJoint = new Button();
        btnAddBatchVariable = new Button();
        btnBatchAddStringRegister = new Button();
        btnBatchAddNumericRegister = new Button();
        btnBatchDelete = new Button();
        lstBatchVariables = new ListView();
        columnHeader6 = new ColumnHeader();
        columnHeader7 = new ColumnHeader();
        tabRegisters = new TabPage();
        panel4 = new Panel();
        label18 = new Label();
        udRegisterIndex = new NumericUpDown();
        panel3 = new Panel();
        label35 = new Label();
        txtStringRegisterValue = new TextBox();
        label32 = new Label();
        btnWriteStringRegister = new Button();
        panel2 = new Panel();
        label34 = new Label();
        rdNumericRegisterReal = new RadioButton();
        rdNumericRegisterInteger = new RadioButton();
        txtNumericRegisterComment = new TextBox();
        btnWriteNumericRegister = new Button();
        btnReadNumericRegister = new Button();
        label31 = new Label();
        label30 = new Label();
        udNumericRegisterValue = new NumericUpDown();
        panel1 = new Panel();
        gridRegisterValue = new PropertyGrid();
        btnReadPositionRegister = new Button();
        udPositionRegisterGroup = new NumericUpDown();
        label29 = new Label();
        label33 = new Label();
        gridRegisterValues = new PropertyGrid();
        btnReadNumericRegisters = new Button();
        btnReadStringRegisters = new Button();
        tabKcl = new TabPage();
        KclControl = new KclControl();
        tabUserAlarms = new TabPage();
        btnUserAlarmSetComment = new Button();
        btnUserAlarmSetSeverity = new Button();
        txtUserAlarmComment = new TextBox();
        label21 = new Label();
        label20 = new Label();
        label19 = new Label();
        udUserAlarmSeverity = new NumericUpDown();
        udUserAlarmIndex = new NumericUpDown();
        btnReadUserAlarms = new Button();
        lstUserAlarms = new ListView();
        columnUserAlarmId = new ColumnHeader();
        columnUserAlarmComment = new ColumnHeader();
        columnUsertAlarmSeverity = new ColumnHeader();
        tabComments = new TabPage();
        btnSetComment = new Button();
        txtComment = new TextBox();
        label23 = new Label();
        label24 = new Label();
        udCommentIndex = new NumericUpDown();
        label22 = new Label();
        cbCommentType = new ComboBox();
        btnReadComments = new Button();
        lstComments = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        tabHttp = new TabPage();
        btnHttpDownloadAscii = new Button();
        btnHttpDownloadFile = new Button();
        lstHttpItems = new ListView();
        columnHeader3 = new ColumnHeader();
        columnHeader4 = new ColumnHeader();
        columnHeader5 = new ColumnHeader();
        btnHttpListOther = new Button();
        btnHttpListDiagnosticFiles = new Button();
        btnHttpListPrograms = new Button();
        btnHttpListVariables = new Button();
        dlgSaveFile = new SaveFileDialog();
        ((System.ComponentModel.ISupportInitialize)udProgramLine).BeginInit();
        TabIo.SuspendLayout();
        tabProgram.SuspendLayout();
        groupBox5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udNEwProgramGroup).BeginInit();
        groupBox4.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udProgramStackSize).BeginInit();
        tabFiles.SuspendLayout();
        tabPageIo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udIoValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize)udIoIndex).BeginInit();
        tabKinematics.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udGroup).BeginInit();
        tabVariables.SuspendLayout();
        tabBatchVariables.SuspendLayout();
        tabRegisters.SuspendLayout();
        panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udRegisterIndex).BeginInit();
        panel3.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udNumericRegisterValue).BeginInit();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udPositionRegisterGroup).BeginInit();
        tabKcl.SuspendLayout();
        tabUserAlarms.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udUserAlarmSeverity).BeginInit();
        ((System.ComponentModel.ISupportInitialize)udUserAlarmIndex).BeginInit();
        tabComments.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udCommentIndex).BeginInit();
        tabHttp.SuspendLayout();
        SuspendLayout();
        // 
        // txtProgram
        // 
        txtProgram.Location = new Point(358, 22);
        txtProgram.Name = "txtProgram";
        txtProgram.Size = new Size(199, 23);
        txtProgram.TabIndex = 0;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(263, 25);
        label2.Name = "label2";
        label2.Size = new Size(89, 15);
        label2.TabIndex = 1;
        label2.Text = "Program name:";
        // 
        // btnSelectProgramLine
        // 
        btnSelectProgramLine.Location = new Point(7, 57);
        btnSelectProgramLine.Name = "btnSelectProgramLine";
        btnSelectProgramLine.Size = new Size(161, 23);
        btnSelectProgramLine.TabIndex = 2;
        btnSelectProgramLine.Text = "Select program line";
        btnSelectProgramLine.UseVisualStyleBackColor = true;
        btnSelectProgramLine.Click += btnSelectProgramLine_Click;
        // 
        // udProgramLine
        // 
        udProgramLine.Location = new Point(45, 28);
        udProgramLine.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
        udProgramLine.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        udProgramLine.Name = "udProgramLine";
        udProgramLine.Size = new Size(123, 23);
        udProgramLine.TabIndex = 3;
        udProgramLine.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(7, 30);
        label3.Name = "label3";
        label3.Size = new Size(32, 15);
        label3.TabIndex = 1;
        label3.Text = "Line:";
        // 
        // btnStartProgram
        // 
        btnStartProgram.Location = new Point(7, 86);
        btnStartProgram.Name = "btnStartProgram";
        btnStartProgram.Size = new Size(161, 23);
        btnStartProgram.TabIndex = 2;
        btnStartProgram.Text = "Start program from line";
        btnStartProgram.UseVisualStyleBackColor = true;
        btnStartProgram.Click += btnStartProgram_Click;
        // 
        // TabIo
        // 
        TabIo.Controls.Add(tabProgram);
        TabIo.Controls.Add(tabFiles);
        TabIo.Controls.Add(tabPageIo);
        TabIo.Controls.Add(tabKinematics);
        TabIo.Controls.Add(tabVariables);
        TabIo.Controls.Add(tabBatchVariables);
        TabIo.Controls.Add(tabRegisters);
        TabIo.Controls.Add(tabKcl);
        TabIo.Controls.Add(tabUserAlarms);
        TabIo.Controls.Add(tabComments);
        TabIo.Controls.Add(tabHttp);
        TabIo.Dock = DockStyle.Fill;
        TabIo.Location = new Point(0, 0);
        TabIo.Name = "TabIo";
        TabIo.SelectedIndex = 0;
        TabIo.Size = new Size(1144, 817);
        TabIo.TabIndex = 4;
        // 
        // tabProgram
        // 
        tabProgram.Controls.Add(groupBox5);
        tabProgram.Controls.Add(groupBox4);
        tabProgram.Controls.Add(groupBox3);
        tabProgram.Controls.Add(groupBox2);
        tabProgram.Controls.Add(groupBox1);
        tabProgram.Controls.Add(txtProgram);
        tabProgram.Controls.Add(label2);
        tabProgram.Location = new Point(4, 24);
        tabProgram.Name = "tabProgram";
        tabProgram.Padding = new Padding(3);
        tabProgram.Size = new Size(1136, 789);
        tabProgram.TabIndex = 1;
        tabProgram.Text = "Programs";
        tabProgram.UseVisualStyleBackColor = true;
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(cbNewProgramType);
        groupBox5.Controls.Add(udNEwProgramGroup);
        groupBox5.Controls.Add(btnCreateProgram);
        groupBox5.Controls.Add(txtNewProgramComment);
        groupBox5.Controls.Add(label9);
        groupBox5.Controls.Add(label8);
        groupBox5.Controls.Add(txtNewProgramOwner);
        groupBox5.Controls.Add(label7);
        groupBox5.Controls.Add(txtNewProgramName);
        groupBox5.Controls.Add(label6);
        groupBox5.Controls.Add(label5);
        groupBox5.Location = new Point(536, 236);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new Size(280, 221);
        groupBox5.TabIndex = 12;
        groupBox5.TabStop = false;
        groupBox5.Text = "New";
        // 
        // cbNewProgramType
        // 
        cbNewProgramType.DropDownStyle = ComboBoxStyle.DropDownList;
        cbNewProgramType.FormattingEnabled = true;
        cbNewProgramType.Location = new Point(152, 113);
        cbNewProgramType.Name = "cbNewProgramType";
        cbNewProgramType.Size = new Size(111, 23);
        cbNewProgramType.TabIndex = 7;
        // 
        // udNEwProgramGroup
        // 
        udNEwProgramGroup.Location = new Point(152, 142);
        udNEwProgramGroup.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        udNEwProgramGroup.Name = "udNEwProgramGroup";
        udNEwProgramGroup.Size = new Size(111, 23);
        udNEwProgramGroup.TabIndex = 5;
        // 
        // btnCreateProgram
        // 
        btnCreateProgram.Location = new Point(26, 171);
        btnCreateProgram.Name = "btnCreateProgram";
        btnCreateProgram.Size = new Size(237, 23);
        btnCreateProgram.TabIndex = 2;
        btnCreateProgram.Text = "Create Program";
        btnCreateProgram.UseVisualStyleBackColor = true;
        btnCreateProgram.Click += btnCreateProgram_Click;
        // 
        // txtNewProgramComment
        // 
        txtNewProgramComment.Location = new Point(152, 83);
        txtNewProgramComment.Name = "txtNewProgramComment";
        txtNewProgramComment.Size = new Size(111, 23);
        txtNewProgramComment.TabIndex = 0;
        // 
        // label9
        // 
        label9.Location = new Point(26, 140);
        label9.Name = "label9";
        label9.Size = new Size(120, 23);
        label9.TabIndex = 1;
        label9.Text = "Group (0=omit):";
        label9.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label8
        // 
        label8.Location = new Point(26, 112);
        label8.Name = "label8";
        label8.Size = new Size(120, 23);
        label8.TabIndex = 1;
        label8.Text = "Type:";
        label8.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtNewProgramOwner
        // 
        txtNewProgramOwner.Location = new Point(152, 57);
        txtNewProgramOwner.Name = "txtNewProgramOwner";
        txtNewProgramOwner.Size = new Size(111, 23);
        txtNewProgramOwner.TabIndex = 0;
        // 
        // label7
        // 
        label7.Location = new Point(26, 83);
        label7.Name = "label7";
        label7.Size = new Size(120, 23);
        label7.TabIndex = 1;
        label7.Text = "Comment (optional):";
        label7.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtNewProgramName
        // 
        txtNewProgramName.Location = new Point(152, 32);
        txtNewProgramName.Name = "txtNewProgramName";
        txtNewProgramName.Size = new Size(111, 23);
        txtNewProgramName.TabIndex = 0;
        txtNewProgramName.Text = "NEW_JOB";
        // 
        // label6
        // 
        label6.Location = new Point(26, 57);
        label6.Name = "label6";
        label6.Size = new Size(120, 23);
        label6.TabIndex = 1;
        label6.Text = "Owner (optional):";
        label6.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label5
        // 
        label5.Location = new Point(26, 32);
        label5.Name = "label5";
        label5.Size = new Size(120, 23);
        label5.TabIndex = 1;
        label5.Text = "New program name:";
        label5.TextAlign = ContentAlignment.MiddleRight;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(btnDeleteProgram);
        groupBox4.Location = new Point(688, 100);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(128, 122);
        groupBox4.TabIndex = 11;
        groupBox4.TabStop = false;
        groupBox4.Text = "Delete";
        // 
        // btnDeleteProgram
        // 
        btnDeleteProgram.Location = new Point(8, 48);
        btnDeleteProgram.Name = "btnDeleteProgram";
        btnDeleteProgram.Size = new Size(111, 23);
        btnDeleteProgram.TabIndex = 2;
        btnDeleteProgram.Text = "Delete Program";
        btnDeleteProgram.UseVisualStyleBackColor = true;
        btnDeleteProgram.Click += btnDeleteProgram_Click;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(btnRenameProgram);
        groupBox3.Controls.Add(txtProgramNewName);
        groupBox3.Controls.Add(label4);
        groupBox3.Location = new Point(536, 100);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(146, 122);
        groupBox3.TabIndex = 10;
        groupBox3.TabStop = false;
        groupBox3.Text = "Rename";
        // 
        // btnRenameProgram
        // 
        btnRenameProgram.Location = new Point(16, 77);
        btnRenameProgram.Name = "btnRenameProgram";
        btnRenameProgram.Size = new Size(115, 23);
        btnRenameProgram.TabIndex = 2;
        btnRenameProgram.Text = "Rename Program";
        btnRenameProgram.UseVisualStyleBackColor = true;
        btnRenameProgram.Click += btnRenameProgram_Click;
        // 
        // txtProgramNewName
        // 
        txtProgramNewName.Location = new Point(16, 48);
        txtProgramNewName.Name = "txtProgramNewName";
        txtProgramNewName.Size = new Size(115, 23);
        txtProgramNewName.TabIndex = 0;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(16, 30);
        label4.Name = "label4";
        label4.Size = new Size(67, 15);
        label4.TabIndex = 1;
        label4.Text = "New name:";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(BtnPause);
        groupBox2.Controls.Add(btnStartProgram);
        groupBox2.Controls.Add(udProgramLine);
        groupBox2.Controls.Add(btnAbort);
        groupBox2.Controls.Add(btnSelectProgram);
        groupBox2.Controls.Add(btnSelectProgramLine);
        groupBox2.Controls.Add(label3);
        groupBox2.Location = new Point(28, 100);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(324, 122);
        groupBox2.TabIndex = 9;
        groupBox2.TabStop = false;
        groupBox2.Text = "Start";
        // 
        // BtnPause
        // 
        BtnPause.Location = new Point(174, 86);
        BtnPause.Name = "BtnPause";
        BtnPause.Size = new Size(126, 23);
        BtnPause.TabIndex = 2;
        BtnPause.Text = "Pause all tasks";
        BtnPause.UseVisualStyleBackColor = true;
        BtnPause.Click += BtnPause_Click;
        // 
        // btnAbort
        // 
        btnAbort.Location = new Point(174, 57);
        btnAbort.Name = "btnAbort";
        btnAbort.Size = new Size(126, 23);
        btnAbort.TabIndex = 2;
        btnAbort.Text = "Abort task";
        btnAbort.UseVisualStyleBackColor = true;
        btnAbort.Click += btnAbort_Click;
        // 
        // btnSelectProgram
        // 
        btnSelectProgram.Location = new Point(174, 28);
        btnSelectProgram.Name = "btnSelectProgram";
        btnSelectProgram.Size = new Size(126, 23);
        btnSelectProgram.TabIndex = 2;
        btnSelectProgram.Text = "Select program";
        btnSelectProgram.UseVisualStyleBackColor = true;
        btnSelectProgram.Click += btnSelectProgram_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(cbProgramType);
        groupBox1.Controls.Add(chkWriteProtect);
        groupBox1.Controls.Add(chkProgramIgnorePause);
        groupBox1.Controls.Add(udProgramStackSize);
        groupBox1.Controls.Add(txtProgramOwner);
        groupBox1.Controls.Add(txtProgramComment);
        groupBox1.Controls.Add(btnSetProgramType);
        groupBox1.Controls.Add(btnSetProgramWriteProtect);
        groupBox1.Controls.Add(btnSetProgramIgnorePause);
        groupBox1.Controls.Add(btnSetProgramStackSize);
        groupBox1.Controls.Add(btnSetProgramOwner);
        groupBox1.Controls.Add(btnSetProgramComment);
        groupBox1.Controls.Add(btnGetProgramType);
        groupBox1.Controls.Add(btnGetProgramWriteProtect);
        groupBox1.Controls.Add(btnGetProgramIgnorePause);
        groupBox1.Controls.Add(btnGetProgramStackSize);
        groupBox1.Controls.Add(btnGetProgramOwner);
        groupBox1.Controls.Add(btnGetProgramComment);
        groupBox1.Location = new Point(29, 236);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(478, 221);
        groupBox1.TabIndex = 8;
        groupBox1.TabStop = false;
        groupBox1.Text = "Attributes";
        // 
        // cbProgramType
        // 
        cbProgramType.DropDownStyle = ComboBoxStyle.DropDownList;
        cbProgramType.FormattingEnabled = true;
        cbProgramType.Location = new Point(173, 155);
        cbProgramType.Name = "cbProgramType";
        cbProgramType.Size = new Size(126, 23);
        cbProgramType.TabIndex = 7;
        // 
        // chkWriteProtect
        // 
        chkWriteProtect.AutoSize = true;
        chkWriteProtect.Location = new Point(317, 54);
        chkWriteProtect.Name = "chkWriteProtect";
        chkWriteProtect.Size = new Size(95, 19);
        chkWriteProtect.TabIndex = 6;
        chkWriteProtect.Text = "Write protect";
        chkWriteProtect.UseVisualStyleBackColor = true;
        // 
        // chkProgramIgnorePause
        // 
        chkProgramIgnorePause.AutoSize = true;
        chkProgramIgnorePause.Location = new Point(6, 157);
        chkProgramIgnorePause.Name = "chkProgramIgnorePause";
        chkProgramIgnorePause.Size = new Size(94, 19);
        chkProgramIgnorePause.TabIndex = 6;
        chkProgramIgnorePause.Text = "Ignore pause";
        chkProgramIgnorePause.UseVisualStyleBackColor = true;
        // 
        // udProgramStackSize
        // 
        udProgramStackSize.Location = new Point(317, 155);
        udProgramStackSize.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        udProgramStackSize.Name = "udProgramStackSize";
        udProgramStackSize.Size = new Size(155, 23);
        udProgramStackSize.TabIndex = 5;
        // 
        // txtProgramOwner
        // 
        txtProgramOwner.Location = new Point(173, 52);
        txtProgramOwner.Name = "txtProgramOwner";
        txtProgramOwner.Size = new Size(126, 23);
        txtProgramOwner.TabIndex = 4;
        // 
        // txtProgramComment
        // 
        txtProgramComment.Location = new Point(6, 52);
        txtProgramComment.Name = "txtProgramComment";
        txtProgramComment.Size = new Size(144, 23);
        txtProgramComment.TabIndex = 4;
        // 
        // btnSetProgramType
        // 
        btnSetProgramType.Location = new Point(173, 183);
        btnSetProgramType.Name = "btnSetProgramType";
        btnSetProgramType.Size = new Size(126, 23);
        btnSetProgramType.TabIndex = 2;
        btnSetProgramType.Text = "Set program type";
        btnSetProgramType.UseVisualStyleBackColor = true;
        btnSetProgramType.Click += btnSetProgramType_Click;
        // 
        // btnSetProgramWriteProtect
        // 
        btnSetProgramWriteProtect.Location = new Point(317, 80);
        btnSetProgramWriteProtect.Name = "btnSetProgramWriteProtect";
        btnSetProgramWriteProtect.Size = new Size(155, 23);
        btnSetProgramWriteProtect.TabIndex = 2;
        btnSetProgramWriteProtect.Text = "Set program write protect";
        btnSetProgramWriteProtect.UseVisualStyleBackColor = true;
        btnSetProgramWriteProtect.Click += btnSetProgramWriteProtect_Click;
        // 
        // btnSetProgramIgnorePause
        // 
        btnSetProgramIgnorePause.Location = new Point(6, 183);
        btnSetProgramIgnorePause.Name = "btnSetProgramIgnorePause";
        btnSetProgramIgnorePause.Size = new Size(141, 23);
        btnSetProgramIgnorePause.TabIndex = 2;
        btnSetProgramIgnorePause.Text = "Set program ignore pause";
        btnSetProgramIgnorePause.UseVisualStyleBackColor = true;
        btnSetProgramIgnorePause.Click += btnSetProgramIgnorePause_Click;
        // 
        // btnSetProgramStackSize
        // 
        btnSetProgramStackSize.Location = new Point(317, 183);
        btnSetProgramStackSize.Name = "btnSetProgramStackSize";
        btnSetProgramStackSize.Size = new Size(155, 23);
        btnSetProgramStackSize.TabIndex = 2;
        btnSetProgramStackSize.Text = "Set program stack size";
        btnSetProgramStackSize.UseVisualStyleBackColor = true;
        btnSetProgramStackSize.Click += btnSetProgramStackSize_Click;
        // 
        // btnSetProgramOwner
        // 
        btnSetProgramOwner.Location = new Point(173, 80);
        btnSetProgramOwner.Name = "btnSetProgramOwner";
        btnSetProgramOwner.Size = new Size(126, 23);
        btnSetProgramOwner.TabIndex = 2;
        btnSetProgramOwner.Text = "Set program owner";
        btnSetProgramOwner.UseVisualStyleBackColor = true;
        btnSetProgramOwner.Click += btnSetProgramOwner_Click;
        // 
        // btnSetProgramComment
        // 
        btnSetProgramComment.Location = new Point(6, 80);
        btnSetProgramComment.Name = "btnSetProgramComment";
        btnSetProgramComment.Size = new Size(144, 23);
        btnSetProgramComment.TabIndex = 2;
        btnSetProgramComment.Text = "Set program comment";
        btnSetProgramComment.UseVisualStyleBackColor = true;
        btnSetProgramComment.Click += btnSetProgramComment_Click;
        // 
        // btnGetProgramType
        // 
        btnGetProgramType.Location = new Point(173, 125);
        btnGetProgramType.Name = "btnGetProgramType";
        btnGetProgramType.Size = new Size(126, 23);
        btnGetProgramType.TabIndex = 2;
        btnGetProgramType.Text = "Get program type";
        btnGetProgramType.UseVisualStyleBackColor = true;
        btnGetProgramType.Click += btnGetProgramType_Click;
        // 
        // btnGetProgramWriteProtect
        // 
        btnGetProgramWriteProtect.Location = new Point(317, 22);
        btnGetProgramWriteProtect.Name = "btnGetProgramWriteProtect";
        btnGetProgramWriteProtect.Size = new Size(155, 23);
        btnGetProgramWriteProtect.TabIndex = 2;
        btnGetProgramWriteProtect.Text = "Get program write protect";
        btnGetProgramWriteProtect.UseVisualStyleBackColor = true;
        btnGetProgramWriteProtect.Click += btnGetProgramWriteProtect_Click;
        // 
        // btnGetProgramIgnorePause
        // 
        btnGetProgramIgnorePause.Location = new Point(6, 125);
        btnGetProgramIgnorePause.Name = "btnGetProgramIgnorePause";
        btnGetProgramIgnorePause.Size = new Size(141, 23);
        btnGetProgramIgnorePause.TabIndex = 2;
        btnGetProgramIgnorePause.Text = "Get program ignore pause";
        btnGetProgramIgnorePause.UseVisualStyleBackColor = true;
        btnGetProgramIgnorePause.Click += btnGetProgramIgnorePause_Click;
        // 
        // btnGetProgramStackSize
        // 
        btnGetProgramStackSize.Location = new Point(317, 125);
        btnGetProgramStackSize.Name = "btnGetProgramStackSize";
        btnGetProgramStackSize.Size = new Size(155, 23);
        btnGetProgramStackSize.TabIndex = 2;
        btnGetProgramStackSize.Text = "Get program stack size";
        btnGetProgramStackSize.UseVisualStyleBackColor = true;
        btnGetProgramStackSize.Click += btnGetProgramStackSize_Click;
        // 
        // btnGetProgramOwner
        // 
        btnGetProgramOwner.Location = new Point(173, 22);
        btnGetProgramOwner.Name = "btnGetProgramOwner";
        btnGetProgramOwner.Size = new Size(126, 23);
        btnGetProgramOwner.TabIndex = 2;
        btnGetProgramOwner.Text = "Get program owner";
        btnGetProgramOwner.UseVisualStyleBackColor = true;
        btnGetProgramOwner.Click += btnGetProgramOwner_Click;
        // 
        // btnGetProgramComment
        // 
        btnGetProgramComment.Location = new Point(6, 22);
        btnGetProgramComment.Name = "btnGetProgramComment";
        btnGetProgramComment.Size = new Size(144, 23);
        btnGetProgramComment.TabIndex = 2;
        btnGetProgramComment.Text = "Get program comment";
        btnGetProgramComment.UseVisualStyleBackColor = true;
        btnGetProgramComment.Click += btnGetProgramComment_Click;
        // 
        // tabFiles
        // 
        tabFiles.Controls.Add(label11);
        tabFiles.Controls.Add(label10);
        tabFiles.Controls.Add(txtContent);
        tabFiles.Controls.Add(treeFiles);
        tabFiles.Controls.Add(btnReadContent);
        tabFiles.Controls.Add(btnListFiles);
        tabFiles.Controls.Add(txtFile);
        tabFiles.Controls.Add(txtPath);
        tabFiles.Location = new Point(4, 24);
        tabFiles.Name = "tabFiles";
        tabFiles.Padding = new Padding(3);
        tabFiles.Size = new Size(1136, 789);
        tabFiles.TabIndex = 0;
        tabFiles.Text = "Files";
        tabFiles.UseVisualStyleBackColor = true;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(290, 119);
        label11.Name = "label11";
        label11.Size = new Size(28, 15);
        label11.TabIndex = 4;
        label11.Text = "File:";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(48, 32);
        label10.Name = "label10";
        label10.Size = new Size(34, 15);
        label10.TabIndex = 4;
        label10.Text = "Path:";
        // 
        // txtContent
        // 
        txtContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtContent.Location = new Point(290, 166);
        txtContent.Name = "txtContent";
        txtContent.ReadOnly = true;
        txtContent.Size = new Size(543, 403);
        txtContent.TabIndex = 3;
        txtContent.Text = "";
        // 
        // treeFiles
        // 
        treeFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        treeFiles.Location = new Point(48, 137);
        treeFiles.Name = "treeFiles";
        treeFiles.Size = new Size(178, 432);
        treeFiles.TabIndex = 2;
        treeFiles.AfterSelect += treeFiles_AfterSelect;
        // 
        // btnReadContent
        // 
        btnReadContent.Location = new Point(474, 137);
        btnReadContent.Name = "btnReadContent";
        btnReadContent.Size = new Size(178, 23);
        btnReadContent.TabIndex = 1;
        btnReadContent.Text = "Read Content";
        btnReadContent.UseVisualStyleBackColor = true;
        btnReadContent.Click += btnReadContent_Click;
        // 
        // btnListFiles
        // 
        btnListFiles.Location = new Point(48, 95);
        btnListFiles.Name = "btnListFiles";
        btnListFiles.Size = new Size(178, 23);
        btnListFiles.TabIndex = 1;
        btnListFiles.Text = "List files";
        btnListFiles.UseVisualStyleBackColor = true;
        btnListFiles.Click += btnListFiles_Click;
        // 
        // txtFile
        // 
        txtFile.Location = new Point(290, 137);
        txtFile.Name = "txtFile";
        txtFile.Size = new Size(178, 23);
        txtFile.TabIndex = 0;
        // 
        // txtPath
        // 
        txtPath.Location = new Point(48, 50);
        txtPath.Name = "txtPath";
        txtPath.Size = new Size(178, 23);
        txtPath.TabIndex = 0;
        txtPath.Text = "MD:";
        // 
        // tabPageIo
        // 
        tabPageIo.Controls.Add(txtSimulationStatus);
        tabPageIo.Controls.Add(udIoValue);
        tabPageIo.Controls.Add(udIoIndex);
        tabPageIo.Controls.Add(cbIoTypes);
        tabPageIo.Controls.Add(label13);
        tabPageIo.Controls.Add(label26);
        tabPageIo.Controls.Add(label27);
        tabPageIo.Controls.Add(btnWriteIo);
        tabPageIo.Controls.Add(btnUnsimulate);
        tabPageIo.Controls.Add(btnReadIo);
        tabPageIo.Controls.Add(btnSimulate);
        tabPageIo.Controls.Add(btnReadSimulation);
        tabPageIo.Location = new Point(4, 24);
        tabPageIo.Name = "tabPageIo";
        tabPageIo.Padding = new Padding(3);
        tabPageIo.Size = new Size(1136, 789);
        tabPageIo.TabIndex = 3;
        tabPageIo.Text = "I/O";
        tabPageIo.UseVisualStyleBackColor = true;
        // 
        // txtSimulationStatus
        // 
        txtSimulationStatus.BackColor = SystemColors.Control;
        txtSimulationStatus.Location = new Point(28, 287);
        txtSimulationStatus.Name = "txtSimulationStatus";
        txtSimulationStatus.ReadOnly = true;
        txtSimulationStatus.Size = new Size(167, 23);
        txtSimulationStatus.TabIndex = 25;
        // 
        // udIoValue
        // 
        udIoValue.Location = new Point(292, 213);
        udIoValue.Margin = new Padding(4, 3, 4, 3);
        udIoValue.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
        udIoValue.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
        udIoValue.Name = "udIoValue";
        udIoValue.Size = new Size(121, 23);
        udIoValue.TabIndex = 24;
        // 
        // udIoIndex
        // 
        udIoIndex.Location = new Point(174, 131);
        udIoIndex.Margin = new Padding(4, 3, 4, 3);
        udIoIndex.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
        udIoIndex.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        udIoIndex.Name = "udIoIndex";
        udIoIndex.Size = new Size(167, 23);
        udIoIndex.TabIndex = 24;
        udIoIndex.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // cbIoTypes
        // 
        cbIoTypes.DropDownStyle = ComboBoxStyle.DropDownList;
        cbIoTypes.FormattingEnabled = true;
        cbIoTypes.Location = new Point(174, 70);
        cbIoTypes.Name = "cbIoTypes";
        cbIoTypes.Size = new Size(167, 23);
        cbIoTypes.TabIndex = 23;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(246, 215);
        label13.Margin = new Padding(4, 0, 4, 0);
        label13.Name = "label13";
        label13.Size = new Size(38, 15);
        label13.TabIndex = 19;
        label13.Text = "Value:";
        // 
        // label26
        // 
        label26.AutoSize = true;
        label26.Location = new Point(160, 113);
        label26.Margin = new Padding(4, 0, 4, 0);
        label26.Name = "label26";
        label26.Size = new Size(38, 15);
        label26.TabIndex = 18;
        label26.Text = "Index:";
        // 
        // label27
        // 
        label27.AutoSize = true;
        label27.Location = new Point(160, 52);
        label27.Margin = new Padding(4, 0, 4, 0);
        label27.Name = "label27";
        label27.Size = new Size(35, 15);
        label27.TabIndex = 19;
        label27.Text = "Type:";
        // 
        // btnWriteIo
        // 
        btnWriteIo.Location = new Point(246, 254);
        btnWriteIo.Margin = new Padding(4, 3, 4, 3);
        btnWriteIo.Name = "btnWriteIo";
        btnWriteIo.Size = new Size(167, 27);
        btnWriteIo.TabIndex = 20;
        btnWriteIo.Text = "Write";
        btnWriteIo.UseVisualStyleBackColor = true;
        btnWriteIo.Click += btnWriteIo_Click;
        // 
        // btnUnsimulate
        // 
        btnUnsimulate.Location = new Point(28, 206);
        btnUnsimulate.Margin = new Padding(4, 3, 4, 3);
        btnUnsimulate.Name = "btnUnsimulate";
        btnUnsimulate.Size = new Size(167, 27);
        btnUnsimulate.TabIndex = 20;
        btnUnsimulate.Text = "Unsimulate";
        btnUnsimulate.UseVisualStyleBackColor = true;
        btnUnsimulate.Click += btnUnsimulate_Click;
        // 
        // btnReadIo
        // 
        btnReadIo.Location = new Point(246, 173);
        btnReadIo.Margin = new Padding(4, 3, 4, 3);
        btnReadIo.Name = "btnReadIo";
        btnReadIo.Size = new Size(167, 27);
        btnReadIo.TabIndex = 21;
        btnReadIo.Text = "Read";
        btnReadIo.UseVisualStyleBackColor = true;
        btnReadIo.Click += btnReadIo_Click;
        // 
        // btnSimulate
        // 
        btnSimulate.Location = new Point(28, 173);
        btnSimulate.Margin = new Padding(4, 3, 4, 3);
        btnSimulate.Name = "btnSimulate";
        btnSimulate.Size = new Size(167, 27);
        btnSimulate.TabIndex = 21;
        btnSimulate.Text = "Simulate";
        btnSimulate.UseVisualStyleBackColor = true;
        btnSimulate.Click += btnSimulate_Click;
        // 
        // btnReadSimulation
        // 
        btnReadSimulation.Location = new Point(28, 254);
        btnReadSimulation.Margin = new Padding(4, 3, 4, 3);
        btnReadSimulation.Name = "btnReadSimulation";
        btnReadSimulation.Size = new Size(167, 27);
        btnReadSimulation.TabIndex = 22;
        btnReadSimulation.Text = "Read simulation status";
        btnReadSimulation.UseVisualStyleBackColor = true;
        btnReadSimulation.Click += btnReadSimulation_Click;
        // 
        // tabKinematics
        // 
        tabKinematics.Controls.Add(btnInverseKinematics);
        tabKinematics.Controls.Add(btnForwardKinematics);
        tabKinematics.Controls.Add(gridJointPosition);
        tabKinematics.Controls.Add(gridCartesianPosition);
        tabKinematics.Controls.Add(label14);
        tabKinematics.Controls.Add(btnReadJointsPosition);
        tabKinematics.Controls.Add(udGroup);
        tabKinematics.Controls.Add(btnReadCartesian);
        tabKinematics.Location = new Point(4, 24);
        tabKinematics.Name = "tabKinematics";
        tabKinematics.Padding = new Padding(3);
        tabKinematics.Size = new Size(1136, 789);
        tabKinematics.TabIndex = 4;
        tabKinematics.Text = "Kinematics";
        tabKinematics.UseVisualStyleBackColor = true;
        // 
        // btnInverseKinematics
        // 
        btnInverseKinematics.Location = new Point(342, 359);
        btnInverseKinematics.Name = "btnInverseKinematics";
        btnInverseKinematics.Size = new Size(142, 50);
        btnInverseKinematics.TabIndex = 6;
        btnInverseKinematics.Text = "<< Invert Kinematics";
        btnInverseKinematics.UseVisualStyleBackColor = true;
        btnInverseKinematics.Click += btnInverseKinematics_Click;
        // 
        // btnForwardKinematics
        // 
        btnForwardKinematics.Location = new Point(342, 255);
        btnForwardKinematics.Name = "btnForwardKinematics";
        btnForwardKinematics.Size = new Size(142, 50);
        btnForwardKinematics.TabIndex = 7;
        btnForwardKinematics.Text = "Forward Kinematics >>";
        btnForwardKinematics.UseVisualStyleBackColor = true;
        btnForwardKinematics.Click += btnForwardKinematics_Click;
        // 
        // gridJointPosition
        // 
        gridJointPosition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridJointPosition.HelpVisible = false;
        gridJointPosition.Location = new Point(15, 191);
        gridJointPosition.Name = "gridJointPosition";
        gridJointPosition.PropertySort = PropertySort.NoSort;
        gridJointPosition.Size = new Size(307, 385);
        gridJointPosition.TabIndex = 3;
        gridJointPosition.ToolbarVisible = false;
        // 
        // gridCartesianPosition
        // 
        gridCartesianPosition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridCartesianPosition.HelpVisible = false;
        gridCartesianPosition.Location = new Point(507, 191);
        gridCartesianPosition.Name = "gridCartesianPosition";
        gridCartesianPosition.PropertySort = PropertySort.NoSort;
        gridCartesianPosition.Size = new Size(307, 385);
        gridCartesianPosition.TabIndex = 3;
        gridCartesianPosition.ToolbarVisible = false;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(303, 57);
        label14.Name = "label14";
        label14.Size = new Size(43, 15);
        label14.TabIndex = 2;
        label14.Text = "Group:";
        // 
        // btnReadJointsPosition
        // 
        btnReadJointsPosition.Location = new Point(15, 141);
        btnReadJointsPosition.Name = "btnReadJointsPosition";
        btnReadJointsPosition.Size = new Size(307, 23);
        btnReadJointsPosition.TabIndex = 0;
        btnReadJointsPosition.Text = "Read current joint position";
        btnReadJointsPosition.UseVisualStyleBackColor = true;
        btnReadJointsPosition.Click += btnReadJointsPosition_Click;
        // 
        // udGroup
        // 
        udGroup.Location = new Point(353, 55);
        udGroup.Name = "udGroup";
        udGroup.Size = new Size(120, 23);
        udGroup.TabIndex = 1;
        udGroup.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnReadCartesian
        // 
        btnReadCartesian.Location = new Point(507, 141);
        btnReadCartesian.Name = "btnReadCartesian";
        btnReadCartesian.Size = new Size(307, 23);
        btnReadCartesian.TabIndex = 0;
        btnReadCartesian.Text = "Read current cartesian position";
        btnReadCartesian.UseVisualStyleBackColor = true;
        btnReadCartesian.Click += btnReadCartesian_Click;
        // 
        // tabVariables
        // 
        tabVariables.Controls.Add(txtVariableProgram);
        tabVariables.Controls.Add(label17);
        tabVariables.Controls.Add(gridVariableCartesianValue);
        tabVariables.Controls.Add(label16);
        tabVariables.Controls.Add(gridVariableJointValue);
        tabVariables.Controls.Add(label15);
        tabVariables.Controls.Add(label12);
        tabVariables.Controls.Add(label1);
        tabVariables.Controls.Add(txtVariableValue);
        tabVariables.Controls.Add(btnWriteCartesianVariableValue);
        tabVariables.Controls.Add(txtVariableName);
        tabVariables.Controls.Add(btnWriteJointPositionVariable);
        tabVariables.Controls.Add(btnWriteVariable);
        tabVariables.Controls.Add(btnReadVariableAsPosition);
        tabVariables.Controls.Add(btnReadVariableAsString);
        tabVariables.Location = new Point(4, 24);
        tabVariables.Name = "tabVariables";
        tabVariables.Padding = new Padding(3);
        tabVariables.Size = new Size(1136, 789);
        tabVariables.TabIndex = 2;
        tabVariables.Text = "Variables";
        tabVariables.UseVisualStyleBackColor = true;
        // 
        // txtVariableProgram
        // 
        txtVariableProgram.Cue = "Optional - Leave empty for system variables";
        txtVariableProgram.Location = new Point(56, 83);
        txtVariableProgram.Margin = new Padding(4, 3, 4, 3);
        txtVariableProgram.Name = "txtVariableProgram";
        txtVariableProgram.Size = new Size(622, 23);
        txtVariableProgram.TabIndex = 5;
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(56, 65);
        label17.Margin = new Padding(4, 0, 4, 0);
        label17.Name = "label17";
        label17.Size = new Size(59, 15);
        label17.TabIndex = 6;
        label17.Text = "Program :";
        label17.TextAlign = ContentAlignment.MiddleRight;
        // 
        // gridVariableCartesianValue
        // 
        gridVariableCartesianValue.HelpVisible = false;
        gridVariableCartesianValue.Location = new Point(488, 189);
        gridVariableCartesianValue.Name = "gridVariableCartesianValue";
        gridVariableCartesianValue.PropertySort = PropertySort.NoSort;
        gridVariableCartesianValue.Size = new Size(190, 280);
        gridVariableCartesianValue.TabIndex = 4;
        gridVariableCartesianValue.ToolbarVisible = false;
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(479, 171);
        label16.Name = "label16";
        label16.Size = new Size(90, 15);
        label16.TabIndex = 2;
        label16.Text = "Cartesian value:";
        // 
        // gridVariableJointValue
        // 
        gridVariableJointValue.HelpVisible = false;
        gridVariableJointValue.Location = new Point(263, 189);
        gridVariableJointValue.Name = "gridVariableJointValue";
        gridVariableJointValue.PropertySort = PropertySort.NoSort;
        gridVariableJointValue.Size = new Size(190, 280);
        gridVariableJointValue.TabIndex = 4;
        gridVariableJointValue.ToolbarVisible = false;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(254, 171);
        label15.Name = "label15";
        label15.Size = new Size(66, 15);
        label15.TabIndex = 2;
        label15.Text = "Joint value:";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(56, 171);
        label12.Name = "label12";
        label12.Size = new Size(72, 15);
        label12.TabIndex = 2;
        label12.Text = "String value:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(56, 13);
        label1.Name = "label1";
        label1.Size = new Size(51, 15);
        label1.TabIndex = 2;
        label1.Text = "Variable:";
        // 
        // txtVariableValue
        // 
        txtVariableValue.Location = new Point(56, 189);
        txtVariableValue.Multiline = true;
        txtVariableValue.Name = "txtVariableValue";
        txtVariableValue.Size = new Size(164, 124);
        txtVariableValue.TabIndex = 1;
        // 
        // btnWriteCartesianVariableValue
        // 
        btnWriteCartesianVariableValue.Location = new Point(488, 475);
        btnWriteCartesianVariableValue.Name = "btnWriteCartesianVariableValue";
        btnWriteCartesianVariableValue.Size = new Size(190, 23);
        btnWriteCartesianVariableValue.TabIndex = 0;
        btnWriteCartesianVariableValue.Text = "Write cartesian value";
        btnWriteCartesianVariableValue.UseVisualStyleBackColor = true;
        btnWriteCartesianVariableValue.Click += btnWriteCartesianVariableValue_Click;
        // 
        // txtVariableName
        // 
        txtVariableName.Location = new Point(56, 31);
        txtVariableName.Name = "txtVariableName";
        txtVariableName.Size = new Size(622, 23);
        txtVariableName.TabIndex = 1;
        txtVariableName.Text = "$RMT_MASTER";
        // 
        // btnWriteJointPositionVariable
        // 
        btnWriteJointPositionVariable.Location = new Point(263, 475);
        btnWriteJointPositionVariable.Name = "btnWriteJointPositionVariable";
        btnWriteJointPositionVariable.Size = new Size(190, 23);
        btnWriteJointPositionVariable.TabIndex = 0;
        btnWriteJointPositionVariable.Text = "Write joint value";
        btnWriteJointPositionVariable.UseVisualStyleBackColor = true;
        btnWriteJointPositionVariable.Click += btnWriteJointPositionVariable_Click;
        // 
        // btnWriteVariable
        // 
        btnWriteVariable.Location = new Point(56, 319);
        btnWriteVariable.Name = "btnWriteVariable";
        btnWriteVariable.Size = new Size(164, 23);
        btnWriteVariable.TabIndex = 0;
        btnWriteVariable.Text = "Write";
        btnWriteVariable.UseVisualStyleBackColor = true;
        btnWriteVariable.Click += btnWriteVariable_Click;
        // 
        // btnReadVariableAsPosition
        // 
        btnReadVariableAsPosition.Location = new Point(254, 136);
        btnReadVariableAsPosition.Name = "btnReadVariableAsPosition";
        btnReadVariableAsPosition.Size = new Size(424, 23);
        btnReadVariableAsPosition.TabIndex = 0;
        btnReadVariableAsPosition.Text = "Read as position";
        btnReadVariableAsPosition.UseVisualStyleBackColor = true;
        btnReadVariableAsPosition.Click += btnReadVariableAsPosition_Click;
        // 
        // btnReadVariableAsString
        // 
        btnReadVariableAsString.Location = new Point(56, 136);
        btnReadVariableAsString.Name = "btnReadVariableAsString";
        btnReadVariableAsString.Size = new Size(164, 23);
        btnReadVariableAsString.TabIndex = 0;
        btnReadVariableAsString.Text = "Read as string";
        btnReadVariableAsString.UseVisualStyleBackColor = true;
        btnReadVariableAsString.Click += btnReadVariable_Click;
        // 
        // tabBatchVariables
        // 
        tabBatchVariables.Controls.Add(txtBatchVariableProgram);
        tabBatchVariables.Controls.Add(label28);
        tabBatchVariables.Controls.Add(label25);
        tabBatchVariables.Controls.Add(txtBatchVariableName);
        tabBatchVariables.Controls.Add(gridSelectedBatchVariable);
        tabBatchVariables.Controls.Add(btnWriteBatchVariable);
        tabBatchVariables.Controls.Add(btnReadBatchVariable);
        tabBatchVariables.Controls.Add(btnBatchPositionCartesian);
        tabBatchVariables.Controls.Add(btnBatchPositionJoint);
        tabBatchVariables.Controls.Add(btnAddBatchVariable);
        tabBatchVariables.Controls.Add(btnBatchAddStringRegister);
        tabBatchVariables.Controls.Add(btnBatchAddNumericRegister);
        tabBatchVariables.Controls.Add(btnBatchDelete);
        tabBatchVariables.Controls.Add(lstBatchVariables);
        tabBatchVariables.Location = new Point(4, 24);
        tabBatchVariables.Name = "tabBatchVariables";
        tabBatchVariables.Padding = new Padding(3);
        tabBatchVariables.Size = new Size(1136, 789);
        tabBatchVariables.TabIndex = 7;
        tabBatchVariables.Text = "Batch variables & registers";
        tabBatchVariables.UseVisualStyleBackColor = true;
        // 
        // txtBatchVariableProgram
        // 
        txtBatchVariableProgram.Cue = "Optional";
        txtBatchVariableProgram.Location = new Point(26, 480);
        txtBatchVariableProgram.Margin = new Padding(4, 3, 4, 3);
        txtBatchVariableProgram.Name = "txtBatchVariableProgram";
        txtBatchVariableProgram.Size = new Size(143, 23);
        txtBatchVariableProgram.TabIndex = 8;
        // 
        // label28
        // 
        label28.AutoSize = true;
        label28.Location = new Point(26, 462);
        label28.Name = "label28";
        label28.Size = new Size(56, 15);
        label28.TabIndex = 7;
        label28.Text = "Program:";
        // 
        // label25
        // 
        label25.AutoSize = true;
        label25.Location = new Point(26, 418);
        label25.Name = "label25";
        label25.Size = new Size(81, 15);
        label25.TabIndex = 7;
        label25.Text = "New variable :";
        // 
        // txtBatchVariableName
        // 
        txtBatchVariableName.Location = new Point(26, 436);
        txtBatchVariableName.Name = "txtBatchVariableName";
        txtBatchVariableName.Size = new Size(143, 23);
        txtBatchVariableName.TabIndex = 6;
        txtBatchVariableName.Text = "$MCR.$GENOVERRIDE";
        txtBatchVariableName.TextChanged += txtBatchVariableName_TextChanged;
        // 
        // gridSelectedBatchVariable
        // 
        gridSelectedBatchVariable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridSelectedBatchVariable.HelpVisible = false;
        gridSelectedBatchVariable.Location = new Point(629, 108);
        gridSelectedBatchVariable.Name = "gridSelectedBatchVariable";
        gridSelectedBatchVariable.PropertySort = PropertySort.NoSort;
        gridSelectedBatchVariable.Size = new Size(329, 678);
        gridSelectedBatchVariable.TabIndex = 5;
        gridSelectedBatchVariable.ToolbarVisible = false;
        gridSelectedBatchVariable.PropertyValueChanged += gridSelectedBatchVariable_PropertyValueChanged;
        // 
        // btnWriteBatchVariable
        // 
        btnWriteBatchVariable.Location = new Point(395, 29);
        btnWriteBatchVariable.Name = "btnWriteBatchVariable";
        btnWriteBatchVariable.Size = new Size(143, 73);
        btnWriteBatchVariable.TabIndex = 3;
        btnWriteBatchVariable.Text = "Write";
        btnWriteBatchVariable.UseVisualStyleBackColor = true;
        btnWriteBatchVariable.Click += btnWriteBatchVariable_Click;
        // 
        // btnReadBatchVariable
        // 
        btnReadBatchVariable.Location = new Point(206, 29);
        btnReadBatchVariable.Name = "btnReadBatchVariable";
        btnReadBatchVariable.Size = new Size(150, 73);
        btnReadBatchVariable.TabIndex = 3;
        btnReadBatchVariable.Text = "Read";
        btnReadBatchVariable.UseVisualStyleBackColor = true;
        btnReadBatchVariable.Click += btnReadBatchVariable_Click;
        // 
        // btnBatchPositionCartesian
        // 
        btnBatchPositionCartesian.Location = new Point(26, 310);
        btnBatchPositionCartesian.Name = "btnBatchPositionCartesian";
        btnBatchPositionCartesian.Size = new Size(143, 40);
        btnBatchPositionCartesian.TabIndex = 3;
        btnBatchPositionCartesian.Text = "Add Position register (cartesian)";
        btnBatchPositionCartesian.UseVisualStyleBackColor = true;
        btnBatchPositionCartesian.Click += btnBatchPositionCartesian_Click;
        // 
        // btnBatchPositionJoint
        // 
        btnBatchPositionJoint.Location = new Point(26, 264);
        btnBatchPositionJoint.Name = "btnBatchPositionJoint";
        btnBatchPositionJoint.Size = new Size(143, 40);
        btnBatchPositionJoint.TabIndex = 3;
        btnBatchPositionJoint.Text = "Add Position register (joint)";
        btnBatchPositionJoint.UseVisualStyleBackColor = true;
        btnBatchPositionJoint.Click += btnBatchPositionJoint_Click;
        // 
        // btnAddBatchVariable
        // 
        btnAddBatchVariable.Location = new Point(26, 509);
        btnAddBatchVariable.Name = "btnAddBatchVariable";
        btnAddBatchVariable.Size = new Size(143, 41);
        btnAddBatchVariable.TabIndex = 3;
        btnAddBatchVariable.Text = "Add variable";
        btnAddBatchVariable.UseVisualStyleBackColor = true;
        btnAddBatchVariable.Click += btnAddBatchVariable_Click;
        // 
        // btnBatchAddStringRegister
        // 
        btnBatchAddStringRegister.Location = new Point(26, 219);
        btnBatchAddStringRegister.Name = "btnBatchAddStringRegister";
        btnBatchAddStringRegister.Size = new Size(143, 23);
        btnBatchAddStringRegister.TabIndex = 3;
        btnBatchAddStringRegister.Text = "Add String Register";
        btnBatchAddStringRegister.UseVisualStyleBackColor = true;
        btnBatchAddStringRegister.Click += btnBatchAddStringRegister_Click;
        // 
        // btnBatchAddNumericRegister
        // 
        btnBatchAddNumericRegister.Location = new Point(26, 190);
        btnBatchAddNumericRegister.Name = "btnBatchAddNumericRegister";
        btnBatchAddNumericRegister.Size = new Size(143, 23);
        btnBatchAddNumericRegister.TabIndex = 3;
        btnBatchAddNumericRegister.Text = "Add Numeric Register";
        btnBatchAddNumericRegister.UseVisualStyleBackColor = true;
        btnBatchAddNumericRegister.Click += btnBatchAddNumericRegister_Click;
        // 
        // btnBatchDelete
        // 
        btnBatchDelete.Enabled = false;
        btnBatchDelete.Location = new Point(39, 108);
        btnBatchDelete.Name = "btnBatchDelete";
        btnBatchDelete.Size = new Size(115, 23);
        btnBatchDelete.TabIndex = 2;
        btnBatchDelete.Text = "Delete selected";
        btnBatchDelete.UseVisualStyleBackColor = true;
        btnBatchDelete.Click += btnBatchDelete_Click;
        // 
        // lstBatchVariables
        // 
        lstBatchVariables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lstBatchVariables.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7 });
        lstBatchVariables.FullRowSelect = true;
        lstBatchVariables.Location = new Point(175, 108);
        lstBatchVariables.Name = "lstBatchVariables";
        lstBatchVariables.Size = new Size(408, 678);
        lstBatchVariables.TabIndex = 1;
        lstBatchVariables.UseCompatibleStateImageBehavior = false;
        lstBatchVariables.View = View.Details;
        lstBatchVariables.ItemSelectionChanged += lstBatchVariables_ItemSelectionChanged;
        // 
        // columnHeader6
        // 
        columnHeader6.Text = "Name";
        columnHeader6.Width = 150;
        // 
        // columnHeader7
        // 
        columnHeader7.Text = "Value";
        columnHeader7.Width = 250;
        // 
        // tabRegisters
        // 
        tabRegisters.Controls.Add(panel4);
        tabRegisters.Controls.Add(panel3);
        tabRegisters.Controls.Add(panel2);
        tabRegisters.Controls.Add(panel1);
        tabRegisters.Controls.Add(gridRegisterValues);
        tabRegisters.Controls.Add(btnReadNumericRegisters);
        tabRegisters.Controls.Add(btnReadStringRegisters);
        tabRegisters.Location = new Point(4, 24);
        tabRegisters.Name = "tabRegisters";
        tabRegisters.Padding = new Padding(3);
        tabRegisters.Size = new Size(1136, 789);
        tabRegisters.TabIndex = 5;
        tabRegisters.Text = "Registers";
        tabRegisters.UseVisualStyleBackColor = true;
        // 
        // panel4
        // 
        panel4.BorderStyle = BorderStyle.FixedSingle;
        panel4.Controls.Add(label18);
        panel4.Controls.Add(udRegisterIndex);
        panel4.Location = new Point(357, 44);
        panel4.Name = "panel4";
        panel4.Size = new Size(525, 79);
        panel4.TabIndex = 12;
        // 
        // label18
        // 
        label18.Location = new Point(121, 22);
        label18.Name = "label18";
        label18.Size = new Size(100, 23);
        label18.TabIndex = 1;
        label18.Text = "Register Index :";
        label18.TextAlign = ContentAlignment.MiddleRight;
        // 
        // udRegisterIndex
        // 
        udRegisterIndex.Location = new Point(237, 22);
        udRegisterIndex.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
        udRegisterIndex.Name = "udRegisterIndex";
        udRegisterIndex.Size = new Size(120, 23);
        udRegisterIndex.TabIndex = 0;
        udRegisterIndex.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // panel3
        // 
        panel3.BorderStyle = BorderStyle.FixedSingle;
        panel3.Controls.Add(label35);
        panel3.Controls.Add(txtStringRegisterValue);
        panel3.Controls.Add(label32);
        panel3.Controls.Add(btnWriteStringRegister);
        panel3.Location = new Point(626, 392);
        panel3.Name = "panel3";
        panel3.Size = new Size(256, 181);
        panel3.TabIndex = 11;
        // 
        // label35
        // 
        label35.Dock = DockStyle.Top;
        label35.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label35.Location = new Point(0, 0);
        label35.Name = "label35";
        label35.Size = new Size(254, 39);
        label35.TabIndex = 10;
        label35.Text = "String";
        label35.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtStringRegisterValue
        // 
        txtStringRegisterValue.Location = new Point(101, 63);
        txtStringRegisterValue.Name = "txtStringRegisterValue";
        txtStringRegisterValue.Size = new Size(131, 23);
        txtStringRegisterValue.TabIndex = 7;
        // 
        // label32
        // 
        label32.Location = new Point(23, 63);
        label32.Name = "label32";
        label32.Size = new Size(72, 23);
        label32.TabIndex = 1;
        label32.Text = "Value:";
        label32.TextAlign = ContentAlignment.MiddleRight;
        // 
        // btnWriteStringRegister
        // 
        btnWriteStringRegister.Location = new Point(101, 105);
        btnWriteStringRegister.Name = "btnWriteStringRegister";
        btnWriteStringRegister.Size = new Size(131, 46);
        btnWriteStringRegister.TabIndex = 2;
        btnWriteStringRegister.Text = "Write string register";
        btnWriteStringRegister.UseVisualStyleBackColor = true;
        btnWriteStringRegister.Click += btnWriteStringRegister_Click;
        // 
        // panel2
        // 
        panel2.BorderStyle = BorderStyle.FixedSingle;
        panel2.Controls.Add(label34);
        panel2.Controls.Add(rdNumericRegisterReal);
        panel2.Controls.Add(rdNumericRegisterInteger);
        panel2.Controls.Add(txtNumericRegisterComment);
        panel2.Controls.Add(btnWriteNumericRegister);
        panel2.Controls.Add(btnReadNumericRegister);
        panel2.Controls.Add(label31);
        panel2.Controls.Add(label30);
        panel2.Controls.Add(udNumericRegisterValue);
        panel2.Location = new Point(626, 121);
        panel2.Name = "panel2";
        panel2.Size = new Size(256, 274);
        panel2.TabIndex = 10;
        // 
        // label34
        // 
        label34.Dock = DockStyle.Top;
        label34.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label34.Location = new Point(0, 0);
        label34.Name = "label34";
        label34.Size = new Size(254, 39);
        label34.TabIndex = 9;
        label34.Text = "Numeric";
        label34.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // rdNumericRegisterReal
        // 
        rdNumericRegisterReal.AutoSize = true;
        rdNumericRegisterReal.Location = new Point(185, 153);
        rdNumericRegisterReal.Name = "rdNumericRegisterReal";
        rdNumericRegisterReal.Size = new Size(47, 19);
        rdNumericRegisterReal.TabIndex = 8;
        rdNumericRegisterReal.TabStop = true;
        rdNumericRegisterReal.Text = "Real";
        rdNumericRegisterReal.UseVisualStyleBackColor = true;
        rdNumericRegisterReal.CheckedChanged += rdNumericRegisterReal_CheckedChanged;
        // 
        // rdNumericRegisterInteger
        // 
        rdNumericRegisterInteger.AutoSize = true;
        rdNumericRegisterInteger.Location = new Point(84, 153);
        rdNumericRegisterInteger.Name = "rdNumericRegisterInteger";
        rdNumericRegisterInteger.Size = new Size(62, 19);
        rdNumericRegisterInteger.TabIndex = 8;
        rdNumericRegisterInteger.TabStop = true;
        rdNumericRegisterInteger.Text = "Integer";
        rdNumericRegisterInteger.UseVisualStyleBackColor = true;
        rdNumericRegisterInteger.CheckedChanged += rdNumericRegisterInteger_CheckedChanged;
        // 
        // txtNumericRegisterComment
        // 
        txtNumericRegisterComment.Location = new Point(84, 124);
        txtNumericRegisterComment.Name = "txtNumericRegisterComment";
        txtNumericRegisterComment.ReadOnly = true;
        txtNumericRegisterComment.Size = new Size(148, 23);
        txtNumericRegisterComment.TabIndex = 7;
        // 
        // btnWriteNumericRegister
        // 
        btnWriteNumericRegister.Location = new Point(84, 193);
        btnWriteNumericRegister.Name = "btnWriteNumericRegister";
        btnWriteNumericRegister.Size = new Size(148, 46);
        btnWriteNumericRegister.TabIndex = 2;
        btnWriteNumericRegister.Text = "Write numeric register";
        btnWriteNumericRegister.UseVisualStyleBackColor = true;
        btnWriteNumericRegister.Click += btnWriteNumericRegister_Click;
        // 
        // btnReadNumericRegister
        // 
        btnReadNumericRegister.Location = new Point(84, 53);
        btnReadNumericRegister.Name = "btnReadNumericRegister";
        btnReadNumericRegister.Size = new Size(148, 23);
        btnReadNumericRegister.TabIndex = 2;
        btnReadNumericRegister.Text = "Read numeric register";
        btnReadNumericRegister.UseVisualStyleBackColor = true;
        btnReadNumericRegister.Click += btnReadNumericRegister_Click;
        // 
        // label31
        // 
        label31.Location = new Point(6, 124);
        label31.Name = "label31";
        label31.Size = new Size(72, 23);
        label31.TabIndex = 1;
        label31.Text = "Comment:";
        label31.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label30
        // 
        label30.Location = new Point(6, 95);
        label30.Name = "label30";
        label30.Size = new Size(72, 23);
        label30.TabIndex = 1;
        label30.Text = "Value:";
        label30.TextAlign = ContentAlignment.MiddleRight;
        // 
        // udNumericRegisterValue
        // 
        udNumericRegisterValue.Location = new Point(84, 97);
        udNumericRegisterValue.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
        udNumericRegisterValue.Name = "udNumericRegisterValue";
        udNumericRegisterValue.Size = new Size(148, 23);
        udNumericRegisterValue.TabIndex = 0;
        udNumericRegisterValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(gridRegisterValue);
        panel1.Controls.Add(btnReadPositionRegister);
        panel1.Controls.Add(udPositionRegisterGroup);
        panel1.Controls.Add(label29);
        panel1.Controls.Add(label33);
        panel1.Location = new Point(357, 121);
        panel1.Name = "panel1";
        panel1.Size = new Size(270, 662);
        panel1.TabIndex = 9;
        // 
        // gridRegisterValue
        // 
        gridRegisterValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridRegisterValue.HelpVisible = false;
        gridRegisterValue.Location = new Point(23, 124);
        gridRegisterValue.Name = "gridRegisterValue";
        gridRegisterValue.PropertySort = PropertySort.NoSort;
        gridRegisterValue.Size = new Size(219, 522);
        gridRegisterValue.TabIndex = 6;
        gridRegisterValue.ToolbarVisible = false;
        // 
        // btnReadPositionRegister
        // 
        btnReadPositionRegister.Location = new Point(77, 93);
        btnReadPositionRegister.Name = "btnReadPositionRegister";
        btnReadPositionRegister.Size = new Size(144, 23);
        btnReadPositionRegister.TabIndex = 2;
        btnReadPositionRegister.Text = "Read position registers";
        btnReadPositionRegister.UseVisualStyleBackColor = true;
        btnReadPositionRegister.Click += btnReadPositionRegister_Click;
        // 
        // udPositionRegisterGroup
        // 
        udPositionRegisterGroup.Location = new Point(101, 53);
        udPositionRegisterGroup.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        udPositionRegisterGroup.Name = "udPositionRegisterGroup";
        udPositionRegisterGroup.Size = new Size(120, 23);
        udPositionRegisterGroup.TabIndex = 0;
        udPositionRegisterGroup.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label29
        // 
        label29.Location = new Point(33, 53);
        label29.Name = "label29";
        label29.Size = new Size(62, 23);
        label29.TabIndex = 1;
        label29.Text = "Group:";
        label29.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label33
        // 
        label33.Dock = DockStyle.Top;
        label33.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label33.Location = new Point(0, 0);
        label33.Name = "label33";
        label33.Size = new Size(268, 39);
        label33.TabIndex = 1;
        label33.Text = "Position";
        label33.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // gridRegisterValues
        // 
        gridRegisterValues.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridRegisterValues.HelpVisible = false;
        gridRegisterValues.Location = new Point(6, 79);
        gridRegisterValues.Name = "gridRegisterValues";
        gridRegisterValues.PropertySort = PropertySort.NoSort;
        gridRegisterValues.Size = new Size(325, 704);
        gridRegisterValues.TabIndex = 6;
        gridRegisterValues.ToolbarVisible = false;
        // 
        // btnReadNumericRegisters
        // 
        btnReadNumericRegisters.Location = new Point(6, 50);
        btnReadNumericRegisters.Name = "btnReadNumericRegisters";
        btnReadNumericRegisters.Size = new Size(154, 23);
        btnReadNumericRegisters.TabIndex = 2;
        btnReadNumericRegisters.Text = "Read all numeric register";
        btnReadNumericRegisters.UseVisualStyleBackColor = true;
        btnReadNumericRegisters.Click += btnReadNumericRegisters_Click;
        // 
        // btnReadStringRegisters
        // 
        btnReadStringRegisters.Location = new Point(166, 50);
        btnReadStringRegisters.Name = "btnReadStringRegisters";
        btnReadStringRegisters.Size = new Size(165, 23);
        btnReadStringRegisters.TabIndex = 2;
        btnReadStringRegisters.Text = "Read all string registers";
        btnReadStringRegisters.UseVisualStyleBackColor = true;
        btnReadStringRegisters.Click += btnReadStringRegisters_Click;
        // 
        // tabKcl
        // 
        tabKcl.Controls.Add(KclControl);
        tabKcl.Location = new Point(4, 24);
        tabKcl.Name = "tabKcl";
        tabKcl.Padding = new Padding(3);
        tabKcl.Size = new Size(1136, 789);
        tabKcl.TabIndex = 6;
        tabKcl.Text = "KCL";
        tabKcl.UseVisualStyleBackColor = true;
        // 
        // KclControl
        // 
        KclControl.Dock = DockStyle.Fill;
        KclControl.Location = new Point(3, 3);
        KclControl.Margin = new Padding(4, 3, 4, 3);
        KclControl.Name = "KclControl";
        KclControl.Size = new Size(1130, 783);
        KclControl.SupportVariableParse = true;
        KclControl.TabIndex = 0;
        // 
        // tabUserAlarms
        // 
        tabUserAlarms.Controls.Add(btnUserAlarmSetComment);
        tabUserAlarms.Controls.Add(btnUserAlarmSetSeverity);
        tabUserAlarms.Controls.Add(txtUserAlarmComment);
        tabUserAlarms.Controls.Add(label21);
        tabUserAlarms.Controls.Add(label20);
        tabUserAlarms.Controls.Add(label19);
        tabUserAlarms.Controls.Add(udUserAlarmSeverity);
        tabUserAlarms.Controls.Add(udUserAlarmIndex);
        tabUserAlarms.Controls.Add(btnReadUserAlarms);
        tabUserAlarms.Controls.Add(lstUserAlarms);
        tabUserAlarms.Location = new Point(4, 24);
        tabUserAlarms.Name = "tabUserAlarms";
        tabUserAlarms.Padding = new Padding(3);
        tabUserAlarms.Size = new Size(1136, 789);
        tabUserAlarms.TabIndex = 9;
        tabUserAlarms.Text = "User Alarms";
        tabUserAlarms.UseVisualStyleBackColor = true;
        // 
        // btnUserAlarmSetComment
        // 
        btnUserAlarmSetComment.Location = new Point(562, 221);
        btnUserAlarmSetComment.Name = "btnUserAlarmSetComment";
        btnUserAlarmSetComment.Size = new Size(120, 23);
        btnUserAlarmSetComment.TabIndex = 5;
        btnUserAlarmSetComment.Text = "Set Comment";
        btnUserAlarmSetComment.UseVisualStyleBackColor = true;
        btnUserAlarmSetComment.Click += btnUserAlarmSetComment_Click;
        // 
        // btnUserAlarmSetSeverity
        // 
        btnUserAlarmSetSeverity.Location = new Point(562, 304);
        btnUserAlarmSetSeverity.Name = "btnUserAlarmSetSeverity";
        btnUserAlarmSetSeverity.Size = new Size(120, 23);
        btnUserAlarmSetSeverity.TabIndex = 5;
        btnUserAlarmSetSeverity.Text = "Set severity";
        btnUserAlarmSetSeverity.UseVisualStyleBackColor = true;
        btnUserAlarmSetSeverity.Click += btnUserAlarmSetSeverity_Click;
        // 
        // txtUserAlarmComment
        // 
        txtUserAlarmComment.Location = new Point(562, 192);
        txtUserAlarmComment.Name = "txtUserAlarmComment";
        txtUserAlarmComment.Size = new Size(271, 23);
        txtUserAlarmComment.TabIndex = 4;
        // 
        // label21
        // 
        label21.Location = new Point(456, 192);
        label21.Name = "label21";
        label21.Size = new Size(100, 23);
        label21.TabIndex = 3;
        label21.Text = "Comment:";
        label21.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label20
        // 
        label20.Location = new Point(456, 275);
        label20.Name = "label20";
        label20.Size = new Size(100, 23);
        label20.TabIndex = 3;
        label20.Text = "Severity:";
        label20.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label19
        // 
        label19.Location = new Point(456, 130);
        label19.Name = "label19";
        label19.Size = new Size(100, 23);
        label19.TabIndex = 3;
        label19.Text = "Index:";
        label19.TextAlign = ContentAlignment.MiddleRight;
        // 
        // udUserAlarmSeverity
        // 
        udUserAlarmSeverity.Location = new Point(562, 275);
        udUserAlarmSeverity.Name = "udUserAlarmSeverity";
        udUserAlarmSeverity.Size = new Size(120, 23);
        udUserAlarmSeverity.TabIndex = 2;
        // 
        // udUserAlarmIndex
        // 
        udUserAlarmIndex.Location = new Point(562, 130);
        udUserAlarmIndex.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
        udUserAlarmIndex.Name = "udUserAlarmIndex";
        udUserAlarmIndex.Size = new Size(120, 23);
        udUserAlarmIndex.TabIndex = 2;
        udUserAlarmIndex.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnReadUserAlarms
        // 
        btnReadUserAlarms.Location = new Point(27, 89);
        btnReadUserAlarms.Name = "btnReadUserAlarms";
        btnReadUserAlarms.Size = new Size(388, 23);
        btnReadUserAlarms.TabIndex = 1;
        btnReadUserAlarms.Text = "Read user alarms";
        btnReadUserAlarms.UseVisualStyleBackColor = true;
        btnReadUserAlarms.Click += btnReadUserAlarms_Click;
        // 
        // lstUserAlarms
        // 
        lstUserAlarms.Columns.AddRange(new ColumnHeader[] { columnUserAlarmId, columnUserAlarmComment, columnUsertAlarmSeverity });
        lstUserAlarms.FullRowSelect = true;
        lstUserAlarms.Location = new Point(27, 132);
        lstUserAlarms.Name = "lstUserAlarms";
        lstUserAlarms.Size = new Size(388, 339);
        lstUserAlarms.TabIndex = 0;
        lstUserAlarms.UseCompatibleStateImageBehavior = false;
        lstUserAlarms.View = View.Details;
        lstUserAlarms.ItemSelectionChanged += lstUserAlarms_ItemSelectionChanged;
        // 
        // columnUserAlarmId
        // 
        columnUserAlarmId.Text = "Id";
        // 
        // columnUserAlarmComment
        // 
        columnUserAlarmComment.Text = "Comment";
        columnUserAlarmComment.Width = 250;
        // 
        // columnUsertAlarmSeverity
        // 
        columnUsertAlarmSeverity.Text = "Severity";
        // 
        // tabComments
        // 
        tabComments.Controls.Add(btnSetComment);
        tabComments.Controls.Add(txtComment);
        tabComments.Controls.Add(label23);
        tabComments.Controls.Add(label24);
        tabComments.Controls.Add(udCommentIndex);
        tabComments.Controls.Add(label22);
        tabComments.Controls.Add(cbCommentType);
        tabComments.Controls.Add(btnReadComments);
        tabComments.Controls.Add(lstComments);
        tabComments.Location = new Point(4, 24);
        tabComments.Name = "tabComments";
        tabComments.Padding = new Padding(3);
        tabComments.Size = new Size(1136, 789);
        tabComments.TabIndex = 10;
        tabComments.Text = "Comments";
        tabComments.UseVisualStyleBackColor = true;
        // 
        // btnSetComment
        // 
        btnSetComment.Location = new Point(593, 339);
        btnSetComment.Name = "btnSetComment";
        btnSetComment.Size = new Size(120, 23);
        btnSetComment.TabIndex = 10;
        btnSetComment.Text = "Set Comment";
        btnSetComment.UseVisualStyleBackColor = true;
        btnSetComment.Click += btnSetComment_Click_1;
        // 
        // txtComment
        // 
        txtComment.Location = new Point(593, 310);
        txtComment.Name = "txtComment";
        txtComment.Size = new Size(240, 23);
        txtComment.TabIndex = 9;
        // 
        // label23
        // 
        label23.Location = new Point(487, 310);
        label23.Name = "label23";
        label23.Size = new Size(100, 23);
        label23.TabIndex = 7;
        label23.Text = "Comment:";
        label23.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label24
        // 
        label24.Location = new Point(487, 248);
        label24.Name = "label24";
        label24.Size = new Size(100, 23);
        label24.TabIndex = 8;
        label24.Text = "Index:";
        label24.TextAlign = ContentAlignment.MiddleRight;
        // 
        // udCommentIndex
        // 
        udCommentIndex.Location = new Point(593, 248);
        udCommentIndex.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
        udCommentIndex.Name = "udCommentIndex";
        udCommentIndex.Size = new Size(120, 23);
        udCommentIndex.TabIndex = 6;
        udCommentIndex.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label22
        // 
        label22.Location = new Point(111, 69);
        label22.Name = "label22";
        label22.Size = new Size(71, 23);
        label22.TabIndex = 5;
        label22.Text = "Type:";
        label22.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cbCommentType
        // 
        cbCommentType.DropDownStyle = ComboBoxStyle.DropDownList;
        cbCommentType.FormattingEnabled = true;
        cbCommentType.Location = new Point(188, 69);
        cbCommentType.Name = "cbCommentType";
        cbCommentType.Size = new Size(153, 23);
        cbCommentType.TabIndex = 4;
        // 
        // btnReadComments
        // 
        btnReadComments.Location = new Point(66, 121);
        btnReadComments.Name = "btnReadComments";
        btnReadComments.Size = new Size(388, 23);
        btnReadComments.TabIndex = 3;
        btnReadComments.Text = "Read all comments";
        btnReadComments.UseVisualStyleBackColor = true;
        btnReadComments.Click += btnReadComments_Click;
        // 
        // lstComments
        // 
        lstComments.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
        lstComments.FullRowSelect = true;
        lstComments.Location = new Point(66, 164);
        lstComments.Name = "lstComments";
        lstComments.Size = new Size(388, 339);
        lstComments.TabIndex = 2;
        lstComments.UseCompatibleStateImageBehavior = false;
        lstComments.View = View.Details;
        lstComments.ItemSelectionChanged += lstComments_ItemSelectionChanged;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "Id";
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Comment";
        columnHeader2.Width = 250;
        // 
        // tabHttp
        // 
        tabHttp.Controls.Add(btnHttpDownloadAscii);
        tabHttp.Controls.Add(btnHttpDownloadFile);
        tabHttp.Controls.Add(lstHttpItems);
        tabHttp.Controls.Add(btnHttpListOther);
        tabHttp.Controls.Add(btnHttpListDiagnosticFiles);
        tabHttp.Controls.Add(btnHttpListPrograms);
        tabHttp.Controls.Add(btnHttpListVariables);
        tabHttp.Location = new Point(4, 24);
        tabHttp.Name = "tabHttp";
        tabHttp.Padding = new Padding(3);
        tabHttp.Size = new Size(1136, 789);
        tabHttp.TabIndex = 11;
        tabHttp.Text = "HTTP";
        tabHttp.UseVisualStyleBackColor = true;
        // 
        // btnHttpDownloadAscii
        // 
        btnHttpDownloadAscii.Image = UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.save_3_fill;
        btnHttpDownloadAscii.Location = new Point(655, 224);
        btnHttpDownloadAscii.Name = "btnHttpDownloadAscii";
        btnHttpDownloadAscii.Size = new Size(125, 49);
        btnHttpDownloadAscii.TabIndex = 2;
        btnHttpDownloadAscii.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnHttpDownloadAscii.UseVisualStyleBackColor = true;
        btnHttpDownloadAscii.Visible = false;
        btnHttpDownloadAscii.Click += btnHttpDownloadFile_Click;
        // 
        // btnHttpDownloadFile
        // 
        btnHttpDownloadFile.Enabled = false;
        btnHttpDownloadFile.Image = UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.save_3_fill;
        btnHttpDownloadFile.Location = new Point(655, 169);
        btnHttpDownloadFile.Name = "btnHttpDownloadFile";
        btnHttpDownloadFile.Size = new Size(125, 49);
        btnHttpDownloadFile.TabIndex = 2;
        btnHttpDownloadFile.Text = "Download";
        btnHttpDownloadFile.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnHttpDownloadFile.UseVisualStyleBackColor = true;
        btnHttpDownloadFile.Click += btnHttpDownloadFile_Click;
        // 
        // lstHttpItems
        // 
        lstHttpItems.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5 });
        lstHttpItems.FullRowSelect = true;
        lstHttpItems.Location = new Point(6, 124);
        lstHttpItems.Name = "lstHttpItems";
        lstHttpItems.Size = new Size(610, 339);
        lstHttpItems.TabIndex = 1;
        lstHttpItems.UseCompatibleStateImageBehavior = false;
        lstHttpItems.View = View.Details;
        lstHttpItems.ItemSelectionChanged += lstHttpItems_ItemSelectionChanged;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "File";
        columnHeader3.Width = 200;
        // 
        // columnHeader4
        // 
        columnHeader4.Text = "ASCII File";
        columnHeader4.Width = 200;
        // 
        // columnHeader5
        // 
        columnHeader5.Text = "Comment";
        columnHeader5.Width = 200;
        // 
        // btnHttpListOther
        // 
        btnHttpListOther.Location = new Point(563, 56);
        btnHttpListOther.Name = "btnHttpListOther";
        btnHttpListOther.Size = new Size(139, 30);
        btnHttpListOther.TabIndex = 0;
        btnHttpListOther.Text = "List other files";
        btnHttpListOther.UseVisualStyleBackColor = true;
        btnHttpListOther.Click += btnHttpListOther_Click;
        // 
        // btnHttpListDiagnosticFiles
        // 
        btnHttpListDiagnosticFiles.Location = new Point(382, 56);
        btnHttpListDiagnosticFiles.Name = "btnHttpListDiagnosticFiles";
        btnHttpListDiagnosticFiles.Size = new Size(139, 30);
        btnHttpListDiagnosticFiles.TabIndex = 0;
        btnHttpListDiagnosticFiles.Text = "List diagnostic files";
        btnHttpListDiagnosticFiles.UseVisualStyleBackColor = true;
        btnHttpListDiagnosticFiles.Click += btnHttpListDiagnosticFiles_Click;
        // 
        // btnHttpListPrograms
        // 
        btnHttpListPrograms.Location = new Point(206, 56);
        btnHttpListPrograms.Name = "btnHttpListPrograms";
        btnHttpListPrograms.Size = new Size(139, 30);
        btnHttpListPrograms.TabIndex = 0;
        btnHttpListPrograms.Text = "List TP programs";
        btnHttpListPrograms.UseVisualStyleBackColor = true;
        btnHttpListPrograms.Click += btnHttpListPrograms_Click;
        // 
        // btnHttpListVariables
        // 
        btnHttpListVariables.Location = new Point(34, 56);
        btnHttpListVariables.Name = "btnHttpListVariables";
        btnHttpListVariables.Size = new Size(139, 30);
        btnHttpListVariables.TabIndex = 0;
        btnHttpListVariables.Text = "List variable files";
        btnHttpListVariables.UseVisualStyleBackColor = true;
        btnHttpListVariables.Click += btnHttpListVariables_Click;
        // 
        // dlgSaveFile
        // 
        dlgSaveFile.Filter = "All Files|*.*";
        // 
        // CgtpControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(TabIo);
        Margin = new Padding(4, 3, 4, 3);
        Name = "CgtpControl";
        Size = new Size(1144, 817);
        ((System.ComponentModel.ISupportInitialize)udProgramLine).EndInit();
        TabIo.ResumeLayout(false);
        tabProgram.ResumeLayout(false);
        tabProgram.PerformLayout();
        groupBox5.ResumeLayout(false);
        groupBox5.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)udNEwProgramGroup).EndInit();
        groupBox4.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)udProgramStackSize).EndInit();
        tabFiles.ResumeLayout(false);
        tabFiles.PerformLayout();
        tabPageIo.ResumeLayout(false);
        tabPageIo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)udIoValue).EndInit();
        ((System.ComponentModel.ISupportInitialize)udIoIndex).EndInit();
        tabKinematics.ResumeLayout(false);
        tabKinematics.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)udGroup).EndInit();
        tabVariables.ResumeLayout(false);
        tabVariables.PerformLayout();
        tabBatchVariables.ResumeLayout(false);
        tabBatchVariables.PerformLayout();
        tabRegisters.ResumeLayout(false);
        panel4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)udRegisterIndex).EndInit();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)udNumericRegisterValue).EndInit();
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)udPositionRegisterGroup).EndInit();
        tabKcl.ResumeLayout(false);
        tabUserAlarms.ResumeLayout(false);
        tabUserAlarms.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)udUserAlarmSeverity).EndInit();
        ((System.ComponentModel.ISupportInitialize)udUserAlarmIndex).EndInit();
        tabComments.ResumeLayout(false);
        tabComments.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)udCommentIndex).EndInit();
        tabHttp.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private TextBox txtProgram;
    private Label label2;
    private Button btnSelectProgramLine;
    private NumericUpDown udProgramLine;
    private Label label3;
    private Button btnStartProgram;
    private TabControl TabIo;
    private TabPage tabFiles;
    private TabPage tabProgram;
    private Button btnDeleteProgram;
    private Button btnGetProgramComment;
    private CheckBox chkWriteProtect;
    private CheckBox chkProgramIgnorePause;
    private NumericUpDown udProgramStackSize;
    private TextBox txtProgramComment;
    private Button btnSetProgramWriteProtect;
    private Button btnSetProgramIgnorePause;
    private Button btnSetProgramStackSize;
    private Button btnSetProgramComment;
    private Button btnGetProgramWriteProtect;
    private Button btnGetProgramIgnorePause;
    private Button btnGetProgramStackSize;
    private ComboBox cbProgramType;
    private Button btnSetProgramType;
    private Button btnGetProgramType;
    private Button btnRenameProgram;
    private Button btnCreateProgram;
    private TextBox txtProgramNewName;
    private Label label4;
    private TextBox txtNewProgramName;
    private Label label5;
    private ComboBox cbNewProgramType;
    private TextBox txtNewProgramComment;
    private Label label8;
    private TextBox txtNewProgramOwner;
    private Label label7;
    private Label label6;
    private GroupBox groupBox5;
    private NumericUpDown udNEwProgramGroup;
    private Label label9;
    private GroupBox groupBox4;
    private GroupBox groupBox3;
    private GroupBox groupBox2;
    private GroupBox groupBox1;
    private TextBox txtProgramOwner;
    private Button btnSetProgramOwner;
    private Button btnGetProgramOwner;
    private Button BtnPause;
    private Button btnAbort;
    private Button btnSelectProgram;
    private RichTextBox txtContent;
    private TreeView treeFiles;
    private Button btnReadContent;
    private Button btnListFiles;
    private TextBox txtFile;
    private TextBox txtPath;
    private TabPage tabVariables;
    private Label label11;
    private Label label10;
    private Label label1;
    private TextBox txtVariableName;
    private Button btnReadVariableAsString;
    private Label label12;
    private TextBox txtVariableValue;
    private Button btnWriteVariable;
    private TabPage tabPageIo;
    private TextBox txtSimulationStatus;
    private NumericUpDown udIoIndex;
    private ComboBox cbIoTypes;
    private Label label13;
    private Label label26;
    private Label label27;
    private Button btnWriteIo;
    private Button btnUnsimulate;
    private Button btnReadIo;
    private Button btnSimulate;
    private Button btnReadSimulation;
    private NumericUpDown udIoValue;
    private PropertyGrid gridCartesianPosition;
    private Label label14;
    private NumericUpDown udGroup;
    private Button btnReadCartesian;
    private PropertyGrid gridJointPosition;
    private Button btnReadJointsPosition;
    private Button btnReadVariableAsPosition;
    private PropertyGrid gridVariableCartesianValue;
    private Label label16;
    private PropertyGrid gridVariableJointValue;
    private Label label15;
    internal CueTextBox txtVariableProgram;
    private Label label17;
    private TabPage tabRegisters;
    private TabPage tabKcl;
    private KclControl KclControl;
    private Button btnWriteCartesianVariableValue;
    private Button btnWriteJointPositionVariable;
    private TabPage tabBatchVariables;
    private TabPage tabKinematics;
    private NumericUpDown udRegisterIndex;
    private Label label18;
    private Button btnReadStringRegisters;
    private TabPage tabUserAlarms;
    private Button btnReadUserAlarms;
    private ListView lstUserAlarms;
    private ColumnHeader columnUserAlarmId;
    private ColumnHeader columnUserAlarmComment;
    private ColumnHeader columnUsertAlarmSeverity;
    private Button btnUserAlarmSetComment;
    private Button btnUserAlarmSetSeverity;
    private TextBox txtUserAlarmComment;
    private Label label21;
    private Label label20;
    private Label label19;
    private NumericUpDown udUserAlarmSeverity;
    private NumericUpDown udUserAlarmIndex;
    private TabPage tabComments;
    private Button btnSetComment;
    private TextBox txtComment;
    private Label label23;
    private Label label24;
    private NumericUpDown udCommentIndex;
    private Label label22;
    private ComboBox cbCommentType;
    private Button btnReadComments;
    private ListView lstComments;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private Button btnInverseKinematics;
    private Button btnForwardKinematics;
    private TabPage tabHttp;
    private Button btnHttpListVariables;
    private ListView lstHttpItems;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private Button btnHttpDownloadAscii;
    private Button btnHttpDownloadFile;
    private SaveFileDialog dlgSaveFile;
    private Button btnHttpListPrograms;
    private Button btnHttpListOther;
    private Button btnHttpListDiagnosticFiles;
    private ListView lstBatchVariables;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;
    private Button btnBatchDelete;
    private Button btnBatchAddNumericRegister;
    private PropertyGrid gridSelectedBatchVariable;
    private Button btnWriteBatchVariable;
    private Button btnReadBatchVariable;
    private Button btnBatchPositionJoint;
    private Button btnBatchAddStringRegister;
    internal CueTextBox txtBatchVariableProgram;
    private Label label25;
    private TextBox txtBatchVariableName;
    private Button btnBatchPositionCartesian;
    private Label label28;
    private Button btnAddBatchVariable;
    private PropertyGrid gridRegisterValues;
    private Button btnReadPositionRegister;
    private Button btnReadNumericRegisters;
    private Label label29;
    private NumericUpDown udPositionRegisterGroup;
    private PropertyGrid gridRegisterValue;
    private Button btnReadNumericRegister;
    private TextBox txtNumericRegisterComment;
    private Button btnWriteNumericRegister;
    private Label label31;
    private Label label30;
    private NumericUpDown udNumericRegisterValue;
    private RadioButton rdNumericRegisterReal;
    private RadioButton rdNumericRegisterInteger;
    private Panel panel4;
    private Panel panel3;
    private Panel panel2;
    private Panel panel1;
    private TextBox txtStringRegisterValue;
    private Label label32;
    private Button btnWriteStringRegister;
    private Label label35;
    private Label label34;
    private Label label33;
}
