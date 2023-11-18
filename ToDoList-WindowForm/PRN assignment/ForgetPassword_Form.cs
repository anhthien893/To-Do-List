using data;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_assignment
{
    public partial class ForgetPassword_Form : Form
    {
        public ForgetPassword_Form()
        {
            InitializeComponent();
        }
        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string otp = null;
        string userEmail = null;

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                otp = null;
                ForgetPassword_Form forgetPassword = new ForgetPassword_Form();
                userEmail = txtEmail.Text;
                var email = new MailAddress(txtEmail.Text);
                var userRepo = new UserRepository();
                bool emailCheck = userRepo.IsEmailDuplicate(txtEmail.Text);
                if (!emailCheck)
                {
                    MessageBox.Show("This email has not been registered.");
                    return;
                }

                otp = new Random().Next(1000, 9999).ToString();

                var fromEmail = new MailAddress("nhatnmse171301@fpt.edu.vn");
                var toAdress = email;


                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(fromEmail.Address, "wshwclyaksmhcgve");
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = fromEmail;
                mailMessage.To.Add(toAdress);
                mailMessage.Subject = "OPT code: ";
                mailMessage.Body = otp;



                smtpClient.Send(mailMessage);

                MessageBox.Show("OPT is sent to your mail.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.StackTrace}");
            }



        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            if (otp.Equals(txtResult.Text))
            {
            MessageBox.Show("Incorrect OTP");
                return;
            }
            UpdatePassword_Form updatePassword = new UpdatePassword_Form(userEmail);
            this.Hide();
            updatePassword.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            this.Hide();
            login.Show();
        }
    }
}
