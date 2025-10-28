
    partial class ErrorListControl
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
        gridErrorList = new CustomPropertyGrid();
        gridActiveAlarms = new CustomPropertyGrid();
        panel1 = new Panel();
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
        // gridErrorList
        // 
        gridErrorList.BackColor = SystemColors.Window;
        gridErrorList.BorderStyle = BorderStyle.FixedSingle;
        gridErrorList.Dock = DockStyle.Left;
        gridErrorList.LabelText = "Error list";
        gridErrorList.Location = new Point(0, 78);
        gridErrorList.Margin = new Padding(5, 3, 5, 3);
        gridErrorList.Name = "gridErrorList";
        gridErrorList.Size = new Size(417, 414);
        gridErrorList.TabIndex = 1;
        // 
        // gridActiveAlarms
        // 
        gridActiveAlarms.BackColor = SystemColors.Window;
        gridActiveAlarms.BorderStyle = BorderStyle.FixedSingle;
        gridActiveAlarms.Dock = DockStyle.Left;
        gridActiveAlarms.LabelText = "Active alarms";
        gridActiveAlarms.Location = new Point(496, 78);
        gridActiveAlarms.Margin = new Padding(5, 3, 5, 3);
        gridActiveAlarms.Name = "gridActiveAlarms";
        gridActiveAlarms.Size = new Size(417, 414);
        gridActiveAlarms.TabIndex = 2;
        // 
        // panel1
        // 
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(417, 78);
        panel1.Name = "panel1";
        panel1.Size = new Size(79, 414);
        panel1.TabIndex = 3;
        // 
        // ErrorListControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(gridActiveAlarms);
        Controls.Add(panel1);
        Controls.Add(gridErrorList);
        Controls.Add(Header);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ErrorListControl";
        Size = new Size(990, 492);
        ResumeLayout(false);
    }

    #endregion

    private UnderAutomation.Fanuc.Showcase.Forms.Components.HeaderFileControl Header;
    private CustomPropertyGrid gridErrorList;
    private CustomPropertyGrid gridActiveAlarms;
    private Panel panel1;
}
