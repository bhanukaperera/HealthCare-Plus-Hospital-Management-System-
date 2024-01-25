using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class receptionist : Form
    {
        public receptionist()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            patients patients = new patients();
            patients.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appoinment appoinment = new appoinment();
            appoinment.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            docdata docdata = new docdata();
            docdata.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            medselectrpt medselectrpt = new medselectrpt();
            medselectrpt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rooms rooms = new rooms();
            rooms.Show();
        }
    }
}
