
namespace UnderAutomation.Fanuc.Showcase.Forms.Components
{
    partial class HeaderFileControl
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
            lblStatus = new Label();
            toolStrip1 = new ToolStrip();
            tsProtocol = new ToolStripComboBox();
            tsRefresh = new ToolStripButton();
            tsBrowse = new ToolStripButton();
            dlgOpen = new OpenFileDialog();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(0, 25);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(924, 53);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "...";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsProtocol, tsRefresh, tsBrowse });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(924, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsProtocol
            // 
            tsProtocol.DropDownStyle = ComboBoxStyle.DropDownList;
            tsProtocol.Items.AddRange(new object[] { "Use CGTP", "Use FTP" });
            tsProtocol.Name = "tsProtocol";
            tsProtocol.Size = new Size(121, 25);
            tsProtocol.SelectedIndexChanged += tsProtocol_SelectedIndexChanged;
            // 
            // tsRefresh
            // 
            tsRefresh.Image = Properties.Resources.refresh_line;
            tsRefresh.ImageTransparentColor = Color.Magenta;
            tsRefresh.Name = "tsRefresh";
            tsRefresh.Size = new Size(66, 22);
            tsRefresh.Text = "Refresh";
            tsRefresh.Click += tsRefresh_Click;
            // 
            // tsBrowse
            // 
            tsBrowse.Image = Properties.Resources.folder_line;
            tsBrowse.ImageTransparentColor = Color.Magenta;
            tsBrowse.Name = "tsBrowse";
            tsBrowse.Size = new Size(118, 22);
            tsBrowse.Text = "Browse and open";
            tsBrowse.Click += tsBrowse_Click;
            // 
            // HeaderFileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblStatus);
            Controls.Add(toolStrip1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "HeaderFileControl";
            Size = new Size(924, 78);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsRefresh;
        private System.Windows.Forms.ToolStripButton tsBrowse;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private ToolStripComboBox tsProtocol;
    }
}
