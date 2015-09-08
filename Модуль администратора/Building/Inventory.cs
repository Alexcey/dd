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
    public partial class Inventory : Form
    {
        List<inv_type> inv_type_List = new List<inv_type>();
        struct inv_type
        {
            public int id;
            public string title;
        }
        public Inventory()
        {
            InitializeComponent();
            loadTypeInv();
        }
        public void loadTypeInv()
        {
            inv_type_List.Clear();
            lb_inv_type.Items.Clear();
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select id_inv_type,title from inv_type";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        inv_type s = new inv_type();
                        s.id = int.Parse(reader[0].ToString());
                        s.title = reader[1].ToString();
                        inv_type_List.Add(s);
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            for (int i = 0; i < inv_type_List.Count; i++)
            {
                lb_inv_type.Items.Add(inv_type_List[i].title);
            }
        }

        private void bt_add_type_inv_Click(object sender, EventArgs e)
        {
            type_inv form = new type_inv();
            form.ShowDialog();
            loadTypeInv();
        }

        private void btt_update_type_inv_Click(object sender, EventArgs e)
        {
            if (lb_inv_type.SelectedIndex != -1)
            {
                string[] mas = new string[3];
                mas[0] = inv_type_List[lb_inv_type.SelectedIndex].id.ToString();
                mas[1] = inv_type_List[lb_inv_type.SelectedIndex].title.ToString();
                type_inv form = new type_inv(mas);
                form.ShowDialog();
                loadTypeInv();
            }
        }

        private void bt_del_type_inv_Click(object sender, EventArgs e)
        {
            if (lb_inv_type.SelectedIndex != -1)
            {
                if (MessageBox.Show("Вы хотите удалить " + lb_inv_type.SelectedItem.ToString() + "?", "Внимание!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = string.Format("DELETE FROM inv_type where id_inv_type={0}", inv_type_List[lb_inv_type.SelectedIndex].id);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                loadTypeInv();
            }
        }

        public void LoadInv()
        {
            if (lb_inv_type.SelectedIndex != -1)
            {
                dg_inv.Rows.Clear();
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText =
                            string.Format("select _i.id_inventory,_i.id_room,_i.title,_i.seria_number,_i.description,_i.data_add,_r.floor,_r.number_room,_b.city,_b.street,_b.house,_b.title from inventory as _i,room as _r, building as _b where _i.id_room=_r.id_room and _r.id_building=_b.id_building and id_inv_type={0}",
                            inv_type_List[lb_inv_type.SelectedIndex].id.ToString());
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            dg_inv.Rows.Add(reader[0].ToString(),
                                inv_type_List[lb_inv_type.SelectedIndex].id.ToString(),
                                reader[1].ToString(),
                                reader[2].ToString(),
                                reader[3].ToString(),
                                reader[4].ToString(),
                                DateTime.Parse(reader[5].ToString()).ToShortDateString(),
                                reader[6].ToString(),
                                reader[7].ToString(),
                                reader[8].ToString(),
                                reader[9].ToString(),
                                reader[10].ToString(),
                                reader[11].ToString());
                        }
                        reader.Close();
                        reader.Dispose();
                    }
                }
            }
        }

        private void lb_inv_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInv();
        }

        private void bt_add_inv_Click(object sender, EventArgs e)
        {
            if (lb_inv_type.SelectedIndex != -1)
            {
                InvEdit from = new InvEdit(inv_type_List[lb_inv_type.SelectedIndex].id);
                if (from.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
            LoadInv();
        }

        private void bt_del_inv_Click(object sender, EventArgs e)
        {
            if (dg_inv.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить " + dg_inv.SelectedRows[0].Cells[3].Value + "?", "Внимание!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = string.Format("DELETE FROM inventory WHERE id_inventory = {0}",
                                dg_inv.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            LoadInv();
        }

        private void bt_update_inv_Click(object sender, EventArgs e)
        {
            if (dg_inv.SelectedRows.Count != 0)
            {
                InvEdit from = new InvEdit(
                    int.Parse(dg_inv.SelectedRows[0].Cells[0].Value.ToString()),
                    int.Parse(dg_inv.SelectedRows[0].Cells[1].Value.ToString()),
                    int.Parse(dg_inv.SelectedRows[0].Cells[2].Value.ToString()),
                    dg_inv.SelectedRows[0].Cells[3].Value.ToString(),
                    dg_inv.SelectedRows[0].Cells[4].Value.ToString(),
                    dg_inv.SelectedRows[0].Cells[5].Value.ToString(),
                    dg_inv.SelectedRows[0].Cells[6].Value.ToString(),
                    dg_inv.SelectedRows[0].Cells[7].Value.ToString(),
                    dg_inv.SelectedRows[0].Cells[8].Value.ToString(),
                    dg_inv.SelectedRows[0].Cells[9].Value.ToString(),
                    dg_inv.SelectedRows[0].Cells[10].Value.ToString(),
                    dg_inv.SelectedRows[0].Cells[11].Value.ToString(),
                    dg_inv.SelectedRows[0].Cells[12].Value.ToString());
                if (from.ShowDialog() == DialogResult.OK)
                {

                }
                LoadInv();
            }
        }

        private void bt_add_PO_Click(object sender, EventArgs e)
        {
            if (dg_inv.SelectedRows.Count != 0)
            {
                Add_SOFTinInv from = new Add_SOFTinInv(
                    int.Parse(dg_inv.SelectedRows[0].Cells[0].Value.ToString()));
                if (from.ShowDialog() == DialogResult.OK)
                {

                }
                LoadInv();
            }
        }
    }
}
