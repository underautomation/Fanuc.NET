
    partial class DiagnosisControl
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
            this.Header = new UnderAutomation.Fanuc.Sample.WindowsDesktop.Components.CyclicReadingFileControl();
            this.positionGrid = new CustomPropertyGrid();
            this.IOStatusGrid = new CustomPropertyGrid();
            this.SafetyGrid = new CustomPropertyGrid();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(10, 10);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(829, 68);
            this.Header.TabIndex = 0;
            // 
            // positionGrid
            // 
            this.positionGrid.BackColor = System.Drawing.SystemColors.Window;
            this.positionGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.positionGrid.LabelText = "Current position";
            this.positionGrid.Location = new System.Drawing.Point(10, 78);
            this.positionGrid.Name = "positionGrid";
            this.positionGrid.Size = new System.Drawing.Size(238, 338);
            this.positionGrid.TabIndex = 1;
            // 
            // IOStatusGrid
            // 
            this.IOStatusGrid.BackColor = System.Drawing.SystemColors.Window;
            this.IOStatusGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IOStatusGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.IOStatusGrid.LabelText = "IO Status";
            this.IOStatusGrid.Location = new System.Drawing.Point(248, 78);
            this.IOStatusGrid.Name = "IOStatusGrid";
            this.IOStatusGrid.Size = new System.Drawing.Size(303, 338);
            this.IOStatusGrid.TabIndex = 2;
            // 
            // SafetyGrid
            // 
            this.SafetyGrid.BackColor = System.Drawing.SystemColors.Window;
            this.SafetyGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SafetyGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.SafetyGrid.LabelText = "Safety";
            this.SafetyGrid.Location = new System.Drawing.Point(551, 78);
            this.SafetyGrid.Name = "SafetyGrid";
            this.SafetyGrid.Size = new System.Drawing.Size(254, 338);
            this.SafetyGrid.TabIndex = 3;
            // 
            // DiagnosisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.SafetyGrid);
            this.Controls.Add(this.IOStatusGrid);
            this.Controls.Add(this.positionGrid);
            this.Controls.Add(this.Header);
            this.Name = "DiagnosisControl";
            this.Size = new System.Drawing.Size(849, 426);
            this.ResumeLayout(false);

        }

    #endregion

    private UnderAutomation.Fanuc.Sample.WindowsDesktop.Components.CyclicReadingFileControl Header;
    private CustomPropertyGrid positionGrid;
    private CustomPropertyGrid IOStatusGrid;
    private CustomPropertyGrid SafetyGrid;
}
