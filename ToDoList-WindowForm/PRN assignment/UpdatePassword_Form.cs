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
    public partial class UpdatePassword_Form : Form
    {
        private string userEmail;
        public UpdatePassword_Form(String email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (!password.Equals(confirmPassword))
            {
                MessageBox.Show("Password does not match each others.");
            }

            var userRepo = new UserRepository();
            var user = new User();
            user = userRepo.GetByUserEmail(userEmail);
            user.Password = password;
            userRepo.Update(user);

            MessageBox.Show("Update successfully!");
            this.Hide();
            login.Show();



        }
    }
}
