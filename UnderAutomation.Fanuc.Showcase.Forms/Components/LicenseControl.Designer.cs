
    partial class LicenseControl
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
        txtLicenseInfo = new RichTextBox();
        gridLicense = new PropertyGrid();
        groupBox1 = new GroupBox();
        btnSetLicense = new Button();
        label2 = new Label();
        label1 = new Label();
        txtKey = new TextBox();
        txtLicensee = new TextBox();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // txtLicenseInfo
        // 
        txtLicenseInfo.BackColor = SystemColors.ControlLight;
        txtLicenseInfo.Location = new Point(42, 162);
        txtLicenseInfo.Margin = new Padding(4, 3, 4, 3);
        txtLicenseInfo.Name = "txtLicenseInfo";
        txtLicenseInfo.ReadOnly = true;
        txtLicenseInfo.Size = new Size(535, 125);
        txtLicenseInfo.TabIndex = 6;
        txtLicenseInfo.Text = "";
        txtLicenseInfo.LinkClicked += txtLicenseInfo_LinkClicked;
        // 
        // gridLicense
        // 
        gridLicense.HelpVisible = false;
        gridLicense.Location = new Point(42, 294);
        gridLicense.Margin = new Padding(4, 3, 4, 3);
        gridLicense.Name = "gridLicense";
        gridLicense.Size = new Size(536, 231);
        gridLicense.TabIndex = 7;
        gridLicense.ToolbarVisible = false;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnSetLicense);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(txtKey);
        groupBox1.Controls.Add(txtLicensee);
        groupBox1.Location = new Point(42, 3);
        groupBox1.Margin = new Padding(4, 3, 4, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4, 3, 4, 3);
        groupBox1.Size = new Size(536, 140);
        groupBox1.TabIndex = 8;
        groupBox1.TabStop = false;
        groupBox1.Text = "Add your license key";
        // 
        // btnSetLicense
        // 
        btnSetLicense.Location = new Point(85, 99);
        btnSetLicense.Margin = new Padding(4, 3, 4, 3);
        btnSetLicense.Name = "btnSetLicense";
        btnSetLicense.Size = new Size(148, 28);
        btnSetLicense.TabIndex = 2;
        btnSetLicense.Text = "Set License";
        btnSetLicense.UseVisualStyleBackColor = true;
        btnSetLicense.Click += btnSetLicense_Click;
        // 
        // label2
        // 
        label2.Location = new Point(4, 67);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(75, 27);
        label2.TabIndex = 1;
        label2.Text = "Key :";
        label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label1
        // 
        label1.Location = new Point(4, 36);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(75, 27);
        label1.TabIndex = 1;
        label1.Text = "Licensee :";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtKey
        // 
        txtKey.Location = new Point(85, 69);
        txtKey.Margin = new Padding(4, 3, 4, 3);
        txtKey.Name = "txtKey";
        txtKey.Size = new Size(443, 23);
        txtKey.TabIndex = 0;
        txtKey.UseSystemPasswordChar = true;
        // 
        // txtLicensee
        // 
        txtLicensee.Location = new Point(85, 38);
        txtLicensee.Margin = new Padding(4, 3, 4, 3);
        txtLicensee.Name = "txtLicensee";
        txtLicensee.Size = new Size(443, 23);
        txtLicensee.TabIndex = 0;
        // 
        // LicenseControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Controls.Add(gridLicense);
        Controls.Add(txtLicenseInfo);
        Margin = new Padding(4, 3, 4, 3);
        Name = "LicenseControl";
        Size = new Size(957, 680);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    internal System.Windows.Forms.RichTextBox txtLicenseInfo;
    private System.Windows.Forms.PropertyGrid gridLicense;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.TextBox txtLicensee;
    private System.Windows.Forms.Button btnSetLicense;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
}
