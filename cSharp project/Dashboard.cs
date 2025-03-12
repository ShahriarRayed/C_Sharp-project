using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cSharp_project
{
    public partial class Dashboard : Form
    {
        // Database connection string
        string connectionString = "Data Source=DESKTOP-5903S8A\\SQLEXPRESS;Initial Catalog=Rodelicious;Integrated Security=True;";

        public Dashboard()
        {
            InitializeComponent();
            LoadDashboardData();
            timer1.Start();  // Start the timer on form load
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL Query to get Total Orders and Total Income
                    string query = "SELECT COUNT(OrderID) AS TotalOrders, SUM(TotalAmount) AS TotalIncome FROM Orders;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Create DataTable to hold the result
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Count");
                    dt.Columns.Add("Value");

                    if (reader.Read())
                    {
                        // Add data to DataTable (no need for explicit casting)
                        dt.Rows.Add("Total Orders", reader["TotalOrders"]);
                        dt.Rows.Add("Total Income", reader["TotalIncome"]);
                    }

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





        private void label1_Click(object sender, EventArgs e)
        {
            // No action needed here
        }

        private void totIncome_Click(object sender, EventArgs e)
        {
            // No action needed here
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // No action needed here
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

      
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update the label with current date and time
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
