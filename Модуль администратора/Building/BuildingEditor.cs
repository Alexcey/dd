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
    public partial class BuildingEditor : Form
    {
        string ID;
        //Для добавления
        public BuildingEditor()
        {
            InitializeComponent();
            this.Text = "Добавление адреса";
            ID = "";
            groupBox1.Text = "Добавление здания";
            groupBox2.Text = "Добавление адреса";
        }
        //Для редактирования
        public BuildingEditor(string[] parts)
        {
            InitializeComponent();
            ID = parts[0];
            bt_edit.Text = "Изменить";
            this.Text = "Редактирование адреса " + parts[1];
            mb_Title.Text = parts[3];
            rb_description.Text = parts[2];
            mb_city.Text = parts[1];
            mb_street.Text = parts[4];
            mb_house.Text = parts[5];
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        if (ID == "")
                        {
                            command.CommandText =
                                string.Format("INSERT INTO building(title,description,city,street,house) VALUES ('{0}','{1}','{2}','{3}','{4}')",
                                    mb_Title.Text,          
                                    rb_description.Text,
                                    mb_city.Text,
                                    mb_street.Text,
                                    mb_house.Text
                                            );   
                        }
                        else
                        {
                            command.CommandText =
                                string.Format("UPDATE building SET [title] = '{0}',[description] = '{1}',[city] = '{2}',[street] = '{3}',[house] = '{4}' WHERE id_building = {5}", 
                                                     mb_Title.Text,
                                                     rb_description.Text,
                                                     mb_city.Text,
                                                     mb_street.Text,
                                                     mb_house.Text,
                                                     ID);
                        }
                        command.ExecuteNonQuery();

                    }
                    this.DialogResult=DialogResult.OK;
                    Close();
                }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
