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
    public partial class SignUp : Form
    {
        // Database connection string
        string connectionString = "Data Source=DESKTOP-5903S8A\\SQLEXPRESS;Initial Catalog=Rodelicious;Integrated Security=True;";
        public SignUp()
        {
            InitializeComponent();
        }
        private void buttReg_Click(object sender, EventArgs e)
        {
            try
            {
                // Debug message MessageBox.Show("Save button clicked."); 

                string query = "INSERT INTO [Admin] (Name,UserName, Password, Email, Phone) VALUES (@Name,@UserName,@Password, @Email, @Phone);";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Name", textBoxName.Text);
                        cmd.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                        cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                        cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Resistration successfull.");
                    }
                }


            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in btnReg_Click: " + ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
