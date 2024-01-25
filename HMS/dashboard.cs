using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HMS
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        
        private void dashboard_Load(object sender, EventArgs e)
        {
            // Configure Bar Chart
            chart2.ChartAreas.Add(new ChartArea("BarChartArea"));
            chart2.Series.Add(new Series("BarSeries"));
            chart2.Series["BarSeries"].ChartType = SeriesChartType.Bar;
            chart2.Series["BarSeries"].Points.DataBindY(new double[] { 10, 25, 40, 15, 30 }); // Replace with your data

        }
    }
}
