partial class SnpxSignalControl
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
        this.grp = new System.Windows.Forms.GroupBox();
        this.cb = new System.Windows.Forms.ComboBox();
        this.pnl = new System.Windows.Forms.FlowLayoutPanel();
        this.btnWrite = new System.Windows.Forms.Button();
        this.btnRead = new System.Windows.Forms.Button();
        this.label11 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.label10 = new System.Windows.Forms.Label();
        this.udCount = new System.Windows.Forms.NumericUpDown();
        this.udIndex = new System.Windows.Forms.NumericUpDown();
        this.grp.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.udCount)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.udIndex)).BeginInit();
        this.SuspendLayout();
        // 
        // grp
        // 
        this.grp.Controls.Add(this.cb);
        this.grp.Controls.Add(this.pnl);
        this.grp.Controls.Add(this.btnWrite);
        this.grp.Controls.Add(this.btnRead);
        this.grp.Controls.Add(this.label11);
        this.grp.Controls.Add(this.label1);
        this.grp.Controls.Add(this.label10);
        this.grp.Controls.Add(this.udCount);
        this.grp.Controls.Add(this.udIndex);
        this.grp.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grp.Location = new System.Drawing.Point(0, 0);
        this.grp.Name = "grp";
        this.grp.Size = new System.Drawing.Size(226, 372);
        this.grp.TabIndex = 1;
        this.grp.TabStop = false;
        this.grp.Text = "UI";
        // 
        // cb
        // 
        this.cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cb.FormattingEnabled = true;
        this.cb.Location = new System.Drawing.Point(72, 19);
        this.cb.Name = "cb";
        this.cb.Size = new System.Drawing.Size(148, 21);
        this.cb.TabIndex = 6;
        // 
        // pnl
        // 
        this.pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        this.pnl.AutoScroll = true;
        this.pnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        this.pnl.Location = new System.Drawing.Point(6, 127);
        this.pnl.Name = "pnl";
        this.pnl.Size = new System.Drawing.Size(214, 239);
        this.pnl.TabIndex = 5;
        // 
        // btnWrite
        // 
        this.btnWrite.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.btnWrite.Location = new System.Drawing.Point(113, 98);
        this.btnWrite.Name = "btnWrite";
        this.btnWrite.Size = new System.Drawing.Size(71, 23);
        this.btnWrite.TabIndex = 3;
        this.btnWrite.Text = "Write";
        this.btnWrite.UseVisualStyleBackColor = true;
        this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
        // 
        // btnRead
        // 
        this.btnRead.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.btnRead.Location = new System.Drawing.Point(42, 98);
        this.btnRead.Name = "btnRead";
        this.btnRead.Size = new System.Drawing.Size(71, 23);
        this.btnRead.TabIndex = 4;
        this.btnRead.Text = "Read";
        this.btnRead.UseVisualStyleBackColor = true;
        this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
        // 
        // label11
        // 
        this.label11.Location = new System.Drawing.Point(6, 72);
        this.label11.Name = "label11";
        this.label11.Size = new System.Drawing.Size(60, 20);
        this.label11.TabIndex = 1;
        this.label11.Text = "Count :";
        this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(9, 20);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(60, 20);
        this.label1.TabIndex = 1;
        this.label1.Text = "Signal :";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label10
        // 
        this.label10.Location = new System.Drawing.Point(6, 46);
        this.label10.Name = "label10";
        this.label10.Size = new System.Drawing.Size(60, 20);
        this.label10.TabIndex = 1;
        this.label10.Text = "First index :";
        this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // udCount
        // 
        this.udCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        this.udCount.Location = new System.Drawing.Point(72, 72);
        this.udCount.Maximum = new decimal(new int[] {
        65535,
        0,
        0,
        0});
        this.udCount.Name = "udCount";
        this.udCount.Size = new System.Drawing.Size(148, 20);
        this.udCount.TabIndex = 0;
        this.udCount.Value = new decimal(new int[] {
        1,
        0,
        0,
        0});
        // 
        // udIndex
        // 
        this.udIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        this.udIndex.Location = new System.Drawing.Point(72, 46);
        this.udIndex.Maximum = new decimal(new int[] {
        65535,
        0,
        0,
        0});
        this.udIndex.Minimum = new decimal(new int[] {
        1,
        0,
        0,
        0});
        this.udIndex.Name = "udIndex";
        this.udIndex.Size = new System.Drawing.Size(148, 20);
        this.udIndex.TabIndex = 0;
        this.udIndex.Value = new decimal(new int[] {
        1,
        0,
        0,
        0});
        // 
        // SnpxSignalControl
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.grp);
        this.Name = "SnpxSignalControl";
        this.Size = new System.Drawing.Size(226, 372);
        this.grp.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.udCount)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.udIndex)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grp;
    private System.Windows.Forms.FlowLayoutPanel pnl;
    private System.Windows.Forms.Button btnWrite;
    private System.Windows.Forms.Button btnRead;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.NumericUpDown udCount;
    private System.Windows.Forms.NumericUpDown udIndex;
    private System.Windows.Forms.ComboBox cb;
    private System.Windows.Forms.Label label1;
}
