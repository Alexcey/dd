namespace MasterNamespace
{
    partial class Add_SOFTinInv
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
            this.dg_soft_inv = new System.Windows.Forms.DataGridView();
            this.id_record = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_soft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Инвентарь = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_select = new System.Windows.Forms.ComboBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_soft_inv)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_soft_inv
            // 
            this.dg_soft_inv.AllowUserToAddRows = false;
            this.dg_soft_inv.AllowUserToDeleteRows = false;
            this.dg_soft_inv.AllowUserToResizeRows = false;
            this.dg_soft_inv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_soft_inv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_soft_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_soft_inv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_record,
            this.id_soft,
            this.Инвентарь,
            this.date_add});
            this.dg_soft_inv.Dock = System.Windows.Forms.DockStyle.Left;
            this.dg_soft_inv.Location = new System.Drawing.Point(0, 0);
            this.dg_soft_inv.MultiSelect = false;
            this.dg_soft_inv.Name = "dg_soft_inv";
            this.dg_soft_inv.ReadOnly = true;
            this.dg_soft_inv.RowHeadersVisible = false;
            this.dg_soft_inv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_soft_inv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_soft_inv.Size = new System.Drawing.Size(302, 253);
            this.dg_soft_inv.TabIndex = 7;
            // 
            // id_record
            // 
            this.id_record.HeaderText = "id_record";
            this.id_record.Name = "id_record";
            this.id_record.ReadOnly = true;
            this.id_record.Visible = false;
            // 
            // id_soft
            // 
            this.id_soft.HeaderText = "id_soft";
            this.id_soft.Name = "id_soft";
            this.id_soft.ReadOnly = true;
            this.id_soft.Visible = false;
            // 
            // Инвентарь
            // 
            this.Инвентарь.HeaderText = "Название ПО";
            this.Инвентарь.Name = "Инвентарь";
            this.Инвентарь.ReadOnly = true;
            // 
            // date_add
            // 
            this.date_add.HeaderText = "Дата добавления";
            this.date_add.Name = "date_add";
            this.date_add.ReadOnly = true;
            // 
            // cb_select
            // 
            this.cb_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_select.FormattingEnabled = true;
            this.cb_select.Location = new System.Drawing.Point(308, 12);
            this.cb_select.Name = "cb_select";
            this.cb_select.Size = new System.Drawing.Size(199, 21);
            this.cb_select.TabIndex = 8;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(352, 106);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(155, 49);
            this.bt_add.TabIndex = 9;
            this.bt_add.Text = "Добавить";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(352, 192);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(155, 49);
            this.bt_del.TabIndex = 10;
            this.bt_del.Text = "Удалить";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // Add_SOFTinInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 253);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.cb_select);
            this.Controls.Add(this.dg_soft_inv);
            this.Name = "Add_SOFTinInv";
            this.Text = "Добавление ПО в инвентарь";
            ((System.ComponentModel.ISupportInitialize)(this.dg_soft_inv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_soft_inv;
        private System.Windows.Forms.ComboBox cb_select;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_record;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_soft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Инвентарь;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_add;


    }
}