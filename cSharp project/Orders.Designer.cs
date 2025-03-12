namespace cSharp_project
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            textID = new TextBox();
            textName = new TextBox();
            textQuantity = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            textUT = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(939, 635);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(381, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(452, 521);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 213);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter ID :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 251);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Enter Name :";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 329);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 2;
            label4.Text = "Enter Unit Price :";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 288);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter Quantity :";
            label3.Click += label3_Click;
            // 
            // textID
            // 
            textID.Location = new Point(147, 210);
            textID.Name = "textID";
            textID.Size = new Size(175, 23);
            textID.TabIndex = 3;
            textID.TextChanged += textBox1_TextChanged;
            // 
            // textName
            // 
            textName.Location = new Point(147, 251);
            textName.Name = "textName";
            textName.Size = new Size(175, 23);
            textName.TabIndex = 4;
            textName.TextChanged += textBox2_TextChanged;
            // 
            // textQuantity
            // 
            textQuantity.Location = new Point(147, 288);
            textQuantity.Name = "textQuantity";
            textQuantity.Size = new Size(175, 23);
            textQuantity.TabIndex = 5;
            textQuantity.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(110, 152);
            label6.Name = "label6";
            label6.Size = new Size(185, 25);
            label6.TabIndex = 8;
            label6.Text = "Enter Order Details ";
            // 
            // button1
            // 
            button1.Location = new Point(66, 430);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(211, 430);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "REMOVE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textUT
            // 
            textUT.Location = new Point(147, 326);
            textUT.Name = "textUT";
            textUT.Size = new Size(175, 23);
            textUT.TabIndex = 6;
            textUT.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(549, 39);
            label7.Name = "label7";
            label7.Size = new Size(118, 25);
            label7.TabIndex = 13;
            label7.Text = "Order Chart";
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 628);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textUT);
            Controls.Add(textQuantity);
            Controls.Add(textName);
            Controls.Add(textID);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Orders";
            Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textID;
        private TextBox textName;
        private TextBox textQuantity;
        private Label label6;
        private Button button1;
        private Button button2;
        private TextBox textUT;
        private Label label7;
    }
}