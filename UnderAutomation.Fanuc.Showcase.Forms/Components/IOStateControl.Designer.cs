
    partial class IOStateControl
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
            this.components = new System.ComponentModel.Container();
            this.grid = new System.Windows.Forms.DataGridView();
            this.PortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NamleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Header = new UnderAutomation.Fanuc.Showcase.Forms.Components.HeaderFileControl();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.AutoGenerateColumns = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PortColumn,
            this.IdColumn,
            this.ValueColumn,
            this.NamleColumn});
            this.grid.DataSource = this.iOStateBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 68);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.ShowEditingIcon = false;
            this.grid.Size = new System.Drawing.Size(849, 358);
            this.grid.TabIndex = 1;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // PortColumn
            // 
            this.PortColumn.DataPropertyName = "Port";
            this.PortColumn.HeaderText = "Port";
            this.PortColumn.Name = "PortColumn";
            this.PortColumn.ReadOnly = true;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // ValueColumn
            // 
            this.ValueColumn.DataPropertyName = "Value";
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.ReadOnly = true;
            // 
            // NamleColumn
            // 
            this.NamleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamleColumn.DataPropertyName = "Name";
            this.NamleColumn.HeaderText = "Name";
            this.NamleColumn.Name = "NamleColumn";
            this.NamleColumn.ReadOnly = true;
            // 
            // iOStateBindingSource
            // 
            this.iOStateBindingSource.DataSource = typeof(UnderAutomation.Fanuc.Common.IOStatus);
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(849, 68);
            this.Header.TabIndex = 0;
            // 
            // IOStateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.Header);
            this.Name = "IOStateControl";
            this.Size = new System.Drawing.Size(849, 426);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

    #endregion

    private UnderAutomation.Fanuc.Showcase.Forms.Components.HeaderFileControl Header;
    private System.Windows.Forms.DataGridView grid;
    private System.Windows.Forms.BindingSource iOStateBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn PortColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn ValueColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn NamleColumn;
}
