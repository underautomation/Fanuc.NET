
    partial class SnpxWritePosition : Form
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnpxWritePosition));
        gridCartesian = new PropertyGrid();
        gridJoints = new PropertyGrid();
        label1 = new Label();
        label2 = new Label();
        btnWriteCartesian = new Button();
        btnWriteJoints = new Button();
        SuspendLayout();
        // 
        // gridCartesian
        // 
        gridCartesian.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridCartesian.HelpVisible = false;
        gridCartesian.Location = new Point(17, 44);
        gridCartesian.Margin = new Padding(4, 3, 4, 3);
        gridCartesian.Name = "gridCartesian";
        gridCartesian.PropertySort = PropertySort.NoSort;
        gridCartesian.Size = new Size(265, 336);
        gridCartesian.TabIndex = 4;
        gridCartesian.ToolbarVisible = false;
        // 
        // gridJoints
        // 
        gridJoints.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridJoints.HelpVisible = false;
        gridJoints.Location = new Point(339, 44);
        gridJoints.Margin = new Padding(4, 3, 4, 3);
        gridJoints.Name = "gridJoints";
        gridJoints.PropertySort = PropertySort.NoSort;
        gridJoints.Size = new Size(265, 336);
        gridJoints.TabIndex = 4;
        gridJoints.ToolbarVisible = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(17, 26);
        label1.Name = "label1";
        label1.Size = new Size(108, 15);
        label1.TabIndex = 5;
        label1.Text = "Cartesian position :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(339, 26);
        label2.Name = "label2";
        label2.Size = new Size(89, 15);
        label2.TabIndex = 5;
        label2.Text = "Joints position :";
        // 
        // btnWriteCartesian
        // 
        btnWriteCartesian.DialogResult = DialogResult.OK;
        btnWriteCartesian.Location = new Point(73, 386);
        btnWriteCartesian.Name = "btnWriteCartesian";
        btnWriteCartesian.Size = new Size(147, 23);
        btnWriteCartesian.TabIndex = 6;
        btnWriteCartesian.Text = "Write cartesian position";
        btnWriteCartesian.UseVisualStyleBackColor = true;
        btnWriteCartesian.Click += btnWriteCartesian_Click;
        // 
        // btnWriteJoints
        // 
        btnWriteJoints.DialogResult = DialogResult.OK;
        btnWriteJoints.Location = new Point(396, 386);
        btnWriteJoints.Name = "btnWriteJoints";
        btnWriteJoints.Size = new Size(147, 23);
        btnWriteJoints.TabIndex = 6;
        btnWriteJoints.Text = "Write joints position";
        btnWriteJoints.UseVisualStyleBackColor = true;
        // 
        // SnpxWritePosition
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnWriteJoints);
        Controls.Add(btnWriteCartesian);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(gridJoints);
        Controls.Add(gridCartesian);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "SnpxWritePosition";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Write position";
        TopMost = true;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PropertyGrid gridCartesian;
        private PropertyGrid gridJoints;
        private Label label1;
        private Label label2;
        private Button btnWriteCartesian;
        private Button btnWriteJoints;
    }
