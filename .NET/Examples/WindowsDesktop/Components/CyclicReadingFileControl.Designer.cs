
namespace UnderAutomation.Fanuc.Sample.WindowsDesktop.Components
{
    partial class CyclicReadingFileControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStatus = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsStart = new System.Windows.Forms.ToolStripButton();
            this.tsStop = new System.Windows.Forms.ToolStripButton();
            this.tsBrowse = new System.Windows.Forms.ToolStripButton();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(0, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(792, 43);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStart,
            this.tsStop,
            this.tsBrowse});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsStart
            // 
            this.tsStart.Image = global::UnderAutomation.Fanuc.Sample.WindowsDesktop.Properties.Resources.play;
            this.tsStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStart.Name = "tsStart";
            this.tsStart.Size = new System.Drawing.Size(127, 22);
            this.tsStart.Text = "Start cyclic reading";
            // 
            // tsStop
            // 
            this.tsStop.Image = global::UnderAutomation.Fanuc.Sample.WindowsDesktop.Properties.Resources.pause;
            this.tsStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStop.Name = "tsStop";
            this.tsStop.Size = new System.Drawing.Size(127, 22);
            this.tsStop.Text = "Stop cyclic reading";
            // 
            // tsBrowse
            // 
            this.tsBrowse.Image = global::UnderAutomation.Fanuc.Sample.WindowsDesktop.Properties.Resources.folder_line;
            this.tsBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBrowse.Name = "tsBrowse";
            this.tsBrowse.Size = new System.Drawing.Size(118, 22);
            this.tsBrowse.Text = "Browse and open";
            this.tsBrowse.Click += new System.EventHandler(this.tsBrowse_Click);
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            // 
            // CyclicReadingFileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CyclicReadingFileControl";
            this.Size = new System.Drawing.Size(792, 68);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsStart;
        private System.Windows.Forms.ToolStripButton tsStop;
        private System.Windows.Forms.ToolStripButton tsBrowse;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
    }
}
