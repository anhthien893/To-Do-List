using data;
using data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_assignment
{
    public partial class Task_Form : Form
    {

        private List<data.Models.Task> dataSource = new List<data.Models.Task>();
        public TaskRepository taskRepository = new TaskRepository();
        private User loginUser;
        public Task_Form(User us)
        {
            InitializeComponent();

            loginUser = us;

            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            txtTaskID.Visible = false;
            CompleteDate.Visible = false;

            updateGridView();
        }
        public void updateGridView()
        {
            taskRepository = new TaskRepository();
            List<data.Models.Task> listTask = taskRepository.GetAll()
                .Where(p => p.UserId == loginUser.Id && p.Status == true)
                .ToList();

            BindingSource source = new BindingSource();
            source.DataSource = listTask;
            dvgTask.DataSource = source;
            dvgTask.Columns["Status"].Visible = false;
            dvgTask.Columns["Id"].Visible = false;
            dvgTask.Columns["UserId"].Visible = false;
        }

        public void clearText()
        {
            txtTaskID.Text = string.Empty;
            TitleTextbox.Text = string.Empty;
            DescriptionTextbox.Text = string.Empty;
            ScheduleDate.Value = DateTime.Now;
            Done.Checked = false;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            TitleTextbox.Text = string.Empty;
            DescriptionTextbox.Text = string.Empty;
            ScheduleDate.Value = DateTime.Now;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            data.Models.Task task = new data.Models.Task();
            var Title = TitleTextbox.Text;
            var Description = DescriptionTextbox.Text;
            var Schedule = ScheduleDate.Value;

            if (TitleTextbox.Text != String.Empty && DescriptionTextbox.Text != String.Empty)
            {
                task.Title = Title;
                task.Description = Description;
                task.ScheduleDate = Schedule;
                task.CreateDate = DateTime.Now;
                task.CompleteDate = null;
                task.UserId = loginUser.Id;
                task.Status = true;
                taskRepository.Add(task);

                updateGridView();

                clearText();

            }
            else
            {
                MessageBox.Show("Please fill information");
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var taskID = txtTaskID.Text;

            var task = taskRepository.GetAll().Where(p => p.Id == taskID && p.UserId == loginUser.Id).FirstOrDefault();
            if (task != null)
            {
                task.Status = false;
                taskRepository.Update(task);
            }

            updateGridView();

            clearText();

            DeleteButton.Enabled = false;
            EditButton.Enabled = false;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var taskID = txtTaskID.Text;
            var Title = TitleTextbox.Text;
            var Description = DescriptionTextbox.Text;
            var Schedule = (ScheduleDate.Value).ToLocalTime();

            var task = taskRepository.GetAll().Where(p => p.Id == taskID && p.UserId == loginUser.Id).FirstOrDefault();
            if (task != null)
            {
                if (TitleTextbox.Text != String.Empty && DescriptionTextbox.Text != String.Empty)
                {
                    if (Done.Checked)
                    {
                        task.Title = Title;
                        task.Description = Description;
                        task.ScheduleDate = Schedule;
                        task.UserId = loginUser.Id;
                        task.CompleteDate = DateTime.Now;
                        task.Status = true;
                        taskRepository.Update(task);
                    }
                    else
                    {
                        task.Title = Title;
                        task.Description = Description;
                        task.ScheduleDate = Schedule;
                        task.UserId = loginUser.Id;
                        task.Status = true;
                        taskRepository.Update(task);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill information");
                }
            }

            updateGridView();

            clearText();

            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
        }



        private void Done_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void dvgTask_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

                var row = dvgTask.Rows[e.RowIndex];
                txtTaskID.Text = row.Cells[0].Value.ToString();
                TitleTextbox.Text = row.Cells[2].Value.ToString();
                DescriptionTextbox.Text = row.Cells[3].Value.ToString();
                ScheduleDate.Text = row.Cells[5].Value.ToString();
                if (row.Cells[6].Value != null)
                {
                    Done.Checked = true;
                    Done.Enabled = false;
                    EditButton.Enabled = false;
                    DeleteButton.Enabled = true;
                } else {
                    Done.Checked = false;
                    Done.Enabled = true;
                    EditButton.Enabled = true;
                    DeleteButton.Enabled = true;
                }   
            
        }
    }
}
