namespace cSharp_project
{
    partial class addProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProduct));
            dataOfProduct = new Label();
            dataGridView1 = new DataGridView();
            productId = new Label();
            textBox1 = new TextBox();
            ProductName = new Label();
            prodName = new TextBox();
            Type = new Label();
            comboBoxType = new ComboBox();
            stock = new Label();
            Price = new Label();
            Status = new Label();
            comStatus = new ComboBox();
            PriceBox = new TextBox();
            StockBox = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataOfProduct
            // 
            dataOfProduct.AutoSize = true;
            dataOfProduct.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            dataOfProduct.Location = new Point(441, 19);
            dataOfProduct.Name = "dataOfProduct";
            dataOfProduct.Size = new Size(142, 30);
            dataOfProduct.TabIndex = 0;
            dataOfProduct.Text = "Product Data";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(169, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(699, 244);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // productId
            // 
            productId.AutoSize = true;
            productId.Location = new Point(15, 388);
            productId.Name = "productId";
            productId.Size = new Size(66, 15);
            productId.TabIndex = 2;
            productId.Text = "Product ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 385);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 3;
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Location = new Point(15, 431);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(87, 15);
            ProductName.TabIndex = 4;
            ProductName.Text = "Product Name:";
            // 
            // prodName
            // 
            prodName.Location = new Point(108, 428);
            prodName.Name = "prodName";
            prodName.Size = new Size(174, 23);
            prodName.TabIndex = 5;
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Location = new Point(15, 473);
            Type.Name = "Type";
            Type.Size = new Size(34, 15);
            Type.TabIndex = 6;
            Type.Text = "Type:";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "1. Pound Cake", "2. Bento Cake", "3. Cup Cake" });
            comboBoxType.Location = new Point(108, 470);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(174, 23);
            comboBoxType.TabIndex = 7;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Location = new Point(441, 385);
            stock.Name = "stock";
            stock.Size = new Size(39, 15);
            stock.TabIndex = 8;
            stock.Text = "Stock:";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(441, 431);
            Price.Name = "Price";
            Price.Size = new Size(36, 15);
            Price.TabIndex = 9;
            Price.Text = "Price:";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(441, 476);
            Status.Name = "Status";
            Status.Size = new Size(42, 15);
            Status.TabIndex = 10;
            Status.Text = "Status:";
            // 
            // comStatus
            // 
            comStatus.FormattingEnabled = true;
            comStatus.Items.AddRange(new object[] { "1. Baking", "2. Customization", "3. Ready" });
            comStatus.Location = new Point(509, 473);
            comStatus.Name = "comStatus";
            comStatus.Size = new Size(174, 23);
            comStatus.TabIndex = 11;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(509, 428);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(174, 23);
            PriceBox.TabIndex = 12;
            // 
            // StockBox
            // 
            StockBox.Location = new Point(509, 385);
            StockBox.Name = "StockBox";
            StockBox.Size = new Size(174, 23);
            StockBox.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Location = new Point(283, 537);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(373, 537);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(328, 566);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            // 
            // addProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1097, 604);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(StockBox);
            Controls.Add(PriceBox);
            Controls.Add(comStatus);
            Controls.Add(Status);
            Controls.Add(Price);
            Controls.Add(stock);
            Controls.Add(comboBoxType);
            Controls.Add(Type);
            Controls.Add(prodName);
            Controls.Add(ProductName);
            Controls.Add(textBox1);
            Controls.Add(productId);
            Controls.Add(dataGridView1);
            Controls.Add(dataOfProduct);
            Name = "addProduct";
            Text = "addProduct";
            Load += addProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dataOfProduct;
        private DataGridView dataGridView1;
        private Label productId;
        private TextBox textBox1;
        private Label ProductName;
        private TextBox prodName;
        private Label Type;
        private ComboBox comboBoxType;
        private Label stock;
        private Label Price;
        private Label Status;
        private ComboBox comStatus;
        private TextBox PriceBox;
        private TextBox StockBox;
        private Button btnSave;
        private Button btnDelete;
        private Button button1;
    }
}