namespace MasterNamespace
{
    partial class PersonEdit
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
            this.l_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.l_surname = new System.Windows.Forms.Label();
            this.l_secondaryname = new System.Windows.Forms.Label();
            this.l_date_brith = new System.Windows.Forms.Label();
            this.l_telnumber = new System.Windows.Forms.Label();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_secondaryname = new System.Windows.Forms.TextBox();
            this.dtp_birth_day = new System.Windows.Forms.DateTimePicker();
            this.mb_numberTel = new System.Windows.Forms.MaskedTextBox();
            this.bt_add_dan_pers = new System.Windows.Forms.Button();
            this.bt_canel_dan_person = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_post = new System.Windows.Forms.TextBox();
            this.cb_dept = new System.Windows.Forms.ComboBox();
            this.l3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(10, 35);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(32, 13);
            this.l_name.TabIndex = 0;
            this.l_name.Text = "Имя:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(139, 32);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(135, 20);
            this.tb_name.TabIndex = 1;
            // 
            // l_surname
            // 
            this.l_surname.AutoSize = true;
            this.l_surname.Location = new System.Drawing.Point(10, 9);
            this.l_surname.Name = "l_surname";
            this.l_surname.Size = new System.Drawing.Size(59, 13);
            this.l_surname.TabIndex = 2;
            this.l_surname.Text = "Фамилия:";
            // 
            // l_secondaryname
            // 
            this.l_secondaryname.AutoSize = true;
            this.l_secondaryname.Location = new System.Drawing.Point(10, 61);
            this.l_secondaryname.Name = "l_secondaryname";
            this.l_secondaryname.Size = new System.Drawing.Size(57, 13);
            this.l_secondaryname.TabIndex = 3;
            this.l_secondaryname.Text = "Отчество:";
            // 
            // l_date_brith
            // 
            this.l_date_brith.AutoSize = true;
            this.l_date_brith.Location = new System.Drawing.Point(10, 90);
            this.l_date_brith.Name = "l_date_brith";
            this.l_date_brith.Size = new System.Drawing.Size(90, 13);
            this.l_date_brith.TabIndex = 4;
            this.l_date_brith.Text = "День рождения:";
            // 
            // l_telnumber
            // 
            this.l_telnumber.AutoSize = true;
            this.l_telnumber.Location = new System.Drawing.Point(10, 113);
            this.l_telnumber.Name = "l_telnumber";
            this.l_telnumber.Size = new System.Drawing.Size(55, 13);
            this.l_telnumber.TabIndex = 5;
            this.l_telnumber.Text = "Телефон:";
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(139, 6);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(135, 20);
            this.tb_surname.TabIndex = 6;
            // 
            // tb_secondaryname
            // 
            this.tb_secondaryname.Location = new System.Drawing.Point(139, 58);
            this.tb_secondaryname.Name = "tb_secondaryname";
            this.tb_secondaryname.Size = new System.Drawing.Size(135, 20);
            this.tb_secondaryname.TabIndex = 7;
            // 
            // dtp_birth_day
            // 
            this.dtp_birth_day.Location = new System.Drawing.Point(139, 84);
            this.dtp_birth_day.Name = "dtp_birth_day";
            this.dtp_birth_day.Size = new System.Drawing.Size(135, 20);
            this.dtp_birth_day.TabIndex = 10;
            // 
            // mb_numberTel
            // 
            this.mb_numberTel.Location = new System.Drawing.Point(139, 110);
            this.mb_numberTel.Name = "mb_numberTel";
            this.mb_numberTel.Size = new System.Drawing.Size(135, 20);
            this.mb_numberTel.TabIndex = 11;
            // 
            // bt_add_dan_pers
            // 
            this.bt_add_dan_pers.Location = new System.Drawing.Point(15, 237);
            this.bt_add_dan_pers.Name = "bt_add_dan_pers";
            this.bt_add_dan_pers.Size = new System.Drawing.Size(100, 23);
            this.bt_add_dan_pers.TabIndex = 12;
            this.bt_add_dan_pers.Text = "Добавить";
            this.bt_add_dan_pers.UseVisualStyleBackColor = true;
            this.bt_add_dan_pers.Click += new System.EventHandler(this.bt_add_dan_pers_Click);
            // 
            // bt_canel_dan_person
            // 
            this.bt_canel_dan_person.Location = new System.Drawing.Point(160, 237);
            this.bt_canel_dan_person.Name = "bt_canel_dan_person";
            this.bt_canel_dan_person.Size = new System.Drawing.Size(102, 23);
            this.bt_canel_dan_person.TabIndex = 13;
            this.bt_canel_dan_person.Text = "Отмена";
            this.bt_canel_dan_person.UseVisualStyleBackColor = true;
            this.bt_canel_dan_person.Click += new System.EventHandler(this.bt_canel_dan_person_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Должность:";
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(139, 140);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(135, 20);
            this.tb_mail.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "E-mail:";
            // 
            // tb_post
            // 
            this.tb_post.Location = new System.Drawing.Point(139, 170);
            this.tb_post.Name = "tb_post";
            this.tb_post.Size = new System.Drawing.Size(135, 20);
            this.tb_post.TabIndex = 17;
            // 
            // cb_dept
            // 
            this.cb_dept.FormattingEnabled = true;
            this.cb_dept.Location = new System.Drawing.Point(139, 196);
            this.cb_dept.Name = "cb_dept";
            this.cb_dept.Size = new System.Drawing.Size(135, 21);
            this.cb_dept.TabIndex = 34;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(12, 204);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(41, 13);
            this.l3.TabIndex = 35;
            this.l3.Text = "Отдел:";
            // 
            // PersonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 263);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.cb_dept);
            this.Controls.Add(this.tb_post);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_canel_dan_person);
            this.Controls.Add(this.bt_add_dan_pers);
            this.Controls.Add(this.mb_numberTel);
            this.Controls.Add(this.dtp_birth_day);
            this.Controls.Add(this.tb_secondaryname);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.l_telnumber);
            this.Controls.Add(this.l_date_brith);
            this.Controls.Add(this.l_secondaryname);
            this.Controls.Add(this.l_surname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.l_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(299, 305);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(299, 270);
            this.Name = "PersonEdit";
            this.Text = "Добавление данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label l_surname;
        private System.Windows.Forms.Label l_secondaryname;
        private System.Windows.Forms.Label l_date_brith;
        private System.Windows.Forms.Label l_telnumber;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_secondaryname;
        private System.Windows.Forms.DateTimePicker dtp_birth_day;
        private System.Windows.Forms.MaskedTextBox mb_numberTel;
        private System.Windows.Forms.Button bt_canel_dan_person;
        public System.Windows.Forms.Button bt_add_dan_pers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_post;
        private System.Windows.Forms.ComboBox cb_dept;
        private System.Windows.Forms.Label l3;
    }
}