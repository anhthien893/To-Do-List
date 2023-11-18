using data;
using data.Models;
using Microsoft.VisualBasic.Logging;
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
    public partial class LoginGoogle_Form : Form
    {
        public LoginGoogle_Form()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            this.Hide();
            login.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            User user = new User();

            var userRepo = new UserRepository();
            user = userRepo.GetByUserEmail(email);

            if (user != null && user.Password == password)
            {

                MessageBox.Show("Login successfully.");
                Application_Form app = new Application_Form(user);
                this.Close();
                app.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password is NOT correct");
                pictureBox1.Image = Properties.Resources.fpwd;
            }
        }
    }
}
