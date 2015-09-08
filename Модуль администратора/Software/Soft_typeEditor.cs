using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using uir;

namespace MasterNamespace
{
    public partial class Soft_typeEditor : Form
    {
        string ID;
        public Soft_typeEditor()
        {
            InitializeComponent();
            ID = "";
        }
        public Soft_typeEditor(string[] parts)
        {
            InitializeComponent();
            ID = parts[0];
            bt_edit_soft_type.Text = "Изменить";
            this.Text = "Редактирование отдела " + parts[1];
            tb_title_soft_type.Text = parts[1];
        }
        private void bt_canel_soft_type_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        //Нет в бд описания,только название
        //
        // p.s.create 
        private void bt_edit_soft_type_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    if (ID == "")
                    {
                        command.CommandText = string.Format("INSERT INTO soft_type(title) VALUES ('{0}')",
                            tb_title_soft_type.Text);
                    }
                    else
                    {
                        command.CommandText =
                            string.Format("UPDATE soft_type SET title = '{0}' WHERE  soft_type = {1}",
                            tb_title_soft_type.Text,
                            ID);
                    }
                    command.ExecuteNonQuery();
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
