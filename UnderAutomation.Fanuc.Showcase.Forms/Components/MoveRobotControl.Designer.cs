
    partial class MoveRobotControl
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
            this.currentWorldPositionGrid = new CustomPropertyGrid();
            this.targetWorldPositionGrid = new CustomPropertyGrid();
            this.btnCopyWorldPosition = new System.Windows.Forms.Button();
            this.btnMoveWorldPosition = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrgName = new System.Windows.Forms.Label();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.btnRefreshWorldPosition = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentWorldPositionGrid
            // 
            this.currentWorldPositionGrid.BackColor = System.Drawing.SystemColors.Window;
            this.currentWorldPositionGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentWorldPositionGrid.LabelText = "Current world position";
            this.currentWorldPositionGrid.Location = new System.Drawing.Point(3, 3);
            this.currentWorldPositionGrid.Name = "currentWorldPositionGrid";
            this.currentWorldPositionGrid.Size = new System.Drawing.Size(195, 280);
            this.currentWorldPositionGrid.TabIndex = 1;
            // 
            // targetWorldPositionGrid
            // 
            this.targetWorldPositionGrid.BackColor = System.Drawing.SystemColors.Window;
            this.targetWorldPositionGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetWorldPositionGrid.LabelText = "Target world position";
            this.targetWorldPositionGrid.Location = new System.Drawing.Point(3, 3);
            this.targetWorldPositionGrid.Name = "targetWorldPositionGrid";
            this.targetWorldPositionGrid.Size = new System.Drawing.Size(198, 277);
            this.targetWorldPositionGrid.TabIndex = 1;
            // 
            // btnCopyWorldPosition
            // 
            this.btnCopyWorldPosition.Location = new System.Drawing.Point(215, 102);
            this.btnCopyWorldPosition.Name = "btnCopyWorldPosition";
            this.btnCopyWorldPosition.Size = new System.Drawing.Size(75, 23);
            this.btnCopyWorldPosition.TabIndex = 2;
            this.btnCopyWorldPosition.Text = ">>";
            this.btnCopyWorldPosition.UseVisualStyleBackColor = true;
            this.btnCopyWorldPosition.Click += new System.EventHandler(this.btnCopyWorldPosition_Click);
            // 
            // btnMoveWorldPosition
            // 
            this.btnMoveWorldPosition.Location = new System.Drawing.Point(27, 286);
            this.btnMoveWorldPosition.Name = "btnMoveWorldPosition";
            this.btnMoveWorldPosition.Size = new System.Drawing.Size(159, 23);
            this.btnMoveWorldPosition.TabIndex = 2;
            this.btnMoveWorldPosition.Text = "Move to target world position";
            this.btnMoveWorldPosition.UseVisualStyleBackColor = true;
            this.btnMoveWorldPosition.Click += new System.EventHandler(this.btnMoveWorldPosition_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPrgName);
            this.panel1.Controls.Add(this.btnMoveWorldPosition);
            this.panel1.Controls.Add(this.txtProgram);
            this.panel1.Controls.Add(this.targetWorldPositionGrid);
            this.panel1.Location = new System.Drawing.Point(296, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 312);
            this.panel1.TabIndex = 3;
            // 
            // lblPrgName
            // 
            this.lblPrgName.AutoSize = true;
            this.lblPrgName.Location = new System.Drawing.Point(219, 3);
            this.lblPrgName.Name = "lblPrgName";
            this.lblPrgName.Size = new System.Drawing.Size(16, 13);
            this.lblPrgName.TabIndex = 3;
            this.lblPrgName.Text = "---";
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(222, 19);
            this.txtProgram.Multiline = true;
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.ReadOnly = true;
            this.txtProgram.Size = new System.Drawing.Size(313, 290);
            this.txtProgram.TabIndex = 2;
            // 
            // btnRefreshWorldPosition
            // 
            this.btnRefreshWorldPosition.Location = new System.Drawing.Point(19, 289);
            this.btnRefreshWorldPosition.Name = "btnRefreshWorldPosition";
            this.btnRefreshWorldPosition.Size = new System.Drawing.Size(159, 23);
            this.btnRefreshWorldPosition.TabIndex = 2;
            this.btnRefreshWorldPosition.Text = "Refresh position";
            this.btnRefreshWorldPosition.UseVisualStyleBackColor = true;
            this.btnRefreshWorldPosition.Click += new System.EventHandler(this.btnRefreshWorldPosition_Click);
            // 
            // MoveRobotControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefreshWorldPosition);
            this.Controls.Add(this.btnCopyWorldPosition);
            this.Controls.Add(this.currentWorldPositionGrid);
            this.Name = "MoveRobotControl";
            this.Size = new System.Drawing.Size(849, 515);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

    #endregion
    private CustomPropertyGrid currentWorldPositionGrid;
    private CustomPropertyGrid targetWorldPositionGrid;
    private System.Windows.Forms.Button btnCopyWorldPosition;
    private System.Windows.Forms.Button btnMoveWorldPosition;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblPrgName;
    private System.Windows.Forms.TextBox txtProgram;
    private System.Windows.Forms.Button btnRefreshWorldPosition;
}
