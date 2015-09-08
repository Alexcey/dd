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
    public partial class PersonEdit : Form
    {
        int id_dept = -1;
        int id_person = -1;
        int index_dept = -5;
        string post_old;
        bool CreatePerson = true;
        /// <summary>
        /// Добавление сотрудника
        /// </summary>
        /// <param name="id_dept"></param>
        public PersonEdit(int id_d)
        {
            InitializeComponent();
            id_dept = id_d;          
            cb_dept.Visible = false;
            l3.Visible = false;
            bt_add_dan_pers.Location = new Point(15, 204);
            bt_canel_dan_person.Location = new Point(155, 204);
            this.Size = new Size(299, 270);
            CreatePerson = true;
        }
        /// <summary>
        /// Редактирование сотрудника
        /// </summary>
        /// <param name="id_person"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="secondaryname"></param>
        /// <param name="date"></param>
        /// <param name="number"></param>
        public PersonEdit(int id_p, int id_d, string name, string surname, string secondaryname, string date, string number, string mail, string post)
        {
            InitializeComponent();
            id_person = id_p;
            id_dept = id_d;
            tb_name.Text = name;
            tb_surname.Text = surname;
            tb_secondaryname.Text = secondaryname;
            dtp_birth_day.Text = date;
            mb_numberTel.Text = number;
            tb_mail.Text = mail;
            tb_post.Text = post;
            post_old = post;
            bt_add_dan_pers.Text = "Редактировать";
            this.Text = "Изменение данных";
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("select title from dept where id_dept!={0} and true=1", id_dept);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_dept.Items.Add(reader[0]);
                    }
                }
            }
            CreatePerson = false;
        } 

        private void bt_add_dan_pers_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("Необходимо ввести имя");
                return;
            }
            if (tb_surname.Text == "")
            {
                MessageBox.Show("Необходимо ввести фамилию");
                return;
            }
            if (DateTime.Parse(dtp_birth_day.Text).AddYears(18) > DateTime.Now)
            {
                MessageBox.Show("Сотрдник не может быть моложе 18 лет");
                return;
            }
            string txt = mb_numberTel.Text;
            txt = txt.Replace('-', ' ');
            txt = txt.Trim();
            if (txt.Length < 9 && txt.Length > 0)
            {
                MessageBox.Show("Некорректный телефонный номер");
                return;
            }
            if (CreatePerson == true)
            {
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("ADD_PERSON", connection))
                    {
                        //,,,,
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Входной параметр.
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@surname";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_surname.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@name";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_name.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@secname";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_secondaryname.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@date_birth";
                        param.SqlDbType = SqlDbType.Date;
                        param.Value = DateTime.Parse(dtp_birth_day.Text).ToShortDateString();
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@telephone";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = mb_numberTel.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@mail";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_mail.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@post";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_post.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);                     

                        param = new SqlParameter();
                        param.ParameterName = "@id_dept";
                        param.SqlDbType = SqlDbType.Int;
                        param.Value = id_dept;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);
                        // Выполнение хранимой процедуры.
                        cmd.ExecuteNonQuery();
                    }
                }              
            }
            else
            {
                index_dept = cb_dept.SelectedIndex;
                string title_dept="11";
                if (index_dept!=-1)
                {
                    title_dept = cb_dept.SelectedItem.ToString();
                }
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE_PERSON", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Входной параметр.
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@surname";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_surname.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@name";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_name.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@secname";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_secondaryname.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@date_birth";
                        param.SqlDbType = SqlDbType.Date;
                        param.Value = DateTime.Parse(dtp_birth_day.Text).ToShortDateString();
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@telephone";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = mb_numberTel.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@mail";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_mail.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@post";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_post.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@post_old";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = post_old;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@id_p";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = id_person;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@id_dept";
                        param.SqlDbType = SqlDbType.Int;
                        param.Value = id_dept;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@index_dept";
                        param.SqlDbType = SqlDbType.Int;
                        param.Value = index_dept;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param); 

                        param = new SqlParameter();
                        param.ParameterName = "@title_dept";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = title_dept;
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

        private void bt_canel_dan_person_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
