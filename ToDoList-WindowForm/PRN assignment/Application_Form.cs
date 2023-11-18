using System.DirectoryServices.ActiveDirectory;

using data;
using data.Models;

namespace PRN_assignment
{
    public partial class Application_Form : Form
    {
        int minute;
        int second;
        private bool isEditing;
        private User loginUser;
        public Application_Form(User user)
        {
            InitializeComponent();
            loginUser = user;
        }


        private void btnTimer_Click(object sender, EventArgs e)
        {
            timerGroup.Visible = true;
            if (sidebarTimer.Enabled == false)
            {
                timerMinimize.Visible = false;
            }
            else
            {
                timerMinimize.Visible = true;
            }
        }

        private void timerStartBtn_Click(object sender, EventArgs e)
        {
            if (timerStartBtn.Text.Equals("Start"))
            {
                timerStartBtn.Text = "Pause";
                sidebarTimer.Enabled = true;

                if (minute < 10)
                {
                    if (second < 10)
                    {
                        timeLabel.Text = "0" + minute + ":" + "0" + second;
                    }
                    else
                    {
                        timeLabel.Text = "0" + minute + ":" + second;
                    }

                }
                else
                {
                    if (second < 10)
                    {
                        timeLabel.Text = minute + ":" + "0" + second;
                    }
                    else
                    {
                        timeLabel.Text = minute + ":" + "0" + second;
                    }
                }
            }
            else if (sidebarTimer.Enabled == true)
            {
                timerStartBtn.Text = "Start";
                resetBtn.Enabled = true;
                promodoroBtn.Enabled = true;
                shortBtn.Enabled = true;
                longBtn.Enabled = true;
                sidebarTimer.Enabled = true;
                sidebarTimer.Enabled = false;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            timerGroup.Visible = false;
            if (sidebarTimer.Enabled == false)
            {
                timerMinimize.Visible = false;
            }
            else
            {
                timerMinimize.Visible = true;
            }
        }

        private void promodoroBtn_Click(object sender, EventArgs e)
        {
            if (sidebarTimer.Enabled == false)
            {
                minute = 20;
                second = 0;
                timeLabel.Text = minute + ":0" + second;
            }
        }

        private void shortBtn_Click(object sender, EventArgs e)
        {
            minute = 5;
            second = 0;
            timeLabel.Text = "0" + minute + ":0" + second;
        }

        private void longBtn_Click(object sender, EventArgs e)
        {
            minute = 10;
            second = 0;
            timeLabel.Text = minute + ":0" + second;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            minute = 0;
            second = 0;
            timeLabel.Text = "0" + minute + ":0" + second;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            resetBtn.Enabled = false;
            promodoroBtn.Enabled = false;
            shortBtn.Enabled = false;
            longBtn.Enabled = false;
            second--;
            if (minute > 0)
            {
                if (second < 0)
                {
                    second = 59;
                    minute--;
                }
            }
            if (minute < 10 || second < 10)
            {
                if (second < 10 && minute < 10)
                {
                    timeLabel.Text = "0" + minute + ":" + "0" + second;
                }
                else if (minute < 10)
                {
                    timeLabel.Text = "0" + minute + ":" + second;
                }
                else if (second < 10)
                {
                    timeLabel.Text = minute + ":" + "0" + second;
                }

            }
            else
            {
                timeLabel.Text = minute + ":" + second;
            }


            if (minute == 0 && second == 0)
            {
                resetBtn.Enabled = true;
                promodoroBtn.Enabled = true;
                shortBtn.Enabled = true;
                longBtn.Enabled = true;
                sidebarTimer.Enabled = true;

            }
            timerMinimize.Text = timeLabel.Text;
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            Task_Form task = new Task_Form(loginUser);
            openChildForm(task);
        }
        private Form currentChild;
        private void openChildForm(Form childForm)
        {
            if (currentChild != null)
            {
                currentChild.Close();
            }
            currentChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            Course_Form course = new Course_Form(loginUser);
            openChildForm(course);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form login = new Login_Form();
            login.ShowDialog();
        }
    }
}