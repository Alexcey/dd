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
    public partial class HistoryPerson : Form
    {
        int id_person = -1;
        public HistoryPerson(int id_p)
        {
            InitializeComponent();
            id_person = id_p;
            dg_hp_dept.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(XMLwork.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("select _dept.title,_pd.date,_pd.post from dept as _dept,person_dept as _pd where _pd.id_person={0} and _dept.id_dept=_pd.id_dept",
                        id_person);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dg_hp_dept.Rows.Add(reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString());
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
        }
    }
}
