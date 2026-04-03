
    partial class VariablesControl
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
        ts = new ToolStrip();
        tsProtocol = new ToolStripComboBox();
        tsReadAll = new ToolStripSplitButton();
        tsReadSelected = new ToolStripMenuItem();
        tsOpenFileFromDisc = new ToolStripButton();
        tsOpenFolderFromDisc = new ToolStripButton();
        dlgOpenFile = new OpenFileDialog();
        dlgOpenFolder = new FolderBrowserDialog();
        variableTable = new VariableTableControl();
        ts.SuspendLayout();
        SuspendLayout();
        // 
        // ts
        // 
        ts.GripStyle = ToolStripGripStyle.Hidden;
        ts.Items.AddRange(new ToolStripItem[] { tsProtocol, tsReadAll, tsOpenFileFromDisc, tsOpenFolderFromDisc });
        ts.LayoutStyle = ToolStripLayoutStyle.Flow;
        ts.Location = new Point(0, 0);
        ts.Name = "ts";
        ts.Size = new Size(901, 31);
        ts.TabIndex = 5;
        ts.Text = "toolStrip1";
        // 
        // tsProtocol
        // 
        tsProtocol.DropDownStyle = ComboBoxStyle.DropDownList;
        tsProtocol.Items.AddRange(new object[] { "Use CGTP", "Use FTP" });
        tsProtocol.Name = "tsProtocol";
        tsProtocol.Size = new Size(121, 23);
        tsProtocol.SelectedIndexChanged += tsProtocol_SelectedIndexChanged;
        // 
        // tsReadAll
        // 
        tsReadAll.DropDownItems.AddRange(new ToolStripItem[] { tsReadSelected });
        tsReadAll.Image = UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.refresh_line;
        tsReadAll.ImageScaling = ToolStripItemImageScaling.None;
        tsReadAll.ImageTransparentColor = Color.Magenta;
        tsReadAll.Name = "tsReadAll";
        tsReadAll.Size = new Size(195, 28);
        tsReadAll.Text = "Read all variables on robot...";
        tsReadAll.ToolTipText = "Robot memory access should be connected";
        tsReadAll.ButtonClick += tsReadAll_ButtonClick;
        // 
        // tsReadSelected
        // 
        tsReadSelected.Name = "tsReadSelected";
        tsReadSelected.Size = new Size(138, 22);
        tsReadSelected.Text = "Select files...";
        tsReadSelected.Click += tsReadSelected_Click;
        // 
        // tsOpenFileFromDisc
        // 
        tsOpenFileFromDisc.Image = UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.file_line;
        tsOpenFileFromDisc.ImageScaling = ToolStripItemImageScaling.None;
        tsOpenFileFromDisc.ImageTransparentColor = Color.Magenta;
        tsOpenFileFromDisc.Name = "tsOpenFileFromDisc";
        tsOpenFileFromDisc.Size = new Size(117, 28);
        tsOpenFileFromDisc.Text = "Open *.va File...";
        tsOpenFileFromDisc.Click += tsOpenFileFromDisc_Click;
        // 
        // tsOpenFolderFromDisc
        // 
        tsOpenFolderFromDisc.Image = UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.folder_line;
        tsOpenFolderFromDisc.ImageScaling = ToolStripItemImageScaling.None;
        tsOpenFolderFromDisc.ImageTransparentColor = Color.Magenta;
        tsOpenFolderFromDisc.Name = "tsOpenFolderFromDisc";
        tsOpenFolderFromDisc.Size = new Size(242, 28);
        tsOpenFolderFromDisc.Text = "Open all variable files *.va from a folder";
        tsOpenFolderFromDisc.Click += tsOpenFolderFromDisc_Click;
        // 
        // dlgOpenFile
        // 
        dlgOpenFile.CheckFileExists = false;
        dlgOpenFile.CheckPathExists = false;
        dlgOpenFile.Filter = "Variables|*.va|All files|*.*";
        dlgOpenFile.Multiselect = true;
        // 
        // variableTable
        // 
        variableTable.Dock = DockStyle.Fill;
        variableTable.Location = new Point(0, 31);
        variableTable.Margin = new Padding(5, 3, 5, 3);
        variableTable.Name = "variableTable";
        variableTable.Size = new Size(901, 508);
        variableTable.TabIndex = 4;
        // 
        // VariablesControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(variableTable);
        Controls.Add(ts);
        Margin = new Padding(4, 3, 4, 3);
        Name = "VariablesControl";
        Size = new Size(901, 539);
        ts.ResumeLayout(false);
        ts.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private VariableTableControl variableTable;
    private System.Windows.Forms.ToolStrip ts;
    private System.Windows.Forms.ToolStripButton tsOpenFileFromDisc;
    private System.Windows.Forms.ToolStripButton tsOpenFolderFromDisc;
    private System.Windows.Forms.ToolStripSplitButton tsReadAll;
    private System.Windows.Forms.ToolStripMenuItem tsReadSelected;
    private System.Windows.Forms.OpenFileDialog dlgOpenFile;
    private System.Windows.Forms.FolderBrowserDialog dlgOpenFolder;
    private ToolStripComboBox tsProtocol;
}
