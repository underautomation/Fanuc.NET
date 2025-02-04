
partial class ContactControl
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
        label1 = new Label();
        label2 = new Label();
        txtEmail = new TextBox();
        label3 = new Label();
        label4 = new Label();
        txtMessage = new TextBox();
        btnSend = new Button();
        emailErrorProvider = new ErrorProvider(components);
        textBox1 = new TextBox();
        chkAnonymous = new CheckBox();
        textBox2 = new TextBox();
        ((System.ComponentModel.ISupportInitialize)emailErrorProvider).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Dock = DockStyle.Top;
        label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(0, 0);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(957, 95);
        label1.TabIndex = 0;
        label1.Text = "If you have any problems, please don't get stuck !";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Dock = DockStyle.Top;
        label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(0, 95);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(957, 88);
        label2.TabIndex = 1;
        label2.Text = "it's a shame when we can help you so quickly. This way you'll have all the information you need to get an idea of what this library can do.";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(127, 250);
        txtEmail.Margin = new Padding(4, 3, 4, 3);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(446, 23);
        txtEmail.TabIndex = 2;
        txtEmail.TextChanged += txtEmail_TextChanged;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(26, 254);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(69, 15);
        label3.TabIndex = 3;
        label3.Text = "Your email :";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(26, 332);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(59, 15);
        label4.TabIndex = 3;
        label4.Text = "Message :";
        // 
        // txtMessage
        // 
        txtMessage.Location = new Point(29, 367);
        txtMessage.Margin = new Padding(4, 3, 4, 3);
        txtMessage.Multiline = true;
        txtMessage.Name = "txtMessage";
        txtMessage.Size = new Size(544, 232);
        txtMessage.TabIndex = 2;
        txtMessage.Text = "Hi, \r\n\r\n";
        // 
        // btnSend
        // 
        btnSend.Location = new Point(206, 622);
        btnSend.Margin = new Padding(4, 3, 4, 3);
        btnSend.Name = "btnSend";
        btnSend.Size = new Size(195, 27);
        btnSend.TabIndex = 4;
        btnSend.Text = "Send";
        btnSend.UseVisualStyleBackColor = true;
        btnSend.Click += btnSend_Click;
        // 
        // emailErrorProvider
        // 
        emailErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        emailErrorProvider.ContainerControl = this;
        // 
        // textBox1
        // 
        textBox1.BorderStyle = BorderStyle.None;
        textBox1.Dock = DockStyle.Top;
        textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox1.Location = new Point(0, 183);
        textBox1.Margin = new Padding(4, 3, 4, 3);
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(957, 19);
        textBox1.TabIndex = 6;
        textBox1.Text = "You can also send an email to support@underautomation.com";
        textBox1.TextAlign = HorizontalAlignment.Center;
        // 
        // chkAnonymous
        // 
        chkAnonymous.AutoSize = true;
        chkAnonymous.Location = new Point(127, 280);
        chkAnonymous.Margin = new Padding(4, 3, 4, 3);
        chkAnonymous.Name = "chkAnonymous";
        chkAnonymous.Size = new Size(325, 19);
        chkAnonymous.TabIndex = 7;
        chkAnonymous.Text = "I prefer to remain anonymous and not provide my email.";
        chkAnonymous.UseVisualStyleBackColor = true;
        chkAnonymous.CheckedChanged += chkAnonymous_CheckedChanged;
        // 
        // textBox2
        // 
        textBox2.BorderStyle = BorderStyle.None;
        textBox2.Dock = DockStyle.Top;
        textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox2.Location = new Point(0, 202);
        textBox2.Margin = new Padding(4, 3, 4, 3);
        textBox2.Name = "textBox2";
        textBox2.ReadOnly = true;
        textBox2.Size = new Size(957, 19);
        textBox2.TabIndex = 8;
        textBox2.Text = "Or call : +33 4 87 24 69 80";
        textBox2.TextAlign = HorizontalAlignment.Center;
        // 
        // ContactControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(textBox2);
        Controls.Add(chkAnonymous);
        Controls.Add(textBox1);
        Controls.Add(btnSend);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(txtMessage);
        Controls.Add(txtEmail);
        Controls.Add(label2);
        Controls.Add(label1);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ContactControl";
        Size = new Size(957, 680);
        ((System.ComponentModel.ISupportInitialize)emailErrorProvider).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtMessage;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.ErrorProvider emailErrorProvider;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.CheckBox chkAnonymous;
    private TextBox textBox2;
}
