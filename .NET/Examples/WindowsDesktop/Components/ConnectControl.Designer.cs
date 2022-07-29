
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblConnected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTelnet = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtTelnetKclPassword = new System.Windows.Forms.TextBox();
            this.chkFtp = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFtpUser = new System.Windows.Forms.TextBox();
            this.txtFtpPassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblConnected, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkTelnet, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtTelnetKclPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkFtp, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtFtpUser, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtFtpPassword, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 227);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // lblConnected
            // 
            this.lblConnected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConnected.Location = new System.Drawing.Point(92, 230);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(191, 25);
            this.lblConnected.TabIndex = 19;
            this.lblConnected.Text = "______";
            this.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP address :";
            // 
            // txtIP
            // 
            this.txtIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIP.Location = new System.Drawing.Point(92, 3);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(191, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "192.168.0.1";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "KCL Password :";
            // 
            // chkTelnet
            // 
            this.chkTelnet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkTelnet.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkTelnet, 2);
            this.chkTelnet.Location = new System.Drawing.Point(92, 44);
            this.chkTelnet.Name = "chkTelnet";
            this.chkTelnet.Size = new System.Drawing.Size(115, 17);
            this.chkTelnet.TabIndex = 4;
            this.chkTelnet.Text = "Enable Telnet KCL";
            this.chkTelnet.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(92, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 29);
            this.panel1.TabIndex = 12;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConnect.Location = new System.Drawing.Point(0, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 29);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDisconnect.Location = new System.Drawing.Point(99, 0);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(92, 29);
            this.btnDisconnect.TabIndex = 18;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtTelnetKclPassword
            // 
            this.txtTelnetKclPassword.Location = new System.Drawing.Point(92, 68);
            this.txtTelnetKclPassword.Name = "txtTelnetKclPassword";
            this.txtTelnetKclPassword.Size = new System.Drawing.Size(100, 20);
            this.txtTelnetKclPassword.TabIndex = 20;
            // 
            // chkFtp
            // 
            this.chkFtp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkFtp.AutoSize = true;
            this.chkFtp.Location = new System.Drawing.Point(92, 109);
            this.chkFtp.Name = "chkFtp";
            this.chkFtp.Size = new System.Drawing.Size(82, 17);
            this.chkFtp.TabIndex = 4;
            this.chkFtp.Text = "Enable FTP";
            this.chkFtp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "FTP user :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "FTP password :";
            // 
            // txtFtpUser
            // 
            this.txtFtpUser.Location = new System.Drawing.Point(92, 133);
            this.txtFtpUser.Name = "txtFtpUser";
            this.txtFtpUser.Size = new System.Drawing.Size(100, 20);
            this.txtFtpUser.TabIndex = 20;
            // 
            // txtFtpPassword
            // 
            this.txtFtpPassword.Location = new System.Drawing.Point(92, 158);
            this.txtFtpPassword.Name = "txtFtpPassword";
            this.txtFtpPassword.Size = new System.Drawing.Size(100, 20);
            this.txtFtpPassword.TabIndex = 20;
            // 
            // ConnectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConnectControl";
            this.Size = new System.Drawing.Size(935, 720);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
}
