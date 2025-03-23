
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
        SuspendLayout();
        // 
        // Joystick
        // 
        Joystick.BackColor = Color.Black;
        Joystick.Location = new Point(178, 70);
        Joystick.Name = "Joystick";
        Joystick.Size = new Size(342, 310);
        Joystick.TabIndex = 0;
        // 
        // bw
        // 
        bw.WorkerSupportsCancellation = true;
        bw.DoWork += bw_DoWork;
        // 
        // DpmControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(Joystick);
        Margin = new Padding(4, 3, 4, 3);
        Name = "DpmControl";
        Size = new Size(757, 521);
        ResumeLayout(false);
    }

    #endregion

    private Dpm3DJoystickControl Joystick;
    private System.ComponentModel.BackgroundWorker bw;
}
