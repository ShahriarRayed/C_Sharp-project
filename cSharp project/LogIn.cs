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

namespace cSharp_project
{

    public partial class LogIn : Form
    {
        string connectionString = "Data Source=DESKTOP-5903S8A\\SQLEXPRESS;Initial Catalog=Rodelicious;Integrated Security=True;";
        public LogIn()
        {
            InitializeComponent();
        }

        private void buttLogIn_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text.Trim();
            string password = textPassword.Text.Trim();

            // Validate input (optional, but recommended)
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Query to check for matching credentials in the Admin table.
            // Adjust table/schema name as needed. Here, the table is enclosed in square brackets.
            string query = "SELECT COUNT(*) FROM [Admin] WHERE UserName = @UserName AND Password = @Password;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Use parameterized queries to avoid SQL injection
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@Password", password); // In production, use hashed passwords.

                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();

                        // If count > 0, a matching record was found.
                        if (count > 0)
                        {
                            // Credentials are valid; proceed to the Admin Portal.
                            AdminPortal adminPortal = new AdminPortal();
                            adminPortal.Show();
                            this.Hide();
                        }
                        else
                        {
                            // No matching user found.
                            MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while logging in: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelMess_Click(object sender, EventArgs e)
        {

        }
    }
}
