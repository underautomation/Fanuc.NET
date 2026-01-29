using System.Drawing;
using System.Windows.Forms;

    partial class StreamMotionControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TabControl tabMain;

        // Tab: Command
        private TabPage tabCommand;
        private Panel pnlCommandButtons;
        private Button btnStart;
        private Button btnStop;
        private Button btnSendCommand;
        private Button btnLoadCurrentPosition;
        private PropertyGrid propertyGridCommand;
        private PropertyGrid propertyGridState;

        // Tab: Log
        private TabPage tabLog;
        private TextBox txtLog;
        private Button btnClearLog;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            tabMain = new TabControl();
            tabCommand = new TabPage();
            propertyGridCommand = new PropertyGrid();
            pnlCommandButtons = new Panel();
            btnStart = new Button();
            btnStop = new Button();
            btnSendCommand = new Button();
            btnLoadCurrentPosition = new Button();
            propertyGridState = new PropertyGrid();
            tabLog = new TabPage();
            txtLog = new TextBox();
            btnClearLog = new Button();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            label2 = new Label();
            tabMain.SuspendLayout();
            tabCommand.SuspendLayout();
            pnlCommandButtons.SuspendLayout();
            tabLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabCommand);
            tabMain.Controls.Add(tabLog);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(900, 588);
            tabMain.TabIndex = 0;
            // 
            // tabCommand
            // 
            tabCommand.Controls.Add(splitContainer1);
            tabCommand.Controls.Add(pnlCommandButtons);
            tabCommand.Location = new Point(4, 24);
            tabCommand.Name = "tabCommand";
            tabCommand.Padding = new Padding(3);
            tabCommand.Size = new Size(892, 560);
            tabCommand.TabIndex = 0;
            tabCommand.Text = "Command";
            tabCommand.UseVisualStyleBackColor = true;
            // 
            // propertyGridCommand
            // 
            propertyGridCommand.Dock = DockStyle.Fill;
            propertyGridCommand.HelpVisible = false;
            propertyGridCommand.Location = new Point(0, 33);
            propertyGridCommand.Name = "propertyGridCommand";
            propertyGridCommand.PropertySort = PropertySort.Categorized;
            propertyGridCommand.Size = new Size(412, 471);
            propertyGridCommand.TabIndex = 1;
            // 
            // pnlCommandButtons
            // 
            pnlCommandButtons.Controls.Add(btnStart);
            pnlCommandButtons.Controls.Add(btnStop);
            pnlCommandButtons.Controls.Add(btnSendCommand);
            pnlCommandButtons.Controls.Add(btnLoadCurrentPosition);
            pnlCommandButtons.Dock = DockStyle.Top;
            pnlCommandButtons.Location = new Point(3, 3);
            pnlCommandButtons.Name = "pnlCommandButtons";
            pnlCommandButtons.Size = new Size(886, 50);
            pnlCommandButtons.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(8, 8);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(80, 30);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(93, 8);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(80, 30);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnSendCommand
            // 
            btnSendCommand.Location = new Point(183, 8);
            btnSendCommand.Name = "btnSendCommand";
            btnSendCommand.Size = new Size(110, 30);
            btnSendCommand.TabIndex = 4;
            btnSendCommand.Text = "Send Command";
            btnSendCommand.UseVisualStyleBackColor = true;
            btnSendCommand.Click += btnSendCommand_Click;
            // 
            // btnLoadCurrentPosition
            // 
            btnLoadCurrentPosition.Location = new Point(303, 8);
            btnLoadCurrentPosition.Name = "btnLoadCurrentPosition";
            btnLoadCurrentPosition.Size = new Size(130, 30);
            btnLoadCurrentPosition.TabIndex = 5;
            btnLoadCurrentPosition.Text = "Load Current Pos";
            btnLoadCurrentPosition.UseVisualStyleBackColor = true;
            btnLoadCurrentPosition.Click += btnLoadCurrentPosition_Click;
            // 
            // propertyGridState
            // 
            propertyGridState.Dock = DockStyle.Fill;
            propertyGridState.HelpVisible = false;
            propertyGridState.Location = new Point(0, 33);
            propertyGridState.Name = "propertyGridState";
            propertyGridState.PropertySort = PropertySort.Categorized;
            propertyGridState.Size = new Size(470, 471);
            propertyGridState.TabIndex = 0;
            // 
            // tabLog
            // 
            tabLog.Controls.Add(txtLog);
            tabLog.Controls.Add(btnClearLog);
            tabLog.Location = new Point(4, 24);
            tabLog.Name = "tabLog";
            tabLog.Padding = new Padding(3);
            tabLog.Size = new Size(892, 560);
            tabLog.TabIndex = 3;
            tabLog.Text = "Log";
            tabLog.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            txtLog.Dock = DockStyle.Fill;
            txtLog.Font = new Font("Consolas", 9F);
            txtLog.Location = new Point(3, 3);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Both;
            txtLog.Size = new Size(886, 518);
            txtLog.TabIndex = 0;
            // 
            // btnClearLog
            // 
            btnClearLog.Dock = DockStyle.Bottom;
            btnClearLog.Location = new Point(3, 521);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(886, 36);
            btnClearLog.TabIndex = 1;
            btnClearLog.Text = "Clear Log";
            btnClearLog.UseVisualStyleBackColor = true;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 53);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(propertyGridState);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(propertyGridCommand);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(886, 504);
            splitContainer1.SplitterDistance = 470;
            splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(470, 33);
            label1.TabIndex = 1;
            label1.Text = "State :";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(412, 33);
            label2.TabIndex = 2;
            label2.Text = "Command :";
            // 
            // StreamMotionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabMain);
            Margin = new Padding(4, 3, 4, 3);
            Name = "StreamMotionControl";
            Size = new Size(900, 588);
            tabMain.ResumeLayout(false);
            tabCommand.ResumeLayout(false);
            pnlCommandButtons.ResumeLayout(false);
            tabLog.ResumeLayout(false);
            tabLog.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
    }
