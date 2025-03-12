namespace cSharp_project
{
    partial class AdminPortal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPortal));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            Dashboard = new Button();
            addProduct = new Button();
            addCashier = new Button();
            button5 = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ORbutt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MistyRose;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(70, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 163);
            label1.Name = "label1";
            label1.Size = new Size(95, 17);
            label1.TabIndex = 2;
            label1.Text = "Admin's Portal";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            Dashboard.BackColor = Color.MistyRose;
            Dashboard.FlatStyle = FlatStyle.Popup;
            Dashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard.Location = new Point(46, 204);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(167, 47);
            Dashboard.TabIndex = 4;
            Dashboard.Text = "Dashboard";
            Dashboard.UseVisualStyleBackColor = false;
            Dashboard.Click += Dashboard_Click;
            // 
            // addProduct
            // 
            addProduct.BackColor = Color.MistyRose;
            addProduct.FlatStyle = FlatStyle.Popup;
            addProduct.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProduct.Location = new Point(46, 335);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(167, 47);
            addProduct.TabIndex = 6;
            addProduct.Text = "Inventory";
            addProduct.UseVisualStyleBackColor = false;
            addProduct.Click += addProduct_Click;
            // 
            // addCashier
            // 
            addCashier.BackColor = Color.MistyRose;
            addCashier.FlatStyle = FlatStyle.Popup;
            addCashier.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCashier.Location = new Point(46, 405);
            addCashier.Name = "addCashier";
            addCashier.Size = new Size(167, 47);
            addCashier.TabIndex = 7;
            addCashier.Text = "Employees";
            addCashier.UseVisualStyleBackColor = false;
            addCashier.Click += addCashier_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MistyRose;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(80, 549);
            button5.Name = "button5";
            button5.Size = new Size(95, 23);
            button5.TabIndex = 8;
            button5.Text = "Log Out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(254, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 625);
            panel1.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, -5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(854, 630);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1165, 629);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // ORbutt
            // 
            ORbutt.BackColor = Color.MistyRose;
            ORbutt.FlatStyle = FlatStyle.Popup;
            ORbutt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ORbutt.Location = new Point(46, 268);
            ORbutt.Name = "ORbutt";
            ORbutt.Size = new Size(167, 49);
            ORbutt.TabIndex = 13;
            ORbutt.Text = "Orders";
            ORbutt.UseVisualStyleBackColor = false;
            ORbutt.Click += ORbutt_Click;
            // 
            // AdminPortal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 625);
            Controls.Add(ORbutt);
            Controls.Add(button5);
            Controls.Add(addCashier);
            Controls.Add(addProduct);
            Controls.Add(Dashboard);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AdminPortal";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label1;
        private Button Dashboard;
        private Button addProduct;
        private Button addCashier;
        private Button button5;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button ORbutt;
    }
}
