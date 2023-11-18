namespace PRN_assignment
{
    partial class Login_Form
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            lLForgetPassword = new LinkLabel();
            lLRegister = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnGoogleLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(303, 227);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Enter user's name";
            txtUserName.Size = new Size(259, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(303, 295);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter password";
            txtPassword.Size = new Size(259, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(313, 340);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 33);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            btnLogin.MouseHover += btnLogin_MouseEnter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lavender;
            pictureBox1.ErrorImage = Properties.Resources.fpwd;
            pictureBox1.Image = Properties.Resources.output_onlinegiftools__2_;
            pictureBox1.Location = new Point(303, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lLForgetPassword
            // 
            lLForgetPassword.AutoSize = true;
            lLForgetPassword.LinkColor = Color.DarkSlateGray;
            lLForgetPassword.Location = new Point(303, 388);
            lLForgetPassword.Name = "lLForgetPassword";
            lLForgetPassword.Size = new Size(99, 15);
            lLForgetPassword.TabIndex = 9;
            lLForgetPassword.TabStop = true;
            lLForgetPassword.Text = "Forget Password?";
            lLForgetPassword.LinkClicked += lLForgetPassword_LinkClicked;
            lLForgetPassword.MouseEnter += lLForgetPassword_MouseEnter;
            lLForgetPassword.MouseLeave += lLForgetPassword_MouseLeave;
            // 
            // lLRegister
            // 
            lLRegister.AutoSize = true;
            lLRegister.BackColor = Color.Transparent;
            lLRegister.LinkColor = Color.DarkSlateGray;
            lLRegister.Location = new Point(503, 388);
            lLRegister.Name = "lLRegister";
            lLRegister.Size = new Size(49, 15);
            lLRegister.TabIndex = 10;
            lLRegister.TabStop = true;
            lLRegister.Text = "Register";
            lLRegister.LinkClicked += lLRegister_LinkClicked;
            lLRegister.MouseEnter += lLRegister_MouseEnter;
            lLRegister.MouseLeave += lLRegister_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.username1_removebg_preview;
            pictureBox2.Location = new Point(203, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password12;
            pictureBox3.Location = new Point(203, 286);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // btnGoogleLogin
            // 
            btnGoogleLogin.BackColor = Color.CornflowerBlue;
            btnGoogleLogin.Cursor = Cursors.Hand;
            btnGoogleLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoogleLogin.ForeColor = Color.White;
            btnGoogleLogin.Location = new Point(442, 340);
            btnGoogleLogin.Name = "btnGoogleLogin";
            btnGoogleLogin.Size = new Size(110, 33);
            btnGoogleLogin.TabIndex = 13;
            btnGoogleLogin.Text = "Google login";
            btnGoogleLogin.UseVisualStyleBackColor = false;
            btnGoogleLogin.Click += btnGoogleLogin_Click;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoogleLogin);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lLRegister);
            Controls.Add(lLForgetPassword);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Name = "Login_Form";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private LinkLabel lLForgetPassword;
        private LinkLabel lLRegister;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnGoogleLogin;
    }
}