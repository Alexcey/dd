namespace MasterNamespace
{
    partial class Soft_typeEditor
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
            this.l_title_soft_type = new System.Windows.Forms.Label();
            this.tb_title_soft_type = new System.Windows.Forms.TextBox();
            this.bt_edit_soft_type = new System.Windows.Forms.Button();
            this.bt_canel_soft_type = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_title_soft_type
            // 
            this.l_title_soft_type.AutoSize = true;
            this.l_title_soft_type.Location = new System.Drawing.Point(12, 30);
            this.l_title_soft_type.Name = "l_title_soft_type";
            this.l_title_soft_type.Size = new System.Drawing.Size(60, 13);
            this.l_title_soft_type.TabIndex = 1;
            this.l_title_soft_type.Text = "Название:";
            // 
            // tb_title_soft_type
            // 
            this.tb_title_soft_type.Location = new System.Drawing.Point(94, 27);
            this.tb_title_soft_type.Name = "tb_title_soft_type";
            this.tb_title_soft_type.Size = new System.Drawing.Size(177, 20);
            this.tb_title_soft_type.TabIndex = 5;
            // 
            // bt_edit_soft_type
            // 
            this.bt_edit_soft_type.Location = new System.Drawing.Point(15, 70);
            this.bt_edit_soft_type.Name = "bt_edit_soft_type";
            this.bt_edit_soft_type.Size = new System.Drawing.Size(96, 23);
            this.bt_edit_soft_type.TabIndex = 8;
            this.bt_edit_soft_type.Text = "Добавить";
            this.bt_edit_soft_type.UseVisualStyleBackColor = true;
            this.bt_edit_soft_type.Click += new System.EventHandler(this.bt_edit_soft_type_Click);
            // 
            // bt_canel_soft_type
            // 
            this.bt_canel_soft_type.Location = new System.Drawing.Point(175, 70);
            this.bt_canel_soft_type.Name = "bt_canel_soft_type";
            this.bt_canel_soft_type.Size = new System.Drawing.Size(96, 23);
            this.bt_canel_soft_type.TabIndex = 9;
            this.bt_canel_soft_type.Text = "Отмена";
            this.bt_canel_soft_type.UseVisualStyleBackColor = true;
            this.bt_canel_soft_type.Click += new System.EventHandler(this.bt_canel_soft_type_Click);
            // 
            // Soft_typeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 107);
            this.Controls.Add(this.bt_canel_soft_type);
            this.Controls.Add(this.bt_edit_soft_type);
            this.Controls.Add(this.tb_title_soft_type);
            this.Controls.Add(this.l_title_soft_type);
            this.MaximumSize = new System.Drawing.Size(300, 145);
            this.MinimumSize = new System.Drawing.Size(300, 145);
            this.Name = "Soft_typeEditor";
            this.Text = "Добавить тип ПО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_title_soft_type;
        private System.Windows.Forms.TextBox tb_title_soft_type;
        private System.Windows.Forms.Button bt_edit_soft_type;
        private System.Windows.Forms.Button bt_canel_soft_type;
    }
}