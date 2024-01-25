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
    public partial class patdata : Form
    {
        public patdata()
        {
            InitializeComponent();
        }

        private void patdata_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet9.Patients_table' table. You can move, or remove it, as needed.
            this.patients_tableTableAdapter.Fill(this.hMSDataSet9.Patients_table);

        }
    }
}
