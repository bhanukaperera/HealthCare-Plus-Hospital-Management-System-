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
    public partial class apdata : Form
    {
        public apdata()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appdata appdata = new appdata();
            appdata.Show();
        }

        private void roombtn_Click(object sender, EventArgs e)
        {
            rooms rooms = new rooms();
            rooms.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            medselect medselect = new medselect();
            medselect.Show();
        }

        private void ptbt_Click(object sender, EventArgs e)
        {

        }

        private void apdata_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
