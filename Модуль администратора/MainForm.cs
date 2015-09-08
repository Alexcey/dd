using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasterNamespace
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bt_buildings_Click(object sender, EventArgs e)
        {
            BuildingList sForm = new BuildingList();
            sForm.ShowDialog();
        }

        private void bt_dept_Click(object sender, EventArgs e)
        {
            DeptList sFrom = new DeptList();
            sFrom.ShowDialog();
        }

        private void bt_soft_Click(object sender, EventArgs e)
        {
            SoftList sForm = new SoftList();
            sForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            requestList sForm = new requestList(1);
            sForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            requestList sForm = new requestList(0);
            sForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bt_inv_Click(object sender, EventArgs e)
        {
            Inventory sfrom = new Inventory();
            sfrom.Show();
        }
    }
}
