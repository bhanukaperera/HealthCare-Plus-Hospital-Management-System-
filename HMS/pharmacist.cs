﻿using System;
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
    public partial class pharmacist : Form
    {
        public pharmacist()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            medselect medselect = new medselect();
            medselect.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patdata patdata = new patdata();
            patdata.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
