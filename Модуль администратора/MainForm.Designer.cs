namespace MasterNamespace
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bt_buildings = new System.Windows.Forms.Button();
            this.bt_dept = new System.Windows.Forms.Button();
            this.bt_soft = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_inv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_buildings
            // 
            this.bt_buildings.Location = new System.Drawing.Point(352, 63);
            this.bt_buildings.Name = "bt_buildings";
            this.bt_buildings.Size = new System.Drawing.Size(127, 56);
            this.bt_buildings.TabIndex = 0;
            this.bt_buildings.Text = "Редактор корпусов";
            this.bt_buildings.UseVisualStyleBackColor = true;
            this.bt_buildings.Click += new System.EventHandler(this.bt_buildings_Click);
            // 
            // bt_dept
            // 
            this.bt_dept.Location = new System.Drawing.Point(352, 1);
            this.bt_dept.Name = "bt_dept";
            this.bt_dept.Size = new System.Drawing.Size(127, 56);
            this.bt_dept.TabIndex = 1;
            this.bt_dept.Text = "Редактор отделов";
            this.bt_dept.UseVisualStyleBackColor = true;
            this.bt_dept.Click += new System.EventHandler(this.bt_dept_Click);
            // 
            // bt_soft
            // 
            this.bt_soft.Location = new System.Drawing.Point(352, 187);
            this.bt_soft.Name = "bt_soft";
            this.bt_soft.Size = new System.Drawing.Size(127, 56);
            this.bt_soft.TabIndex = 2;
            this.bt_soft.Text = "Редактор ПО";
            this.bt_soft.UseVisualStyleBackColor = true;
            this.bt_soft.Click += new System.EventHandler(this.bt_soft_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Работа с заявками";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_inv
            // 
            this.bt_inv.Location = new System.Drawing.Point(352, 125);
            this.bt_inv.Name = "bt_inv";
            this.bt_inv.Size = new System.Drawing.Size(127, 56);
            this.bt_inv.TabIndex = 6;
            this.bt_inv.Text = "Редактор инвентаря";
            this.bt_inv.UseVisualStyleBackColor = true;
            this.bt_inv.Click += new System.EventHandler(this.bt_inv_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 309);
            this.Controls.Add(this.bt_inv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_soft);
            this.Controls.Add(this.bt_dept);
            this.Controls.Add(this.bt_buildings);
            this.Name = "MainForm";
            this.Text = "Модуль администратора";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_buildings;
        private System.Windows.Forms.Button bt_dept;
        private System.Windows.Forms.Button bt_soft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_inv;
    }
}