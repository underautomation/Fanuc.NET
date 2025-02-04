
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
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tsReadAll = new System.Windows.Forms.ToolStripSplitButton();
            this.tsReadSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOpenFileFromDisc = new System.Windows.Forms.ToolStripButton();
            this.tsOpenFolderFromDisc = new System.Windows.Forms.ToolStripButton();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgOpenFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.variableTable = new VariableTableControl();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts
            // 
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsReadAll,
            this.tsOpenFileFromDisc,
            this.tsOpenFolderFromDisc});
            this.ts.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(772, 31);
            this.ts.TabIndex = 5;
            this.ts.Text = "toolStrip1";
            // 
            // tsReadAll
            // 
            this.tsReadAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsReadSelected});
            this.tsReadAll.Image = global::UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.refresh_line;
            this.tsReadAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsReadAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReadAll.Name = "tsReadAll";
            this.tsReadAll.Size = new System.Drawing.Size(195, 28);
            this.tsReadAll.Text = "Read all variables on robot...";
            this.tsReadAll.ToolTipText = "Robot memory access should be connected";
            this.tsReadAll.ButtonClick += new System.EventHandler(this.tsReadAll_ButtonClick);
            // 
            // tsReadSelected
            // 
            this.tsReadSelected.Name = "tsReadSelected";
            this.tsReadSelected.Size = new System.Drawing.Size(180, 22);
            this.tsReadSelected.Text = "Select files...";
            this.tsReadSelected.Click += new System.EventHandler(this.tsReadSelected_Click);
            // 
            // tsOpenFileFromDisc
            // 
            this.tsOpenFileFromDisc.Image = global::UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.file_line;
            this.tsOpenFileFromDisc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsOpenFileFromDisc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpenFileFromDisc.Name = "tsOpenFileFromDisc";
            this.tsOpenFileFromDisc.Size = new System.Drawing.Size(117, 28);
            this.tsOpenFileFromDisc.Text = "Open *.va File...";
            this.tsOpenFileFromDisc.Click += new System.EventHandler(this.tsOpenFileFromDisc_Click);
            // 
            // tsOpenFolderFromDisc
            // 
            this.tsOpenFolderFromDisc.Image = global::UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.folder_line;
            this.tsOpenFolderFromDisc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsOpenFolderFromDisc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpenFolderFromDisc.Name = "tsOpenFolderFromDisc";
            this.tsOpenFolderFromDisc.Size = new System.Drawing.Size(242, 28);
            this.tsOpenFolderFromDisc.Text = "Open all variable files *.va from a folder";
            this.tsOpenFolderFromDisc.Click += new System.EventHandler(this.tsOpenFolderFromDisc_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.CheckFileExists = false;
            this.dlgOpenFile.CheckPathExists = false;
            this.dlgOpenFile.Filter = "Variables|*.va|All files|*.*";
            this.dlgOpenFile.Multiselect = true;
            // 
            // variableTable
            // 
            this.variableTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variableTable.Location = new System.Drawing.Point(0, 31);
            this.variableTable.Name = "variableTable";
            this.variableTable.Size = new System.Drawing.Size(772, 436);
            this.variableTable.TabIndex = 4;
            // 
            // VariablesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.variableTable);
            this.Controls.Add(this.ts);
            this.Name = "VariablesControl";
            this.Size = new System.Drawing.Size(772, 467);
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
}
