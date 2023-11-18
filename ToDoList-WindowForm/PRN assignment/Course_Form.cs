using data.Models;
using data;
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
    public partial class Course_Form : Form
    {
        List<UserCourse> courseList;
        UserRepository _userRepository = new UserRepository();
        CourseRepository _courseRepository = new CourseRepository();
        databasePrnContext _dbprnContext = new databasePrnContext();
        private User loginUser;

        public Course_Form(User loginUName)
        {
            InitializeComponent();
            loginUser = loginUName;

            var courseList = _dbprnContext.UserCourses
                .Where(uc => (uc.Course.Status==true))
                .Select(uc => new
                {
                    CourseId = uc.Course.Id,
                    CourseName = uc.Course.Name
                }).ToList();
            dgvUserCourses.DataSource = new BindingSource { DataSource = courseList };
            btnQuestion.Enabled = false;
        }

        public void clearText()
        {
            txtCourseId.Text = string.Empty;
            txtCourseName.Text = string.Empty;
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            var searchList = _dbprnContext.UserCourses
                            .Where(uc => (uc.UserId == loginUser.Id || uc.UserId == "1") && (uc.Course.Name.Contains(search) || uc.CourseId.Contains(search)) && uc.Status == true)
                            .Select(uc => new
                            {
                                CourseId = uc.Course.Id,
                                CourseName = uc.Course.Name
                            })
                            .ToList();

            dgvUserCourses.DataSource = new BindingSource { DataSource = searchList };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCourseId.Text == string.Empty)
            {
                MessageBox.Show("CourseId is empty", "Thong bao", MessageBoxButtons.OK);
                return;
            }


            if (txtCourseName.Text == string.Empty)
            {
                MessageBox.Show("CourseName is empty", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            var inputCourseId = txtCourseId.Text;
            var inputCourseName = txtCourseName.Text;

            try
            {
                Course course = new Course()
                {
                    Id = inputCourseId,
                    Name = inputCourseName,
                    Status = true
                };
                if (_courseRepository.GetAll().Any(c => c.Id == course.Id))
                {
                    MessageBox.Show("CourseId is EXISTED", "Thong bao", MessageBoxButtons.OK);
                }
                else
                {
                    _courseRepository.Add(course);
                    UserCourse userCourse = new UserCourse
                    {
                        UserId = loginUser.Id,
                        CourseId = course.Id,
                        Status = true
                    };
                    _dbprnContext.UserCourses.Add(userCourse);
                    _dbprnContext.SaveChanges();
                    RefreshData();
                    MessageBox.Show("Add successfully", "Thong bao", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Random ERROR", "Thong bao", MessageBoxButtons.OK);
            }

            clearText();
        }

        public void RefreshData()
        {
            var courseList = _dbprnContext.UserCourses
                .Where(uc => (uc.UserId == loginUser.Id || uc.UserId == "1") && uc.Course.Status == true)
                .Select(uc => new
                {
                    CourseId = uc.Course.Id,
                    CourseName = uc.Course.Name
                }).ToList();
            dgvUserCourses.DataSource = new BindingSource { DataSource = courseList };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshData();
            txtSearch.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string deleteID = txtCourseId.Text;

            try
            {
                if (string.IsNullOrEmpty(deleteID))
                {
                    MessageBox.Show("Please Enter CourseId to delete", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    var courseToDelete = _courseRepository.GetAll().FirstOrDefault(c => c.Id == deleteID);

                    if (courseToDelete != null)
                    {
                        if (courseToDelete.Status == false)
                        {
                            MessageBox.Show("Course has already been deleted", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (MessageBox.Show("Delete course?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                courseToDelete.Status = false;
                                _courseRepository.Update(courseToDelete);

                                if (_dbprnContext.UserCourses.Any(uc => uc.Course.Id == courseToDelete.Id))
                                {
                                    var userCoursesToUpdate = _dbprnContext.UserCourses.Where(uc => uc.Course.Id == courseToDelete.Id).ToList();

                                    foreach (var userCourse in userCoursesToUpdate)
                                    {
                                        userCourse.Status = false;
                                    }
                                    _dbprnContext.SaveChanges();
                                }

                                RefreshData();
                                MessageBox.Show("Course " + courseToDelete.Name + " deleted successfully.", "Success", MessageBoxButtons.OK);
                                txtCourseId.Text = "";
                                txtCourseName.Text = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Course with the specified ID does not exist.", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Random ERROR", "Thong bao", MessageBoxButtons.OK);
            }

            clearText();
            btnQuestion.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var updatedtCourseId = txtCourseId.Text;
            var updatedCourseName = txtCourseName.Text;

            try
            {
                var existingCourse = _courseRepository.GetAll().FirstOrDefault(c => c.Id == updatedtCourseId);

                if (existingCourse != null)
                {
                    existingCourse.Name = updatedCourseName;
                    _courseRepository.Update(existingCourse);
                    RefreshData();
                    MessageBox.Show("Course updated successfully.", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Course with ID " + updatedtCourseId + " does not exist", "Thong bao", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Random ERROR", "Thong bao", MessageBoxButtons.OK);
            }

            clearText();
            btnQuestion.Enabled = false;

        }
        String courseId;
        private void dgvUserCourses_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvUserCourses.ReadOnly = true;
            var index = e.RowIndex;
            txtCourseId.Text = dgvUserCourses.Rows[index].Cells[0].Value.ToString();
            txtCourseName.Text = dgvUserCourses.Rows[index].Cells[1].Value.ToString();
            courseId = txtCourseId.Text;
            btnQuestion.Enabled = true;
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            var existingCourse = _courseRepository.GetAll().FirstOrDefault(c => c.Id == courseId);
            Take_Exam exam = new Take_Exam(existingCourse);
            this.Hide();
            exam.Show();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            try
            {

                var existingCourse = _courseRepository.GetAll().FirstOrDefault(c => c.Id == courseId);
                Question_Form question = new Question_Form(existingCourse);
                this.Hide();
                question.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Random ERROR", "Thong bao", MessageBoxButtons.OK);
            }
        }
    }
}
