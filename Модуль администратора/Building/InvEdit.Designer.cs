namespace MasterNamespace
{
    partial class InvEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_id_room1 = new System.Windows.Forms.ComboBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.rtb_des = new System.Windows.Forms.RichTextBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_room = new System.Windows.Forms.ComboBox();
            this.cb_floor = new System.Windows.Forms.ComboBox();
            this.cb_title = new System.Windows.Forms.ComboBox();
            this.cb_house = new System.Windows.Forms.ComboBox();
            this.cb_street = new System.Windows.Forms.ComboBox();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_canel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cb_id_room1);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.rtb_des);
            this.groupBox1.Controls.Add(this.tb_number);
            this.groupBox1.Controls.Add(this.tb_title);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.MinimumSize = new System.Drawing.Size(204, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инвентарь";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 45;
            this.textBox1.Visible = false;
            // 
            // cb_id_room1
            // 
            this.cb_id_room1.FormattingEnabled = true;
            this.cb_id_room1.Location = new System.Drawing.Point(0, 199);
            this.cb_id_room1.Name = "cb_id_room1";
            this.cb_id_room1.Size = new System.Drawing.Size(121, 21);
            this.cb_id_room1.TabIndex = 44;
            this.cb_id_room1.Visible = false;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(76, 88);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(122, 20);
            this.dtp_date.TabIndex = 37;
            // 
            // rtb_des
            // 
            this.rtb_des.Location = new System.Drawing.Point(76, 122);
            this.rtb_des.Name = "rtb_des";
            this.rtb_des.Size = new System.Drawing.Size(122, 88);
            this.rtb_des.TabIndex = 8;
            this.rtb_des.Text = "";
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(76, 54);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(122, 20);
            this.tb_number.TabIndex = 5;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(76, 20);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(122, 20);
            this.tb_title.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата \r\nдобавления :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сер. номер :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cb_room);
            this.groupBox2.Controls.Add(this.cb_floor);
            this.groupBox2.Controls.Add(this.cb_title);
            this.groupBox2.Controls.Add(this.cb_house);
            this.groupBox2.Controls.Add(this.cb_street);
            this.groupBox2.Controls.Add(this.cb_city);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(224, 12);
            this.groupBox2.MinimumSize = new System.Drawing.Size(195, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Адрес";
            // 
            // cb_room
            // 
            this.cb_room.FormattingEnabled = true;
            this.cb_room.Location = new System.Drawing.Point(64, 188);
            this.cb_room.Name = "cb_room";
            this.cb_room.Size = new System.Drawing.Size(121, 21);
            this.cb_room.TabIndex = 43;
            // 
            // cb_floor
            // 
            this.cb_floor.FormattingEnabled = true;
            this.cb_floor.Location = new System.Drawing.Point(64, 156);
            this.cb_floor.Name = "cb_floor";
            this.cb_floor.Size = new System.Drawing.Size(121, 21);
            this.cb_floor.TabIndex = 42;
            // 
            // cb_title
            // 
            this.cb_title.FormattingEnabled = true;
            this.cb_title.Location = new System.Drawing.Point(64, 125);
            this.cb_title.Name = "cb_title";
            this.cb_title.Size = new System.Drawing.Size(121, 21);
            this.cb_title.TabIndex = 41;
            // 
            // cb_house
            // 
            this.cb_house.FormattingEnabled = true;
            this.cb_house.Location = new System.Drawing.Point(64, 86);
            this.cb_house.Name = "cb_house";
            this.cb_house.Size = new System.Drawing.Size(121, 21);
            this.cb_house.TabIndex = 40;
            // 
            // cb_street
            // 
            this.cb_street.FormattingEnabled = true;
            this.cb_street.Location = new System.Drawing.Point(64, 54);
            this.cb_street.Name = "cb_street";
            this.cb_street.Size = new System.Drawing.Size(121, 21);
            this.cb_street.TabIndex = 39;
            // 
            // cb_city
            // 
            this.cb_city.FormattingEnabled = true;
            this.cb_city.Location = new System.Drawing.Point(64, 20);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(121, 21);
            this.cb_city.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Корпус :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Этаж :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Комната :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Город :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Улица :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Дом :";
            // 
            // bt_add
            // 
            this.bt_add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_add.Location = new System.Drawing.Point(12, 244);
            this.bt_add.MinimumSize = new System.Drawing.Size(204, 43);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(206, 43);
            this.bt_add.TabIndex = 2;
            this.bt_add.Text = "bt_add";
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_canel
            // 
            this.bt_canel.Location = new System.Drawing.Point(224, 244);
            this.bt_canel.MinimumSize = new System.Drawing.Size(204, 43);
            this.bt_canel.Name = "bt_canel";
            this.bt_canel.Size = new System.Drawing.Size(206, 43);
            this.bt_canel.TabIndex = 3;
            this.bt_canel.Text = "bt_canel";
            this.bt_canel.UseVisualStyleBackColor = true;
            this.bt_canel.Click += new System.EventHandler(this.bt_canel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // InvEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 294);
            this.Controls.Add(this.bt_canel);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(456, 332);
            this.Name = "InvEdit";
            this.Text = "Добавлние инвентаря по адресу";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtb_des;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_canel;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cb_city;
        private System.Windows.Forms.ComboBox cb_street;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cb_house;
        private System.Windows.Forms.ComboBox cb_title;
        private System.Windows.Forms.ComboBox cb_floor;
        private System.Windows.Forms.ComboBox cb_room;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox cb_id_room1;
        private System.Windows.Forms.TextBox textBox1;
    }
}