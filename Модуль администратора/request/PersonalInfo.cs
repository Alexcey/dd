using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using uir;

namespace MasterNamespace
{
    public partial class PersonalInfo : Form
    {
        public PersonalInfo(int id_inv,string sur,string name,string surname)
        {
            InitializeComponent();
            comboBox2.Text = sur + " " + name + ' ' + surname; ;
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("select _d.title from dept as _d,person as _p, person_dept as _pd where _pd.true=1 and _d.id_dept=_pd.id_dept and _p.surname='{0}' and _p.name='{1}' and _p.secondaryname='{2}'",
                    sur, name, surname);   
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader[0]);
                    }
                    comboBox1.SelectedIndex = 0;
                }
            }
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("select _i.title,_i.seria_number,_r.floor,_r.number_room,_b.city,_b.street,_b.house from inventory as _i,room as _r,building as _b where _b.id_building=_r.id_building and _r.id_room=_i.id_room and _i.id_inventory ={0}",id_inv);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox3.Items.Add(reader[0]);
                        comboBox4.Items.Add(reader[1]);
                        comboBox6.Items.Add(reader[2]);
                        comboBox7.Items.Add(reader[3]);
                        comboBox5.Items.Add(reader[4]);
                        comboBox8.Items.Add(reader[5]);
                        comboBox9.Items.Add(reader[6]);
                    }
                }
            }
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox5.Text = comboBox5.Text +" "+ comboBox8.Text +" "+ comboBox9.Text;
        }
    }
}
