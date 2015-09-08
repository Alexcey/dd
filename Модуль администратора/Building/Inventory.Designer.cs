namespace MasterNamespace
{
    partial class Inventory
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
            this.lb_inv_type = new System.Windows.Forms.ListBox();
            this.dg_inv = new System.Windows.Forms.DataGridView();
            this.id_inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_inv_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seria_numb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btt_update_type_inv = new System.Windows.Forms.Button();
            this.bt_add_type_inv = new System.Windows.Forms.Button();
            this.bt_del_type_inv = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_add_PO = new System.Windows.Forms.Button();
            this.bt_del_inv = new System.Windows.Forms.Button();
            this.bt_update_inv = new System.Windows.Forms.Button();
            this.bt_add_inv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_inv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_inv_type
            // 
            this.lb_inv_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_inv_type.FormattingEnabled = true;
            this.lb_inv_type.Location = new System.Drawing.Point(6, 17);
            this.lb_inv_type.Name = "lb_inv_type";
            this.lb_inv_type.Size = new System.Drawing.Size(232, 199);
            this.lb_inv_type.TabIndex = 5;
            this.lb_inv_type.SelectedIndexChanged += new System.EventHandler(this.lb_inv_type_SelectedIndexChanged);
            // 
            // dg_inv
            // 
            this.dg_inv.AllowUserToAddRows = false;
            this.dg_inv.AllowUserToDeleteRows = false;
            this.dg_inv.AllowUserToResizeRows = false;
            this.dg_inv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dg_inv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_inv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_inv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_inventory,
            this.id_inv_type,
            this.id_room,
            this.title,
            this.seria_numb,
            this.description,
            this.data_add,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dg_inv.Location = new System.Drawing.Point(6, 16);
            this.dg_inv.MultiSelect = false;
            this.dg_inv.Name = "dg_inv";
            this.dg_inv.ReadOnly = true;
            this.dg_inv.RowHeadersVisible = false;
            this.dg_inv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_inv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_inv.Size = new System.Drawing.Size(348, 200);
            this.dg_inv.TabIndex = 6;
            // 
            // id_inventory
            // 
            this.id_inventory.HeaderText = "id_inventory";
            this.id_inventory.Name = "id_inventory";
            this.id_inventory.ReadOnly = true;
            this.id_inventory.Visible = false;
            // 
            // id_inv_type
            // 
            this.id_inv_type.HeaderText = "id_inv_type";
            this.id_inv_type.Name = "id_inv_type";
            this.id_inv_type.ReadOnly = true;
            this.id_inv_type.Visible = false;
            // 
            // id_room
            // 
            this.id_room.HeaderText = "id_room";
            this.id_room.Name = "id_room";
            this.id_room.ReadOnly = true;
            this.id_room.Visible = false;
            // 
            // title
            // 
            this.title.HeaderText = "Название";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // seria_numb
            // 
            this.seria_numb.HeaderText = "Серийный номер";
            this.seria_numb.Name = "seria_numb";
            this.seria_numb.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Описание";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // data_add
            // 
            this.data_add.HeaderText = "Дата";
            this.data_add.Name = "data_add";
            this.data_add.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btt_update_type_inv);
            this.groupBox1.Controls.Add(this.lb_inv_type);
            this.groupBox1.Controls.Add(this.bt_add_type_inv);
            this.groupBox1.Controls.Add(this.bt_del_type_inv);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 266);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип инвентаря";
            // 
            // btt_update_type_inv
            // 
            this.btt_update_type_inv.Location = new System.Drawing.Point(87, 227);
            this.btt_update_type_inv.Name = "btt_update_type_inv";
            this.btt_update_type_inv.Size = new System.Drawing.Size(73, 33);
            this.btt_update_type_inv.TabIndex = 10;
            this.btt_update_type_inv.Text = "Изменить";
            this.btt_update_type_inv.UseVisualStyleBackColor = true;
            this.btt_update_type_inv.Click += new System.EventHandler(this.btt_update_type_inv_Click);
            // 
            // bt_add_type_inv
            // 
            this.bt_add_type_inv.Location = new System.Drawing.Point(6, 227);
            this.bt_add_type_inv.Name = "bt_add_type_inv";
            this.bt_add_type_inv.Size = new System.Drawing.Size(73, 33);
            this.bt_add_type_inv.TabIndex = 9;
            this.bt_add_type_inv.Text = "Добавить";
            this.bt_add_type_inv.UseVisualStyleBackColor = true;
            this.bt_add_type_inv.Click += new System.EventHandler(this.bt_add_type_inv_Click);
            // 
            // bt_del_type_inv
            // 
            this.bt_del_type_inv.Location = new System.Drawing.Point(166, 227);
            this.bt_del_type_inv.Name = "bt_del_type_inv";
            this.bt_del_type_inv.Size = new System.Drawing.Size(73, 32);
            this.bt_del_type_inv.TabIndex = 11;
            this.bt_del_type_inv.Text = "Удалить";
            this.bt_del_type_inv.UseVisualStyleBackColor = true;
            this.bt_del_type_inv.Click += new System.EventHandler(this.bt_del_type_inv_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_add_PO);
            this.groupBox2.Controls.Add(this.bt_del_inv);
            this.groupBox2.Controls.Add(this.dg_inv);
            this.groupBox2.Controls.Add(this.bt_update_inv);
            this.groupBox2.Controls.Add(this.bt_add_inv);
            this.groupBox2.Location = new System.Drawing.Point(262, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 266);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Инвентарь";
            // 
            // bt_add_PO
            // 
            this.bt_add_PO.Location = new System.Drawing.Point(172, 222);
            this.bt_add_PO.Name = "bt_add_PO";
            this.bt_add_PO.Size = new System.Drawing.Size(83, 38);
            this.bt_add_PO.TabIndex = 15;
            this.bt_add_PO.Text = "Добавить ПО";
            this.bt_add_PO.UseVisualStyleBackColor = true;
            this.bt_add_PO.Click += new System.EventHandler(this.bt_add_PO_Click);
            // 
            // bt_del_inv
            // 
            this.bt_del_inv.Location = new System.Drawing.Point(261, 222);
            this.bt_del_inv.Name = "bt_del_inv";
            this.bt_del_inv.Size = new System.Drawing.Size(93, 38);
            this.bt_del_inv.TabIndex = 14;
            this.bt_del_inv.Text = "Удалить";
            this.bt_del_inv.UseVisualStyleBackColor = true;
            this.bt_del_inv.Click += new System.EventHandler(this.bt_del_inv_Click);
            // 
            // bt_update_inv
            // 
            this.bt_update_inv.Location = new System.Drawing.Point(89, 222);
            this.bt_update_inv.Name = "bt_update_inv";
            this.bt_update_inv.Size = new System.Drawing.Size(77, 38);
            this.bt_update_inv.TabIndex = 13;
            this.bt_update_inv.Text = "Изменить";
            this.bt_update_inv.UseVisualStyleBackColor = true;
            this.bt_update_inv.Click += new System.EventHandler(this.bt_update_inv_Click);
            // 
            // bt_add_inv
            // 
            this.bt_add_inv.Location = new System.Drawing.Point(6, 222);
            this.bt_add_inv.Name = "bt_add_inv";
            this.bt_add_inv.Size = new System.Drawing.Size(77, 38);
            this.bt_add_inv.TabIndex = 12;
            this.bt_add_inv.Text = "Добавить";
            this.bt_add_inv.UseVisualStyleBackColor = true;
            this.bt_add_inv.Click += new System.EventHandler(this.bt_add_inv_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inventory";
            this.Text = "Редактор инвенторя";
            ((System.ComponentModel.ISupportInitialize)(this.dg_inv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_inv_type;
        private System.Windows.Forms.DataGridView dg_inv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_add_type_inv;
        private System.Windows.Forms.Button btt_update_type_inv;
        private System.Windows.Forms.Button bt_del_type_inv;
        private System.Windows.Forms.Button bt_add_inv;
        private System.Windows.Forms.Button bt_update_inv;
        private System.Windows.Forms.Button bt_del_inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inv_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn seria_numb;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button bt_add_PO;
    }
}