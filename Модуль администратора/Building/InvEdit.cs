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
    public partial class InvEdit : Form
    {
        int id_inven = 1;
        int id_type_inv = -1;
        int id_room = 1;
        public InvEdit(int _id_type_inv)
        {
            InitializeComponent();
            id_type_inv = _id_type_inv;
            this.Text = "Добавление";
            bt_add.Text = "Добавить";
            bt_canel.Text = "Отменить";
            groupBox2.Text = "Выбор адреса";
            LoadForm_add();
            bt_add.Enabled = false;
        }
        public InvEdit(int id_inv, int _id_type_inv, int id_r, string title, string number,  string des,string date, string floor,string room,string city,string street,string house,string title_b)
        {
            InitializeComponent();
            id_inven = id_inv;
            id_type_inv = _id_type_inv;
            id_room = id_r;
            tb_title.Text = title;
            tb_number.Text = number;
            dtp_date.Text = date;
            rtb_des.Text = des;
            bt_add.Text="Изменить";
            bt_canel.Text = "Отмена";
            this.Text = "Изменение";
            cb_city.Text = city;
            cb_city.Items.Add(city);
            cb_city.SelectedIndex = 0;
            cb_street.Text = street;
            cb_street.Items.Add(street);
            cb_house.Text = house;
            cb_title.Text = title_b;
            cb_floor.Text = floor;
            cb_room.Text=room;
            LoadForm_update();
        }

        public void LoadForm_add()
        {
            //City
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select distinct city from building";
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cb_city.Items.Add(reader[0]);
                        }
                    }
                }
            timer1.Enabled = true;
            timer2.Enabled = false;
        }
        public void LoadForm_update()
        {
            timer1.Enabled = false;
            timer2.Enabled = true;
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("select distinct city from building where city!='{0}'",
                    cb_city.Text.ToString());
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_city.Items.Add(reader[0]);
                    }
                }
            }
        }
        //street
        bool city_b = true;
        bool odinraz = true;
        int city_back = 1;
        //house
        bool street_b = true;
        bool odinraz1 = true;
        int street_back = -1;
        //title
        bool house_b = true;
        bool odinraz2 = true;
        int house_back = -1;
        //floor
        bool title_b = true;
        bool odinraz3 = true;
        int title_back = -1;
        //room
        bool floor_b = true;
        bool odinraz4 = true;
        int floor_back = -1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Street
            int city_now = cb_city.SelectedIndex;
            if (city_now != -1 && city_b == true)
            {
                if (odinraz == true)
                {
                    odinraz = false;
                    city_back = city_now;
                }
                city_b = false;
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("select distinct street from building where city='{0}'",
                        cb_city.SelectedItem.ToString());
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cb_street.Items.Add(reader[0]);
                        }
                    }
                }
            }
            if (city_now != city_back)
            {
                cb_street.Items.Clear();
                cb_street.Text = "";
                cb_street.SelectedIndex = -1;
                cb_house.Items.Clear();
                cb_house.Text = "";
                cb_house.SelectedIndex = -1;
                cb_title.Items.Clear();
                cb_title.Text = "";
                cb_title.SelectedIndex = -1;
                cb_floor.Items.Clear();
                cb_floor.Text = "";
                cb_floor.SelectedIndex = -1;
                cb_room.Items.Clear();
                cb_room.Text = "";
                cb_room.SelectedIndex = -1;
                city_b = true;
            }
            city_back = city_now;
            //house
            int street_now = cb_street.SelectedIndex;
            if (street_now != -1 && street_b == true)
            { 
                if (odinraz1 == true)
                {
                    odinraz1 = false;
                    street_back = street_now;
                }
                street_b = false;
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("select distinct house from building where street='{0}'",
                        cb_street.SelectedItem.ToString());
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cb_house.Items.Add(reader[0]);
                        }
                    }
                }
            }
            if (street_now != street_back)
            {
                cb_house.Items.Clear();
                cb_house.Text = "";
                cb_house.SelectedIndex = -1;
                cb_title.Items.Clear();
                cb_title.Text = "";
                cb_title.SelectedIndex = -1;
                cb_floor.Items.Clear();
                cb_floor.Text = "";
                cb_floor.SelectedIndex = -1;
                cb_room.Items.Clear();
                cb_room.Text = "";
                cb_room.SelectedIndex = -1;
                street_b = true;
            }
            street_back = street_now;
            //title
            int house_now = cb_house.SelectedIndex;
            if (house_now != -1 && house_b == true)
            {
                if (odinraz2 == true)
                {
                    odinraz2 = false;
                    house_back = house_now;
                }
                house_b = false;
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("select distinct title from building where house='{0}'",
                        cb_house.SelectedItem.ToString());
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cb_title.Items.Add(reader[0]);
                        }
                    }
                }
            }
            if (house_now != house_back)
            {
                cb_title.Items.Clear();
                cb_title.Text = "";
                cb_title.SelectedIndex = -1;
                cb_floor.Items.Clear();
                cb_floor.Text = "";
                cb_floor.SelectedIndex = -1;
                cb_room.Items.Clear();
                cb_room.Text = "";
                cb_room.SelectedIndex = -1;
                house_b = true;
            }
            house_back = house_now;
            //floor
            int title_now = cb_house.SelectedIndex;
            if (title_now != -1 && title_b == true)
            {
                if (odinraz3 == true)
                {
                    odinraz3 = false;
                    title_back = title_now;
                }
                title_b = false;
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("select _r.floor from room as _r,building as _b where _b.id_building=_r.id_building and _b.city='{0}' and _b.street='{1}' and _b.house='{2}'",
                        cb_city.Text, cb_street.Text, cb_house.Text);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cb_floor.Items.Add(reader[0]);
                        }
                    }
                }
            }
            if (title_now != title_back)
            {
                cb_floor.Items.Clear();
                cb_floor.Text = "";
                cb_floor.SelectedIndex = -1;
                cb_room.Items.Clear();
                cb_room.Text = "";
                cb_room.SelectedIndex = -1;
                title_b = true;
            }
            title_back = title_now;
            //room
            int floor_now = cb_floor.SelectedIndex;
            if (floor_now != -1 && floor_b == true)
            {
                if (odinraz4 == true)
                {
                    odinraz4 = false;
                    floor_back = floor_now;
                }
                floor_b = false;
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("select _r.number_room from room as _r,building as _b where _r.id_building=_b.id_building and _b.city='{0}' and _b.street='{1}' and _b.house='{2}' and _r.floor='{3}'",
                        cb_city.Text,cb_street.Text,cb_house.Text,cb_floor.Text);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cb_room.Items.Add(reader[0]);
                        }
                    }
                }
            }
            if (floor_now != floor_back)
            {
                cb_room.Items.Clear();
                cb_room.Text = "";
                cb_room.SelectedIndex = -1;
                floor_b = true;
                bt_add.Enabled = false;
            }
            floor_back = floor_now;

            if (cb_room.SelectedIndex!=-1)
                bt_add.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //city
            int city_now = cb_city.SelectedIndex;
            if (city_b == true)
            {
                if (odinraz == true)
                {
                    odinraz = false;
                    city_back = city_now;
                }
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("select distinct street from building where city='{0}' and street!='{1}'",
                        cb_city.Text.ToString(), cb_street.Text.ToString());
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cb_street.Items.Add(reader[0]);
                        }
                    }
                }
                city_b = false;             
            }
            if (city_now != city_back)
            {
                cb_street.Items.Clear();
                cb_street.Text = "";
                cb_street.SelectedIndex = -1;
                cb_house.Items.Clear();
                cb_house.Text = "";
                cb_house.SelectedIndex = -1;
                cb_title.Items.Clear();
                cb_title.Text = "";
                cb_title.SelectedIndex = -1;
                cb_floor.Items.Clear();
                cb_floor.Text = "";
                cb_floor.SelectedIndex = -1;
                cb_room.Items.Clear();
                cb_room.Text = "";
                cb_room.SelectedIndex = -1;
                city_b = true;
            }
            city_back = city_now;
            //house
            int street_now = cb_street.SelectedIndex;
            if (street_b == true)
            {
                if (odinraz1 == true)
                {
                    odinraz1 = false;
                    street_back = street_now;
                }
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("select distinct house from building where street='{0}' and house!='{1}'",
                        cb_street.Text.ToString(), cb_house.Text.ToString());
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cb_house.Items.Add(reader[0]);
                        }
                    }
                }
                street_b = false;
            }
            if (street_now != street_back)
            {
                cb_house.Items.Clear();
                cb_house.Text = "";
                cb_house.SelectedIndex = -1;
                cb_title.Items.Clear();
                cb_title.Text = "";
                cb_title.SelectedIndex = -1;
                cb_floor.Items.Clear();
                cb_floor.Text = "";
                cb_floor.SelectedIndex = -1;
                cb_room.Items.Clear();
                cb_room.Text = "";
                cb_room.SelectedIndex = -1;
                street_b = true;
            }
            street_back = street_now;
            //title
            int house_now = cb_house.SelectedIndex;
            if (house_b == true)
            {
                if (odinraz2 == true)
                {
                    odinraz2 = false;
                    house_back = house_now;
                }
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("select distinct title from building where house='{0}' and title!='{1}'",
                        cb_house.Text.ToString(), cb_title.Text.ToString());
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cb_title.Items.Add(reader[0]);
                        }
                    }
                }
                house_b = false;
            }
            if (house_now != house_back)
            {
                cb_title.Items.Clear();
                cb_title.Text = "";
                cb_title.SelectedIndex = -1;
                cb_floor.Items.Clear();
                cb_floor.Text = "";
                cb_floor.SelectedIndex = -1;
                cb_room.Items.Clear();
                cb_room.Text = "";
                cb_room.SelectedIndex = -1;
                house_b = true;
            }
            house_back = house_now;
            //floor
            int title_now = cb_title.SelectedIndex;
            if (title_b == true)
            {
                if (odinraz3 == true)
                {
                    odinraz3 = false;
                    title_back = title_now;
                }
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("select distinct _r.floor from room as _r,building as _b where _r.id_building=_b.id_building and _b.city='{0}' and _b.street='{1}' and _b.house='{2}'",
                        cb_city.Text, cb_street.Text, cb_house.Text);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cb_floor.Items.Add(reader[0]);
                        }
                    }
                }
                title_b = false;
            }
            if (title_now != title_back)
            {
                cb_floor.Items.Clear();
                cb_floor.Text = "";
                cb_floor.SelectedIndex = -1;
                cb_room.Items.Clear();
                cb_room.Text = "";
                cb_room.SelectedIndex = -1;
                title_b = true;
            }
            title_back = title_now;
            //room
            int floor_now = cb_floor.SelectedIndex;
            if (floor_b == true)
            {
                if (odinraz4 == true)
                {
                    odinraz4 = false;
                    floor_back = floor_now;
                }
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("select _r.number_room from room as _r,building as _b where _r.id_building=_b.id_building and _r.floor='{0}' and _b.city='{1}' and _b.street='{2}' and _b.house='{3}'",
                        cb_floor.Text,cb_city.Text,cb_street.Text,cb_house.Text);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cb_room.Items.Add(reader[0]);
                        }
                    }
                }
                floor_b = false;
            }
            if (floor_now != floor_back)
            {
                cb_room.Items.Clear();
                cb_room.Text = "";
                cb_room.SelectedIndex = -1;
                floor_b = true;
            }
            floor_back = floor_now;         
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            if (id_room == 1)
            {
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("ADD_INV", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //входной параметр
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@title";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_title.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@number";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_number.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@date";
                        param.SqlDbType = SqlDbType.Date;
                        param.Value = DateTime.Parse(dtp_date.Text).ToShortDateString();
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@des";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = rtb_des.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@floor";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = cb_floor.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@room";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = cb_room.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);
                       
                        param = new SqlParameter();
                        param.ParameterName = "@type_inv";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = id_type_inv;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);
                        // Выполнение хранимой процедуры.
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("SELECT distinct _r.id_room FROM inventory as _i,room as _r,building as _b where _r.id_building=_b.id_building and _r.floor='{0}' and _r.number_room='{1}' and _b.city='{2}'and _b.street='{3}' and _b.house='{4}'",
                        cb_floor.Text.ToString(), cb_room.Text.ToString(), cb_city.Text.ToString(), cb_street.Text.ToString(), cb_house.Text.ToString());
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cb_id_room1.Items.Add(reader[0]);
                        }
                    }
                }
                cb_id_room1.SelectedIndex = 0;
                textBox1.Text = cb_id_room1.Text.ToString();

                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText =
                                string.Format("UPDATE inventory SET [title] = '{0}',[seria_number] = '{1}',[data_add] = '{2}',[description] = '{3}',[id_room] = '{4}' WHERE id_inventory = {5}",
                                                     tb_title.Text,
                                                     tb_number.Text,
                                                     DateTime.Parse(dtp_date.Text).ToShortDateString(),
                                                     rtb_des.Text,
                                                     textBox1.Text,
                                                     id_inven);
                        command.ExecuteNonQuery();
                    }
                }
                /*
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE_INV", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //входной параметр
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@title";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_title.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@number";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = tb_number.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@date";
                        param.SqlDbType = SqlDbType.Date;
                        param.Value = DateTime.Parse(dtp_date.Text).ToShortDateString();
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@des";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = rtb_des.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@floor";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = cb_floor.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@room";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = cb_room.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@city";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = cb_city.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@street";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = cb_street.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@house";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = cb_house.Text;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                       /* param = new SqlParameter();
                        param.ParameterName = "@id_r";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = id_room;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@id_inv";
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Value = id_inven;
                        param.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(param);
                        // Выполнение хранимой процедуры.
                        cmd.ExecuteNonQuery();
                    }
                }*/
            }
        }
        private void bt_canel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
