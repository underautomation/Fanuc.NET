
    partial class MemoryAccessControl
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
            this.grid = new System.Windows.Forms.PropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.variableTable = new VariableTable();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Left;
            this.grid.HelpVisible = false;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.grid.Size = new System.Drawing.Size(140, 467);
            this.grid.TabIndex = 0;
            this.grid.ToolbarVisible = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(140, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 38);
            this.panel1.TabIndex = 3;
            // 
            // variableTable
            // 
            this.variableTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variableTable.Location = new System.Drawing.Point(140, 38);
            this.variableTable.Name = "variableTable";
            this.variableTable.Size = new System.Drawing.Size(632, 429);
            this.variableTable.TabIndex = 4;
            // 
            // MemoryAccessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.variableTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid);
            this.Name = "MemoryAccessControl";
            this.Size = new System.Drawing.Size(772, 467);
            this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.PropertyGrid grid;
    private System.Windows.Forms.Panel panel1;
    private VariableTable variableTable;
}
