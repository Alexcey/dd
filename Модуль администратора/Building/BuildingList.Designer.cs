namespace MasterNamespace
{
    partial class BuildingList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_building = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_addBulding = new System.Windows.Forms.Button();
            this.bt_updateBuilding = new System.Windows.Forms.Button();
            this.bt_deleteBuilding = new System.Windows.Forms.Button();
            this.grb_choiceBuilding = new System.Windows.Forms.GroupBox();
            this.rb_house = new System.Windows.Forms.RichTextBox();
            this.rb_street = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_korpys = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_building_description = new System.Windows.Forms.RichTextBox();
            this.bt_deletRoom = new System.Windows.Forms.Button();
            this.bt_addRoom = new System.Windows.Forms.Button();
            this.dg_room = new System.Windows.Forms.DataGridView();
            this.bt_updateRoom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_building)).BeginInit();
            this.grb_choiceBuilding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_room)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_building
            // 
            this.dg_building.AllowUserToAddRows = false;
            this.dg_building.AllowUserToDeleteRows = false;
            this.dg_building.AllowUserToResizeRows = false;
            this.dg_building.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_building.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_building.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.b_title,
            this.b_description,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dg_building.Location = new System.Drawing.Point(6, 16);
            this.dg_building.MultiSelect = false;
            this.dg_building.Name = "dg_building";
            this.dg_building.ReadOnly = true;
            this.dg_building.RowHeadersVisible = false;
            this.dg_building.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dg_building.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_building.Size = new System.Drawing.Size(234, 237);
            this.dg_building.TabIndex = 0;
            this.dg_building.SelectionChanged += new System.EventHandler(this.dg_building_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // b_title
            // 
            this.b_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.b_title.FillWeight = 50F;
            this.b_title.HeaderText = "Город";
            this.b_title.Name = "b_title";
            this.b_title.ReadOnly = true;
            // 
            // b_description
            // 
            this.b_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.b_description.DefaultCellStyle = dataGridViewCellStyle2;
            this.b_description.FillWeight = 73.78038F;
            this.b_description.HeaderText = "Описание";
            this.b_description.Name = "b_description";
            this.b_description.ReadOnly = true;
            this.b_description.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // bt_addBulding
            // 
            this.bt_addBulding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_addBulding.Location = new System.Drawing.Point(6, 262);
            this.bt_addBulding.Name = "bt_addBulding";
            this.bt_addBulding.Size = new System.Drawing.Size(107, 39);
            this.bt_addBulding.TabIndex = 1;
            this.bt_addBulding.Text = "Добавить адрес";
            this.bt_addBulding.UseVisualStyleBackColor = true;
            this.bt_addBulding.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_updateBuilding
            // 
            this.bt_updateBuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_updateBuilding.Location = new System.Drawing.Point(172, 265);
            this.bt_updateBuilding.Name = "bt_updateBuilding";
            this.bt_updateBuilding.Size = new System.Drawing.Size(107, 39);
            this.bt_updateBuilding.TabIndex = 2;
            this.bt_updateBuilding.Text = "Изменить адрес";
            this.bt_updateBuilding.UseVisualStyleBackColor = true;
            this.bt_updateBuilding.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_deleteBuilding
            // 
            this.bt_deleteBuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_deleteBuilding.Location = new System.Drawing.Point(324, 265);
            this.bt_deleteBuilding.Name = "bt_deleteBuilding";
            this.bt_deleteBuilding.Size = new System.Drawing.Size(107, 39);
            this.bt_deleteBuilding.TabIndex = 3;
            this.bt_deleteBuilding.Text = "Удалить адрес";
            this.bt_deleteBuilding.UseVisualStyleBackColor = true;
            this.bt_deleteBuilding.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // grb_choiceBuilding
            // 
            this.grb_choiceBuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grb_choiceBuilding.Controls.Add(this.rb_house);
            this.grb_choiceBuilding.Controls.Add(this.rb_street);
            this.grb_choiceBuilding.Controls.Add(this.label5);
            this.grb_choiceBuilding.Controls.Add(this.label4);
            this.grb_choiceBuilding.Controls.Add(this.rb_building_description);
            this.grb_choiceBuilding.Controls.Add(this.label3);
            this.grb_choiceBuilding.Controls.Add(this.rb_korpys);
            this.grb_choiceBuilding.Controls.Add(this.label1);
            this.grb_choiceBuilding.Controls.Add(this.dg_building);
            this.grb_choiceBuilding.Controls.Add(this.bt_deleteBuilding);
            this.grb_choiceBuilding.Controls.Add(this.bt_addBulding);
            this.grb_choiceBuilding.Controls.Add(this.bt_updateBuilding);
            this.grb_choiceBuilding.Location = new System.Drawing.Point(12, 6);
            this.grb_choiceBuilding.Name = "grb_choiceBuilding";
            this.grb_choiceBuilding.Size = new System.Drawing.Size(437, 312);
            this.grb_choiceBuilding.TabIndex = 4;
            this.grb_choiceBuilding.TabStop = false;
            this.grb_choiceBuilding.Text = "Выбор адреса";
            // 
            // rb_house
            // 
            this.rb_house.Location = new System.Drawing.Point(295, 64);
            this.rb_house.Name = "rb_house";
            this.rb_house.ReadOnly = true;
            this.rb_house.Size = new System.Drawing.Size(136, 23);
            this.rb_house.TabIndex = 13;
            this.rb_house.Text = "";
            // 
            // rb_street
            // 
            this.rb_street.Location = new System.Drawing.Point(295, 19);
            this.rb_street.Name = "rb_street";
            this.rb_street.ReadOnly = true;
            this.rb_street.Size = new System.Drawing.Size(136, 23);
            this.rb_street.TabIndex = 12;
            this.rb_street.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дом :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Улица :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Корпус :";
            // 
            // rb_korpys
            // 
            this.rb_korpys.Location = new System.Drawing.Point(295, 109);
            this.rb_korpys.Name = "rb_korpys";
            this.rb_korpys.ReadOnly = true;
            this.rb_korpys.Size = new System.Drawing.Size(136, 23);
            this.rb_korpys.TabIndex = 7;
            this.rb_korpys.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Описание здания:";
            // 
            // rb_building_description
            // 
            this.rb_building_description.Location = new System.Drawing.Point(246, 177);
            this.rb_building_description.Name = "rb_building_description";
            this.rb_building_description.ReadOnly = true;
            this.rb_building_description.Size = new System.Drawing.Size(185, 79);
            this.rb_building_description.TabIndex = 4;
            this.rb_building_description.Text = "";
            // 
            // bt_deletRoom
            // 
            this.bt_deletRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_deletRoom.Location = new System.Drawing.Point(280, 137);
            this.bt_deletRoom.Name = "bt_deletRoom";
            this.bt_deletRoom.Size = new System.Drawing.Size(88, 39);
            this.bt_deletRoom.TabIndex = 6;
            this.bt_deletRoom.Text = "Удалить комнату";
            this.bt_deletRoom.UseVisualStyleBackColor = true;
            this.bt_deletRoom.Click += new System.EventHandler(this.bt_deletRoom_Click);
            // 
            // bt_addRoom
            // 
            this.bt_addRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_addRoom.Location = new System.Drawing.Point(280, 16);
            this.bt_addRoom.Name = "bt_addRoom";
            this.bt_addRoom.Size = new System.Drawing.Size(88, 39);
            this.bt_addRoom.TabIndex = 4;
            this.bt_addRoom.Text = "Добавить комнату";
            this.bt_addRoom.UseVisualStyleBackColor = true;
            this.bt_addRoom.Click += new System.EventHandler(this.bt_addRoom_Click);
            // 
            // dg_room
            // 
            this.dg_room.AllowUserToAddRows = false;
            this.dg_room.AllowUserToDeleteRows = false;
            this.dg_room.AllowUserToResizeRows = false;
            this.dg_room.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dg_room.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_room.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_room.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_room,
            this.id_building,
            this.number_room,
            this.floor,
            this.description});
            this.dg_room.Location = new System.Drawing.Point(6, 16);
            this.dg_room.MultiSelect = false;
            this.dg_room.Name = "dg_room";
            this.dg_room.ReadOnly = true;
            this.dg_room.RowHeadersVisible = false;
            this.dg_room.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dg_room.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_room.Size = new System.Drawing.Size(268, 285);
            this.dg_room.TabIndex = 0;
            // 
            // bt_updateRoom
            // 
            this.bt_updateRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_updateRoom.Location = new System.Drawing.Point(280, 76);
            this.bt_updateRoom.Name = "bt_updateRoom";
            this.bt_updateRoom.Size = new System.Drawing.Size(88, 39);
            this.bt_updateRoom.TabIndex = 5;
            this.bt_updateRoom.Text = "Изменить комнату";
            this.bt_updateRoom.UseVisualStyleBackColor = true;
            this.bt_updateRoom.Click += new System.EventHandler(this.bt_updateRoom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_room);
            this.groupBox1.Controls.Add(this.bt_addRoom);
            this.groupBox1.Controls.Add(this.bt_deletRoom);
            this.groupBox1.Controls.Add(this.bt_updateRoom);
            this.groupBox1.Location = new System.Drawing.Point(455, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 312);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список комнат в корпусе";
            // 
            // id_room
            // 
            this.id_room.HeaderText = "id_room";
            this.id_room.Name = "id_room";
            this.id_room.ReadOnly = true;
            this.id_room.Visible = false;
            // 
            // id_building
            // 
            this.id_building.HeaderText = "id_building";
            this.id_building.Name = "id_building";
            this.id_building.ReadOnly = true;
            this.id_building.Visible = false;
            // 
            // number_room
            // 
            this.number_room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.number_room.FillWeight = 104.3147F;
            this.number_room.HeaderText = "Номер";
            this.number_room.Name = "number_room";
            this.number_room.ReadOnly = true;
            this.number_room.Width = 66;
            // 
            // floor
            // 
            this.floor.FillWeight = 60F;
            this.floor.HeaderText = "Этаж";
            this.floor.Name = "floor";
            this.floor.ReadOnly = true;
            // 
            // description
            // 
            this.description.FillWeight = 104.3147F;
            this.description.HeaderText = "Описание";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // BuildingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_choiceBuilding);
            this.MaximumSize = new System.Drawing.Size(856, 406);
            this.Name = "BuildingList";
            this.Text = "Редактирование копрусов";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.dg_building)).EndInit();
            this.grb_choiceBuilding.ResumeLayout(false);
            this.grb_choiceBuilding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_room)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_building;
        private System.Windows.Forms.Button bt_addBulding;
        private System.Windows.Forms.Button bt_updateBuilding;
        private System.Windows.Forms.Button bt_deleteBuilding;
        private System.Windows.Forms.GroupBox grb_choiceBuilding;
        private System.Windows.Forms.DataGridView dg_room;
        private System.Windows.Forms.Button bt_deletRoom;
        private System.Windows.Forms.Button bt_addRoom;
        private System.Windows.Forms.Button bt_updateRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rb_building_description;
        private System.Windows.Forms.RichTextBox rb_house;
        private System.Windows.Forms.RichTextBox rb_street;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rb_korpys;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_building;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}