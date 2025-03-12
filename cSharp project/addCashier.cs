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
    public partial class addCashier : Form
    {
        // Database connection string
        string connectionString = "Data Source=DESKTOP-5903S8A\\SQLEXPRESS;Initial Catalog=Rodelicious;Integrated Security=True;";

        public addCashier()
        {
            InitializeComponent();
            LoadCashier(); // Load data when form opens
        }

        private void addCashier_Load(object sender, EventArgs e)
        {
            LoadCashier(); // Load data when the form loads
        }

        private void LoadCashier()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Employee1;";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridEmp.DataSource = dt;
                        dataGridEmp.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No data found in Employee table.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void addEmp_Click(object sender, EventArgs e)
        {
            try
            {
                // Debug message MessageBox.Show("Save button clicked."); 

                string query = "INSERT INTO Employee1 (Name,Password, Role, Status) VALUES (@Name,@Password, @Role, @Status);";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Name", UsernameText.Text);
                        cmd.Parameters.AddWithValue("@Password", PasswordText.Text);
                        cmd.Parameters.AddWithValue("@Role",  RoleCombo.Text);
                        cmd.Parameters.AddWithValue("@Status", comboStatus.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee added successfully.");
                    }
                }

                // Refresh the DataGridView after adding a new product
               LoadCashier();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid price.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in btnSave_Click: " + ex.Message);
            }
        }
        private void delEmp_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected in the DataGridView
                if (dataGridEmp.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridEmp.SelectedRows[0];

                    // Get the ProductId from the selected row
                    int EmployeeId = Convert.ToInt32(selectedRow.Cells["EmployeeId"].Value); // Ensure "ProductId" matches your database column name

                    // Confirm deletion with the user
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Delete the product from the database
                        string query = "DELETE FROM Employee1 WHERE EmployeeId = @EmployeeId;";
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                conn.Open();
                                cmd.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Employee deleted successfully.");
                                    // Refresh the DataGridView
                                   LoadCashier();
                                }
                                else
                                {
                                    MessageBox.Show("Employee not found or could not be deleted.");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an Employee to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in btnDelete_Click: " + ex.Message);
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
