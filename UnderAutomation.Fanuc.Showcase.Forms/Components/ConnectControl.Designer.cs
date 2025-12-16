
partial class ConnectControl
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
        components = new System.ComponentModel.Container();
        tableLayoutPanel1 = new TableLayoutPanel();
        lblConnected = new Label();
        label1 = new Label();
        txtIP = new TextBox();
        label5 = new Label();
        chkTelnet = new CheckBox();
        panel1 = new Panel();
        btnConnect = new Button();
        btnDisconnect = new Button();
        txtTelnetKclPassword = new TextBox();
        chkFtp = new CheckBox();
        label2 = new Label();
        label3 = new Label();
        txtFtpUser = new TextBox();
        txtFtpPassword = new TextBox();
        chkSnpx = new CheckBox();
        chkRmi = new CheckBox();
        label4 = new Label();
        cbLanguage = new ComboBox();
        addressTooltip = new ToolTip(components);
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 205F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.Controls.Add(lblConnected, 1, 16);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(txtIP, 1, 0);
        tableLayoutPanel1.Controls.Add(label5, 0, 5);
        tableLayoutPanel1.Controls.Add(chkTelnet, 1, 4);
        tableLayoutPanel1.Controls.Add(panel1, 1, 15);
        tableLayoutPanel1.Controls.Add(txtTelnetKclPassword, 1, 5);
        tableLayoutPanel1.Controls.Add(chkFtp, 1, 7);
        tableLayoutPanel1.Controls.Add(label2, 0, 8);
        tableLayoutPanel1.Controls.Add(label3, 0, 9);
        tableLayoutPanel1.Controls.Add(txtFtpUser, 1, 8);
        tableLayoutPanel1.Controls.Add(txtFtpPassword, 1, 9);
        tableLayoutPanel1.Controls.Add(chkSnpx, 1, 11);
        tableLayoutPanel1.Controls.Add(chkRmi, 1, 13);
        tableLayoutPanel1.Controls.Add(label4, 0, 2);
        tableLayoutPanel1.Controls.Add(cbLanguage, 1, 2);
        tableLayoutPanel1.Location = new Point(21, 32);
        tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 18;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.Size = new Size(628, 585);
        tableLayoutPanel1.TabIndex = 10;
        // 
        // lblConnected
        // 
        lblConnected.Dock = DockStyle.Fill;
        lblConnected.Location = new Point(209, 443);
        lblConnected.Margin = new Padding(4, 0, 4, 0);
        lblConnected.Name = "lblConnected";
        lblConnected.Size = new Size(242, 29);
        lblConnected.TabIndex = 19;
        lblConnected.Text = "______";
        lblConnected.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Cursor = Cursors.Help;
        label1.Location = new Point(16, 12);
        label1.Margin = new Padding(0);
        label1.Name = "label1";
        label1.Size = new Size(189, 45);
        label1.TabIndex = 0;
        label1.Text = "IP address\r\nor\r\nPath to RoboGuide robot directory";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        addressTooltip.SetToolTip(label1, "192.168.0.1\r\nC:\\Fanuc\\MyCell\\Myrobot\r\n\\\\my-dev-machine\\MyCell\\MyRobot");
        // 
        // txtIP
        // 
        txtIP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel1.SetColumnSpan(txtIP, 2);
        txtIP.Cursor = Cursors.Help;
        txtIP.Location = new Point(209, 23);
        txtIP.Margin = new Padding(4, 3, 4, 3);
        txtIP.Name = "txtIP";
        txtIP.Size = new Size(415, 23);
        txtIP.TabIndex = 1;
        txtIP.Text = "192.168.0.1";
        addressTooltip.SetToolTip(txtIP, "192.168.0.1\r\nC:\\Fanuc\\MyCell\\MyRobot\r\n\\\\my-dev-machine\\MyCell\\MyRobot\r\n");
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Right;
        label5.AutoSize = true;
        label5.Location = new Point(119, 168);
        label5.Margin = new Padding(0);
        label5.Name = "label5";
        label5.Size = new Size(86, 15);
        label5.TabIndex = 0;
        label5.Text = "KCL Password :";
        // 
        // chkTelnet
        // 
        chkTelnet.Anchor = AnchorStyles.Left;
        chkTelnet.AutoSize = true;
        tableLayoutPanel1.SetColumnSpan(chkTelnet, 2);
        chkTelnet.Location = new Point(209, 137);
        chkTelnet.Margin = new Padding(4, 3, 4, 3);
        chkTelnet.Name = "chkTelnet";
        chkTelnet.Size = new Size(231, 19);
        chkTelnet.TabIndex = 4;
        chkTelnet.Text = "Enable remote commands (Telnet KCL)";
        chkTelnet.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnConnect);
        panel1.Controls.Add(btnDisconnect);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(209, 406);
        panel1.Margin = new Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(242, 34);
        panel1.TabIndex = 12;
        // 
        // btnConnect
        // 
        btnConnect.Dock = DockStyle.Left;
        btnConnect.Location = new Point(0, 0);
        btnConnect.Margin = new Padding(4, 3, 4, 3);
        btnConnect.Name = "btnConnect";
        btnConnect.Size = new Size(112, 34);
        btnConnect.TabIndex = 17;
        btnConnect.Text = "Connect";
        btnConnect.UseVisualStyleBackColor = true;
        btnConnect.Click += btnConnect_Click;
        // 
        // btnDisconnect
        // 
        btnDisconnect.Dock = DockStyle.Right;
        btnDisconnect.Location = new Point(135, 0);
        btnDisconnect.Margin = new Padding(4, 3, 4, 3);
        btnDisconnect.Name = "btnDisconnect";
        btnDisconnect.Size = new Size(107, 34);
        btnDisconnect.TabIndex = 18;
        btnDisconnect.Text = "Disconnect";
        btnDisconnect.UseVisualStyleBackColor = true;
        btnDisconnect.Click += btnDisconnect_Click;
        // 
        // txtTelnetKclPassword
        // 
        txtTelnetKclPassword.Location = new Point(209, 164);
        txtTelnetKclPassword.Margin = new Padding(4, 3, 4, 3);
        txtTelnetKclPassword.Name = "txtTelnetKclPassword";
        txtTelnetKclPassword.Size = new Size(116, 23);
        txtTelnetKclPassword.TabIndex = 20;
        // 
        // chkFtp
        // 
        chkFtp.Anchor = AnchorStyles.Left;
        chkFtp.AutoSize = true;
        chkFtp.Location = new Point(209, 212);
        chkFtp.Margin = new Padding(4, 3, 4, 3);
        chkFtp.Name = "chkFtp";
        chkFtp.Size = new Size(177, 19);
        chkFtp.TabIndex = 4;
        chkFtp.Text = "Enable memory access (FTP)";
        chkFtp.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(147, 243);
        label2.Margin = new Padding(0);
        label2.Name = "label2";
        label2.Size = new Size(58, 15);
        label2.TabIndex = 0;
        label2.Text = "FTP user :";
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(119, 272);
        label3.Margin = new Padding(0);
        label3.Name = "label3";
        label3.Size = new Size(86, 15);
        label3.TabIndex = 0;
        label3.Text = "FTP password :";
        // 
        // txtFtpUser
        // 
        txtFtpUser.Location = new Point(209, 239);
        txtFtpUser.Margin = new Padding(4, 3, 4, 3);
        txtFtpUser.Name = "txtFtpUser";
        txtFtpUser.Size = new Size(116, 23);
        txtFtpUser.TabIndex = 20;
        // 
        // txtFtpPassword
        // 
        txtFtpPassword.Location = new Point(209, 268);
        txtFtpPassword.Margin = new Padding(4, 3, 4, 3);
        txtFtpPassword.Name = "txtFtpPassword";
        txtFtpPassword.Size = new Size(116, 23);
        txtFtpPassword.TabIndex = 20;
        // 
        // chkSnpx
        // 
        chkSnpx.Anchor = AnchorStyles.Left;
        chkSnpx.AutoSize = true;
        chkSnpx.Location = new Point(209, 316);
        chkSnpx.Margin = new Padding(4, 3, 4, 3);
        chkSnpx.Name = "chkSnpx";
        chkSnpx.Size = new Size(93, 19);
        chkSnpx.TabIndex = 21;
        chkSnpx.Text = "Enable SNPX";
        chkSnpx.UseVisualStyleBackColor = true;
        // 
        // chkRmi
        // 
        chkRmi.Anchor = AnchorStyles.Left;
        chkRmi.AutoSize = true;
        chkRmi.Location = new Point(209, 362);
        chkRmi.Margin = new Padding(4, 3, 4, 3);
        chkRmi.Name = "chkRmi";
        chkRmi.Size = new Size(228, 19);
        chkRmi.TabIndex = 21;
        chkRmi.Text = "Enable RMI (Remote Motion Interface)";
        chkRmi.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(90, 93);
        label4.Margin = new Padding(0);
        label4.Name = "label4";
        label4.Size = new Size(115, 15);
        label4.TabIndex = 22;
        label4.Text = "Controller Language";
        // 
        // cbLanguage
        // 
        cbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
        cbLanguage.FormattingEnabled = true;
        cbLanguage.Location = new Point(208, 89);
        cbLanguage.Name = "cbLanguage";
        cbLanguage.Size = new Size(121, 23);
        cbLanguage.TabIndex = 23;
        // 
        // addressTooltip
        // 
        addressTooltip.AutomaticDelay = 0;
        addressTooltip.ToolTipIcon = ToolTipIcon.Info;
        addressTooltip.ToolTipTitle = "Examples :";
        addressTooltip.UseAnimation = false;
        addressTooltip.UseFading = false;
        // 
        // ConnectControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ConnectControl";
        Size = new Size(1091, 831);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblConnected;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtIP;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckBox chkTelnet;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.Button btnDisconnect;
    private System.Windows.Forms.TextBox txtTelnetKclPassword;
    private System.Windows.Forms.CheckBox chkFtp;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtFtpUser;
    private System.Windows.Forms.TextBox txtFtpPassword;
    private System.Windows.Forms.ToolTip addressTooltip;
    private System.Windows.Forms.CheckBox chkSnpx;
    private CheckBox chkRmi;
    private Label label4;
    private ComboBox cbLanguage;
}
