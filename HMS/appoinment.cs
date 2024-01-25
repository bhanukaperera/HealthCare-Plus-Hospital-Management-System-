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
using System.Xml.Linq;
using System.Xml.XPath;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS
{
    public partial class appoinment : Form
    {

        string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";

        public appoinment()
        {
            InitializeComponent();
        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pateintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void appoinment_Load(object sender, EventArgs e)
        {
            date.ShowUpDown = true;

            time.Format = DateTimePickerFormat.Custom;

            //Custom Format to show only the time
            time.CustomFormat = "hh:mm tt";
                        
            time.Width = 100;

            LoadDataIntoDataGridViewPatient();
            LoadDataIntoDataGridViewRates();
            LoadDataIntoDataGridViewRoom();
            LoadDataIntoDataGridViewDoctor();
            LoadDataIntoDataGridViewAppt();
            axAcroPDF1.LoadFile(@"C:\Users\jkbpe\Music\Gmail.pdf");
        }

        private void LoadDataIntoDataGridViewPatient()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT FirstName, LastName, PhoneNumber FROM Patients_table";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        patient.DataSource = dt;
                    }
                }
            }
        }

        private void LoadDataIntoDataGridViewRoom()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT RoomType, BedCount, IsOccupied FROM HospitalRooms";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        room.DataSource = dt;
                    }
                }
            }
        }

        private void LoadDataIntoDataGridViewDoctor()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT FirstName, LastName, PhoneNumber, Specialization FROM DoctorDetails"; 
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        doctor.DataSource = dt;
                    }
                }
            }
        }

        private void LoadDataIntoDataGridViewRates()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PackageName, Cost FROM rates";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        rates.DataSource = dt;
                    }
                }
            }
        }

        private void LoadDataIntoDataGridViewAppt()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Appointment";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        appt.DataSource = dt;
                    }
                }
            }
        }

        private void apid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = patient.Rows[e.RowIndex];

                patname.Text = selectedRow.Cells["FirstName"].Value.ToString();
            }
        }

        private void doctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = doctor.Rows[e.RowIndex];

                doc.Text = selectedRow.Cells["FirstName"].Value.ToString();
            }
        }

        private void doctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = room.Rows[e.RowIndex];

                roombox.Text = selectedRow.Cells["RoomType"].Value.ToString();
            }
        }

        private void book_Click(object sender, EventArgs e)
        {
            try
            {
                
                int apidd = int.Parse(apid.Text);
                string patnamee = patname.Text;
                DateTime datee = date.Value.Date; 
                DateTime timee = time.Value; 
                string roomap = roombox.Text;
                string doctorname = doctor.Text;
                decimal ratecost = decimal.Parse(ratebox.SelectedItem.ToString());

                string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL INSERT statement
                    string insertQuery = "INSERT INTO Appointment (AppointmentID, Patientname, Date, Time, Roomap, Doctorname, Ratecost) " +
                                         "VALUES (@AppointmentID, @Patientname, @Date, @Time, @Roomap, @Doctorname, @Ratecost)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", apidd);
                        command.Parameters.AddWithValue("@Patientname", patnamee);
                        command.Parameters.AddWithValue("@Date", datee);
                        command.Parameters.AddWithValue("@Time", timee);
                        command.Parameters.AddWithValue("@Roomap", roomap);
                        command.Parameters.AddWithValue("@Doctorname", doctorname);
                        command.Parameters.AddWithValue("@Ratecost", ratecost);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataIntoDataGridViewAppt();

                        }
                        else
                        {
                            MessageBox.Show("Failed to add record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void appt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void appt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = appt.Rows[e.RowIndex];


                apid.Text = selectedRow.Cells["AppointmentID"].Value.ToString();
                patname.Text = selectedRow.Cells["Patientname"].Value.ToString();
                doc.Text = selectedRow.Cells["Doctorname"].Value.ToString();
                roombox.Text = selectedRow.Cells["Roomap"].Value.ToString();


            }
        }

        private void patname_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                int apidd = int.Parse(apid.Text);
                string patnamee = patname.Text;
                DateTime datee = date.Value.Date;
                DateTime timee = time.Value;
                string roomap = roombox.Text;
                string doctorname = doctor.Text;
                decimal ratecost = decimal.Parse(ratebox.SelectedItem.ToString());

                string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL UPDATE statement
                    string updateQuery = "UPDATE Appointment SET Patientname = @Patientname, Date = @Date, Time = @Time, Roomap = @Roomap, Doctorname = @Doctorname, Ratecost = @Ratecost WHERE AppointmentID = @AppointmentID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", apidd);
                        command.Parameters.AddWithValue("@Patientname", patnamee);
                        command.Parameters.AddWithValue("@Date", datee);
                        command.Parameters.AddWithValue("@Time", timee);
                        command.Parameters.AddWithValue("@Roomap", roomap);
                        command.Parameters.AddWithValue("@Doctorname", doctorname);
                        command.Parameters.AddWithValue("@Ratecost", ratecost);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataIntoDataGridViewAppt();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (appt.SelectedRows.Count > 0)
                {
                    int apidd = int.Parse(apid.Text); 

                    string connectionString = @"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // SQL DELETE statement
                        string deleteQuery = "DELETE FROM Appointment WHERE AppointmentID = @AppointmentID";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@AppointmentID", apidd);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataIntoDataGridViewAppt();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            axAcroPDF1.printWithDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void clr_Click(object sender, EventArgs e)
        {
            apid.Text = string.Empty;
            patname.Text = string.Empty;
            roombox.Text = string.Empty;
            doc.Text = string.Empty;
            ratebox.SelectedIndex = -1;            
        }
    }
 }

