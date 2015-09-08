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
    public partial class SoftEditor : Form
    {
        int id_soft_type = -1;
        int id_software = -1;
        public SoftEditor(int _id_soft_type)
        {
            InitializeComponent();
            id_soft_type = _id_soft_type;
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select distinct title from producer";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_producer.Items.Add(reader[0]);
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select title from type_SW";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_type_SW.Items.Add(reader[0]);
                    }
                }
            }
            bt_edit_soft.Enabled = false;
        }
        /// <summary>
        /// Форма редактирования ПО
        /// </summary>
        /// <param name="id_s">первичный ключ</param>
        /// <param name="title">название по</param>
        /// <param name="type_sw"></param>
        /// <param name="producer"></param>
        /// <param name="country"></param>
        /// <param name="activation_numb"></param>
        /// <param name="date"></param>
        /// <param name="description"></param>
        public SoftEditor(int id_s, string title, string type_sw, string producer, string date, string activation_numb, string description)
        {
            InitializeComponent();
            id_software = id_s;
            tb_title_soft_type.Text = title;
            cb_type_SW.Text = type_sw;
            cb_producer.Text = producer;
            dtp_date_add.Text = date;
            tb_activation_key.Text = activation_numb;
            rb_description_soft.Text = description;
            bt_edit_soft.Text = "Изменить";
            this.Text = "Редактирвоание ПО" + title;
            bt_edit_soft.Enabled = false;
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select distinct title from producer";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_producer.Items.Add(reader[0]);
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select title from type_SW";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_type_SW.Items.Add(reader[0]);
                    }
                }
            }
        }

        private void bt_edit_soft_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                if (id_soft_type != -1)
                {
                    using (SqlCommand cmd = new SqlCommand("ADD_SOFTWARE", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Входной параметр.
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id_s";
                        param.SqlDbType = SqlDbType.Int;
                        param.Value = id_software;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@title";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_title_soft_type.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@type_SW";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = cb_type_SW.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@title_p";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = cb_producer.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@date";
                        param.SqlDbType = SqlDbType.Date;
                        param.Value = DateTime.Parse(dtp_date_add.Text).ToShortDateString();
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@numb";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_activation_key.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@des";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = rb_description_soft.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@type_soft";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = id_soft_type;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);
                        // Выполнение хранимой процедуры.
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE_SOFTWARE", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Входной параметр.
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id_s";
                        param.SqlDbType = SqlDbType.Int;
                        param.Value = id_software;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@title";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_title_soft_type.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@type_SW";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = cb_type_SW.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@title_p";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = cb_producer.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@date";
                        param.SqlDbType = SqlDbType.Date;
                        param.Value = DateTime.Parse(dtp_date_add.Text).ToShortDateString();
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@numb";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_activation_key.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@des";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = rb_description_soft.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);
                        // Выполнение хранимой процедуры.
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void bt_canel_soft_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cb_producer.SelectedIndex != -1 && cb_type_SW.SelectedIndex!=-1)
                bt_edit_soft.Enabled = true;
            else
                bt_edit_soft.Enabled = false;
        }


    }
}
