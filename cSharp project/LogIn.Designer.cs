namespace cSharp_project
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            textUsername = new TextBox();
            Username = new Label();
            textPassword = new TextBox();
            Password = new Label();
            buttLogIn = new Button();
            buttonSignUp = new Button();
            labelMess = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.Location = new Point(569, 158);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(173, 23);
            textUsername.TabIndex = 1;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Location = new Point(489, 161);
            Username.Name = "Username";
            Username.Size = new Size(63, 15);
            Username.TabIndex = 3;
            Username.Text = "Username:";
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.Snow;
            textPassword.Location = new Point(569, 217);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(173, 23);
            textPassword.TabIndex = 4;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Location = new Point(492, 217);
            Password.Name = "Password";
            Password.Size = new Size(60, 15);
            Password.TabIndex = 5;
            Password.Text = "Password:";
            // 
            // buttLogIn
            // 
            buttLogIn.BackColor = Color.Transparent;
            buttLogIn.Location = new Point(616, 264);
            buttLogIn.Name = "buttLogIn";
            buttLogIn.Size = new Size(75, 23);
            buttLogIn.TabIndex = 6;
            buttLogIn.Text = "Log In";
            buttLogIn.UseVisualStyleBackColor = false;
            buttLogIn.Click += buttLogIn_Click;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.Transparent;
            buttonSignUp.Location = new Point(616, 328);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(75, 23);
            buttonSignUp.TabIndex = 7;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // labelMess
            // 
            labelMess.AutoSize = true;
            labelMess.BackColor = SystemColors.Control;
            labelMess.Location = new Point(568, 300);
            labelMess.Name = "labelMess";
            labelMess.Size = new Size(174, 15);
            labelMess.TabIndex = 8;
            labelMess.Text = "Don't have an account? Sign up";
            labelMess.Click += labelMess_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(822, 495);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(595, 121);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 9;
            label1.Text = "Please Log IN";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labelMess);
            Controls.Add(buttonSignUp);
            Controls.Add(buttLogIn);
            Controls.Add(Password);
            Controls.Add(textPassword);
            Controls.Add(Username);
            Controls.Add(textUsername);
            Controls.Add(pictureBox1);
            Name = "LogIn";
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textUsername;
        private Label Username;
        private TextBox textPassword;
        private Label Password;
        private Button buttLogIn;
        private Button buttonSignUp;
        private Label labelMess;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label1;
    }
}