using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS
{
    public partial class rooms : Form
    {

        string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";


        public rooms()
        {
            InitializeComponent();
            chart1.Titles.Add("Pie Chart");

            chart1.Series["s1"].Points.AddXY("Available", "9");
            chart1.Series["s1"].Points.AddXY("Booked", "11");


        }

        private void LoadHospitalRoomsData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM HospitalRooms";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void rooms_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM HospitalRooms";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void book_Click(object sender, EventArgs e)
        {
          
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

               
                int roomID = Convert.ToInt32(selectedRow.Cells["RoomID"].Value);

         
                bool newStatus = !(bool)selectedRow.Cells["IsOccupied"].Value;

            
                string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True"; 
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE HospitalRooms SET IsOccupied = @IsOccupied WHERE RoomID = @RoomID";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@IsOccupied", newStatus);
                        command.Parameters.AddWithValue("@RoomID", roomID);
                        command.ExecuteNonQuery();
                    }
                }

                LoadHospitalRoomsData();
                dataGridView1.ClearSelection();


            }
        }

        private void rid_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int roomID = Convert.ToInt32(selectedRow.Cells["RoomID"].Value);
                bool isOccupied = (bool)selectedRow.Cells["IsOccupied"].Value;

                // Populate the "rid" TextBox with the RoomID
                rid.Text = roomID.ToString();

                // Populate the "combobox1" ComboBox with the IsOccupied status
                comboBox1.SelectedIndex = isOccupied ? 0 : 1;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            rid.Text = string.Empty;

            comboBox1.SelectedIndex = -1;
        }
    }
}
