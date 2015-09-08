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
    public partial class DeptEditor : Form
    {
        string ID;
        public DeptEditor()
        {
            InitializeComponent();
            ID = "";
        }

        public DeptEditor(string[] parts)
        {
            InitializeComponent();            
            ID = parts[0];
            bt_edit_dept.Text = "Изменить";
            this.Text = "Редактирование отдела " + parts[1];
            mb_title.Text = parts[1];
            rb_description_dept.Text = parts[2];
        }

        private void bt_edit_dept_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using(SqlCommand command=new SqlCommand())
                {
                    
                    command.Connection = connection;
                    if (ID == "")
                    {
                        command.CommandText =
                        string.Format("INSERT INTO dept(title,description,true) VALUES ('{0}','{1}',1)",
                        mb_title.Text,
                        rb_description_dept.Text);
                    }
                    else
                    {
                        command.CommandText =
                                string.Format("UPDATE dept SET title = '{0}',description = '{1}' WHERE  id_dept = {2}",
                                                     mb_title.Text,
                                                     rb_description_dept.Text,
                                                     ID);
                    }


                    command.ExecuteNonQuery();
                
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void bt_canel_dept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
