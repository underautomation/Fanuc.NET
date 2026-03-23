
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
        tabControl1 = new TabControl();
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
        tabVariables = new TabPage();
        label12 = new Label();
        label1 = new Label();
        txtVariableValue = new TextBox();
        txtVariableName = new TextBox();
        btnWriteVariable = new Button();
        btnReadVariable = new Button();
        ((System.ComponentModel.ISupportInitialize)udProgramLine).BeginInit();
        tabControl1.SuspendLayout();
        tabProgram.SuspendLayout();
        groupBox5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udNEwProgramGroup).BeginInit();
        groupBox4.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udProgramStackSize).BeginInit();
        tabFiles.SuspendLayout();
        tabVariables.SuspendLayout();
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
        btnSelectProgramLine.Size = new Size(141, 23);
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
        udProgramLine.Size = new Size(103, 23);
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
        btnStartProgram.Size = new Size(141, 23);
        btnStartProgram.TabIndex = 2;
        btnStartProgram.Text = "Start program from line";
        btnStartProgram.UseVisualStyleBackColor = true;
        btnStartProgram.Click += btnStartProgram_Click;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabProgram);
        tabControl1.Controls.Add(tabFiles);
        tabControl1.Controls.Add(tabVariables);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(847, 603);
        tabControl1.TabIndex = 4;
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
        tabProgram.Size = new Size(839, 575);
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
        tabFiles.Size = new Size(839, 575);
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
        // tabVariables
        // 
        tabVariables.Controls.Add(label12);
        tabVariables.Controls.Add(label1);
        tabVariables.Controls.Add(txtVariableValue);
        tabVariables.Controls.Add(txtVariableName);
        tabVariables.Controls.Add(btnWriteVariable);
        tabVariables.Controls.Add(btnReadVariable);
        tabVariables.Location = new Point(4, 24);
        tabVariables.Name = "tabVariables";
        tabVariables.Padding = new Padding(3);
        tabVariables.Size = new Size(839, 575);
        tabVariables.TabIndex = 2;
        tabVariables.Text = "Variables";
        tabVariables.UseVisualStyleBackColor = true;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(56, 111);
        label12.Name = "label12";
        label12.Size = new Size(38, 15);
        label12.TabIndex = 2;
        label12.Text = "Value:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(56, 29);
        label1.Name = "label1";
        label1.Size = new Size(51, 15);
        label1.TabIndex = 2;
        label1.Text = "Variable:";
        // 
        // txtVariableValue
        // 
        txtVariableValue.Location = new Point(56, 129);
        txtVariableValue.Multiline = true;
        txtVariableValue.Name = "txtVariableValue";
        txtVariableValue.Size = new Size(164, 124);
        txtVariableValue.TabIndex = 1;
        // 
        // txtVariableName
        // 
        txtVariableName.Location = new Point(56, 47);
        txtVariableName.Name = "txtVariableName";
        txtVariableName.Size = new Size(164, 23);
        txtVariableName.TabIndex = 1;
        txtVariableName.Text = "$RMT_MASTER";
        // 
        // btnWriteVariable
        // 
        btnWriteVariable.Location = new Point(56, 259);
        btnWriteVariable.Name = "btnWriteVariable";
        btnWriteVariable.Size = new Size(164, 23);
        btnWriteVariable.TabIndex = 0;
        btnWriteVariable.Text = "Write";
        btnWriteVariable.UseVisualStyleBackColor = true;
        btnWriteVariable.Click += btnWriteVariable_Click;
        // 
        // btnReadVariable
        // 
        btnReadVariable.Location = new Point(56, 76);
        btnReadVariable.Name = "btnReadVariable";
        btnReadVariable.Size = new Size(164, 23);
        btnReadVariable.TabIndex = 0;
        btnReadVariable.Text = "Read";
        btnReadVariable.UseVisualStyleBackColor = true;
        btnReadVariable.Click += btnReadVariable_Click;
        // 
        // CgtpControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(tabControl1);
        Margin = new Padding(4, 3, 4, 3);
        Name = "CgtpControl";
        Size = new Size(847, 603);
        ((System.ComponentModel.ISupportInitialize)udProgramLine).EndInit();
        tabControl1.ResumeLayout(false);
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
        tabVariables.ResumeLayout(false);
        tabVariables.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private TextBox txtProgram;
    private Label label2;
    private Button btnSelectProgramLine;
    private NumericUpDown udProgramLine;
    private Label label3;
    private Button btnStartProgram;
    private TabControl tabControl1;
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
    private Button btnReadVariable;
    private Label label12;
    private TextBox txtVariableValue;
    private Button btnWriteVariable;
}
