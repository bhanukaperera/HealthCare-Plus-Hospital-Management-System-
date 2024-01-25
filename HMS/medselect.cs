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

namespace HMS
{
    public partial class medselect : Form
    {
        public medselect()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";

        private DataTable patientsTable;
        private DataTable medicinesTable;
        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT FirstName, LastName, Gender, Age FROM Patients_table";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        pat.DataSource = dt;
                    }
                }
            }
        }
        private void LoadDataIntoDataGridViewMed()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT medicine_name, sales_price, current_stock FROM medicines";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        med.DataSource = dt;
                    }
                }
            }
        }

        private void LoadDataIntoDataGridViewMeddata()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM PatientMedicines";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        meddata.DataSource = dt;
                    }
                }
            }
        }
        private void SearchPatients()
        {
            if (patientsTable != null)
            {
                string searchText = patientSearchBox.Text.Trim();
                DataView dv = patientsTable.DefaultView;
                if (!string.IsNullOrEmpty(searchText))
                {
                    // Search
                    dv.RowFilter = $"FirstName LIKE '%{searchText}%'";
                }
                else
                {
                    dv.RowFilter = string.Empty; 
                }
                pat.DataSource = dv.ToTable();
            }
        }

        private void pat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = pat.Rows[e.RowIndex];

                patientSearchBox.Text = selectedRow.Cells["FirstName"].Value.ToString();
            }
        }

        private void medselect_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            LoadDataIntoDataGridViewMed();
            LoadDataIntoDataGridViewMeddata();

        }

        private void patientSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = patientSearchBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                foreach (DataGridViewRow row in pat.Rows)
                {
                    var cell = row.Cells["FirstName"];
                    if (cell != null && cell.Value != null)
                    {
                        string cellValue = cell.Value.ToString();

                        if (cellValue.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false; 
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in pat.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void med_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Clear the TextBox to start with a clean slate
                medlist.Text = "";

                // Loop through the selected rows and concatenate the values
                foreach (DataGridViewRow selectedRow in med.SelectedRows)
                {
                    string medicineName = selectedRow.Cells["medicine_name"].Value.ToString();

                    // Check if the TextBox already contains text
                    if (!string.IsNullOrEmpty(medlist.Text))
                    {
                        // If it does, append a comma and a space before adding the next medicine name
                        medlist.Text += ", ";
                    }

                    medlist.Text += medicineName;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            int selectedRow = meddata.CurrentCell.RowIndex;
            int patientMedicineID = Convert.ToInt32(meddata.Rows[selectedRow].Cells["PatientMedicineID"].Value);
            string patientName = patientSearchBox.Text;
            string medicines = medlist.Text;
            string remarks = remarksTextBox.Text;

            if (string.IsNullOrWhiteSpace(patientName) || string.IsNullOrWhiteSpace(medicines))
            {
                MessageBox.Show("Patient Name and Medicines are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE PatientMedicines " +
                                         "SET Patientname = @Patientname, Medicines = @Medicines, Remarks = @Remarks " +
                                         "WHERE PatientMedicineID = @PatientMedicineID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Patientname", patientName);
                        command.Parameters.AddWithValue("@Medicines", medicines);
                        command.Parameters.AddWithValue("@Remarks", remarks);
                        command.Parameters.AddWithValue("@PatientMedicineID", patientMedicineID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadDataIntoDataGridViewMeddata();
                            // Clear input fields after successful update
                            patientSearchBox.Clear();
                            medlist.Clear();
                            remarksTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void issue_Click(object sender, EventArgs e)
        {
            string patientName = patientSearchBox.Text;
            string medicines = medlist.Text;
            string remarks = remarksTextBox.Text;

            if (string.IsNullOrWhiteSpace(patientName) || string.IsNullOrWhiteSpace(medicines))
            {
                MessageBox.Show("Patient Name and Medicines are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO PatientMedicines (Patientname, Medicines, Remarks) " +
                                         "VALUES (@Patientname, @Medicines, @Remarks)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Patientname", patientName);
                        command.Parameters.AddWithValue("@Medicines", medicines);
                        command.Parameters.AddWithValue("@Remarks", remarks);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadDataIntoDataGridViewMeddata();
                            // Clear input fields after successful addition
                            patientSearchBox.Clear();
                            medlist.Clear();
                            remarksTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void meddata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void meddata_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = meddata.Rows[e.RowIndex];

                // Assuming you have textboxes named textBoxPatientName, textBoxMedicines, and textBoxRemarks:
                patientSearchBox.Text = selectedRow.Cells["Patientname"].Value.ToString();
                medlist.Text = selectedRow.Cells["Medicines"].Value.ToString();
                remarksTextBox.Text = selectedRow.Cells["remarks"].Value.ToString();
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (meddata.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = meddata.SelectedRows[0];

                // Assuming the first column (index 0) contains a unique identifier like an ID
                int recordID = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Confirm the deletion with a dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Execute a DELETE query to remove the record from your database or data source
                        // You'll need to adapt this code to your specific database setup
                        string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string deleteQuery = "DELETE FROM PatientMedicines WHERE Patientname = @Patientname"; // Modify to match your table structure
                            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@ID", recordID);
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Successful deletion
                                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Refresh the DataGridView to reflect the changes
                                    LoadDataIntoDataGridView();
                                }
                                else
                                {
                                    // Deletion failed
                                    MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("No record selected for deletion.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clr_Click(object sender, EventArgs e)
        {
            patientSearchBox.Clear();
            medlist.Clear();
            remarksTextBox.Clear();
        }
    }
}
