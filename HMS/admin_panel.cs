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
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }

     
        private void doct_Click(object sender, EventArgs e)
        {
            Doctor Doctor = new Doctor();
            Doctor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patients patients = new patients();
            patients.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lcred lcred = new lcred();
            lcred.Show();
        }

        private void appdatabtn_Click(object sender, EventArgs e)
        {
            appdata appdata = new appdata();
            appdata.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            medselectrpt medselectrpt = new medselectrpt();
            medselectrpt.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            rooms rooms = new rooms();
            rooms.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
        }

        private void dash_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
