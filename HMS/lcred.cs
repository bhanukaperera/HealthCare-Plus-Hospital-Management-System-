using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Web.UI;

namespace HMS
{
    public partial class lcred : Form
    {

        string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";

        public lcred()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True");
                string query = "SELECT * FROM login_t";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
        private void lcred_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                username.Text = selectedRow.Cells["username"].Value.ToString();
                pwd.Text = selectedRow.Cells["password"].Value.ToString();
                typebox.SelectedItem = selectedRow.Cells["type"].Value.ToString();
            }
        }

        private void pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string usern = username.Text;
            string pswd = pwd.Text;
            string typee = typebox.SelectedItem.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO login_t (username, password, type) VALUES(@username, @password, @type)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", usern);
                        command.Parameters.AddWithValue("@password", pswd);
                        command.Parameters.AddWithValue("@type", typee);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //username.Clear();
                            //pwd.Clear();

                            LoadDataIntoDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string usernameToDelete = username.Text;

                    string deleteQuery = "DELETE FROM login_t WHERE username = @username";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", usernameToDelete);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataIntoDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No records deleted. Username not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string usernameToUpdate = username.Text;
                    string newPassword = pwd.Text; // Assuming you have a new password input field

                    // SQL UPDATE statement
                    string updateQuery = "UPDATE login_t SET password = @newPassword WHERE username = @username";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newPassword", newPassword);
                        command.Parameters.AddWithValue("@username", usernameToUpdate);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataIntoDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No records updated. Username not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
