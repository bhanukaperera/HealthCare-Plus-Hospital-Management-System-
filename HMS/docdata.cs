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
    public partial class docdata : Form
    {
        public docdata()
        {
            InitializeComponent();
        }

        private void docdata_Load(object sender, EventArgs e)
        {
           
            this.doctorDetailsTableAdapter.Fill(this.hMSDataSet7.DoctorDetails);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
