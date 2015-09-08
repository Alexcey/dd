namespace MasterNamespace
{
    partial class DeptEditor
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
            this.mb_title_dept = new System.Windows.Forms.Label();
            this.mb_title = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_description_dept = new System.Windows.Forms.RichTextBox();
            this.bt_edit_dept = new System.Windows.Forms.Button();
            this.bt_canel_dept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mb_title_dept
            // 
            this.mb_title_dept.AutoSize = true;
            this.mb_title_dept.Location = new System.Drawing.Point(12, 25);
            this.mb_title_dept.Name = "mb_title_dept";
            this.mb_title_dept.Size = new System.Drawing.Size(63, 13);
            this.mb_title_dept.TabIndex = 0;
            this.mb_title_dept.Text = "Название :";
            // 
            // mb_title
            // 
            this.mb_title.Location = new System.Drawing.Point(100, 22);
            this.mb_title.Name = "mb_title";
            this.mb_title.Size = new System.Drawing.Size(176, 20);
            this.mb_title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание :";
            // 
            // rb_description_dept
            // 
            this.rb_description_dept.Location = new System.Drawing.Point(100, 72);
            this.rb_description_dept.Name = "rb_description_dept";
            this.rb_description_dept.Size = new System.Drawing.Size(176, 159);
            this.rb_description_dept.TabIndex = 3;
            this.rb_description_dept.Text = "";
            // 
            // bt_edit_dept
            // 
            this.bt_edit_dept.Location = new System.Drawing.Point(18, 252);
            this.bt_edit_dept.Name = "bt_edit_dept";
            this.bt_edit_dept.Size = new System.Drawing.Size(106, 23);
            this.bt_edit_dept.TabIndex = 4;
            this.bt_edit_dept.Text = "Добавить";
            this.bt_edit_dept.UseVisualStyleBackColor = true;
            this.bt_edit_dept.Click += new System.EventHandler(this.bt_edit_dept_Click);
            // 
            // bt_canel_dept
            // 
            this.bt_canel_dept.Location = new System.Drawing.Point(170, 252);
            this.bt_canel_dept.Name = "bt_canel_dept";
            this.bt_canel_dept.Size = new System.Drawing.Size(106, 23);
            this.bt_canel_dept.TabIndex = 5;
            this.bt_canel_dept.Text = "Отмена";
            this.bt_canel_dept.UseVisualStyleBackColor = true;
            this.bt_canel_dept.Click += new System.EventHandler(this.bt_canel_dept_Click);
            // 
            // DeptEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 287);
            this.Controls.Add(this.bt_canel_dept);
            this.Controls.Add(this.bt_edit_dept);
            this.Controls.Add(this.rb_description_dept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mb_title);
            this.Controls.Add(this.mb_title_dept);
            this.MaximumSize = new System.Drawing.Size(312, 325);
            this.MinimumSize = new System.Drawing.Size(312, 325);
            this.Name = "DeptEditor";
            this.Text = "Добавление отдела";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mb_title_dept;
        private System.Windows.Forms.MaskedTextBox mb_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rb_description_dept;
        private System.Windows.Forms.Button bt_edit_dept;
        private System.Windows.Forms.Button bt_canel_dept;
    }
}