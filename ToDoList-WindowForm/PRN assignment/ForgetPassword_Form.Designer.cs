namespace PRN_assignment
{
    partial class ForgetPassword_Form
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
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            lbEmail = new Label();
            lbResult = new Label();
            btnGetPassword = new Button();
            txtResult = new TextBox();
            btnCheck = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.giphy;
            pictureBox1.Location = new Point(259, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(278, 235);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(204, 243);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(42, 15);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email :";
            lbEmail.Click += lbEmail_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(204, 287);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(35, 15);
            lbResult.TabIndex = 3;
            lbResult.Text = "OPT :";
            // 
            // btnGetPassword
            // 
            btnGetPassword.BackColor = SystemColors.ActiveCaption;
            btnGetPassword.Location = new Point(568, 234);
            btnGetPassword.Name = "btnGetPassword";
            btnGetPassword.Size = new Size(83, 32);
            btnGetPassword.TabIndex = 4;
            btnGetPassword.Text = "Send OTP";
            btnGetPassword.UseVisualStyleBackColor = false;
            btnGetPassword.Click += btnGetPassword_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(278, 284);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(113, 23);
            txtResult.TabIndex = 5;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = SystemColors.ActiveCaption;
            btnCheck.Location = new Point(568, 284);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(83, 32);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "Check OTP";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(46, 407);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(74, 21);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ForgetPassword_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnCheck);
            Controls.Add(txtResult);
            Controls.Add(btnGetPassword);
            Controls.Add(lbResult);
            Controls.Add(lbEmail);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox1);
            Name = "ForgetPassword_Form";
            Text = "ForgetPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private Label lbEmail;
        private Label lbResult;
        private Button btnGetPassword;
        private TextBox txtResult;
        private Button btnCheck;
        private Button btnBack;
    }
}