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

namespace HMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True"); 



        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-EQ31;Initial Catalog=HMS;Integrated Security=True";
            string username = tusername.Text;
            string password = tpassword.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = "SELECT COUNT(*) FROM login_t WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {                        

                        string query1 = "SELECT type FROM login_t WHERE username = @username AND password = @Password";
                        SqlCommand command1 = new SqlCommand(query1, conn);
                        
                        DataTable Mytb = new DataTable();
                        SqlCommand Mycom = new SqlCommand();
                        Mycom.CommandText = query1;
                        Mycom.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                        Mycom.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
                        SqlConnection JustOpenCommand = new SqlConnection(connectionString);
                        JustOpenCommand.Open();
                        Mycom.Connection = JustOpenCommand;
                        SqlDataAdapter myda = new SqlDataAdapter(Mycom);
                        myda.Fill(Mytb);
                        DataRow r = Mytb.Rows[0];
                        string typename = r[0].ToString();

                        //Greetings
                        MessageBox.Show("Welcome " + typename);

                        if (typename == "Admin")
                        {                           
                            admin_panel adminForm = new admin_panel();
                            adminForm.Show();
                            this.Hide();
                        }
                        else if (typename == "Nurse")
                        {                            
                            apdata Nurse = new apdata();
                            Nurse.Show();
                            this.Hide();
                        }
                        else if (typename == "Receptionist")
                        {
                            receptionist receptionist = new receptionist();
                            receptionist.Show();
                            this.Hide();
                        }
                        else if (typename == "Pharmacist")
                        {
                            pharmacist pharmacist = new pharmacist();
                            pharmacist.Show();
                            this.Hide();
                        }
                       
                    }
                    else
                    {
                        // Fail
                        MessageBox.Show("Invalid, Please try again !!");
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }


        private void tusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
