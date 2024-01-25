using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS
{
    public partial class medicines : Form
    {        
        string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";


        public medicines()
        {
            InitializeComponent();
        }

        private void medicines_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a SQL command to retrieve data
                string query = "SELECT * FROM medicines";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Create a DataTable to hold the data
                    DataTable dt = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    dataGridView1.DataSource = dt;
                }
            }
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                medID.Text = selectedRow.Cells["part_number"].Value.ToString();
                medname.Text = selectedRow.Cells["medicine_name"].Value.ToString();
                price.Text = selectedRow.Cells["sales_price"].Value.ToString();
                stock.Text = selectedRow.Cells["current_stock"].Value.ToString();



            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            medID.Text = string.Empty;
            medname.Text = string.Empty;
            price.Text = string.Empty;
            stock.Text = string.Empty;
        }
    }
        


    
}
