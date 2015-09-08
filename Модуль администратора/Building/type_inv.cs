using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using uir;

namespace MasterNamespace
{
    public partial class type_inv : Form
    {
        string ID;
        public type_inv()
        {
            InitializeComponent();
            ID = "";
        }
        public type_inv(string[] parts)
        {
            InitializeComponent();
            ID = parts[0];
            bt_ok_type_inv.Text = "Изменить";
            this.Text = "Редактирование инвентаря " + parts[1];
            tb_title_type_inv.Text = parts[1];
        }
        private void bt_ok_type_inv_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    if (ID == "")
                    {
                        command.CommandText = string.Format("INSERT INTO inv_type(title) VALUES ('{0}')",
                            tb_title_type_inv.Text);
                    }
                    else
                    {
                        command.CommandText =
                            string.Format("UPDATE inv_type SET title = '{0}' WHERE  id_inv_type = {1}",
                            tb_title_type_inv.Text,
                            ID);
                    }
                    command.ExecuteNonQuery();
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void bt_canel_type_inv_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
