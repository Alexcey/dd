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
    public partial class BuildingList : Form
    {
        public BuildingList()
        {
            InitializeComponent();
            dg_building.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dg_room.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            loadDG();
        }

        private void loadDG()
        {
            dg_building.Rows.Clear();
            dg_room.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT id_building,city,description,title,street,house FROM building";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dg_building.Rows.Add(reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            reader[4].ToString(),
                            reader[5].ToString()); 
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            
        }
        
        private void bt_add_Click(object sender, EventArgs e)
        {
            BuildingEditor form = new BuildingEditor();
            if (form.ShowDialog() == DialogResult.OK)
            {
                loadDG();
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if(dg_building.SelectedRows.Count!=0)
            {
                string[] parts = new string[dg_building.Columns.Count];
                for (int i = 0; i < dg_building.Columns.Count;i++ )
                    parts[i] = dg_building.SelectedRows[0].Cells[i].Value.ToString();
                BuildingEditor form = new BuildingEditor(parts);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    loadDG();
                }
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (dg_building.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить " + dg_building.SelectedRows[0].Cells[1].Value + "?", "Внимание!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = string.Format("DELETE FROM building WHERE id_building = {0}",
                                dg_building.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();

                        }
                    }
                }
            }
            loadDG();
        }
        int selected_building = -1;
        private void dg_building_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_building.SelectedRows.Count != 0)
            {
                selected_building = int.Parse(dg_building.SelectedRows[0].Cells[0].Value.ToString());
                rb_building_description.Text = dg_building.SelectedRows[0].Cells[2].Value.ToString();
                rb_korpys.Text = dg_building.SelectedRows[0].Cells[3].Value.ToString();
                rb_street.Text = dg_building.SelectedRows[0].Cells[4].Value.ToString();
                rb_house.Text = dg_building.SelectedRows[0].Cells[5].Value.ToString();
                loadRoom(selected_building);
            }
            else
            {
                selected_building = -1;
                rb_building_description.Text = "Корпус не выбран";
            }
        }
        private void loadRoom(int id_building)
        {
            dg_room.Rows.Clear();
            if (selected_building != -1)
            {
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("SELECT id_room,id_building,number_room,floor,description FROM room where id_building = {0}", id_building);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            dg_room.Rows.Add(reader[0].ToString(),
                                reader[1].ToString(),
                                reader[2].ToString(),
                                reader[3].ToString(),
                                reader[4].ToString());
                        }
                        reader.Close();
                        reader.Dispose();
                    }
                }
            }
        }

        private void bt_addRoom_Click(object sender, EventArgs e)
        {
            if (selected_building != -1)
            {
                RoomEditor form = new RoomEditor(selected_building);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                    loadRoom(selected_building);
            }
            else
            {
                MessageBox.Show(this, "Не выбран корпус.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_updateRoom_Click(object sender, EventArgs e)
        {
            if (selected_building != -1)
            {
                if (dg_room.SelectedRows.Count != 0)
                {
                    RoomEditor form = new RoomEditor(
                        int.Parse(dg_room.SelectedRows[0].Cells[0].Value.ToString()),
                        dg_room.SelectedRows[0].Cells[2].Value.ToString(),
                        dg_room.SelectedRows[0].Cells[3].Value.ToString(),
                        dg_room.SelectedRows[0].Cells[4].Value.ToString()); 
                    if (form.ShowDialog() == DialogResult.OK)
                        loadRoom(selected_building);
               /*     RoomEditor form = new RoomEditor(int.Parse(dg_room.SelectedRows[0].Cells[0].Value.ToString(),
                      
                        )); */
                    
                }
                else
                {
                    MessageBox.Show("Не выбрано ни одной комнаты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            } 
        }

        private void bt_deletRoom_Click(object sender, EventArgs e)
        {
            if (dg_room.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Вы хотите удалить комнату " + dg_room.SelectedRows[0].Cells[2].Value.ToString() + "?"
                    , "Удаление комнаты", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = string.Format("DELETE FROM room WHERE ID_ROOM = {0}",
                                dg_room.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();

                        }
                    }
                }
                loadRoom(selected_building);
            }
            else
            {
                MessageBox.Show("Не выбрано ни одной комнаты");
            }
        }
    }
}
