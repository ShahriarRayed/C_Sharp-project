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
    public partial class Orders : Form
    {
        string connectionString = "Data Source=DESKTOP-5903S8A\\SQLEXPRESS;Initial Catalog=Rodelicious;Integrated Security=True;";
        public Orders()
        {
            InitializeComponent();
            LoadOrder();
        }

        private void order_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void LoadOrder()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM ORDERS;";
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
                        MessageBox.Show("No data found in Orders table.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Debug message MessageBox.Show("Save button clicked."); 

                string query = "INSERT INTO ORDERS (Name, Quantity, UnitPrice) VALUES (@Name, @Quantity, @UnitPrice );";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@Quantity", textQuantity.Text);
                        cmd.Parameters.AddWithValue("@UnitPrice", decimal.Parse(textUT.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product added successfully.");
                    }
                }

                // Refresh the DataGridView after adding a new product
                LoadOrder();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
