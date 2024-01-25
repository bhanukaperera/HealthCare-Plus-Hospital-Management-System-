using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections.ObjectModel;

namespace HMS
{
    public partial class Doctor : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True");
        public string connectionString;

        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public Doctor()

        {
            InitializeComponent();
            connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";
        }

        
                

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet6.DoctorDetails' table. You can move, or remove it, as needed.
            this.doctorDetailsTableAdapter1.Fill(this.hMSDataSet6.DoctorDetails);
            // TODO: This line of code loads data into the 'hMSDataSet5.DoctorDetails' table. You can move, or remove it, as needed.
            this.doctorDetailsTableAdapter.Fill(this.hMSDataSet5.DoctorDetails);


        }

        private void street_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void ClearInputFields()
        {
            throw new NotImplementedException();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string firstName = fname.Text;
            string lastName = lname.Text;
            string gender = sex.SelectedItem?.ToString(); // Handle null selection
            DateTime dateOfBirth = bday.Value;
            string Email = email.Text;
            string phoneNumber = contact.Text;
            string specialization = area.Text;
            string HouseNo = houseNo.Text;
            string Street = street.Text;
            string City = city.Text;
            int experience = string.IsNullOrEmpty(expyear.Text) ? 0 : Convert.ToInt32(expyear.Text); // Handle empty input
            string Comments = comments.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL INSERT statement
                    string insertQuery = "INSERT INTO DoctorDetails (FirstName, LastName, Gender, DateOfBirth, Email, PhoneNumber, Specialization, HouseNo, Street, City, Experience, Comments) " +
                                         "VALUES (@FirstName, @LastName, @Gender, @DateOfBirth, @Email, @PhoneNumber, @Specialization, @HouseNo, @Street, @City, @Experience, @Comments)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Specialization", specialization);
                        cmd.Parameters.AddWithValue("@HouseNo", HouseNo);
                        cmd.Parameters.AddWithValue("@Street", Street);
                        cmd.Parameters.AddWithValue("@City", City);
                        cmd.Parameters.AddWithValue("@Experience", experience);
                        cmd.Parameters.AddWithValue("@Comments", Comments);

                        // Execute the SQL command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Optionally, display a success message
                            MessageBox.Show("Data added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the input fields
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected. Data not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fname_MouseClick(object sender, MouseEventArgs e)
        {
            fname.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void area_TextChanged(object sender, EventArgs e)
        {

        }

        private void houseNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void expyear_TextChanged(object sender, EventArgs e)
        {

        }

        private void comments_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                ID.Text = selectedRow.Cells["DoctorID"].Value.ToString();
                fname.Text = selectedRow.Cells["FirstName"].Value.ToString();
                lname.Text = selectedRow.Cells["LastName"].Value.ToString();
                sex.SelectedItem = selectedRow.Cells["Gender"].Value.ToString();
                bday.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                email.Text = selectedRow.Cells["Email"].Value.ToString();
                contact.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                area.Text = selectedRow.Cells["Specialization"].Value.ToString();
                houseNo.Text = selectedRow.Cells["HouseNo"].Value.ToString();
                street.Text = selectedRow.Cells["Street"].Value.ToString();
                city.Text = selectedRow.Cells["City"].Value.ToString();
                expyear.Text = selectedRow.Cells["Experience"].Value.ToString();
                comments.Text = selectedRow.Cells["Comments"].Value.ToString();
            }
        }



        private void lname_MouseClick(object sender, MouseEventArgs e)
        {
            lname.Text = string.Empty;
        }

        private void sex_MouseClick(object sender, MouseEventArgs e)
        {
            sex.Text = string.Empty;
        }

        private void ID_MouseClick(object sender, MouseEventArgs e)
        {
            ID.Text = string.Empty;
        }

        private void area_MouseClick(object sender, MouseEventArgs e)
        {
            area.Text = string.Empty;
        }

        private void contact_MouseClick(object sender, MouseEventArgs e)
        {
            contact.Text = string.Empty;
        }

        private void city_MouseClick(object sender, MouseEventArgs e)
        {
            city.Text = string.Empty;
        }

        private void expyear_MouseClick(object sender, MouseEventArgs e)
        {
            expyear.Text = string.Empty;
        }

        private void comments_MouseClick(object sender, MouseEventArgs e)
        {
            comments.Text = string.Empty;
        }

        private void street_TextChanged(object sender, EventArgs e)
        {

        }

        private void street_MouseClick(object sender, MouseEventArgs e)
        {
            street.Text = string.Empty;
        }

        private void houseNo_MouseClick(object sender, MouseEventArgs e)
        {
            houseNo.Text = string.Empty;
        }

        private void email_MouseClick(object sender, MouseEventArgs e)
        {
            email.Text = string.Empty;
        }

        private void clear_Click(object sender, EventArgs e)
        {

        }
    }
}
