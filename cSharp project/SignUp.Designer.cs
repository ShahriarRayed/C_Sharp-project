namespace cSharp_project
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            labelUsername = new Label();
            labelEmail = new Label();
            labelPassword = new Label();
            labelPhone = new Label();
            textBoxName = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            buttReg = new Button();
            pictureBox1 = new PictureBox();
            buttonBack = new Button();
            labelName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.MistyRose;
            labelUsername.Location = new Point(21, 167);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(60, 15);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.MistyRose;
            labelEmail.Location = new Point(24, 217);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.MistyRose;
            labelPassword.Location = new Point(21, 260);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.BackColor = Color.MistyRose;
            labelPhone.Location = new Point(21, 304);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(63, 15);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone No.";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.Snow;
            textBoxName.Location = new Point(103, 113);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(217, 23);
            textBoxName.TabIndex = 5;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.Snow;
            textBoxUsername.Location = new Point(103, 164);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(217, 23);
            textBoxUsername.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.Snow;
            textBoxPassword.Location = new Point(103, 257);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(217, 23);
            textBoxPassword.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.Snow;
            textBoxPhone.Location = new Point(103, 301);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(217, 23);
            textBoxPhone.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.Snow;
            textBoxEmail.Location = new Point(103, 214);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(217, 23);
            textBoxEmail.TabIndex = 11;
            // 
            // buttReg
            // 
            buttReg.BackColor = Color.MistyRose;
            buttReg.Location = new Point(141, 355);
            buttReg.Name = "buttReg";
            buttReg.Size = new Size(75, 23);
            buttReg.TabIndex = 12;
            buttReg.Text = "Register";
            buttReg.UseVisualStyleBackColor = false;
            buttReg.Click += buttReg_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-25, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(819, 470);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.MistyRose;
            buttonBack.Location = new Point(141, 397);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 14;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.MistyRose;
            labelName.Location = new Point(21, 116);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            labelName.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 48);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 15;
            label1.Text = "Registration";
            label1.Click += label1_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 449);
            Controls.Add(label1);
            Controls.Add(buttonBack);
            Controls.Add(buttReg);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxName);
            Controls.Add(labelPhone);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Controls.Add(labelUsername);
            Controls.Add(pictureBox1);
            Name = "SignUp";
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Label labelEmail;
        private Label labelPassword;
        private Label labelPhone;
        private TextBox textBoxName;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private Button buttReg;
        private PictureBox pictureBox1;
        private Button buttonBack;
        private Label labelName;
        private Label label1;
    }
}