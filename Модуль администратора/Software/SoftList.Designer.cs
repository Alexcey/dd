namespace MasterNamespace
{
    partial class SoftList
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
            this.grb_choiceSoft_type = new System.Windows.Forms.GroupBox();
            this.bt_updateSoft_type = new System.Windows.Forms.Button();
            this.lb_soft_type = new System.Windows.Forms.ListBox();
            this.bt_deleteSoft_type = new System.Windows.Forms.Button();
            this.bt_addSoft_type = new System.Windows.Forms.Button();
            this.grb_choiceSoft = new System.Windows.Forms.GroupBox();
            this.tb_activation_key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_description_soft = new System.Windows.Forms.RichTextBox();
            this.l_activation_numb = new System.Windows.Forms.Label();
            this.l_date_add = new System.Windows.Forms.Label();
            this.dtp_date_add = new System.Windows.Forms.DateTimePicker();
            this.bt_delete_software = new System.Windows.Forms.Button();
            this.bt_update_software = new System.Windows.Forms.Button();
            this.bt_add_software = new System.Windows.Forms.Button();
            this.dg_Soft = new System.Windows.Forms.DataGridView();
            this.id_software = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_soft_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_sw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activation_numb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_choiceSoft_type.SuspendLayout();
            this.grb_choiceSoft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Soft)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_choiceSoft_type
            // 
            this.grb_choiceSoft_type.Controls.Add(this.bt_updateSoft_type);
            this.grb_choiceSoft_type.Controls.Add(this.lb_soft_type);
            this.grb_choiceSoft_type.Controls.Add(this.bt_deleteSoft_type);
            this.grb_choiceSoft_type.Controls.Add(this.bt_addSoft_type);
            this.grb_choiceSoft_type.Location = new System.Drawing.Point(12, 3);
            this.grb_choiceSoft_type.Name = "grb_choiceSoft_type";
            this.grb_choiceSoft_type.Size = new System.Drawing.Size(312, 353);
            this.grb_choiceSoft_type.TabIndex = 5;
            this.grb_choiceSoft_type.TabStop = false;
            this.grb_choiceSoft_type.Text = "Выбор типа ПО:";
            // 
            // bt_updateSoft_type
            // 
            this.bt_updateSoft_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_updateSoft_type.Location = new System.Drawing.Point(111, 311);
            this.bt_updateSoft_type.Name = "bt_updateSoft_type";
            this.bt_updateSoft_type.Size = new System.Drawing.Size(86, 36);
            this.bt_updateSoft_type.TabIndex = 2;
            this.bt_updateSoft_type.Text = "Изменить тип ПО";
            this.bt_updateSoft_type.UseVisualStyleBackColor = true;
            this.bt_updateSoft_type.Click += new System.EventHandler(this.bt_updateSoft_type_Click);
            // 
            // lb_soft_type
            // 
            this.lb_soft_type.FormattingEnabled = true;
            this.lb_soft_type.Location = new System.Drawing.Point(6, 19);
            this.lb_soft_type.Name = "lb_soft_type";
            this.lb_soft_type.Size = new System.Drawing.Size(292, 277);
            this.lb_soft_type.TabIndex = 4;
            this.lb_soft_type.SelectedIndexChanged += new System.EventHandler(this.lb_soft_type_SelectedIndexChanged);
            // 
            // bt_deleteSoft_type
            // 
            this.bt_deleteSoft_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_deleteSoft_type.Location = new System.Drawing.Point(212, 311);
            this.bt_deleteSoft_type.Name = "bt_deleteSoft_type";
            this.bt_deleteSoft_type.Size = new System.Drawing.Size(86, 36);
            this.bt_deleteSoft_type.TabIndex = 3;
            this.bt_deleteSoft_type.Text = "Удалить тип ПО";
            this.bt_deleteSoft_type.UseVisualStyleBackColor = true;
            this.bt_deleteSoft_type.Click += new System.EventHandler(this.bt_deleteSoft_type_Click);
            // 
            // bt_addSoft_type
            // 
            this.bt_addSoft_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_addSoft_type.Location = new System.Drawing.Point(6, 311);
            this.bt_addSoft_type.Name = "bt_addSoft_type";
            this.bt_addSoft_type.Size = new System.Drawing.Size(89, 36);
            this.bt_addSoft_type.TabIndex = 1;
            this.bt_addSoft_type.Text = "Добавить тип ПО";
            this.bt_addSoft_type.UseVisualStyleBackColor = true;
            this.bt_addSoft_type.Click += new System.EventHandler(this.bt_addSoft_type_Click);
            // 
            // grb_choiceSoft
            // 
            this.grb_choiceSoft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grb_choiceSoft.Controls.Add(this.tb_activation_key);
            this.grb_choiceSoft.Controls.Add(this.label2);
            this.grb_choiceSoft.Controls.Add(this.rb_description_soft);
            this.grb_choiceSoft.Controls.Add(this.l_activation_numb);
            this.grb_choiceSoft.Controls.Add(this.l_date_add);
            this.grb_choiceSoft.Controls.Add(this.dtp_date_add);
            this.grb_choiceSoft.Controls.Add(this.bt_delete_software);
            this.grb_choiceSoft.Controls.Add(this.bt_update_software);
            this.grb_choiceSoft.Controls.Add(this.bt_add_software);
            this.grb_choiceSoft.Controls.Add(this.dg_Soft);
            this.grb_choiceSoft.Location = new System.Drawing.Point(330, 3);
            this.grb_choiceSoft.Name = "grb_choiceSoft";
            this.grb_choiceSoft.Size = new System.Drawing.Size(532, 353);
            this.grb_choiceSoft.TabIndex = 6;
            this.grb_choiceSoft.TabStop = false;
            this.grb_choiceSoft.Text = "Выбор ПО:";
            // 
            // tb_activation_key
            // 
            this.tb_activation_key.Location = new System.Drawing.Point(381, 74);
            this.tb_activation_key.Name = "tb_activation_key";
            this.tb_activation_key.ReadOnly = true;
            this.tb_activation_key.Size = new System.Drawing.Size(145, 20);
            this.tb_activation_key.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Описание:";
            // 
            // rb_description_soft
            // 
            this.rb_description_soft.Location = new System.Drawing.Point(385, 113);
            this.rb_description_soft.Name = "rb_description_soft";
            this.rb_description_soft.ReadOnly = true;
            this.rb_description_soft.Size = new System.Drawing.Size(141, 183);
            this.rb_description_soft.TabIndex = 15;
            this.rb_description_soft.Text = "";
            // 
            // l_activation_numb
            // 
            this.l_activation_numb.AutoSize = true;
            this.l_activation_numb.Location = new System.Drawing.Point(378, 58);
            this.l_activation_numb.Name = "l_activation_numb";
            this.l_activation_numb.Size = new System.Drawing.Size(141, 13);
            this.l_activation_numb.TabIndex = 14;
            this.l_activation_numb.Text = "Ключ активации продукта:";
            // 
            // l_date_add
            // 
            this.l_date_add.AutoSize = true;
            this.l_date_add.Location = new System.Drawing.Point(378, 19);
            this.l_date_add.Name = "l_date_add";
            this.l_date_add.Size = new System.Drawing.Size(99, 13);
            this.l_date_add.TabIndex = 12;
            this.l_date_add.Text = "Дата добавления:";
            // 
            // dtp_date_add
            // 
            this.dtp_date_add.Enabled = false;
            this.dtp_date_add.Location = new System.Drawing.Point(381, 35);
            this.dtp_date_add.Name = "dtp_date_add";
            this.dtp_date_add.Size = new System.Drawing.Size(145, 20);
            this.dtp_date_add.TabIndex = 11;
            // 
            // bt_delete_software
            // 
            this.bt_delete_software.Location = new System.Drawing.Point(374, 309);
            this.bt_delete_software.Name = "bt_delete_software";
            this.bt_delete_software.Size = new System.Drawing.Size(145, 36);
            this.bt_delete_software.TabIndex = 3;
            this.bt_delete_software.Text = "Удалить ПО";
            this.bt_delete_software.UseVisualStyleBackColor = true;
            this.bt_delete_software.Click += new System.EventHandler(this.bt_delete_software_Click);
            // 
            // bt_update_software
            // 
            this.bt_update_software.Location = new System.Drawing.Point(188, 309);
            this.bt_update_software.Name = "bt_update_software";
            this.bt_update_software.Size = new System.Drawing.Size(145, 36);
            this.bt_update_software.TabIndex = 2;
            this.bt_update_software.Text = "Изменить данные о ПО";
            this.bt_update_software.UseVisualStyleBackColor = true;
            this.bt_update_software.Click += new System.EventHandler(this.bt_update_software_Click);
            // 
            // bt_add_software
            // 
            this.bt_add_software.Location = new System.Drawing.Point(7, 309);
            this.bt_add_software.Name = "bt_add_software";
            this.bt_add_software.Size = new System.Drawing.Size(145, 36);
            this.bt_add_software.TabIndex = 1;
            this.bt_add_software.Text = "Добавить ПО";
            this.bt_add_software.UseVisualStyleBackColor = true;
            this.bt_add_software.Click += new System.EventHandler(this.bt_add_software_Click);
            // 
            // dg_Soft
            // 
            this.dg_Soft.AllowUserToAddRows = false;
            this.dg_Soft.AllowUserToDeleteRows = false;
            this.dg_Soft.AllowUserToResizeRows = false;
            this.dg_Soft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dg_Soft.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_Soft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Soft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_software,
            this.id_soft_type,
            this.s_title,
            this.type_sw,
            this.Column1,
            this.date_add,
            this.activation_numb,
            this.description});
            this.dg_Soft.Location = new System.Drawing.Point(7, 19);
            this.dg_Soft.MultiSelect = false;
            this.dg_Soft.Name = "dg_Soft";
            this.dg_Soft.ReadOnly = true;
            this.dg_Soft.RowHeadersVisible = false;
            this.dg_Soft.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_Soft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Soft.Size = new System.Drawing.Size(369, 277);
            this.dg_Soft.TabIndex = 0;
            this.dg_Soft.SelectionChanged += new System.EventHandler(this.dg_Soft_SelectionChanged);
            // 
            // id_software
            // 
            this.id_software.FillWeight = 60F;
            this.id_software.HeaderText = "id_software";
            this.id_software.Name = "id_software";
            this.id_software.ReadOnly = true;
            this.id_software.Visible = false;
            this.id_software.Width = 67;
            // 
            // id_soft_type
            // 
            this.id_soft_type.HeaderText = "id_soft_type";
            this.id_soft_type.Name = "id_soft_type";
            this.id_soft_type.ReadOnly = true;
            this.id_soft_type.Visible = false;
            this.id_soft_type.Width = 70;
            // 
            // s_title
            // 
            this.s_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.s_title.FillWeight = 86.92893F;
            this.s_title.HeaderText = "Название";
            this.s_title.Name = "s_title";
            this.s_title.ReadOnly = true;
            // 
            // type_sw
            // 
            this.type_sw.HeaderText = "Тип лицензии";
            this.type_sw.Name = "type_sw";
            this.type_sw.ReadOnly = true;
            this.type_sw.Width = 102;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Производитель";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 111;
            // 
            // date_add
            // 
            this.date_add.HeaderText = "date_add";
            this.date_add.Name = "date_add";
            this.date_add.ReadOnly = true;
            this.date_add.Visible = false;
            this.date_add.Width = 77;
            // 
            // activation_numb
            // 
            this.activation_numb.HeaderText = "activation_numb";
            this.activation_numb.Name = "activation_numb";
            this.activation_numb.ReadOnly = true;
            this.activation_numb.Visible = false;
            this.activation_numb.Width = 110;
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            this.description.Width = 83;
            // 
            // SoftList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 370);
            this.Controls.Add(this.grb_choiceSoft);
            this.Controls.Add(this.grb_choiceSoft_type);
            this.MaximumSize = new System.Drawing.Size(890, 408);
            this.MinimumSize = new System.Drawing.Size(890, 408);
            this.Name = "SoftList";
            this.Text = "Редактирование ПО";
            this.grb_choiceSoft_type.ResumeLayout(false);
            this.grb_choiceSoft.ResumeLayout(false);
            this.grb_choiceSoft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Soft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_choiceSoft_type;
        private System.Windows.Forms.ListBox lb_soft_type;
        private System.Windows.Forms.Button bt_deleteSoft_type;
        private System.Windows.Forms.Button bt_addSoft_type;
        private System.Windows.Forms.Button bt_updateSoft_type;
        private System.Windows.Forms.GroupBox grb_choiceSoft;
        private System.Windows.Forms.Button bt_delete_software;
        private System.Windows.Forms.Button bt_update_software;
        private System.Windows.Forms.Button bt_add_software;
        private System.Windows.Forms.DataGridView dg_Soft;
        private System.Windows.Forms.DateTimePicker dtp_date_add;
        private System.Windows.Forms.Label l_date_add;
        private System.Windows.Forms.Label l_activation_numb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rb_description_soft;
        private System.Windows.Forms.TextBox tb_activation_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_software;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_soft_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_sw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn activation_numb;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;

    }
}