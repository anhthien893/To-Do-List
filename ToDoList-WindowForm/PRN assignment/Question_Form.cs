using data;
using data.Models;
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
    public partial class Question_Form : Form
    {
        public List<Question> questionListSearch = new List<Question>();

        public QuestionRepository questionRepository;

        private Course course;
        public Question_Form(Course CourseEntity)
        {
            InitializeComponent();
            course = CourseEntity;

            questionRepository = new QuestionRepository();
            updateGridView();

            if (course != null)
            {
                txtCourseID.Text = course.Id;
                txtCourseID.Enabled = false;
                txtQuestionID.Enabled = false;
                btnUpdateQuestion.Enabled = false;
                btnDeleteQuestion.Enabled = false;
            }
            else Close();
        }


        public void updateGridView()
        {
            try
            {
                questionRepository = new QuestionRepository();
                List<Question> listQuestion = questionRepository.GetAll().Where(p => p.CourseId == course.Id && p.Status == true).ToList();
                BindingSource source = new BindingSource();
                source.DataSource = listQuestion;
                dvgQuestion.DataSource = source;
                dvgQuestion.Columns["Status"].Visible = false;
                dvgQuestion.Columns["QuestionTests"].Visible = false;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You should choose your course first!");
                Close();

            }
        }

        public void clearText()
        {
            txtTitle.Text = "";
            txtQuestionID.Text = "";
            txtAnswerA.Text = "";
            txtAnswerB.Text = "";
            txtAnswerC.Text = "";
            txtAnswerD.Text = "";
        }

        public bool checkValidation()
        {

            if (cbCorrectAnswer.SelectedItem == null)
            {
                MessageBox.Show("Please select correct answer");
                return false;
            }

            if (txtTitle.Text == "")
            {
                MessageBox.Show("Title must not be empty");
                return false;
            }

            if (txtAnswerA.Text == "")
            {
                MessageBox.Show("Answer A must not be empty");
                return false;
            }

            if (txtAnswerB.Text == "")
            {
                MessageBox.Show("Answer B must not be empty");
                return false;
            }

            if (txtAnswerC.Text == "")
            {
                MessageBox.Show("Answer C must not be empty");
                return false;
            }

            if (txtAnswerD.Text == "")
            {
                MessageBox.Show("Answer D must not be empty");
                return false;
            }

            return true;
        }

        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            if (!checkValidation()) return;

            var courseID = txtCourseID.Text;
            var title = txtTitle.Text;
            var answerA = txtAnswerA.Text;
            var answerB = txtAnswerB.Text;
            var answerC = txtAnswerC.Text;
            var answerD = txtAnswerD.Text;
            var correctAnswer = cbCorrectAnswer.SelectedItem as String;

            var question = new Question();

            question.CourseId = courseID;
            question.Title = title;
            question.CorrectAnswer = correctAnswer;
            question.A = answerA;
            question.B = answerB;
            question.C = answerC;
            question.D = answerD;
            question.Status = true;

            questionRepository.Add(question);

            updateGridView();

            this.clearText();
        }

        private void dvgQuestion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dvgQuestion.Rows[e.RowIndex];
            txtQuestionID.Text = row.Cells[0].Value.ToString();
            txtCourseID.Text = row.Cells[1].Value.ToString();
            txtTitle.Text = row.Cells[2].Value.ToString();
            txtAnswerA.Text = row.Cells[3].Value.ToString();
            txtAnswerB.Text = row.Cells[4].Value.ToString();
            txtAnswerC.Text = row.Cells[5].Value.ToString();
            txtAnswerD.Text = row.Cells[6].Value.ToString();
            cbCorrectAnswer.Text = row.Cells[7].Value.ToString();

            btnCreateQuestion.Enabled = false;
            btnUpdateQuestion.Enabled = true;
            btnDeleteQuestion.Enabled = true;
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            if (!checkValidation()) return;

            var questionID = txtQuestionID.Text;
            var courseID = txtCourseID.Text;
            var title = txtTitle.Text;
            var answerA = txtAnswerA.Text;
            var answerB = txtAnswerB.Text;
            var answerC = txtAnswerC.Text;
            var answerD = txtAnswerD.Text;
            var correctAnswer = cbCorrectAnswer.SelectedItem as String;

            var CurQuestion = questionRepository.GetAll().Where(p => p.QuestionId == questionID && p.Status == true).FirstOrDefault();

            if (CurQuestion != null)
            {
                CurQuestion.Title = title;
                CurQuestion.A = answerA;
                CurQuestion.B = answerB;
                CurQuestion.C = answerC;
                CurQuestion.D = answerD;
                CurQuestion.CorrectAnswer = correctAnswer;
                questionRepository.Update(CurQuestion);
            }

            updateGridView();

            btnCreateQuestion.Enabled = true;
            btnUpdateQuestion.Enabled = false;
            btnDeleteQuestion.Enabled = false;

            this.clearText();
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {

            var questionID = txtQuestionID.Text;
            var CurQuestion = questionRepository.GetAll().Where(p => p.QuestionId == questionID && p.Status == true).FirstOrDefault();
            if (CurQuestion != null)
            {
                CurQuestion.Status = false;
                questionRepository.Update(CurQuestion);
            }

            updateGridView();

            btnCreateQuestion.Enabled = true;
            btnUpdateQuestion.Enabled = false;
            btnDeleteQuestion.Enabled = false;
        }

        private void btnSearchQuestion_Click(object sender, EventArgs e)
        {
            string title = txtSearchTitle.Text.ToString();

            questionListSearch = new();

            var listQuestion = questionRepository.GetAll().Where(p => p.CourseId == course.Id).ToList();
            
            for (int i = 0; i < listQuestion.Count; i++)
            {
                string j = listQuestion[i].Title;

                if (listQuestion[i].Title.Contains(title))
                {
                    questionListSearch.Add(listQuestion[i]);
                }

            }

            if (questionListSearch.Count != 0)
            {
                BindingSource source = new BindingSource();
                source.DataSource = questionListSearch;
                dvgQuestion.DataSource = source;

            }
            else
            {
                BindingSource source = new BindingSource();
                source.DataSource = null;
                dvgQuestion.DataSource = source;
                MessageBox.Show("This title of question is not existed");
            }
        }
    }
}
