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
    public partial class Add_SOFTinInv : Form
    {
        int id_inven;
        public Add_SOFTinInv(int id_inv)
        {
            InitializeComponent();
            id_inven = id_inv;
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT title FROM software";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_select.Items.Add(reader[0].ToString());
                    }
                }
                cb_select.SelectedIndex = 0;
            }
            LoadForm();
            
        }
        private void LoadForm()
        {
            dg_soft_inv.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT _si.id_record,_si.id_software,_s.title,_si.record_add FROM software as _s,software_inventory as _si where _s.id_software=_si.id_software and _si.id_inventory={0}", id_inven.ToString());
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dg_soft_inv.Rows.Add(reader[0],
                            reader[1],
                            reader[2],
                            DateTime.Parse(reader[3].ToString()).ToShortDateString());
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("ADD_SOFTinINV", connection))
                {
                    //,,,,
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Входной параметр.
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@title_po";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Value = cb_select.Text;
                    param.Direction = ParameterDirection.Input;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@date";
                    param.SqlDbType = SqlDbType.Date;
                    param.Value = DateTime.Parse(dg_soft_inv.SelectedRows[0].Cells[3].Value.ToString());
                    param.Direction = ParameterDirection.Input;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@id_inv";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = id_inven;
                    param.Direction = ParameterDirection.Input;
                    cmd.Parameters.Add(param);
                    // Выполнение хранимой процедуры.
                    cmd.ExecuteNonQuery();
                }
            }
            LoadForm();      
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("DELETE FROM software_inventory WHERE id_record = {0}",
                        dg_soft_inv.SelectedRows[0].Cells[0].Value.ToString());
                    command.ExecuteNonQuery();

                }
            }
            LoadForm();
        }
    }
}
