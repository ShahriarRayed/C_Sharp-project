namespace cSharp_project
{
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
        }

        protected void Form1_Load(object sender, EventArgs e)
        {

        }

        protected void Dashboard_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Dashboard dashboard = new Dashboard()

            {
                TopLevel = false,  // Allows embedding inside another control
                TopMost = true     // Ensures it appears on top
            };

            dashboard.FormBorderStyle = FormBorderStyle.None;

            dashboard.Dock = DockStyle.Fill; // Makes it expand inside the panel

            panel1.Controls.Add(dashboard);

            dashboard.Show();
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Customers_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            Customers customer = new Customers()

            {
                TopLevel = false,  // Allows embedding inside another control
                TopMost = true     // Ensures it appears on top
            };

            customer.FormBorderStyle = FormBorderStyle.None;

            customer.Dock = DockStyle.Fill; // Makes it expand inside the panel

            panel1.Controls.Add(customer);

            customer.Show();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            addProduct addproduct = new addProduct()

            {
                TopLevel = false,
                TopMost = true
            };

            addproduct.FormBorderStyle = FormBorderStyle.None;

            addproduct.Dock = DockStyle.Fill;

            panel1.Controls.Add((addproduct));


            addproduct.Show();
        }

        private void addCashier_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            addCashier addcashier = new addCashier()
            {
                TopLevel = false,
                TopMost = true

            };

            addcashier.FormBorderStyle = FormBorderStyle.None;

            addcashier.Dock = DockStyle.Fill;

            panel1.Controls.Add((addcashier));

            addcashier.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();

            this.Hide();
        }

        private void ORbutt_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Orders order = new Orders()

            {
                TopLevel = false,
                TopMost = true
            };

            order.FormBorderStyle = FormBorderStyle.None;

            order.Dock = DockStyle.Fill;

            panel1.Controls.Add((order));


            order.Show();
        }
    }
}
