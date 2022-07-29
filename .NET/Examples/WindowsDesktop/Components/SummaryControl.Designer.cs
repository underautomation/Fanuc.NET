
    partial class SummaryControl
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
            this.grid = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.HelpVisible = false;
            this.grid.Location = new System.Drawing.Point(24, 26);
            this.grid.Name = "grid";
            this.grid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.grid.Size = new System.Drawing.Size(452, 402);
            this.grid.TabIndex = 0;
            this.grid.ToolbarVisible = false;
            // 
            // SummaryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "SummaryControl";
            this.Size = new System.Drawing.Size(820, 589);
            this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.PropertyGrid grid;
}
