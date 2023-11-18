using data;
using data.Models;
using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_assignment
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private bool isHovered = false;


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lLForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword_Form forgetPassword = new ForgetPassword_Form();
            this.Hide();
            forgetPassword.ShowDialog();
        }

        private void lLForgetPassword_MouseEnter(object sender, EventArgs e)
        {

            isHovered = true;
            ZoomLinkLabel(lLForgetPassword);
        }

        private void lLForgetPassword_MouseLeave(object sender, EventArgs e)
        {

            isHovered = false;
            ResetLinkLabelSize(lLForgetPassword);
        }

        private void lLRegister_MouseEnter(object sender, EventArgs e)
        {

            isHovered = true;
            ZoomLinkLabel(lLRegister);
        }

        private void lLRegister_MouseLeave(object sender, EventArgs e)
        {

            isHovered = false;
            ResetLinkLabelSize(lLRegister);
        }


        private void lLRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register_Form register = new Register_Form();
            this.Hide();
            register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            User user = new User();

            var userRepo = new UserRepository();
            user = userRepo.GetByUsername(userName);

            if (user != null && user.Password == password)
            {

                MessageBox.Show("Login successfully.");

                Application_Form app = new Application_Form(user);
                app.ShowDialog();

                this.Close();

            }
            else
            {
                MessageBox.Show("Username or password is NOT correct");
                pictureBox1.Image = Properties.Resources.fpwd;
            }

        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.SlateBlue;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.CornflowerBlue;
        }
        private void ZoomLinkLabel(LinkLabel linkLabel)
        {
            if (isHovered)
            {
                linkLabel.Font = new Font(linkLabel.Font, FontStyle.Bold);
            }
        }

        private void ResetLinkLabelSize(LinkLabel linkLabel)
        {
            linkLabel.Font = new Font(linkLabel.Font, FontStyle.Regular);
        }       

        private void btnGoogleLogin_Click(object sender, EventArgs e)
        {
            LoginGoogle_Form loginGoogle = new LoginGoogle_Form();
            this.Hide();
            loginGoogle.Show();
        }
    }
}
