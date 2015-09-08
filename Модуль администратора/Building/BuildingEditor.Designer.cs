namespace MasterNamespace
{
    partial class BuildingEditor
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mb_Title = new System.Windows.Forms.MaskedTextBox();
            this.rb_description = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mb_house = new System.Windows.Forms.MaskedTextBox();
            this.mb_street = new System.Windows.Forms.MaskedTextBox();
            this.mb_city = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Город:";
            // 
            // mb_Title
            // 
            this.mb_Title.Location = new System.Drawing.Point(54, 96);
            this.mb_Title.Name = "mb_Title";
            this.mb_Title.Size = new System.Drawing.Size(174, 20);
            this.mb_Title.TabIndex = 1;
            // 
            // rb_description
            // 
            this.rb_description.Location = new System.Drawing.Point(72, 52);
            this.rb_description.Name = "rb_description";
            this.rb_description.Size = new System.Drawing.Size(161, 65);
            this.rb_description.TabIndex = 6;
            this.rb_description.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Описание:";
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(56, 146);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(170, 27);
            this.bt_edit.TabIndex = 8;
            this.bt_edit.Text = "Добавить";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(302, 146);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(170, 27);
            this.bt_cancel.TabIndex = 10;
            this.bt_cancel.Text = "Отмена";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_description);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mb_city);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 128);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменение корпуса";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mb_house);
            this.groupBox2.Controls.Add(this.mb_street);
            this.groupBox2.Controls.Add(this.mb_Title);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(262, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 127);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение адреса";
            // 
            // mb_house
            // 
            this.mb_house.Location = new System.Drawing.Point(52, 61);
            this.mb_house.Name = "mb_house";
            this.mb_house.Size = new System.Drawing.Size(176, 20);
            this.mb_house.TabIndex = 10;
            // 
            // mb_street
            // 
            this.mb_street.Location = new System.Drawing.Point(52, 22);
            this.mb_street.Name = "mb_street";
            this.mb_street.Size = new System.Drawing.Size(176, 20);
            this.mb_street.TabIndex = 9;
            // 
            // mb_city
            // 
            this.mb_city.Location = new System.Drawing.Point(72, 23);
            this.mb_city.Name = "mb_city";
            this.mb_city.Size = new System.Drawing.Size(161, 20);
            this.mb_city.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Дом:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Улица:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Корпус:";
            // 
            // BuildingEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 188);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_edit);
            this.MaximumSize = new System.Drawing.Size(527, 226);
            this.MinimumSize = new System.Drawing.Size(527, 226);
            this.Name = "BuildingEditor";
            this.Text = "Изменения корпуса";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mb_Title;
        private System.Windows.Forms.RichTextBox rb_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mb_house;
        private System.Windows.Forms.MaskedTextBox mb_street;
        private System.Windows.Forms.MaskedTextBox mb_city;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

