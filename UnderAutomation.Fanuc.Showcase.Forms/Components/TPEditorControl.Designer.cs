
    partial class TPEditorControl
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
        editor = new UnderAutomation.Fanuc.Showcase.Forms.TPSyntaxEditor.BreakpointEditor();
        splitContainer1 = new SplitContainer();
        treeFile = new TreeView();
        menuStrip1 = new MenuStrip();
        mnu = new MenuStrip();
        bw = new System.ComponentModel.BackgroundWorker();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // editor
        // 
        editor.Dock = DockStyle.Fill;
        editor.Location = new Point(0, 24);
        editor.Name = "editor";
        editor.Size = new Size(787, 570);
        editor.TabIndex = 0;
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(treeFile);
        splitContainer1.Panel1.Controls.Add(menuStrip1);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(editor);
        splitContainer1.Panel2.Controls.Add(mnu);
        splitContainer1.Size = new Size(990, 594);
        splitContainer1.SplitterDistance = 199;
        splitContainer1.TabIndex = 1;
        // 
        // treeFile
        // 
        treeFile.Dock = DockStyle.Fill;
        treeFile.Location = new Point(0, 24);
        treeFile.Name = "treeFile";
        treeFile.Size = new Size(199, 570);
        treeFile.TabIndex = 0;
        // 
        // menuStrip1
        // 
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(199, 24);
        menuStrip1.TabIndex = 2;
        menuStrip1.Text = "menuStrip1";
        // 
        // mnu
        // 
        mnu.Location = new Point(0, 0);
        mnu.Name = "mnu";
        mnu.Size = new Size(787, 24);
        mnu.TabIndex = 1;
        mnu.Text = "menuStrip1";
        // 
        // bw
        // 
        bw.WorkerReportsProgress = true;
        bw.WorkerSupportsCancellation = true;
        bw.DoWork += bw_DoWork;
        bw.ProgressChanged += bw_ProgressChanged;
        // 
        // TPEditorControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(splitContainer1);
        Margin = new Padding(4, 3, 4, 3);
        Name = "TPEditorControl";
        Size = new Size(990, 594);
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel1.PerformLayout();
        splitContainer1.Panel2.ResumeLayout(false);
        splitContainer1.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private UnderAutomation.Fanuc.Showcase.Forms.TPSyntaxEditor.BreakpointEditor editor;
    private SplitContainer splitContainer1;
    private TreeView treeFile;
    private MenuStrip mnu;
    private MenuStrip menuStrip1;
    private System.ComponentModel.BackgroundWorker bw;
}
