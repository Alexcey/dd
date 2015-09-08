namespace MasterNamespace
{
    partial class requestList
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
            this.cb_rq_type = new System.Windows.Forms.ComboBox();
            this.CloseRequest = new System.Windows.Forms.Button();
            this.dg_request = new System.Windows.Forms.DataGridView();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.rb_new = new System.Windows.Forms.RadioButton();
            this.rb_inWork = new System.Windows.Forms.RadioButton();
            this.lb_fio = new System.Windows.Forms.Label();
            this.rtb_des = new System.Windows.Forms.RichTextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.num_request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_request)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cb_rq_type);
            this.groupBox1.Controls.Add(this.CloseRequest);
            this.groupBox1.Controls.Add(this.dg_request);
            this.groupBox1.Controls.Add(this.rb_all);
            this.groupBox1.Controls.Add(this.rb_new);
            this.groupBox1.Controls.Add(this.rb_inWork);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с запросами";
            // 
            // cb_rq_type
            // 
            this.cb_rq_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rq_type.FormattingEnabled = true;
            this.cb_rq_type.Items.AddRange(new object[] {
            "Все"});
            this.cb_rq_type.Location = new System.Drawing.Point(6, 339);
            this.cb_rq_type.Name = "cb_rq_type";
            this.cb_rq_type.Size = new System.Drawing.Size(159, 21);
            this.cb_rq_type.TabIndex = 5;
            this.cb_rq_type.SelectedIndexChanged += new System.EventHandler(this.cb_rq_type_SelectedIndexChanged);
            // 
            // CloseRequest
            // 
            this.CloseRequest.Location = new System.Drawing.Point(224, 325);
            this.CloseRequest.Name = "CloseRequest";
            this.CloseRequest.Size = new System.Drawing.Size(128, 23);
            this.CloseRequest.TabIndex = 4;
            this.CloseRequest.Text = "Закрыть заявку";
            this.CloseRequest.UseVisualStyleBackColor = true;
            this.CloseRequest.Click += new System.EventHandler(this.CloseRequest_Click);
            // 
            // dg_request
            // 
            this.dg_request.AllowUserToAddRows = false;
            this.dg_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_request.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_request,
            this.Column5,
            this.request_start,
            this.request_end,
            this.request_status,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dg_request.Location = new System.Drawing.Point(6, 19);
            this.dg_request.Name = "dg_request";
            this.dg_request.ReadOnly = true;
            this.dg_request.RowHeadersVisible = false;
            this.dg_request.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_request.Size = new System.Drawing.Size(346, 236);
            this.dg_request.TabIndex = 3;
            this.dg_request.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Location = new System.Drawing.Point(6, 316);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(83, 17);
            this.rb_all.TabIndex = 2;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "Все заявки";
            this.rb_all.UseVisualStyleBackColor = true;
            this.rb_all.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rb_new
            // 
            this.rb_new.AutoSize = true;
            this.rb_new.Location = new System.Drawing.Point(6, 264);
            this.rb_new.Name = "rb_new";
            this.rb_new.Size = new System.Drawing.Size(120, 17);
            this.rb_new.TabIndex = 0;
            this.rb_new.TabStop = true;
            this.rb_new.Text = "Неначатые заявки";
            this.rb_new.UseVisualStyleBackColor = true;
            this.rb_new.CheckedChanged += new System.EventHandler(this.rb_new_CheckedChanged);
            // 
            // rb_inWork
            // 
            this.rb_inWork.AutoSize = true;
            this.rb_inWork.Location = new System.Drawing.Point(6, 293);
            this.rb_inWork.Name = "rb_inWork";
            this.rb_inWork.Size = new System.Drawing.Size(109, 17);
            this.rb_inWork.TabIndex = 1;
            this.rb_inWork.TabStop = true;
            this.rb_inWork.Text = "Заявки в работе";
            this.rb_inWork.UseVisualStyleBackColor = true;
            this.rb_inWork.CheckedChanged += new System.EventHandler(this.rb_inWork_CheckedChanged);
            // 
            // lb_fio
            // 
            this.lb_fio.AutoSize = true;
            this.lb_fio.Location = new System.Drawing.Point(381, 22);
            this.lb_fio.Name = "lb_fio";
            this.lb_fio.Size = new System.Drawing.Size(37, 13);
            this.lb_fio.TabIndex = 1;
            this.lb_fio.Text = "ФИО:";
            // 
            // rtb_des
            // 
            this.rtb_des.Enabled = false;
            this.rtb_des.Location = new System.Drawing.Point(384, 72);
            this.rtb_des.Name = "rtb_des";
            this.rtb_des.ReadOnly = true;
            this.rtb_des.Size = new System.Drawing.Size(288, 119);
            this.rtb_des.TabIndex = 2;
            this.rtb_des.Text = "";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(424, 22);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(35, 13);
            this.lb_name.TabIndex = 5;
            this.lb_name.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Заявка :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Информация о заявке";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ответ :";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(384, 222);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(288, 156);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Начать заявку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // num_request
            // 
            this.num_request.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.num_request.HeaderText = "Номер запроса";
            this.num_request.Name = "num_request";
            this.num_request.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "id_inv";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // request_start
            // 
            this.request_start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.request_start.HeaderText = "Дата начала";
            this.request_start.Name = "request_start";
            this.request_start.ReadOnly = true;
            // 
            // request_end
            // 
            this.request_end.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.request_end.HeaderText = "Дата окончания";
            this.request_end.Name = "request_end";
            this.request_end.ReadOnly = true;
            // 
            // request_status
            // 
            this.request_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.request_status.HeaderText = "Состояние";
            this.request_status.Name = "request_status";
            this.request_status.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отч";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ответ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 26);
            this.button3.TabIndex = 7;
            this.button3.Text = "Отправить в очередь";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // requestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 380);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.rtb_des);
            this.Controls.Add(this.lb_fio);
            this.Controls.Add(this.groupBox1);
            this.Name = "requestList";
            this.Text = "Запросы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_request)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.RadioButton rb_inWork;
        private System.Windows.Forms.RadioButton rb_new;
        private System.Windows.Forms.DataGridView dg_request;
        private System.Windows.Forms.Label lb_fio;
        private System.Windows.Forms.RichTextBox rtb_des;
        private System.Windows.Forms.Button CloseRequest;
        private System.Windows.Forms.ComboBox cb_rq_type;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_request;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;

    }
}