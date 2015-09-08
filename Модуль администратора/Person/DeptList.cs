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
    public partial class DeptList : Form
    {
        List<dept> deptList = new List<dept>();
        struct dept
        {
            public int id;
            public string title;
            public string description;
        }
        public DeptList()
        {
            InitializeComponent();
            loadDeptList();
        }

        private void loadDeptList()
        {
            deptList.Clear();
            lb_dept.Items.Clear();
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT id_dept,title,description FROM dept where true=1";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dept t = new dept();
                        t.id = int.Parse(reader[0].ToString());
                        t.title = reader[1].ToString();
                        t.description = reader[2].ToString();
                        deptList.Add(t);
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }

            for (int i = 0; i < deptList.Count; i++)
            {
                lb_dept.Items.Add(deptList[i].title);
            }
        }

        public void LoadPerson()
        {
            dg_person.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        string.Format("select _person.id_person,_person.surname,_person.name,_person.secondaryname,_person.date_birth,_person.tel_number,_person.mail,_person_dept.post from person as _person,person_dept as _person_dept where _person.id_person=_person_dept.id_person and _person_dept.id_dept={0} and _person_dept.true_post=1 ",
                        deptList[lb_dept.SelectedIndex].id.ToString());
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dg_person.Rows.Add(reader[0].ToString(),
                            deptList[lb_dept.SelectedIndex].id.ToString(),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),                           
                            DateTime.Parse(reader[4].ToString()).ToShortDateString(),
                            reader[5].ToString(),
                            reader[6].ToString(),
                            reader[7].ToString());
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
        }

        private void bt_add_person_Click(object sender, EventArgs e)
        {
            if (lb_dept.SelectedIndex != -1)
            {
                PersonEdit form = new PersonEdit(deptList[lb_dept.SelectedIndex].id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadPerson();
                }
            }
        }

        private void bt_addDept_Click(object sender, EventArgs e)
        {
            DeptEditor form = new DeptEditor();
            form.ShowDialog();
            loadDeptList();
        }

        private void bt_updateDept_Click(object sender, EventArgs e)
        {
            if (lb_dept.SelectedIndex != -1)
            {
                string[] mas = new string[3];
                mas[0] = deptList[lb_dept.SelectedIndex].id.ToString();
                mas[1] = deptList[lb_dept.SelectedIndex].title.ToString();
                mas[2] = deptList[lb_dept.SelectedIndex].description.ToString();
                DeptEditor form = new DeptEditor(mas);
                form.ShowDialog();
                loadDeptList();
            }
        }

        private void bt_deleteDept_Click(object sender, EventArgs e)
        {
            if (dg_person.SelectedRows.Count == 0)
            {
                if (lb_dept.SelectedIndex != -1)
                {
                    if (MessageBox.Show("Вы хотите удалить " + lb_dept.SelectedItem.ToString() + "?", "Внимание!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand())
                            {
                                command.Connection = connection;
                                command.CommandText = string.Format("UPDATE dept set true=0 where id_dept={0}", deptList[lb_dept.SelectedIndex].id);
                                command.ExecuteNonQuery();
                            }
                        }
                        loadDeptList();
                        rb_description_dept.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Нельзя удалить отдел с сотрудниками");
            }
        }
        private void lb_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            rb_description_dept.Text = deptList[lb_dept.SelectedIndex].description;
            LoadPerson();
        }
        private void bt_update_person_Click(object sender, EventArgs e)
        {
            if (dg_person.SelectedRows.Count != 0)
            {
                PersonEdit form = new PersonEdit(int.Parse(dg_person.SelectedRows[0].Cells[0].Value.ToString()),
                                                            int.Parse(dg_person.SelectedRows[0].Cells[1].Value.ToString()),
                                                            dg_person.SelectedRows[0].Cells[3].Value.ToString(),
                                                            dg_person.SelectedRows[0].Cells[2].Value.ToString(),
                                                            dg_person.SelectedRows[0].Cells[4].Value.ToString(),
                                                            dg_person.SelectedRows[0].Cells[5].Value.ToString(),
                                                            dg_person.SelectedRows[0].Cells[6].Value.ToString(),
                                                            dg_person.SelectedRows[0].Cells[7].Value.ToString(),
                                                            dg_person.SelectedRows[0].Cells[8].Value.ToString());
                form.ShowDialog();
                LoadPerson();
            }
        }

        private void bt_delete_person_Click(object sender, EventArgs e)
        {
            if (dg_person.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Вы действительно хотите уволить сотрудника? ", "Внимание!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = string.Format("DELETE FROM person WHERE id_person = {0}", dg_person.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }
                    }
                    LoadPerson();
                }
            }

        }

        private void bt_HP_Click(object sender, EventArgs e)
        {
            if (lb_dept.SelectedIndex != -1)
            {
                if (dg_person.SelectedRows.Count != 0)
                {
                    HistoryPerson form = new HistoryPerson(int.Parse(dg_person.SelectedRows[0].Cells[0].Value.ToString()));
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                    }
                }
            }
        }
    }
}
