namespace MasterNamespace
{
    partial class type_inv
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
            this.tb_title_type_inv = new System.Windows.Forms.TextBox();
            this.bt_ok_type_inv = new System.Windows.Forms.Button();
            this.bt_canel_type_inv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_title_soft_type
            // 
            this.l_title_soft_type.AutoSize = true;
            this.l_title_soft_type.Location = new System.Drawing.Point(12, 18);
            this.l_title_soft_type.Name = "l_title_soft_type";
            this.l_title_soft_type.Size = new System.Drawing.Size(60, 13);
            this.l_title_soft_type.TabIndex = 2;
            this.l_title_soft_type.Text = "Название:";
            // 
            // tb_title_type_inv
            // 
            this.tb_title_type_inv.Location = new System.Drawing.Point(95, 15);
            this.tb_title_type_inv.Name = "tb_title_type_inv";
            this.tb_title_type_inv.Size = new System.Drawing.Size(177, 20);
            this.tb_title_type_inv.TabIndex = 6;
            // 
            // bt_ok_type_inv
            // 
            this.bt_ok_type_inv.Location = new System.Drawing.Point(15, 56);
            this.bt_ok_type_inv.MaximumSize = new System.Drawing.Size(96, 23);
            this.bt_ok_type_inv.MinimumSize = new System.Drawing.Size(96, 23);
            this.bt_ok_type_inv.Name = "bt_ok_type_inv";
            this.bt_ok_type_inv.Size = new System.Drawing.Size(96, 23);
            this.bt_ok_type_inv.TabIndex = 9;
            this.bt_ok_type_inv.Text = "Добавить";
            this.bt_ok_type_inv.UseVisualStyleBackColor = true;
            this.bt_ok_type_inv.Click += new System.EventHandler(this.bt_ok_type_inv_Click);
            // 
            // bt_canel_type_inv
            // 
            this.bt_canel_type_inv.Location = new System.Drawing.Point(167, 56);
            this.bt_canel_type_inv.Name = "bt_canel_type_inv";
            this.bt_canel_type_inv.Size = new System.Drawing.Size(96, 23);
            this.bt_canel_type_inv.TabIndex = 10;
            this.bt_canel_type_inv.Text = "Отмена";
            this.bt_canel_type_inv.UseVisualStyleBackColor = true;
            this.bt_canel_type_inv.Click += new System.EventHandler(this.bt_canel_type_inv_Click);
            // 
            // type_inv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 93);
            this.Controls.Add(this.bt_canel_type_inv);
            this.Controls.Add(this.bt_ok_type_inv);
            this.Controls.Add(this.tb_title_type_inv);
            this.Controls.Add(this.l_title_soft_type);
            this.Name = "type_inv";
            this.Text = "Добавить тип инвентаря";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_title_soft_type;
        private System.Windows.Forms.TextBox tb_title_type_inv;
        private System.Windows.Forms.Button bt_ok_type_inv;
        private System.Windows.Forms.Button bt_canel_type_inv;
    }
}