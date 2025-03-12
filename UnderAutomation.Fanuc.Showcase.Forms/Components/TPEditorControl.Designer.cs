
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
        components = new System.ComponentModel.Container();
        editor = new UnderAutomation.Fanuc.Showcase.Forms.TPSyntaxEditor.BreakpointEditor();
        splitContainer1 = new SplitContainer();
        treeFile = new TpTreeView();
        mnu = new MenuStrip();
        btnSave = new ToolStripMenuItem();
        btnStart = new ToolStripMenuItem();
        btnPause = new ToolStripMenuItem();
        btnAbort = new ToolStripMenuItem();
        btnStep = new ToolStripMenuItem();
        bw = new System.ComponentModel.BackgroundWorker();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        mnu.SuspendLayout();
        SuspendLayout();
        // 
        // editor
        // 
        editor.Dock = DockStyle.Fill;
        editor.Location = new Point(0, 24);
        editor.Name = "editor";
        editor.Size = new Size(787, 570);
        editor.TabIndex = 0;
        editor.BreakpointAdded += editor_BreakpointAdded;
        editor.BreakpointRemoved += editor_BreakpointRemoved;
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
        treeFile.ImageIndex = 0;
        treeFile.LabelEdit = true;
        treeFile.Location = new Point(0, 0);
        treeFile.Name = "treeFile";
        treeFile.SelectedImageIndex = 0;
        treeFile.Size = new Size(199, 594);
        treeFile.TabIndex = 0;
        treeFile.ItemRenamed += treeFile_ItemRenamed;
        treeFile.ItemSelected += treeFile_ItemSelected;
        // 
        // mnu
        // 
        mnu.Items.AddRange(new ToolStripItem[] { btnSave, btnStart, btnPause, btnAbort, btnStep });
        mnu.Location = new Point(0, 0);
        mnu.Name = "mnu";
        mnu.Size = new Size(787, 24);
        mnu.TabIndex = 1;
        mnu.Text = "menuStrip1";
        // 
        // btnSave
        // 
        btnSave.Image = UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.save_3_fill;
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(59, 20);
        btnSave.Text = "Save";
        btnSave.Click += btnSave_Click;
        // 
        // btnStart
        // 
        btnStart.Image = UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.play;
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(59, 20);
        btnStart.Text = "Start";
        btnStart.Click += btnStart_Click;
        // 
        // btnPause
        // 
        btnPause.Image = UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.pause;
        btnPause.Name = "btnPause";
        btnPause.Size = new Size(66, 20);
        btnPause.Text = "Pause";
        btnPause.Click += btnPause_Click;
        // 
        // btnAbort
        // 
        btnAbort.Image = UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.stop_fill;
        btnAbort.Name = "btnAbort";
        btnAbort.Size = new Size(65, 20);
        btnAbort.Text = "Abort";
        btnAbort.Click += btnAbort_Click;
        // 
        // btnStep
        // 
        btnStep.Image = UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.corner_down_right_line;
        btnStep.Name = "btnStep";
        btnStep.Size = new Size(58, 20);
        btnStep.Text = "Step";
        btnStep.Click += btnStep_Click;
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
        splitContainer1.Panel2.ResumeLayout(false);
        splitContainer1.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        mnu.ResumeLayout(false);
        mnu.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private UnderAutomation.Fanuc.Showcase.Forms.TPSyntaxEditor.BreakpointEditor editor;
    private SplitContainer splitContainer1;
    private MenuStrip mnu;
    private System.ComponentModel.BackgroundWorker bw;
    private TpTreeView treeFile;
    private ToolStripMenuItem btnStart;
    private ToolStripMenuItem btnPause;
    private ToolStripMenuItem btnAbort;
    private ToolStripMenuItem btnStep;
    private ToolStripMenuItem btnSave;
}
