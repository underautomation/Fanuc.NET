
    partial class TelnetControl
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
        KclControl = new KclControl();
        SuspendLayout();
        // 
        // KclControl
        // 
        KclControl.Dock = DockStyle.Fill;
        KclControl.Location = new Point(0, 0);
        KclControl.Margin = new Padding(4, 3, 4, 3);
        KclControl.Name = "KclControl";
        KclControl.Size = new Size(990, 848);
        KclControl.SupportVariableParse = false;
        KclControl.TabIndex = 0;
        // 
        // TelnetControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(KclControl);
        Margin = new Padding(4, 3, 4, 3);
        Name = "TelnetControl";
        Size = new Size(990, 848);
        ResumeLayout(false);
    }

    #endregion

    private KclControl KclControl;
}
