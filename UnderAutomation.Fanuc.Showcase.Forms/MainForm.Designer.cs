
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        horizontalSplitContainer = new SplitContainer();
        panel1 = new Panel();
        label1 = new Label();
        lblLink = new LinkLabel();
        lblTitle = new Label();
        titlePictureBox = new PictureBox();
        verticalSplitContainer = new SplitContainer();
        leftTreeView = new TreeView();
        imgLst = new ImageList(components);
        mainPanel = new Panel();
        panelTitle = new Label();
        tmrPeriodicUpdate = new System.Windows.Forms.Timer(components);
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)horizontalSplitContainer).BeginInit();
        horizontalSplitContainer.Panel1.SuspendLayout();
        horizontalSplitContainer.Panel2.SuspendLayout();
        horizontalSplitContainer.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)titlePictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)verticalSplitContainer).BeginInit();
        verticalSplitContainer.Panel1.SuspendLayout();
        verticalSplitContainer.Panel2.SuspendLayout();
        verticalSplitContainer.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // horizontalSplitContainer
        // 
        horizontalSplitContainer.BorderStyle = BorderStyle.FixedSingle;
        horizontalSplitContainer.Dock = DockStyle.Fill;
        horizontalSplitContainer.FixedPanel = FixedPanel.Panel1;
        horizontalSplitContainer.Location = new Point(0, 0);
        horizontalSplitContainer.Margin = new Padding(4, 3, 4, 3);
        horizontalSplitContainer.Name = "horizontalSplitContainer";
        horizontalSplitContainer.Orientation = Orientation.Horizontal;
        // 
        // horizontalSplitContainer.Panel1
        // 
        horizontalSplitContainer.Panel1.Controls.Add(pictureBox1);
        horizontalSplitContainer.Panel1.Controls.Add(panel1);
        horizontalSplitContainer.Panel1.Controls.Add(lblTitle);
        horizontalSplitContainer.Panel1.Controls.Add(titlePictureBox);
        // 
        // horizontalSplitContainer.Panel2
        // 
        horizontalSplitContainer.Panel2.Controls.Add(verticalSplitContainer);
        horizontalSplitContainer.Size = new Size(1231, 858);
        horizontalSplitContainer.SplitterDistance = 91;
        horizontalSplitContainer.SplitterWidth = 5;
        horizontalSplitContainer.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(label1);
        panel1.Controls.Add(lblLink);
        panel1.Dock = DockStyle.Right;
        panel1.Location = new Point(780, 0);
        panel1.Margin = new Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(449, 89);
        panel1.TabIndex = 3;
        // 
        // label1
        // 
        label1.Dock = DockStyle.Fill;
        label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label1.Location = new Point(0, 0);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(449, 66);
        label1.TabIndex = 3;
        label1.Text = "Fanuc Robot Communication SDK Library demo software";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblLink
        // 
        lblLink.Dock = DockStyle.Bottom;
        lblLink.Location = new Point(0, 66);
        lblLink.Margin = new Padding(4, 0, 4, 0);
        lblLink.Name = "lblLink";
        lblLink.Size = new Size(449, 23);
        lblLink.TabIndex = 2;
        lblLink.TabStop = true;
        lblLink.Text = "https://underautomation.com/Fanuc/documentation";
        lblLink.TextAlign = ContentAlignment.MiddleCenter;
        lblLink.LinkClicked += lblLink_LinkClicked;
        // 
        // lblTitle
        // 
        lblTitle.Dock = DockStyle.Left;
        lblTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.Location = new Point(132, 0);
        lblTitle.Margin = new Padding(4, 0, 4, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(296, 89);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "UnderAutomation";
        lblTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // titlePictureBox
        // 
        titlePictureBox.Dock = DockStyle.Left;
        titlePictureBox.Image = UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.UnderAutomation132;
        titlePictureBox.Location = new Point(0, 0);
        titlePictureBox.Margin = new Padding(4, 3, 4, 3);
        titlePictureBox.Name = "titlePictureBox";
        titlePictureBox.Size = new Size(132, 89);
        titlePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        titlePictureBox.TabIndex = 0;
        titlePictureBox.TabStop = false;
        titlePictureBox.MouseDoubleClick += titlePictureBox_MouseDoubleClick;
        // 
        // verticalSplitContainer
        // 
        verticalSplitContainer.BorderStyle = BorderStyle.FixedSingle;
        verticalSplitContainer.Dock = DockStyle.Fill;
        verticalSplitContainer.FixedPanel = FixedPanel.Panel1;
        verticalSplitContainer.Location = new Point(0, 0);
        verticalSplitContainer.Margin = new Padding(4, 3, 4, 3);
        verticalSplitContainer.Name = "verticalSplitContainer";
        // 
        // verticalSplitContainer.Panel1
        // 
        verticalSplitContainer.Panel1.Controls.Add(leftTreeView);
        // 
        // verticalSplitContainer.Panel2
        // 
        verticalSplitContainer.Panel2.Controls.Add(mainPanel);
        verticalSplitContainer.Panel2.Controls.Add(panelTitle);
        verticalSplitContainer.Size = new Size(1231, 762);
        verticalSplitContainer.SplitterDistance = 328;
        verticalSplitContainer.SplitterWidth = 5;
        verticalSplitContainer.TabIndex = 0;
        // 
        // leftTreeView
        // 
        leftTreeView.Dock = DockStyle.Fill;
        leftTreeView.HideSelection = false;
        leftTreeView.ImageIndex = 0;
        leftTreeView.ImageList = imgLst;
        leftTreeView.Location = new Point(0, 0);
        leftTreeView.Margin = new Padding(4, 3, 4, 3);
        leftTreeView.Name = "leftTreeView";
        leftTreeView.SelectedImageIndex = 0;
        leftTreeView.Size = new Size(326, 760);
        leftTreeView.TabIndex = 0;
        leftTreeView.NodeMouseClick += leftTreeView_NodeMouseClick;
        // 
        // imgLst
        // 
        imgLst.ColorDepth = ColorDepth.Depth8Bit;
        imgLst.ImageStream = (ImageListStreamer)resources.GetObject("imgLst.ImageStream");
        imgLst.TransparentColor = Color.Transparent;
        imgLst.Images.SetKeyName(0, "OFF");
        imgLst.Images.SetKeyName(1, "ON");
        // 
        // mainPanel
        // 
        mainPanel.Dock = DockStyle.Fill;
        mainPanel.Location = new Point(0, 36);
        mainPanel.Margin = new Padding(4, 3, 4, 3);
        mainPanel.Name = "mainPanel";
        mainPanel.Size = new Size(896, 724);
        mainPanel.TabIndex = 1;
        // 
        // panelTitle
        // 
        panelTitle.Dock = DockStyle.Top;
        panelTitle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        panelTitle.Location = new Point(0, 0);
        panelTitle.Margin = new Padding(4, 0, 4, 0);
        panelTitle.Name = "panelTitle";
        panelTitle.Size = new Size(896, 36);
        panelTitle.TabIndex = 0;
        panelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tmrPeriodicUpdate
        // 
        tmrPeriodicUpdate.Enabled = true;
        tmrPeriodicUpdate.Interval = 200;
        tmrPeriodicUpdate.Tick += tmrPeriodicUpdate_Tick;
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Left;
        pictureBox1.Image = UnderAutomation.Fanuc.Showcase.Forms.Properties.Resources.fanuc;
        pictureBox1.Location = new Point(428, 0);
        pictureBox1.Margin = new Padding(4, 3, 4, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(185, 89);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 4;
        pictureBox1.TabStop = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Window;
        ClientSize = new Size(1231, 858);
        Controls.Add(horizontalSplitContainer);
        Icon = (Icon)resources.GetObject("$this.Icon");
        KeyPreview = true;
        Margin = new Padding(4, 3, 4, 3);
        Name = "MainForm";
        Text = "UnderAutomation - Fanuc communication SDK";
        FormClosing += MainForm_FormClosing;
        horizontalSplitContainer.Panel1.ResumeLayout(false);
        horizontalSplitContainer.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)horizontalSplitContainer).EndInit();
        horizontalSplitContainer.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)titlePictureBox).EndInit();
        verticalSplitContainer.Panel1.ResumeLayout(false);
        verticalSplitContainer.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)verticalSplitContainer).EndInit();
        verticalSplitContainer.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
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
    private PictureBox pictureBox1;
}

