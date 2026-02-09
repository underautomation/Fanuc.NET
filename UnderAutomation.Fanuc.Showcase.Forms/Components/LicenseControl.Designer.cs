
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
        groupBox2 = new GroupBox();
        lnkOrder = new LinkLabel();
        lnkLicense = new LinkLabel();
        label5 = new Label();
        label4 = new Label();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // txtLicenseInfo
        // 
        txtLicenseInfo.BackColor = SystemColors.ControlLight;
        txtLicenseInfo.Location = new Point(46, 243);
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
        gridLicense.Location = new Point(46, 375);
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
        groupBox1.Location = new Point(46, 97);
        groupBox1.Margin = new Padding(4, 3, 4, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4, 3, 4, 3);
        groupBox1.Size = new Size(536, 140);
        groupBox1.TabIndex = 8;
        groupBox1.TabStop = false;
        groupBox1.Text = "Enter your license key";
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
        // groupBox2
        // 
        groupBox2.Controls.Add(lnkOrder);
        groupBox2.Controls.Add(lnkLicense);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(label4);
        groupBox2.Location = new Point(46, 3);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(536, 88);
        groupBox2.TabIndex = 9;
        groupBox2.TabStop = false;
        groupBox2.Text = "Get a license";
        // 
        // lnkOrder
        // 
        lnkOrder.AutoSize = true;
        lnkOrder.Location = new Point(220, 54);
        lnkOrder.Name = "lnkOrder";
        lnkOrder.Size = new Size(200, 15);
        lnkOrder.TabIndex = 1;
        lnkOrder.TabStop = true;
        lnkOrder.Text = "https://underautomation.com/order";
        lnkOrder.LinkClicked += lnkOrder_LinkClicked;
        // 
        // lnkLicense
        // 
        lnkLicense.AutoSize = true;
        lnkLicense.Location = new Point(220, 28);
        lnkLicense.Name = "lnkLicense";
        lnkLicense.Size = new Size(208, 15);
        lnkLicense.TabIndex = 1;
        lnkLicense.TabStop = true;
        lnkLicense.Text = "https://underautomation.com/license";
        lnkLicense.LinkClicked += lnkOrder_LinkClicked;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(6, 54);
        label5.Name = "label5";
        label5.Size = new Size(215, 15);
        label5.TabIndex = 0;
        label5.Text = "To get a quote or a lifetime license key :";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(6, 28);
        label4.Name = "label4";
        label4.Size = new Size(208, 15);
        label4.TabIndex = 0;
        label4.Text = "Get your trial licence key immediately:";
        // 
        // LicenseControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(gridLicense);
        Controls.Add(txtLicenseInfo);
        Margin = new Padding(4, 3, 4, 3);
        Name = "LicenseControl";
        Size = new Size(957, 680);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
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
    private GroupBox groupBox2;
    private Label label5;
    private Label label4;
    private LinkLabel lnkOrder;
    private LinkLabel lnkLicense;
}
