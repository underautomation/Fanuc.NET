
partial class MainForm
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

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.horizontalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            this.verticalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.leftTreeView = new System.Windows.Forms.TreeView();
            this.imgLst = new System.Windows.Forms.ImageList(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Label();
            this.tmrPeriodicUpdate = new System.Windows.Forms.Timer(this.components);
            this.horizontalSplitContainer.Panel1.SuspendLayout();
            this.horizontalSplitContainer.Panel2.SuspendLayout();
            this.horizontalSplitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            this.verticalSplitContainer.Panel1.SuspendLayout();
            this.verticalSplitContainer.Panel2.SuspendLayout();
            this.verticalSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // horizontalSplitContainer
            // 
            this.horizontalSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.horizontalSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horizontalSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.horizontalSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.horizontalSplitContainer.Name = "horizontalSplitContainer";
            this.horizontalSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // horizontalSplitContainer.Panel1
            // 
            this.horizontalSplitContainer.Panel1.Controls.Add(this.panel1);
            this.horizontalSplitContainer.Panel1.Controls.Add(this.lblTitle);
            this.horizontalSplitContainer.Panel1.Controls.Add(this.titlePictureBox);
            // 
            // horizontalSplitContainer.Panel2
            // 
            this.horizontalSplitContainer.Panel2.Controls.Add(this.verticalSplitContainer);
            this.horizontalSplitContainer.Size = new System.Drawing.Size(1055, 744);
            this.horizontalSplitContainer.SplitterDistance = 79;
            this.horizontalSplitContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblLink);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(668, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 77);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fanuc Robot Communication SDK Library demo software";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLink
            // 
            this.lblLink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLink.Location = new System.Drawing.Point(0, 57);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(385, 20);
            this.lblLink.TabIndex = 2;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "https://underautomation.com/Fanuc/documentation";
            this.lblLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(113, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 77);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "UnderAutomation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titlePictureBox
            // 
            this.titlePictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.titlePictureBox.Image = global::UnderAutomation.Fanuc.Sample.WindowsDesktop.Properties.Resources.UnderAutomation132;
            this.titlePictureBox.Location = new System.Drawing.Point(0, 0);
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.Size = new System.Drawing.Size(113, 77);
            this.titlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titlePictureBox.TabIndex = 0;
            this.titlePictureBox.TabStop = false;
            this.titlePictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.titlePictureBox_MouseDoubleClick);
            // 
            // verticalSplitContainer
            // 
            this.verticalSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verticalSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.verticalSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.verticalSplitContainer.Name = "verticalSplitContainer";
            // 
            // verticalSplitContainer.Panel1
            // 
            this.verticalSplitContainer.Panel1.Controls.Add(this.leftTreeView);
            // 
            // verticalSplitContainer.Panel2
            // 
            this.verticalSplitContainer.Panel2.Controls.Add(this.mainPanel);
            this.verticalSplitContainer.Panel2.Controls.Add(this.panelTitle);
            this.verticalSplitContainer.Size = new System.Drawing.Size(1055, 661);
            this.verticalSplitContainer.SplitterDistance = 281;
            this.verticalSplitContainer.TabIndex = 0;
            // 
            // leftTreeView
            // 
            this.leftTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftTreeView.HideSelection = false;
            this.leftTreeView.ImageIndex = 0;
            this.leftTreeView.ImageList = this.imgLst;
            this.leftTreeView.Location = new System.Drawing.Point(0, 0);
            this.leftTreeView.Name = "leftTreeView";
            this.leftTreeView.SelectedImageIndex = 0;
            this.leftTreeView.Size = new System.Drawing.Size(279, 659);
            this.leftTreeView.TabIndex = 0;
            this.leftTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.leftTreeView_NodeMouseClick);
            // 
            // imgLst
            // 
            this.imgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLst.ImageStream")));
            this.imgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLst.Images.SetKeyName(0, "OFF");
            this.imgLst.Images.SetKeyName(1, "ON");
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 31);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(768, 628);
            this.mainPanel.TabIndex = 1;
            // 
            // panelTitle
            // 
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(768, 31);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrPeriodicUpdate
            // 
            this.tmrPeriodicUpdate.Enabled = true;
            this.tmrPeriodicUpdate.Interval = 200;
            this.tmrPeriodicUpdate.Tick += new System.EventHandler(this.tmrPeriodicUpdate_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1055, 744);
            this.Controls.Add(this.horizontalSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "UnderAutomation - Fanuc communication SDK";
            this.horizontalSplitContainer.Panel1.ResumeLayout(false);
            this.horizontalSplitContainer.Panel2.ResumeLayout(false);
            this.horizontalSplitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            this.verticalSplitContainer.Panel1.ResumeLayout(false);
            this.verticalSplitContainer.Panel2.ResumeLayout(false);
            this.verticalSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer horizontalSplitContainer;
    private System.Windows.Forms.SplitContainer verticalSplitContainer;
    private System.Windows.Forms.Panel mainPanel;
    private System.Windows.Forms.Label panelTitle;
    private System.Windows.Forms.Timer tmrPeriodicUpdate;
    private System.Windows.Forms.ImageList imgLst;
    private System.Windows.Forms.PictureBox titlePictureBox;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.LinkLabel lblLink;
    private System.Windows.Forms.Label label1;
    internal System.Windows.Forms.TreeView leftTreeView;
}

