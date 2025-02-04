
    partial class CurrentPositionControl
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
            this.Header = new UnderAutomation.Fanuc.Showcase.Forms.Components.HeaderFileControl();
            this.positionGrid = new CustomPropertyGrid();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(849, 68);
            this.Header.TabIndex = 0;
            // 
            // positionGrid
            // 
            this.positionGrid.BackColor = System.Drawing.SystemColors.Window;
            this.positionGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.positionGrid.LabelText = "Current position";
            this.positionGrid.Location = new System.Drawing.Point(0, 68);
            this.positionGrid.Name = "positionGrid";
            this.positionGrid.Size = new System.Drawing.Size(267, 358);
            this.positionGrid.TabIndex = 1;
            // 
            // CurrentPositionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.positionGrid);
            this.Controls.Add(this.Header);
            this.Name = "CurrentPositionControl";
            this.Size = new System.Drawing.Size(849, 426);
            this.ResumeLayout(false);

        }

    #endregion

    private UnderAutomation.Fanuc.Showcase.Forms.Components.HeaderFileControl Header;
    private CustomPropertyGrid positionGrid;
}
