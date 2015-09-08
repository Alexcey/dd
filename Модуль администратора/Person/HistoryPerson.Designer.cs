namespace MasterNamespace
{
    partial class HistoryPerson
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_hp_dept = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_hp_dept)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_hp_dept
            // 
            this.dg_hp_dept.AllowUserToAddRows = false;
            this.dg_hp_dept.AllowUserToDeleteRows = false;
            this.dg_hp_dept.AllowUserToResizeRows = false;
            this.dg_hp_dept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_hp_dept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_hp_dept.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_hp_dept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_hp_dept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.post});
            this.dg_hp_dept.Location = new System.Drawing.Point(1, 1);
            this.dg_hp_dept.MultiSelect = false;
            this.dg_hp_dept.Name = "dg_hp_dept";
            this.dg_hp_dept.ReadOnly = true;
            this.dg_hp_dept.RowHeadersVisible = false;
            this.dg_hp_dept.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_hp_dept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_hp_dept.Size = new System.Drawing.Size(481, 253);
            this.dg_hp_dept.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Отдел";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // post
            // 
            this.post.HeaderText = "Должность";
            this.post.Name = "post";
            this.post.ReadOnly = true;
            // 
            // HistoryPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 254);
            this.Controls.Add(this.dg_hp_dept);
            this.MaximumSize = new System.Drawing.Size(497, 292);
            this.MinimumSize = new System.Drawing.Size(497, 292);
            this.Name = "HistoryPerson";
            this.Text = "История";
            ((System.ComponentModel.ISupportInitialize)(this.dg_hp_dept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_hp_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn post;
    }
}