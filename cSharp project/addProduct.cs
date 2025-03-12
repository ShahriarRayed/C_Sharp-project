using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cSharp_project
{
    public partial class addProduct : Form
    {
        // Database connection string
        string connectionString = "Data Source=DESKTOP-5903S8A\\SQLEXPRESS;Initial Catalog=Rodelicious;Integrated Security=True;";

        public addProduct()
        {
            InitializeComponent(); // Ensure this is called first
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            LoadData(); // Load data when the form loads
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM PRODUCTS;";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No data found in PRODUCTS table.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Debug message MessageBox.Show("Save button clicked."); 

                string query = "INSERT INTO PRODUCTS (Name, Category, Price) VALUES (@Name, @Category, @Price);";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Name", prodName.Text);
                        cmd.Parameters.AddWithValue("@Category", comboBoxType.Text);
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(PriceBox.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product added successfully.");
                    }
                }

                // Refresh the DataGridView after adding a new product
                LoadData();
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected in the DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Get the ProductId from the selected row
                    int productId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value); // Ensure "ProductId" matches your database column name

                    // Confirm deletion with the user
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Delete the product from the database
                        string query = "DELETE FROM PRODUCTS WHERE ProductId = @ProductId;";
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                conn.Open();
                                cmd.Parameters.AddWithValue("@ProductId", productId);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Product deleted successfully.");
                                    // Refresh the DataGridView
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Product not found or could not be deleted.");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in btnDelete_Click: " + ex.Message);
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No changes needed here unless additional functionality is required
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // No changes needed here unless additional functionality is required
        }

        private void prodName_TextChanged(object sender, EventArgs e)
        {
            // No changes needed here unless additional functionality is required
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
