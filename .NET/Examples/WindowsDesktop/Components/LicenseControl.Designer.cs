
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
            this.txtLicenseInfo = new System.Windows.Forms.RichTextBox();
            this.gridLicense = new System.Windows.Forms.PropertyGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetLicense = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtLicensee = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLicenseInfo
            // 
            this.txtLicenseInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLicenseInfo.Location = new System.Drawing.Point(36, 140);
            this.txtLicenseInfo.Name = "txtLicenseInfo";
            this.txtLicenseInfo.ReadOnly = true;
            this.txtLicenseInfo.Size = new System.Drawing.Size(459, 109);
            this.txtLicenseInfo.TabIndex = 6;
            this.txtLicenseInfo.Text = "";
            // 
            // gridLicense
            // 
            this.gridLicense.HelpVisible = false;
            this.gridLicense.Location = new System.Drawing.Point(36, 255);
            this.gridLicense.Name = "gridLicense";
            this.gridLicense.Size = new System.Drawing.Size(459, 200);
            this.gridLicense.TabIndex = 7;
            this.gridLicense.ToolbarVisible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetLicense);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.txtLicensee);
            this.groupBox1.Location = new System.Drawing.Point(36, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 121);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add your license key";
            // 
            // btnSetLicense
            // 
            this.btnSetLicense.Location = new System.Drawing.Point(73, 86);
            this.btnSetLicense.Name = "btnSetLicense";
            this.btnSetLicense.Size = new System.Drawing.Size(127, 24);
            this.btnSetLicense.TabIndex = 2;
            this.btnSetLicense.Text = "Set License";
            this.btnSetLicense.UseVisualStyleBackColor = true;
            this.btnSetLicense.Click += new System.EventHandler(this.btnSetLicense_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Licensee :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(73, 60);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(380, 20);
            this.txtKey.TabIndex = 0;
            this.txtKey.UseSystemPasswordChar = true;
            // 
            // txtLicensee
            // 
            this.txtLicensee.Location = new System.Drawing.Point(73, 33);
            this.txtLicensee.Name = "txtLicensee";
            this.txtLicensee.Size = new System.Drawing.Size(380, 20);
            this.txtLicensee.TabIndex = 0;
            // 
            // LicenseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridLicense);
            this.Controls.Add(this.txtLicenseInfo);
            this.Name = "LicenseControl";
            this.Size = new System.Drawing.Size(820, 589);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
