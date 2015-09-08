namespace MasterNamespace
{
    partial class DeptList
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
            this.bt_addDept = new System.Windows.Forms.Button();
            this.bt_updateDept = new System.Windows.Forms.Button();
            this.bt_deleteDept = new System.Windows.Forms.Button();
            this.grb_choiceDept = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_description_dept = new System.Windows.Forms.RichTextBox();
            this.lb_dept = new System.Windows.Forms.ListBox();
            this.grb_choicePerson = new System.Windows.Forms.GroupBox();
            this.bt_HP = new System.Windows.Forms.Button();
            this.bt_delete_person = new System.Windows.Forms.Button();
            this.bt_update_person = new System.Windows.Forms.Button();
            this.bt_add_person = new System.Windows.Forms.Button();
            this.dg_person = new System.Windows.Forms.DataGridView();
            this.id_person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondaryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_brith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_choiceDept.SuspendLayout();
            this.grb_choicePerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_person)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_addDept
            // 
            this.bt_addDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_addDept.Location = new System.Drawing.Point(6, 347);
            this.bt_addDept.Name = "bt_addDept";
            this.bt_addDept.Size = new System.Drawing.Size(94, 36);
            this.bt_addDept.TabIndex = 1;
            this.bt_addDept.Text = "Добавить отдел";
            this.bt_addDept.UseVisualStyleBackColor = true;
            this.bt_addDept.Click += new System.EventHandler(this.bt_addDept_Click);
            // 
            // bt_updateDept
            // 
            this.bt_updateDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_updateDept.Location = new System.Drawing.Point(106, 347);
            this.bt_updateDept.Name = "bt_updateDept";
            this.bt_updateDept.Size = new System.Drawing.Size(100, 36);
            this.bt_updateDept.TabIndex = 2;
            this.bt_updateDept.Text = "Изменить  данные о отделе";
            this.bt_updateDept.UseVisualStyleBackColor = true;
            this.bt_updateDept.Click += new System.EventHandler(this.bt_updateDept_Click);
            // 
            // bt_deleteDept
            // 
            this.bt_deleteDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_deleteDept.Location = new System.Drawing.Point(217, 347);
            this.bt_deleteDept.Name = "bt_deleteDept";
            this.bt_deleteDept.Size = new System.Drawing.Size(94, 36);
            this.bt_deleteDept.TabIndex = 3;
            this.bt_deleteDept.Text = "Удалить отдел";
            this.bt_deleteDept.UseVisualStyleBackColor = true;
            this.bt_deleteDept.Click += new System.EventHandler(this.bt_deleteDept_Click);
            // 
            // grb_choiceDept
            // 
            this.grb_choiceDept.Controls.Add(this.label1);
            this.grb_choiceDept.Controls.Add(this.rb_description_dept);
            this.grb_choiceDept.Controls.Add(this.lb_dept);
            this.grb_choiceDept.Controls.Add(this.bt_deleteDept);
            this.grb_choiceDept.Controls.Add(this.bt_addDept);
            this.grb_choiceDept.Controls.Add(this.bt_updateDept);
            this.grb_choiceDept.Location = new System.Drawing.Point(13, 3);
            this.grb_choiceDept.Name = "grb_choiceDept";
            this.grb_choiceDept.Size = new System.Drawing.Size(317, 391);
            this.grb_choiceDept.TabIndex = 4;
            this.grb_choiceDept.TabStop = false;
            this.grb_choiceDept.Text = "Выбор отдела:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Описание отдела:";
            // 
            // rb_description_dept
            // 
            this.rb_description_dept.Location = new System.Drawing.Point(6, 209);
            this.rb_description_dept.Name = "rb_description_dept";
            this.rb_description_dept.ReadOnly = true;
            this.rb_description_dept.Size = new System.Drawing.Size(308, 119);
            this.rb_description_dept.TabIndex = 5;
            this.rb_description_dept.Text = "";
            // 
            // lb_dept
            // 
            this.lb_dept.FormattingEnabled = true;
            this.lb_dept.Location = new System.Drawing.Point(6, 19);
            this.lb_dept.Name = "lb_dept";
            this.lb_dept.Size = new System.Drawing.Size(305, 160);
            this.lb_dept.TabIndex = 4;
            this.lb_dept.SelectedIndexChanged += new System.EventHandler(this.lb_dept_SelectedIndexChanged);
            // 
            // grb_choicePerson
            // 
            this.grb_choicePerson.Controls.Add(this.bt_HP);
            this.grb_choicePerson.Controls.Add(this.bt_delete_person);
            this.grb_choicePerson.Controls.Add(this.bt_update_person);
            this.grb_choicePerson.Controls.Add(this.bt_add_person);
            this.grb_choicePerson.Controls.Add(this.dg_person);
            this.grb_choicePerson.Location = new System.Drawing.Point(337, 3);
            this.grb_choicePerson.Name = "grb_choicePerson";
            this.grb_choicePerson.Size = new System.Drawing.Size(574, 391);
            this.grb_choicePerson.TabIndex = 5;
            this.grb_choicePerson.TabStop = false;
            this.grb_choicePerson.Text = "Выбор сотрудника:";
            // 
            // bt_HP
            // 
            this.bt_HP.Location = new System.Drawing.Point(413, 346);
            this.bt_HP.Name = "bt_HP";
            this.bt_HP.Size = new System.Drawing.Size(152, 35);
            this.bt_HP.TabIndex = 4;
            this.bt_HP.Text = "Посмотреть историю";
            this.bt_HP.UseVisualStyleBackColor = true;
            this.bt_HP.Click += new System.EventHandler(this.bt_HP_Click);
            // 
            // bt_delete_person
            // 
            this.bt_delete_person.Location = new System.Drawing.Point(7, 346);
            this.bt_delete_person.Name = "bt_delete_person";
            this.bt_delete_person.Size = new System.Drawing.Size(87, 35);
            this.bt_delete_person.TabIndex = 3;
            this.bt_delete_person.Text = "Уволить сотрудника";
            this.bt_delete_person.UseVisualStyleBackColor = true;
            this.bt_delete_person.Visible = false;
            this.bt_delete_person.Click += new System.EventHandler(this.bt_delete_person_Click);
            // 
            // bt_update_person
            // 
            this.bt_update_person.Location = new System.Drawing.Point(220, 346);
            this.bt_update_person.Name = "bt_update_person";
            this.bt_update_person.Size = new System.Drawing.Size(151, 35);
            this.bt_update_person.TabIndex = 2;
            this.bt_update_person.Text = "Изменить данные о сотруднике";
            this.bt_update_person.UseVisualStyleBackColor = true;
            this.bt_update_person.Click += new System.EventHandler(this.bt_update_person_Click);
            // 
            // bt_add_person
            // 
            this.bt_add_person.Location = new System.Drawing.Point(31, 346);
            this.bt_add_person.Name = "bt_add_person";
            this.bt_add_person.Size = new System.Drawing.Size(153, 35);
            this.bt_add_person.TabIndex = 1;
            this.bt_add_person.Text = "Добавить сотрудника";
            this.bt_add_person.UseVisualStyleBackColor = true;
            this.bt_add_person.Click += new System.EventHandler(this.bt_add_person_Click);
            // 
            // dg_person
            // 
            this.dg_person.AllowUserToAddRows = false;
            this.dg_person.AllowUserToDeleteRows = false;
            this.dg_person.AllowUserToResizeRows = false;
            this.dg_person.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dg_person.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_person.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_person,
            this.id_dept,
            this.name,
            this.surname,
            this.secondaryname,
            this.data_brith,
            this.tel_number,
            this.mail,
            this.post});
            this.dg_person.Location = new System.Drawing.Point(7, 20);
            this.dg_person.MultiSelect = false;
            this.dg_person.Name = "dg_person";
            this.dg_person.ReadOnly = true;
            this.dg_person.RowHeadersVisible = false;
            this.dg_person.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_person.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_person.Size = new System.Drawing.Size(561, 308);
            this.dg_person.TabIndex = 0;
            // 
            // id_person
            // 
            this.id_person.FillWeight = 60F;
            this.id_person.HeaderText = "id_person";
            this.id_person.Name = "id_person";
            this.id_person.ReadOnly = true;
            this.id_person.Visible = false;
            this.id_person.Width = 59;
            // 
            // id_dept
            // 
            this.id_dept.HeaderText = "id_dept";
            this.id_dept.Name = "id_dept";
            this.id_dept.ReadOnly = true;
            this.id_dept.Visible = false;
            this.id_dept.Width = 48;
            // 
            // name
            // 
            this.name.FillWeight = 86.92893F;
            this.name.HeaderText = "Фамилия";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 81;
            // 
            // surname
            // 
            this.surname.FillWeight = 86.92893F;
            this.surname.HeaderText = "Имя";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 54;
            // 
            // secondaryname
            // 
            this.secondaryname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.secondaryname.FillWeight = 86.92893F;
            this.secondaryname.HeaderText = "Отчество";
            this.secondaryname.Name = "secondaryname";
            this.secondaryname.ReadOnly = true;
            // 
            // data_brith
            // 
            this.data_brith.FillWeight = 60F;
            this.data_brith.HeaderText = "День рожд.";
            this.data_brith.Name = "data_brith";
            this.data_brith.ReadOnly = true;
            this.data_brith.Width = 91;
            // 
            // tel_number
            // 
            this.tel_number.FillWeight = 86.92893F;
            this.tel_number.HeaderText = "Номер тел.";
            this.tel_number.Name = "tel_number";
            this.tel_number.ReadOnly = true;
            this.tel_number.Width = 89;
            // 
            // mail
            // 
            this.mail.HeaderText = "e-mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Width = 59;
            // 
            // post
            // 
            this.post.HeaderText = "Должность";
            this.post.Name = "post";
            this.post.ReadOnly = true;
            this.post.Width = 90;
            // 
            // DeptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(914, 397);
            this.Controls.Add(this.grb_choicePerson);
            this.Controls.Add(this.grb_choiceDept);
            this.MaximumSize = new System.Drawing.Size(930, 435);
            this.MinimumSize = new System.Drawing.Size(930, 435);
            this.Name = "DeptList";
            this.Text = "Редактирование отделов";
            this.grb_choiceDept.ResumeLayout(false);
            this.grb_choiceDept.PerformLayout();
            this.grb_choicePerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_person)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_addDept;
        private System.Windows.Forms.Button bt_updateDept;
        private System.Windows.Forms.Button bt_deleteDept;
        private System.Windows.Forms.GroupBox grb_choiceDept;
        private System.Windows.Forms.GroupBox grb_choicePerson;
        private System.Windows.Forms.Button bt_delete_person;
        private System.Windows.Forms.Button bt_update_person;
        private System.Windows.Forms.Button bt_add_person;
        private System.Windows.Forms.DataGridView dg_person;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rb_description_dept;
        private System.Windows.Forms.ListBox lb_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_person;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondaryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_brith;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn post;
        private System.Windows.Forms.Button bt_HP;
    }
}