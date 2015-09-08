namespace MasterNamespace
{
    partial class SoftEditor
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
            this.components = new System.ComponentModel.Container();
            this.l_title_soft = new System.Windows.Forms.Label();
            this.tb_title_soft_type = new System.Windows.Forms.TextBox();
            this.l_date_add = new System.Windows.Forms.Label();
            this.l_activation_numb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_description_soft = new System.Windows.Forms.RichTextBox();
            this.bt_edit_soft = new System.Windows.Forms.Button();
            this.bt_canel_soft = new System.Windows.Forms.Button();
            this.tb_activation_key = new System.Windows.Forms.TextBox();
            this.dtp_date_add = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_producer = new System.Windows.Forms.ComboBox();
            this.cb_type_SW = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // l_title_soft
            // 
            this.l_title_soft.AutoSize = true;
            this.l_title_soft.Location = new System.Drawing.Point(12, 9);
            this.l_title_soft.Name = "l_title_soft";
            this.l_title_soft.Size = new System.Drawing.Size(60, 13);
            this.l_title_soft.TabIndex = 2;
            this.l_title_soft.Text = "Название:";
            // 
            // tb_title_soft_type
            // 
            this.tb_title_soft_type.Location = new System.Drawing.Point(159, 9);
            this.tb_title_soft_type.Name = "tb_title_soft_type";
            this.tb_title_soft_type.Size = new System.Drawing.Size(155, 20);
            this.tb_title_soft_type.TabIndex = 6;
            // 
            // l_date_add
            // 
            this.l_date_add.AutoSize = true;
            this.l_date_add.Location = new System.Drawing.Point(12, 97);
            this.l_date_add.Name = "l_date_add";
            this.l_date_add.Size = new System.Drawing.Size(99, 13);
            this.l_date_add.TabIndex = 15;
            this.l_date_add.Text = "Дата добавления:";
            // 
            // l_activation_numb
            // 
            this.l_activation_numb.AutoSize = true;
            this.l_activation_numb.Location = new System.Drawing.Point(12, 128);
            this.l_activation_numb.Name = "l_activation_numb";
            this.l_activation_numb.Size = new System.Drawing.Size(141, 13);
            this.l_activation_numb.TabIndex = 17;
            this.l_activation_numb.Text = "Ключ активации продукта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Описание:";
            // 
            // rb_description_soft
            // 
            this.rb_description_soft.Location = new System.Drawing.Point(159, 159);
            this.rb_description_soft.Name = "rb_description_soft";
            this.rb_description_soft.Size = new System.Drawing.Size(155, 72);
            this.rb_description_soft.TabIndex = 20;
            this.rb_description_soft.Text = "";
            // 
            // bt_edit_soft
            // 
            this.bt_edit_soft.Location = new System.Drawing.Point(15, 248);
            this.bt_edit_soft.Name = "bt_edit_soft";
            this.bt_edit_soft.Size = new System.Drawing.Size(106, 23);
            this.bt_edit_soft.TabIndex = 21;
            this.bt_edit_soft.Text = "Добавить";
            this.bt_edit_soft.UseVisualStyleBackColor = true;
            this.bt_edit_soft.Click += new System.EventHandler(this.bt_edit_soft_Click);
            // 
            // bt_canel_soft
            // 
            this.bt_canel_soft.Location = new System.Drawing.Point(208, 248);
            this.bt_canel_soft.Name = "bt_canel_soft";
            this.bt_canel_soft.Size = new System.Drawing.Size(106, 23);
            this.bt_canel_soft.TabIndex = 22;
            this.bt_canel_soft.Text = "Отмена";
            this.bt_canel_soft.UseVisualStyleBackColor = true;
            this.bt_canel_soft.Click += new System.EventHandler(this.bt_canel_soft_Click);
            // 
            // tb_activation_key
            // 
            this.tb_activation_key.Location = new System.Drawing.Point(159, 128);
            this.tb_activation_key.Name = "tb_activation_key";
            this.tb_activation_key.Size = new System.Drawing.Size(155, 20);
            this.tb_activation_key.TabIndex = 23;
            // 
            // dtp_date_add
            // 
            this.dtp_date_add.Location = new System.Drawing.Point(159, 97);
            this.dtp_date_add.Name = "dtp_date_add";
            this.dtp_date_add.Size = new System.Drawing.Size(155, 20);
            this.dtp_date_add.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Производитель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Тип лицензии:";
            // 
            // cb_producer
            // 
            this.cb_producer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_producer.FormattingEnabled = true;
            this.cb_producer.Location = new System.Drawing.Point(159, 64);
            this.cb_producer.Name = "cb_producer";
            this.cb_producer.Size = new System.Drawing.Size(155, 21);
            this.cb_producer.TabIndex = 31;
            // 
            // cb_type_SW
            // 
            this.cb_type_SW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type_SW.FormattingEnabled = true;
            this.cb_type_SW.Location = new System.Drawing.Point(159, 35);
            this.cb_type_SW.Name = "cb_type_SW";
            this.cb_type_SW.Size = new System.Drawing.Size(155, 21);
            this.cb_type_SW.TabIndex = 32;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SoftEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 278);
            this.Controls.Add(this.cb_type_SW);
            this.Controls.Add(this.cb_producer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_date_add);
            this.Controls.Add(this.tb_activation_key);
            this.Controls.Add(this.bt_canel_soft);
            this.Controls.Add(this.bt_edit_soft);
            this.Controls.Add(this.rb_description_soft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_activation_numb);
            this.Controls.Add(this.l_date_add);
            this.Controls.Add(this.tb_title_soft_type);
            this.Controls.Add(this.l_title_soft);
            this.MaximumSize = new System.Drawing.Size(350, 316);
            this.MinimumSize = new System.Drawing.Size(350, 316);
            this.Name = "SoftEditor";
            this.Text = "Добавление ПО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_title_soft;
        private System.Windows.Forms.TextBox tb_title_soft_type;
        private System.Windows.Forms.Label l_date_add;
        private System.Windows.Forms.Label l_activation_numb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rb_description_soft;
        private System.Windows.Forms.Button bt_edit_soft;
        private System.Windows.Forms.Button bt_canel_soft;
        private System.Windows.Forms.TextBox tb_activation_key;
        private System.Windows.Forms.DateTimePicker dtp_date_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_producer;
        private System.Windows.Forms.ComboBox cb_type_SW;
        private System.Windows.Forms.Timer timer1;
    }
}