using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using uir;

namespace MasterNamespace
{
    public partial class SoftList : Form   
    {
        List<soft> softList = new List<soft>();
        struct soft
        {
            public int id;
            public string title;
        }
        public SoftList()
        {
            InitializeComponent();
            LoadListSoftType();
        }

        public void LoadListSoftType()
        {
            softList.Clear();
            lb_soft_type.Items.Clear();
            using(SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select soft_type,title from soft_type";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        soft s = new soft();
                        s.id = int.Parse(reader[0].ToString());
                        s.title = reader[1].ToString();
                        softList.Add(s);
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            for (int i = 0; i < softList.Count; i++)
            {
                lb_soft_type.Items.Add(softList[i].title);
            }
        }
        public void LoadSoft()
        {
            dg_Soft.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        string.Format("select _s.id_software,_s.title,_t.title,_p.title,_s.date_add,_s.activation_numb,_s.description from software as _s,type_sw as _t,producer as _p,soft_type as _st where _s.type_sw=_t.type_sw and _p.id_producer=_s.id_producer and _st.soft_type=_s.soft_type and _st.soft_type={0}",
                        softList[lb_soft_type.SelectedIndex].id.ToString());
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        dg_Soft.Rows.Add(reader[0].ToString(),
                            softList[lb_soft_type.SelectedIndex].id.ToString(),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            DateTime.Parse(reader[4].ToString()).ToShortDateString(),
                            reader[5].ToString(),
                            reader[6].ToString());
                    }
                    reader.Close();
                    reader.Dispose();
                }
            } 
        } 

        private void bt_addSoft_type_Click(object sender, EventArgs e)
        {
            Soft_typeEditor form = new Soft_typeEditor();
            form.ShowDialog();
            LoadListSoftType();
        }

        private void bt_updateSoft_type_Click(object sender, EventArgs e)
        {
            if (lb_soft_type.SelectedIndex != -1)
            {
                string[] mas = new string[3];
                mas[0] = softList[lb_soft_type.SelectedIndex].id.ToString();
                mas[1] = softList[lb_soft_type.SelectedIndex].title.ToString();
                Soft_typeEditor form = new Soft_typeEditor(mas);
                form.ShowDialog();
                LoadListSoftType();
            }
        }

        private void lb_soft_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSoft();
        }

        private void bt_deleteSoft_type_Click(object sender, EventArgs e)
        {
            if (lb_soft_type.SelectedIndex != -1)
            {
                if (MessageBox.Show("Вы хотите удалить " + lb_soft_type.SelectedItem.ToString() + "?", "Внимание!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = string.Format("DELETE FROM soft_type where soft_type={0}",softList[lb_soft_type.SelectedIndex].id);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                LoadListSoftType();
            }
        }
        private void bt_add_software_Click(object sender, EventArgs e)
        {
                if (lb_soft_type.SelectedIndex != -1)
                {
                    SoftEditor form = new SoftEditor(softList[lb_soft_type.SelectedIndex].id);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadSoft();
                    }
                }
        }

        private void dg_Soft_SelectionChanged(object sender, EventArgs e)
        {
           if (dg_Soft.SelectedRows.Count != 0)
            {
                dtp_date_add.Value = DateTime.Parse(dg_Soft.SelectedRows[0].Cells[5].Value.ToString());
                tb_activation_key.Text = dg_Soft.SelectedRows[0].Cells[6].Value.ToString();
                rb_description_soft.Text = dg_Soft.SelectedRows[0].Cells[7].Value.ToString();
            } 
        }

        private void bt_update_software_Click(object sender, EventArgs e)
        {
            if (dg_Soft.SelectedRows.Count != 0)
            {
                //TODO 1: сделать промежуточные переменные и их уже передавать в форму
                SoftEditor form = new SoftEditor(int.Parse(dg_Soft.SelectedRows[0].Cells[0].Value.ToString()),
                                                            dg_Soft.SelectedRows[0].Cells[2].Value.ToString(),                            
                                                            dg_Soft.SelectedRows[0].Cells[3].Value.ToString(),
                                                            dg_Soft.SelectedRows[0].Cells[4].Value.ToString(),
                                                            dg_Soft.SelectedRows[0].Cells[5].Value.ToString(),
                                                            dg_Soft.SelectedRows[0].Cells[6].Value.ToString(),
                                                            dg_Soft.SelectedRows[0].Cells[7].Value.ToString());
                form.ShowDialog();
                LoadSoft();
            }
        }

        private void bt_delete_software_Click(object sender, EventArgs e)
        {
            if (dg_Soft.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Вы хотите удалить ПО " + dg_Soft.SelectedRows[0].Cells[2].Value.ToString() + "?",
                    "Удаление комнаты", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = string.Format("DELETE FROM software WHERE id_software = {0}",
                                dg_Soft.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }
                    }
                }
                LoadSoft();
            }
            else
            {
                MessageBox.Show("НЕ выбрано ни одного ПО");
            }
        }
    }
}
