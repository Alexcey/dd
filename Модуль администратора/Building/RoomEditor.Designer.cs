namespace MasterNamespace
{
    partial class RoomEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.mb_number_room = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_canel = new System.Windows.Forms.Button();
            this.rb_editionRoom = new System.Windows.Forms.RichTextBox();
            this.mb_floor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер комнаты:";
            // 
            // mb_number_room
            // 
            this.mb_number_room.Location = new System.Drawing.Point(110, 12);
            this.mb_number_room.Name = "mb_number_room";
            this.mb_number_room.Size = new System.Drawing.Size(162, 20);
            this.mb_number_room.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбор этажа:";
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(14, 172);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(75, 23);
            this.bt_edit.TabIndex = 4;
            this.bt_edit.Text = "Добавить";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_canel
            // 
            this.bt_canel.Location = new System.Drawing.Point(170, 172);
            this.bt_canel.Name = "bt_canel";
            this.bt_canel.Size = new System.Drawing.Size(75, 23);
            this.bt_canel.TabIndex = 5;
            this.bt_canel.Text = "Отмена";
            this.bt_canel.UseVisualStyleBackColor = true;
            this.bt_canel.Click += new System.EventHandler(this.bt_canel_Click);
            // 
            // rb_editionRoom
            // 
            this.rb_editionRoom.Location = new System.Drawing.Point(110, 66);
            this.rb_editionRoom.Name = "rb_editionRoom";
            this.rb_editionRoom.Size = new System.Drawing.Size(162, 94);
            this.rb_editionRoom.TabIndex = 6;
            this.rb_editionRoom.Text = "";
            // 
            // mb_floor
            // 
            this.mb_floor.Location = new System.Drawing.Point(110, 40);
            this.mb_floor.Name = "mb_floor";
            this.mb_floor.Size = new System.Drawing.Size(162, 20);
            this.mb_floor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Описание:";
            // 
            // RoomEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mb_floor);
            this.Controls.Add(this.rb_editionRoom);
            this.Controls.Add(this.bt_canel);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mb_number_room);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(300, 251);
            this.MinimumSize = new System.Drawing.Size(300, 251);
            this.Name = "RoomEditor";
            this.Text = "Изменение комнаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mb_number_room;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_canel;
        private System.Windows.Forms.RichTextBox rb_editionRoom;
        private System.Windows.Forms.MaskedTextBox mb_floor;
        private System.Windows.Forms.Label label3;
    }
}