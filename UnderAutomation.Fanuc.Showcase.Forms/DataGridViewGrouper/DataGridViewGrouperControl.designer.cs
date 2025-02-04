namespace Subro.Controls
{
    partial class DataGridViewGrouperControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.chk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbFields
            // 
            this.cmbFields.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFields.DisplayMember = "Name";
            this.cmbFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFields.DropDownWidth = 120;
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Location = new System.Drawing.Point(70, 0);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(129, 21);
            this.cmbFields.Sorted = true;
            this.cmbFields.TabIndex = 0;
            this.cmbFields.SelectedIndexChanged += new System.EventHandler(this.cmbFields_SelectedIndexChanged);
            
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.Dock = System.Windows.Forms.DockStyle.Left;
            this.chk.Location = new System.Drawing.Point(0, 0);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(70, 20);
            this.chk.TabIndex = 1;
            this.chk.Text = "Group on";
            this.chk.UseVisualStyleBackColor = true;
            this.chk.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // DataGridViewGrouperControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cmbFields);
            this.Controls.Add(this.chk);
            this.Name = "DataGridViewGrouperControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Size = new System.Drawing.Size(209, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFields;
        private System.Windows.Forms.CheckBox chk;
    }
}
