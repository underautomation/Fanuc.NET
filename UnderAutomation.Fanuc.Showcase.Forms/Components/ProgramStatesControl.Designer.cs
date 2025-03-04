
    partial class ProgramStatesControl
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
        Header = new UnderAutomation.Fanuc.Showcase.Forms.Components.HeaderFileControl();
        programStatesGrid = new CustomPropertyGrid();
        SuspendLayout();
        // 
        // Header
        // 
        Header.Dock = DockStyle.Top;
        Header.Location = new Point(0, 0);
        Header.Margin = new Padding(5, 3, 5, 3);
        Header.Name = "Header";
        Header.Size = new Size(990, 78);
        Header.TabIndex = 0;
        // 
        // programStatesGrid
        // 
        programStatesGrid.BackColor = SystemColors.Window;
        programStatesGrid.BorderStyle = BorderStyle.FixedSingle;
        programStatesGrid.Dock = DockStyle.Left;
        programStatesGrid.LabelText = "Program States";
        programStatesGrid.Location = new Point(0, 78);
        programStatesGrid.Margin = new Padding(5, 3, 5, 3);
        programStatesGrid.Name = "programStatesGrid";
        programStatesGrid.Size = new Size(311, 414);
        programStatesGrid.TabIndex = 1;
        // 
        // ProgramStatesControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(programStatesGrid);
        Controls.Add(Header);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ProgramStatesControl";
        Size = new Size(990, 492);
        ResumeLayout(false);
    }

    #endregion

    private UnderAutomation.Fanuc.Showcase.Forms.Components.HeaderFileControl Header;
    private CustomPropertyGrid programStatesGrid;
}
