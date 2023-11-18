using data;
using data.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PRN_assignment
{


    public partial class Take_Exam : Form
    {

        int iquestion;
        int totalQuestions;
        int second;
        int minute = 60;

        public TestRepository testRepository;
        public QuestionRepository questionRepository;
        public CourseRepository courseRepository;

        public new Course selected;

        public List<Question> selectedQuestions;
        public int totalPoints = 0;

        public Take_Exam(Course course)
        {
            InitializeComponent();
            selected = course;
            testRepository = new TestRepository();
            questionRepository = new QuestionRepository();
            courseRepository = new CourseRepository();

        }
        private List<Question> LoadAllQuestion(string courseId)
        {
            List<Question> questions = questionRepository.FindQuestionsByCourseId(courseId);
            return questions;
        }

        private static Random rng = new Random();

        private List<Question> SelectRandomQuestions(List<Question> questionAnswerPairs, int countToSelect)
        {
            if (questionAnswerPairs.Count < countToSelect)
            {
                MessageBox.Show("There are not enough questions available for the requested count.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

            List<Question> selectedQuestions = new List<Question>();

            // Create a copy of the original list to avoid modifying it.
            List<Question> availableQuestions = new List<Question>(questionAnswerPairs);

            for (int i = 0; i < countToSelect; i++)
            {
                int randomIndex = rng.Next(0, availableQuestions.Count);
                Question selectedQuestion = availableQuestions[randomIndex];
                availableQuestions.RemoveAt(randomIndex);

                selectedQuestions.Add(selectedQuestion);
            }

            return selectedQuestions;
        }

        private void LoadQuestions(string courseId)
        {
            List<Question> loadAllQuestion = LoadAllQuestion(courseId);
            selectedQuestions = SelectRandomQuestions(loadAllQuestion, 10);

            if (selectedQuestions.Count < 10)
            {
                MessageBox.Show("There are not enough questions available for the requested count.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Handle the error as needed
            }

            // Assuming you have a list of visible GroupBoxes named groupBoxList
            for (int i = 0; i < 10; i++)
            {
                string groupBoxName = "grpQ" + (i + 1);
                GroupBox groupBox = this.Controls.Find(groupBoxName, true).FirstOrDefault() as GroupBox;
                if (groupBox != null)
                {
                    LoadQuestionIntoGroupBox(selectedQuestions[i], groupBox);
                }
            }
        }



        private void LoadQuestionIntoGroupBox(Question question, GroupBox groupBox)
        {
            groupBox.Controls.Clear();

            // Create and configure a label for the question text
            Label questionLabel = new Label();
            questionLabel.Text = $"{question.Title}";
            questionLabel.Location = new Point(20, 20); // Adjust the position to fit your form
            questionLabel.Size = new Size(1223, 100); // Adjust the size to fit your form
            questionLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            questionLabel.BackColor = SystemColors.Control;
            questionLabel.TextAlign = ContentAlignment.MiddleCenter; // Center-align text
            questionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right; // Allow resizing
            groupBox.Controls.Add(questionLabel);

            // Create and configure radio buttons for answer options
            RadioButton[] answerOptions = new RadioButton[4];
            string[] answerTexts = { "A." + question.A, "B." + question.B, "C." + question.C, "D." + question.D };

            int verticalSpacing = 40; // Increase the vertical spacing

            for (int i = 0; i < 4; i++)
            {
                answerOptions[i] = new RadioButton();
                answerOptions[i].Text = answerTexts[i];
                answerOptions[i].Location = new Point(20, 130 + i * verticalSpacing); // Adjust the vertical spacing
                answerOptions[i].Size = new Size(300, 40); // Increase the height
                answerOptions[i].Font = new Font("Microsoft Sans Serif", 12F);
                // answerOptions[i].BackColor = SystemColors.Control;
                answerOptions[i].Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                groupBox.Controls.Add(answerOptions[i]);
            }
        }

        private void Take_Exam_Load(object sender, EventArgs e)
        {
            String courseId = selected.Id;
            iquestion = 0;
            ShowGroupBox(iquestion);
            grpHomePage.Visible = true;


            btnTimer.Visible = false;
            buttonReview.Enabled = false;
            btnBack.Enabled = false;
            btnClock.Enabled = false;
            btnExit.Enabled = false;
            btnGuide.Enabled = false;
            btnNext.Enabled = false;

            timer1.Stop();

            LoadQuestions(courseId);

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            ShowGroupBox(iquestion);

            grpGuide.Visible = true;

            btnClock.Enabled = true;
            btnTimer.Visible = false;
            timer1.Start();

        }

        private void btnOK2_Click(object sender, EventArgs e)
        {

            btnNext.Enabled = true;
            timer1.Start();
            btnGuide.Enabled = true;
            btnNext.Enabled = true;
            btnBack.Enabled = true;
            btnClock.Enabled = true;
            btnExit.Enabled = true;
            buttonReview.Enabled = true;

            iquestion = 1;
            ShowGroupBox(iquestion);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var resutl = MessageBox.Show("Are you sure to exist?", "Closing Program",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resutl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            TestGuide guide = new TestGuide();
            guide.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (second > 0)
            {
                second--;
            }
            else if (minute > 0)
            {
                second = 59;
                minute--;
            }

            lblTimer.Text = "Time Remaining: " + $"{minute:D2}:{second:D2}";

            if (minute == 0 && second == 0)
            {
                timer1.Stop();
            }
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            btnTimer.Visible = true;
            lblTimer.Visible = true;
            lblTimerCover.Visible = false;
            btnClock.Visible = false;
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            btnClock.Visible = true;
            lblTimer.Visible = false;
            lblTimerCover.Visible = true;
            btnTimer.Visible = false;
        }

        private void buttonReview_Click(object sender, EventArgs e)
        {
            iquestion = 1;
            ShowGroupBox(iquestion);
            btnNext.Enabled = true;
            btnNext.Text = "2";
            btnBack.Enabled = false;
            btnBack.Text = "Back";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int maxQuestion = 10;

            if (iquestion < maxQuestion)
            {
                iquestion++;
                ShowGroupBox(iquestion);

                btnBack.Text = (iquestion == 1) ? "Back" : (iquestion - 1).ToString();
                btnNext.Text = (iquestion == maxQuestion) ? "Submit" : (iquestion + 1).ToString();

                btnBack.Enabled = true;

                if (iquestion == maxQuestion)
                {
                    btnNext.Enabled = true;
                    btnNext.Text = "submit";
                }
            }
            else if (iquestion == maxQuestion)
            {
                iquestion++;
                ShowGroupBox(11);
                btnNext.Enabled = false;
            }
            else if (iquestion == 11)
            {
                ShowGroupBox(11);
                btnNext.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int maxQuestion = 10;

            if (iquestion > 1)
            {
                iquestion--;
                ShowGroupBox(iquestion);
                btnNext.Text = (iquestion == maxQuestion) ? "Submit" : iquestion.ToString();
                btnBack.Text = (iquestion == 1) ? "Back" : (iquestion - 1).ToString();
                if (iquestion == 1)
                {
                    btnBack.Enabled = false;
                    btnNext.Text = "2";
                }

                btnNext.Enabled = true;
            }
            else
            {
                // iquestion is already at 1, so we can't go back further
                btnBack.Enabled = false;
                btnBack.Text = "Back";
            }
        }

        private void ShowGroupBox(int questionNumber)
        {
            grpHomePage.Visible = false;
            grpGuide.Visible = false;

            grpQ1.Visible = false;
            grpQ2.Visible = false;
            grpQ3.Visible = false;
            grpQ4.Visible = false;
            grpQ5.Visible = false;
            grpQ6.Visible = false;
            grpQ7.Visible = false;
            grpQ8.Visible = false;
            grpQ9.Visible = false;
            grpQ10.Visible = false;


            grpResult.Visible = false;
            grpEndExam.Visible = false;

            switch (questionNumber)
            {
                case 1:
                    grpQ1.Visible = true;
                    btnBack.Enabled = false;

                    break;
                case 2:
                    grpQ2.Visible = true;
                    break;
                case 3:
                    grpQ3.Visible = true;
                    break;
                case 4:
                    grpQ4.Visible = true;
                    break;
                case 5:
                    grpQ5.Visible = true;
                    break;
                case 6:
                    grpQ6.Visible = true;
                    break;
                case 7:
                    grpQ7.Visible = true;
                    break;
                case 8:
                    grpQ8.Visible = true;
                    break;
                case 9:
                    grpQ9.Visible = true;
                    break;
                case 10:
                    grpQ10.Visible = true;
                    break;
                case 11:
                    grpEndExam.Visible = true;
                    break;
                case 12:
                    grpResult.Visible = true;

                    btnBack.Enabled = false;
                    btnNext.Enabled = false;
                    btnTimer.Enabled = false;
                    btnReview.Enabled = false;
                    buttonReview.Enabled = false;
                    btnClock.Enabled = false;
                    btnGuide.Enabled = false;

                    break;
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            iquestion = 1;
            ShowGroupBox(iquestion);
            btnNext.Enabled = true;
            btnNext.Text = "2";
            btnBack.Enabled = false;
            btnBack.Text = "Back";
        }

        private void btnContinuos_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to finish your exam?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Call the CheckAnswers method with the list of selected questions and answers
                CheckAnswers();

                Close(); // Close the form or perform any other necessary actions
            }
        }


        private void CheckAnswers()
        {
            for (int i = 0; i < selectedQuestions.Count; i++)
            {
                CheckAnswer(selectedQuestions[i], i);
            }

            MessageBox.Show("Total Points: " + totalPoints);
        }

        private void CheckAnswer(Question selectedQuestion, int count)
        {
            // Find the GroupBox associated with the selected question
            string groupBoxName = "grpQ" + (count + 1);
            GroupBox groupBox = this.Controls.Find(groupBoxName, true).FirstOrDefault() as GroupBox;

            if (groupBox != null)
            {
                RadioButton selectedRadioButton = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                if (selectedRadioButton != null)
                {
                    string[] selectedAnswerParts = selectedRadioButton.Text.Split('.');
                    if (selectedAnswerParts.Length == 2)
                    {
                        string selectedAnswer = selectedAnswerParts[0].Trim(); // Extract the selected answer part
                        string correctAnswer = selectedQuestion.CorrectAnswer;

                        if (selectedAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
                        {
                            // The answer is correct
                            totalPoints++;
                        }
                    }
                }
                else
                {
                    // Radio button not checked, you can handle this as needed (e.g., show a message).
                    MessageBox.Show("Please select an answer for question " + count + 1, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}