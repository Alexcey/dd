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
    public partial class RoomEditor : Form
    {
        int id_building;
        int id_room = 0;
        public RoomEditor(int _id_building)
        {
            InitializeComponent();
            this.Text="Добавление комнаты";
            id_building = _id_building;
           
        }
        public RoomEditor(int id, string number_room, string floor, string descrition)
        {
            InitializeComponent();
            mb_number_room.Text = number_room;
            id_room = id;
            rb_editionRoom.Text = descrition;
            bt_edit.Text = "Изменить комнату";
            mb_floor.Text = floor;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
                if (mb_number_room.Text =="")
                {
                MessageBox.Show("Введите номер комнаты");
            }
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    if (id_room == 0)
                    {
                        command.CommandText =
                            string.Format("INSERT INTO room(id_building, floor, number_room, description) VALUES ({0},'{1}','{2}','{3}')",
                                    id_building.ToString(),
                                    mb_floor.Text,
                                    mb_number_room.Text,
                                    rb_editionRoom.Text);
                    }
                    else
                    {
                        command.CommandText =
                            string.Format("UPDATE room SET floor = '{0}',number_room = '{1}',description = '{2}' WHERE id_room = {3}",
                            mb_floor.Text, mb_number_room.Text, rb_editionRoom.Text,id_room.ToString());
                    }
                    command.ExecuteNonQuery();
                }
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void bt_canel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
