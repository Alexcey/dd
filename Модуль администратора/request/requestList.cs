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
    public partial class requestList : Form
    {
        const int arch = 0;
        const int work = 1;
        private int status;
        bool update = true;
        int seldown = 0;
        struct selection_objectType
        {
            //string id_req;
            //DateTime DateStart;
            //DateTime DateEnd;
            //int personID;
            //string person_name;
            //public string description;

        }
        public requestList(int status_form)
        {
            InitializeComponent();
            
            if (status_form == arch)
            {
                //со статусом завершено и отказ
                //loadList(12);
              //  loadList(status);
                rb_all.Visible = false;
                rb_inWork.Visible = false;
                rb_new.Visible = false;
                button1.Visible = false;
            }
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT description FROM request_type";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_rq_type.Items.Add(reader[0].ToString());
                    }
                }
                cb_rq_type.SelectedIndex = 0;
            }
        }

        private void rb_new_CheckedChanged(object sender, EventArgs e)
        {
            status = 1;
            //loadList(status);
            update = true;
        }

        private void rb_inWork_CheckedChanged(object sender, EventArgs e)
        {
            status = 3;
           // loadList(status);
            update = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            status = 6;
            update = true;
           // loadList(status);
        }
     /*   void loadList(int status_req)
        {
            //"select * from request where status_request = "+status_req.tostring+" andrequest_type = "+typ_requst.to string
            dg_request.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select t_rq.id_request, t_rq.date_start, t_rq.date_end, t_rq_type.description from request as t_rq, request_type as t_rq_type where t_rq.request_type = t_rq_type.request_type";
                    if (status_req >=10)
                        command.CommandText += " and (status_request = " + status_req / 10 + " OR status_request = " + status_req % 10 + ") ";
                    else
                        command.CommandText += " and status_request = "+status_req.ToString()+" ";
                    if (cb_rq_type.SelectedIndex != 0)
                    {
                        command.CommandText += " AND t_rq.request_type =" + (cb_rq_type.SelectedIndex + 1).ToString();
                    }
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dg_request.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
        } */
     /*    void loadList(int status_req)
        {
            int SelectStatus = cb_rq_type.SelectedIndex;
            dg_request.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select distinct _r.id_request,_r.id_inventory,_r.date_start,_r.date_end,_sr.description,_p.surname,_p.name,_p.secondaryname,_r.description,_r.answer from request as _r,status_request as _sr,person as _p,request_type as _rt where _r.status_request=_sr.status_request and _r.id_person=_p.id_person";
                    if (status_req <= 1)
                        command.CommandText += " and _sr.status_request=1";
                    else if (status_req > 2 && status_req < 5)
                        command.CommandText += " and _sr.status_request = 3 and _sr.status_request = 4";
                    else
                        command.CommandText += " ";
                    if (SelectStatus == 1)
                    command.CommandText += "  and _rt.request_type=2";
                    else if(SelectStatus == 2)
                        command.CommandText += "  and _rt.request_type=3";
                    else if (SelectStatus == 3)
                        command.CommandText += "  and _rt.request_type=4";
                    else if (SelectStatus == 4)
                        command.CommandText += "  and _rt.request_type=5";
                    else if (SelectStatus == 5)
                        command.CommandText += "  and _rt.request_type=6";
                    else command.CommandText += " and _rt.request_type!=1";

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dg_request.Rows.Add(reader[0],
                           reader[1],
                           DateTime.Parse(reader[2].ToString()).ToShortDateString(),
                           DateTime.Parse(reader[3].ToString()).ToShortDateString(), 
                            reader[4].ToString(), 
                            reader[5].ToString(), 
                            reader[6].ToString(),
                            reader[7].ToString(), 
                            reader[8].ToString(),
                            reader[9].ToString());
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
        } */
        private void dg_request_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_request.SelectedRows.Count != 0)
            {
                lb_name.Text = dg_request.SelectedRows[0].Cells[5].Value.ToString() + ' ' + dg_request.SelectedRows[0].Cells[6].Value.ToString() + ' ' + dg_request.SelectedRows[0].Cells[7].Value.ToString();
                rtb_des.Text = dg_request.SelectedRows[0].Cells[8].Value.ToString();
                richTextBox2.Text = dg_request.SelectedRows[0].Cells[9].Value.ToString();
            }
            else
            {
                lb_name.Text = "";
                rtb_des.Text = "";
                richTextBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                //делаем update в БД.
        }

        private void cb_rq_type_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  loadList(status);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dg_request.SelectedRows.Count != 0)
            {
                PersonalInfo Form = new PersonalInfo(
                    int.Parse(dg_request.SelectedRows[0].Cells[1].Value.ToString()),
                    dg_request.SelectedRows[0].Cells[5].Value.ToString(),
                    dg_request.SelectedRows[0].Cells[6].Value.ToString(),
                    dg_request.SelectedRows[0].Cells[7].Value.ToString());
                Form.ShowDialog();            
            }
        }

        private void CloseRequest_Click(object sender, EventArgs e)
        {          
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("update request set status_request=4 ,date_end=getdate(),answer='{0}' where id_request={1}",
                            richTextBox2.Text,
                           dg_request.SelectedRows[0].Cells[0].Value.ToString());
                        command.ExecuteNonQuery();
                    }
                }
                update = true;
                //status = 6;
           // loadList(status);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int SelectStatus = cb_rq_type.SelectedIndex;
            if (SelectStatus != seldown) update = true;
            if (update == true)
            {
                dg_request.Rows.Clear();
                richTextBox2.Clear();
                using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select distinct _r.id_request,_r.id_inventory,_r.date_start,_r.date_end,_sr.description,_p.surname,_p.name,_p.secondaryname,_r.description,_r.answer from request as _r,status_request as _sr,person as _p,request_type as _rt where _r.status_request=_sr.status_request and _r.id_person=_p.id_person and _rt.request_type=_r.request_type";
                        if (status == 1)
                            command.CommandText += " and _sr.status_request=1";
                        else if (status==3)
                            command.CommandText += " and (_sr.status_request = 2 or _sr.status_request = 3)";
                        else
                            command.CommandText += " and _sr.status_request != 5 "; 
                        if (SelectStatus == 1)
                            command.CommandText += "  and _rt.request_type=1";
                        else if (SelectStatus == 2)
                            command.CommandText += "  and _rt.request_type=2";
                        else if (SelectStatus == 3)
                            command.CommandText += "  and _rt.request_type=3";
                        else if (SelectStatus == 4)
                            command.CommandText += "  and _rt.request_type=4";                    
                        else command.CommandText += " and _rt.request_type!=0"; 

                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            dg_request.Rows.Add(reader[0],
                               reader[1],
                               DateTime.Parse(reader[2].ToString()).ToShortDateString(),
                               //DateTime.Parse(reader[3].ToString()).ToShortDateString(),
                               reader[3].ToString(),
                                reader[4].ToString(),
                                reader[5].ToString(),
                                reader[6].ToString(),
                                reader[7].ToString(),
                                reader[8].ToString(),
                                reader[9].ToString());
                        }
                        reader.Close();
                        reader.Dispose();
                    }
                }
                seldown = SelectStatus;
                update = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update request set status_request=2 where id_request={0}",
                       dg_request.SelectedRows[0].Cells[0].Value.ToString());
                    command.ExecuteNonQuery();
                }
            }
            update = true;
           // status = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update request set status_request=3 where id_request={0}",
                       dg_request.SelectedRows[0].Cells[0].Value.ToString());
                    command.ExecuteNonQuery();
                }
            }
            update = true;
            //status = 2;
        }
    }
}
