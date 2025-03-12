namespace cSharp_project
{
    partial class addCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCashier));
            label1 = new Label();
            dataGridEmp = new DataGridView();
            Username = new Label();
            Password = new Label();
            Role = new Label();
            Status = new Label();
            UsernameText = new TextBox();
            PasswordText = new TextBox();
            RoleCombo = new ComboBox();
            comboStatus = new ComboBox();
            addEmp = new Button();
            delEmp = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridEmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(510, 40);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 0;
            label1.Text = "Employee Data";
            label1.Click += label1_Click;
            // 
            // dataGridEmp
            // 
            dataGridEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridEmp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridEmp.BackgroundColor = Color.Snow;
            dataGridEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmp.Location = new Point(350, 88);
            dataGridEmp.Name = "dataGridEmp";
            dataGridEmp.Size = new Size(511, 492);
            dataGridEmp.TabIndex = 1;
            dataGridEmp.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(27, 208);
            Username.Name = "Username";
            Username.Size = new Size(63, 15);
            Username.TabIndex = 2;
            Username.Text = "Username:";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(27, 249);
            Password.Name = "Password";
            Password.Size = new Size(60, 15);
            Password.TabIndex = 3;
            Password.Text = "Password:";
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Location = new Point(27, 290);
            Role.Name = "Role";
            Role.Size = new Size(33, 15);
            Role.TabIndex = 4;
            Role.Text = "Role:";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(27, 328);
            Status.Name = "Status";
            Status.Size = new Size(42, 15);
            Status.TabIndex = 5;
            Status.Text = "Status:";
            // 
            // UsernameText
            // 
            UsernameText.Location = new Point(121, 205);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(196, 23);
            UsernameText.TabIndex = 6;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(121, 241);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(196, 23);
            PasswordText.TabIndex = 7;
            // 
            // RoleCombo
            // 
            RoleCombo.FormattingEnabled = true;
            RoleCombo.Items.AddRange(new object[] { "Admin", "Cashier", "Baker" });
            RoleCombo.Location = new Point(121, 287);
            RoleCombo.Name = "RoleCombo";
            RoleCombo.Size = new Size(196, 23);
            RoleCombo.TabIndex = 8;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Available", "Un-Available" });
            comboStatus.Location = new Point(121, 328);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(196, 23);
            comboStatus.TabIndex = 9;
            // 
            // addEmp
            // 
            addEmp.Location = new Point(66, 429);
            addEmp.Name = "addEmp";
            addEmp.Size = new Size(96, 49);
            addEmp.TabIndex = 12;
            addEmp.Text = "ADD";
            addEmp.UseVisualStyleBackColor = true;
            addEmp.Click += addEmp_Click;
            // 
            // delEmp
            // 
            delEmp.Location = new Point(203, 429);
            delEmp.Name = "delEmp";
            delEmp.Size = new Size(96, 49);
            delEmp.TabIndex = 14;
            delEmp.Text = "DELETE";
            delEmp.UseVisualStyleBackColor = true;
            delEmp.Click += delEmp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 127);
            label2.Name = "label2";
            label2.Size = new Size(141, 32);
            label2.TabIndex = 15;
            label2.Text = "Enroll Data";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(899, 619);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // addCashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(882, 605);
            Controls.Add(label2);
            Controls.Add(delEmp);
            Controls.Add(addEmp);
            Controls.Add(comboStatus);
            Controls.Add(RoleCombo);
            Controls.Add(PasswordText);
            Controls.Add(UsernameText);
            Controls.Add(Status);
            Controls.Add(Role);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(dataGridEmp);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "addCashier";
            Text = "addCashier";
            ((System.ComponentModel.ISupportInitialize)dataGridEmp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridEmp;
        private Label Username;
        private Label Password;
        private Label Role;
        private Label Status;
        private TextBox UsernameText;
        private TextBox PasswordText;
        private ComboBox RoleCombo;
        private ComboBox comboStatus;
        private Button addEmp;
        private Button delEmp;
        private Label label2;
        private PictureBox pictureBox1;
    }
}