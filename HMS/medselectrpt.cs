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
    public partial class medselectrpt : Form
    {
        public medselectrpt()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void medselectrpt_Load(object sender, EventArgs e)
        {
            this.patientMedicinesTableAdapter.Fill(this.hMSDataSet8.PatientMedicines);
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            // Create a ChartArea
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Months";
            chartArea.AxisY.Title = "Total Receipts";

            chart.ChartAreas.Add(chartArea);

            Series series = new Series("Total Receipts");
            series.ChartType = SeriesChartType.Bar;

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            int[] receipts = { 1200, 1500, 800, 1600, 2000, 1800 };

            for (int i = 0; i < months.Length; i++)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = months[i];
                dataPoint.YValues = new double[] { receipts[i] };
                series.Points.Add(dataPoint);
            }

            chart.Series.Add(series);

            // Add the chart to the form
            Controls.Add(chart);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
