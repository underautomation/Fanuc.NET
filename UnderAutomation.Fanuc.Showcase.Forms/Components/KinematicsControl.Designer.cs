    partial class KinematicsControl
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
        ListViewItem listViewItem1 = new ListViewItem(new string[] { "", "0.2", "", "", "", "", "0.3" }, -1);
        gridCurrentCartesian = new PropertyGrid();
        gridCurrentDh = new PropertyGrid();
        gridCurrentJoints = new PropertyGrid();
        btnCopyCurrentJoints = new Button();
        btnCopyCurrentCartesian = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        gridDH = new PropertyGrid();
        gridCartesianIK = new PropertyGrid();
        gridJointsFK = new PropertyGrid();
        gridFKResult = new PropertyGrid();
        btnForwardKinematics = new Button();
        btnInvertKinematics = new Button();
        lstIKResults = new ListView();
        columnId = new ColumnHeader();
        columnJ1 = new ColumnHeader();
        columnJ2 = new ColumnHeader();
        columnJ3 = new ColumnHeader();
        columnJ4 = new ColumnHeader();
        columnJ5 = new ColumnHeader();
        columnJ6 = new ColumnHeader();
        btnCopyFKResult = new Button();
        BtnCopyIKSelectedResult = new Button();
        cbModele = new ComboBox();
        btnImportDH = new Button();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        label9 = new Label();
        panel1 = new Panel();
        pictureBox1 = new PictureBox();
        btnReadCurrentJoints = new Button();
        btnReadCurrentDh = new Button();
        btnReadCurrentCartesianPosition = new Button();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // gridCurrentCartesian
        // 
        gridCurrentCartesian.HelpVisible = false;
        gridCurrentCartesian.Location = new Point(48, 491);
        gridCurrentCartesian.Name = "gridCurrentCartesian";
        gridCurrentCartesian.PropertySort = PropertySort.NoSort;
        gridCurrentCartesian.Size = new Size(205, 216);
        gridCurrentCartesian.TabIndex = 0;
        gridCurrentCartesian.ToolbarVisible = false;
        // 
        // gridCurrentDh
        // 
        gridCurrentDh.HelpVisible = false;
        gridCurrentDh.Location = new Point(48, 280);
        gridCurrentDh.Name = "gridCurrentDh";
        gridCurrentDh.PropertySort = PropertySort.NoSort;
        gridCurrentDh.Size = new Size(205, 136);
        gridCurrentDh.TabIndex = 0;
        gridCurrentDh.ToolbarVisible = false;
        // 
        // gridCurrentJoints
        // 
        gridCurrentJoints.HelpVisible = false;
        gridCurrentJoints.Location = new Point(48, 22);
        gridCurrentJoints.Name = "gridCurrentJoints";
        gridCurrentJoints.PropertySort = PropertySort.NoSort;
        gridCurrentJoints.Size = new Size(205, 191);
        gridCurrentJoints.TabIndex = 0;
        gridCurrentJoints.ToolbarVisible = false;
        // 
        // btnCopyCurrentJoints
        // 
        btnCopyCurrentJoints.Location = new Point(351, 119);
        btnCopyCurrentJoints.Name = "btnCopyCurrentJoints";
        btnCopyCurrentJoints.Size = new Size(55, 55);
        btnCopyCurrentJoints.TabIndex = 1;
        btnCopyCurrentJoints.Text = ">>";
        btnCopyCurrentJoints.UseVisualStyleBackColor = true;
        btnCopyCurrentJoints.Click += btnCopyCurrentJoints_Click;
        // 
        // btnCopyCurrentCartesian
        // 
        btnCopyCurrentCartesian.Location = new Point(351, 550);
        btnCopyCurrentCartesian.Name = "btnCopyCurrentCartesian";
        btnCopyCurrentCartesian.Size = new Size(55, 55);
        btnCopyCurrentCartesian.TabIndex = 1;
        btnCopyCurrentCartesian.Text = ">>";
        btnCopyCurrentCartesian.UseVisualStyleBackColor = true;
        btnCopyCurrentCartesian.Click += btnCopyCurrentCartesian_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(48, 4);
        label1.Name = "label1";
        label1.Size = new Size(85, 15);
        label1.TabIndex = 2;
        label1.Text = "Current joints :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(48, 262);
        label2.Name = "label2";
        label2.Size = new Size(135, 15);
        label2.TabIndex = 2;
        label2.Text = "Current DH parameters :";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(48, 473);
        label3.Name = "label3";
        label3.Size = new Size(149, 15);
        label3.TabIndex = 2;
        label3.Text = "Current cartesian position :";
        // 
        // gridDH
        // 
        gridDH.HelpVisible = false;
        gridDH.Location = new Point(513, 280);
        gridDH.Name = "gridDH";
        gridDH.PropertySort = PropertySort.NoSort;
        gridDH.Size = new Size(205, 136);
        gridDH.TabIndex = 0;
        gridDH.ToolbarVisible = false;
        // 
        // gridCartesianIK
        // 
        gridCartesianIK.HelpVisible = false;
        gridCartesianIK.Location = new Point(513, 491);
        gridCartesianIK.Name = "gridCartesianIK";
        gridCartesianIK.PropertySort = PropertySort.NoSort;
        gridCartesianIK.Size = new Size(205, 159);
        gridCartesianIK.TabIndex = 0;
        gridCartesianIK.ToolbarVisible = false;
        // 
        // gridJointsFK
        // 
        gridJointsFK.HelpVisible = false;
        gridJointsFK.Location = new Point(513, 22);
        gridJointsFK.Name = "gridJointsFK";
        gridJointsFK.PropertySort = PropertySort.NoSort;
        gridJointsFK.Size = new Size(205, 191);
        gridJointsFK.TabIndex = 0;
        gridJointsFK.ToolbarVisible = false;
        // 
        // gridFKResult
        // 
        gridFKResult.Enabled = false;
        gridFKResult.HelpVisible = false;
        gridFKResult.Location = new Point(979, 81);
        gridFKResult.Name = "gridFKResult";
        gridFKResult.PropertySort = PropertySort.NoSort;
        gridFKResult.Size = new Size(284, 196);
        gridFKResult.TabIndex = 0;
        gridFKResult.ToolbarVisible = false;
        // 
        // btnForwardKinematics
        // 
        btnForwardKinematics.Location = new Point(803, 119);
        btnForwardKinematics.Name = "btnForwardKinematics";
        btnForwardKinematics.Size = new Size(103, 55);
        btnForwardKinematics.TabIndex = 1;
        btnForwardKinematics.Text = "Forward kinematics";
        btnForwardKinematics.UseVisualStyleBackColor = true;
        btnForwardKinematics.Click += btnForwardKinematics_Click;
        // 
        // btnInvertKinematics
        // 
        btnInvertKinematics.Location = new Point(803, 550);
        btnInvertKinematics.Name = "btnInvertKinematics";
        btnInvertKinematics.Size = new Size(103, 55);
        btnInvertKinematics.TabIndex = 1;
        btnInvertKinematics.Text = "Invert kinematics";
        btnInvertKinematics.UseVisualStyleBackColor = true;
        btnInvertKinematics.Click += btnInvertKinematics_Click;
        // 
        // lstIKResults
        // 
        lstIKResults.Columns.AddRange(new ColumnHeader[] { columnId, columnJ1, columnJ2, columnJ3, columnJ4, columnJ5, columnJ6 });
        lstIKResults.FullRowSelect = true;
        lstIKResults.Items.AddRange(new ListViewItem[] { listViewItem1 });
        lstIKResults.Location = new Point(979, 491);
        lstIKResults.Name = "lstIKResults";
        lstIKResults.Size = new Size(390, 249);
        lstIKResults.TabIndex = 3;
        lstIKResults.UseCompatibleStateImageBehavior = false;
        lstIKResults.View = View.Details;
        // 
        // columnId
        // 
        columnId.Text = "ID";
        columnId.Width = 25;
        // 
        // columnJ1
        // 
        columnJ1.Text = "J1";
        // 
        // columnJ2
        // 
        columnJ2.Text = "J2";
        // 
        // columnJ3
        // 
        columnJ3.Text = "J3";
        // 
        // columnJ4
        // 
        columnJ4.Text = "J4";
        // 
        // columnJ5
        // 
        columnJ5.Text = "J5";
        // 
        // columnJ6
        // 
        columnJ6.Text = "J6";
        // 
        // btnCopyFKResult
        // 
        btnCopyFKResult.Location = new Point(824, 280);
        btnCopyFKResult.Name = "btnCopyFKResult";
        btnCopyFKResult.Size = new Size(55, 55);
        btnCopyFKResult.TabIndex = 1;
        btnCopyFKResult.Text = "<<";
        btnCopyFKResult.UseVisualStyleBackColor = true;
        btnCopyFKResult.Click += btnCopyFKResult_Click;
        // 
        // BtnCopyIKSelectedResult
        // 
        BtnCopyIKSelectedResult.Location = new Point(824, 345);
        BtnCopyIKSelectedResult.Name = "BtnCopyIKSelectedResult";
        BtnCopyIKSelectedResult.Size = new Size(55, 55);
        BtnCopyIKSelectedResult.TabIndex = 1;
        BtnCopyIKSelectedResult.Text = "<<";
        BtnCopyIKSelectedResult.UseVisualStyleBackColor = true;
        BtnCopyIKSelectedResult.Click += BtnCopyIKSelectedResult_Click;
        // 
        // cbModele
        // 
        cbModele.DropDownStyle = ComboBoxStyle.DropDownList;
        cbModele.FormattingEnabled = true;
        cbModele.Location = new Point(3, 8);
        cbModele.Name = "cbModele";
        cbModele.Size = new Size(143, 23);
        cbModele.TabIndex = 4;
        // 
        // btnImportDH
        // 
        btnImportDH.Location = new Point(3, 37);
        btnImportDH.Name = "btnImportDH";
        btnImportDH.Size = new Size(143, 51);
        btnImportDH.TabIndex = 1;
        btnImportDH.Text = "Import DH parameters";
        btnImportDH.UseVisualStyleBackColor = true;
        btnImportDH.Click += btnImportDH_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(306, 262);
        label4.Name = "label4";
        label4.Size = new Size(108, 15);
        label4.TabIndex = 2;
        label4.Text = "Robot modele DH :";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(513, 4);
        label5.Name = "label5";
        label5.Size = new Size(165, 15);
        label5.TabIndex = 2;
        label5.Text = "Joints for forward kinematics :";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(513, 262);
        label6.Name = "label6";
        label6.Size = new Size(162, 15);
        label6.TabIndex = 5;
        label6.Text = "DH parameters for FK and IK :";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(513, 473);
        label7.Name = "label7";
        label7.Size = new Size(219, 15);
        label7.TabIndex = 2;
        label7.Text = "Cartesian position for invert kinematics :";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(979, 473);
        label8.Name = "label8";
        label8.Size = new Size(154, 15);
        label8.TabIndex = 2;
        label8.Text = "Invert kinematics solutions :";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(979, 63);
        label9.Name = "label9";
        label9.Size = new Size(148, 15);
        label9.TabIndex = 2;
        label9.Text = "Forward kinematics result :";
        // 
        // panel1
        // 
        panel1.BackColor = Color.White;
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(cbModele);
        panel1.Controls.Add(btnImportDH);
        panel1.Location = new Point(306, 280);
        panel1.Name = "panel1";
        panel1.Size = new Size(152, 89);
        panel1.TabIndex = 6;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.ik_diagram_background_drawio;
        pictureBox1.Location = new Point(44, 68);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(1343, 621);
        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        pictureBox1.TabIndex = 7;
        pictureBox1.TabStop = false;
        // 
        // btnReadCurrentJoints
        // 
        btnReadCurrentJoints.Location = new Point(48, 218);
        btnReadCurrentJoints.Name = "btnReadCurrentJoints";
        btnReadCurrentJoints.Size = new Size(205, 27);
        btnReadCurrentJoints.TabIndex = 1;
        btnReadCurrentJoints.Text = "Read";
        btnReadCurrentJoints.UseVisualStyleBackColor = true;
        btnReadCurrentJoints.Click += btnReadCurrentJoints_Click;
        // 
        // btnReadCurrentDh
        // 
        btnReadCurrentDh.Location = new Point(48, 422);
        btnReadCurrentDh.Name = "btnReadCurrentDh";
        btnReadCurrentDh.Size = new Size(205, 27);
        btnReadCurrentDh.TabIndex = 1;
        btnReadCurrentDh.Text = "Read";
        btnReadCurrentDh.UseVisualStyleBackColor = true;
        btnReadCurrentDh.Click += btnReadCurrentDh_Click;
        // 
        // btnReadCurrentCartesianPosition
        // 
        btnReadCurrentCartesianPosition.Location = new Point(48, 713);
        btnReadCurrentCartesianPosition.Name = "btnReadCurrentCartesianPosition";
        btnReadCurrentCartesianPosition.Size = new Size(205, 27);
        btnReadCurrentCartesianPosition.TabIndex = 1;
        btnReadCurrentCartesianPosition.Text = "Read";
        btnReadCurrentCartesianPosition.UseVisualStyleBackColor = true;
        btnReadCurrentCartesianPosition.Click += btnReadCurrentCartesianPosition_Click;
        // 
        // KinematicsControl
        // 
        AutoScaleMode = AutoScaleMode.None;
        AutoScroll = true;
        Controls.Add(panel1);
        Controls.Add(label4);
        Controls.Add(label6);
        Controls.Add(lstIKResults);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(label9);
        Controls.Add(label5);
        Controls.Add(label1);
        Controls.Add(btnCopyCurrentCartesian);
        Controls.Add(btnInvertKinematics);
        Controls.Add(btnForwardKinematics);
        Controls.Add(BtnCopyIKSelectedResult);
        Controls.Add(btnCopyFKResult);
        Controls.Add(btnReadCurrentCartesianPosition);
        Controls.Add(btnReadCurrentDh);
        Controls.Add(btnReadCurrentJoints);
        Controls.Add(btnCopyCurrentJoints);
        Controls.Add(gridJointsFK);
        Controls.Add(gridFKResult);
        Controls.Add(gridCartesianIK);
        Controls.Add(gridCurrentJoints);
        Controls.Add(gridDH);
        Controls.Add(gridCurrentCartesian);
        Controls.Add(gridCurrentDh);
        Controls.Add(pictureBox1);
        Margin = new Padding(4, 3, 4, 3);
        Name = "KinematicsControl";
        Size = new Size(1451, 802);
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PropertyGrid gridCurrentCartesian;
    private PropertyGrid gridCurrentDh;
    private PropertyGrid gridCurrentJoints;
    private Button btnCopyCurrentJoints;
    private Button btnCopyCurrentCartesian;
    private Label label1;
    private Label label2;
    private Label label3;
    private PropertyGrid gridDH;
    private PropertyGrid gridCartesianIK;
    private PropertyGrid gridJointsFK;
    private PropertyGrid gridFKResult;
    private Button btnForwardKinematics;
    private Button btnInvertKinematics;
    private ListView lstIKResults;
    private ColumnHeader columnId;
    private ColumnHeader columnJ1;
    private ColumnHeader columnJ2;
    private ColumnHeader columnJ3;
    private ColumnHeader columnJ4;
    private ColumnHeader columnJ5;
    private ColumnHeader columnJ6;
    private Button btnCopyFKResult;
    private Button BtnCopyIKSelectedResult;
    private ComboBox cbModele;
    private Button btnImportDH;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Panel panel1;
    private PictureBox pictureBox1;
    private Button btnReadCurrentJoints;
    private Button btnReadCurrentDh;
    private Button btnReadCurrentCartesianPosition;
}
