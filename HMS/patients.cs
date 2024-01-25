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

namespace HMS
{
    public partial class patients : Form
    {
        string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";


        public patients()
        {
            InitializeComponent();
        }

        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Patients_table";
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void patients_Load(object sender, EventArgs e)
        {
            //Calling the method
            LoadDataIntoDataGridView();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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

                pID.Text = selectedRow.Cells["PatientID"].Value.ToString();
                fname.Text = selectedRow.Cells["FirstName"].Value.ToString();
                lname.Text = selectedRow.Cells["LastName"].Value.ToString();
                city.Text = selectedRow.Cells["City"].Value.ToString();
                phoneno.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                email.Text = selectedRow.Cells["Email"].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(selectedRow.Cells["DateOfBirth"].Value.ToString());
                age.Text = selectedRow.Cells["Age"].Value.ToString();
                comboBox1.SelectedItem = selectedRow.Cells["Gender"].Value.ToString();
                bgrp.Text = selectedRow.Cells["BloodGroup"].Value.ToString();
                cmt.Text = selectedRow.Cells["Comment"].Value.ToString();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            string firstName = fname.Text;
            string lastName = lname.Text;
            string cityy = city.Text;
            string phoneNumber = phoneno.Text;
            string e_mail = email.Text;
            DateTime dateOfBirth = dateTimePicker1.Value;
            int agee = Convert.ToInt32(age.Text);
            string gender = comboBox1.SelectedItem.ToString();
            string bloodGroup = bgrp.Text;
            string comments = cmt.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Patients_table (FirstName, LastName, DateOfBirth, Gender, Email, PhoneNumber, BloodGroup, Age, Comment, City) " +
                                         "VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @Email, @PhoneNumber, @BloodGroup, @Age, @Comment, @City)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Email", e_mail);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                        command.Parameters.AddWithValue("@Age", agee);
                        command.Parameters.AddWithValue("@Comment", comments);
                        command.Parameters.AddWithValue("@City", cityy);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            fname.Clear();
                            lname.Clear();
                            city.Clear();
                            phoneno.Clear();
                            email.Clear();
                            age.Clear();
                            bgrp.Clear();
                            cmt.Clear();

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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract the pID (assuming pID is the primary key)
                int patientID = Convert.ToInt32(selectedRow.Cells["PatientID"].Value);

                string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // SQL DELETE statement
                        string deleteQuery = "DELETE FROM Patients_table WHERE PatientID = @PatientID";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@PatientID", patientID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh the DataGridView after deleting the record
                                LoadDataIntoDataGridView();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            pID.Text = string.Empty;
            fname.Text = string.Empty;
            lname.Text = string.Empty;
            city.Text = string.Empty;
            phoneno.Text = string.Empty;
            email.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            age.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            bgrp.Text = string.Empty;
            cmt.Text = string.Empty;
        }

        private void update_Click(object sender, EventArgs e)
        {

        }
    }
}
