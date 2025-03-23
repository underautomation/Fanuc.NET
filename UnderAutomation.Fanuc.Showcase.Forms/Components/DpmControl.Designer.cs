
    partial class DpmControl
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
        Joystick = new Dpm3DJoystickControl();
        bw = new System.ComponentModel.BackgroundWorker();
        btnSend = new Button();
        txtPrg = new TextBox();
        btnStart = new Button();
        btnStop = new Button();
        lnk = new LinkLabel();
        SuspendLayout();
        // 
        // Joystick
        // 
        Joystick.BackColor = Color.Black;
        Joystick.Location = new Point(293, 53);
        Joystick.Name = "Joystick";
        Joystick.Size = new Size(342, 310);
        Joystick.TabIndex = 0;
        // 
        // bw
        // 
        bw.WorkerSupportsCancellation = true;
        bw.DoWork += bw_DoWork;
        // 
        // btnSend
        // 
        btnSend.Location = new Point(65, 53);
        btnSend.Name = "btnSend";
        btnSend.Size = new Size(133, 23);
        btnSend.TabIndex = 1;
        btnSend.Text = "Send program";
        btnSend.UseVisualStyleBackColor = true;
        btnSend.Click += btnSend_Click;
        // 
        // txtPrg
        // 
        txtPrg.Location = new Point(19, 82);
        txtPrg.Multiline = true;
        txtPrg.Name = "txtPrg";
        txtPrg.Size = new Size(238, 281);
        txtPrg.TabIndex = 2;
        // 
        // btnStart
        // 
        btnStart.Location = new Point(293, 24);
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(75, 23);
        btnStart.TabIndex = 1;
        btnStart.Text = "Start";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Click += btnStart_Click;
        // 
        // btnStop
        // 
        btnStop.Location = new Point(394, 24);
        btnStop.Name = "btnStop";
        btnStop.Size = new Size(75, 23);
        btnStop.TabIndex = 1;
        btnStop.Text = "Stop";
        btnStop.UseVisualStyleBackColor = true;
        btnStop.Click += btnStop_Click;
        // 
        // lnk
        // 
        lnk.AutoSize = true;
        lnk.Location = new Point(19, 24);
        lnk.Name = "lnk";
        lnk.Size = new Size(198, 15);
        lnk.TabIndex = 3;
        lnk.TabStop = true;
        lnk.Text = "How to use ? Read the related article";
        lnk.LinkClicked += lnk_LinkClicked;
        // 
        // DpmControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(lnk);
        Controls.Add(txtPrg);
        Controls.Add(btnStop);
        Controls.Add(btnStart);
        Controls.Add(btnSend);
        Controls.Add(Joystick);
        Margin = new Padding(4, 3, 4, 3);
        Name = "DpmControl";
        Size = new Size(757, 521);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Dpm3DJoystickControl Joystick;
    private System.ComponentModel.BackgroundWorker bw;
    private Button btnSend;
    private TextBox txtPrg;
    private Button btnStart;
    private Button btnStop;
    private LinkLabel lnk;
}
