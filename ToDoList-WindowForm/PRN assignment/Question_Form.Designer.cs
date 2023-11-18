namespace PRN_assignment
{
    partial class Question_Form
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbQuestionID = new Label();
            lbCourseID = new Label();
            lbAnswerA = new Label();
            lbAnswerB = new Label();
            lbAnswerC = new Label();
            lbAnswerD = new Label();
            lbTitle = new Label();
            label1 = new Label();
            txtQuestionID = new TextBox();
            txtCourseID = new TextBox();
            txtTitle = new TextBox();
            txtAnswerA = new TextBox();
            txtAnswerB = new TextBox();
            txtAnswerC = new TextBox();
            txtAnswerD = new TextBox();
            cbCorrectAnswer = new ComboBox();
            dvgQuestion = new DataGridView();
            btnCreateQuestion = new Button();
            btnSearchQuestion = new Button();
            btnUpdateQuestion = new Button();
            btnDeleteQuestion = new Button();
            txtSearchTitle = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgQuestion).BeginInit();
            SuspendLayout();
            // 
            // lbQuestionID
            // 
            lbQuestionID.AutoSize = true;
            lbQuestionID.Location = new Point(23, 9);
            lbQuestionID.Name = "lbQuestionID";
            lbQuestionID.Size = new Size(87, 20);
            lbQuestionID.TabIndex = 0;
            lbQuestionID.Text = "Question ID";
            // 
            // lbCourseID
            // 
            lbCourseID.AutoSize = true;
            lbCourseID.Location = new Point(23, 52);
            lbCourseID.Name = "lbCourseID";
            lbCourseID.Size = new Size(73, 20);
            lbCourseID.TabIndex = 1;
            lbCourseID.Text = "Course ID";
            // 
            // lbAnswerA
            // 
            lbAnswerA.AutoSize = true;
            lbAnswerA.Location = new Point(412, 13);
            lbAnswerA.Name = "lbAnswerA";
            lbAnswerA.Size = new Size(71, 20);
            lbAnswerA.TabIndex = 2;
            lbAnswerA.Text = "Answer A";
            // 
            // lbAnswerB
            // 
            lbAnswerB.AutoSize = true;
            lbAnswerB.Location = new Point(412, 62);
            lbAnswerB.Name = "lbAnswerB";
            lbAnswerB.Size = new Size(70, 20);
            lbAnswerB.TabIndex = 3;
            lbAnswerB.Text = "Answer B";
            // 
            // lbAnswerC
            // 
            lbAnswerC.AutoSize = true;
            lbAnswerC.Location = new Point(413, 112);
            lbAnswerC.Name = "lbAnswerC";
            lbAnswerC.Size = new Size(70, 20);
            lbAnswerC.TabIndex = 4;
            lbAnswerC.Text = "Answer C";
            // 
            // lbAnswerD
            // 
            lbAnswerD.AutoSize = true;
            lbAnswerD.Location = new Point(413, 158);
            lbAnswerD.Name = "lbAnswerD";
            lbAnswerD.Size = new Size(72, 20);
            lbAnswerD.TabIndex = 5;
            lbAnswerD.Text = "Answer D";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(23, 96);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(38, 20);
            lbTitle.TabIndex = 6;
            lbTitle.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 136);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 7;
            label1.Text = "Correct Answer";
            // 
            // txtQuestionID
            // 
            txtQuestionID.Location = new Point(116, 6);
            txtQuestionID.Name = "txtQuestionID";
            txtQuestionID.Size = new Size(146, 27);
            txtQuestionID.TabIndex = 8;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(114, 52);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(146, 27);
            txtCourseID.TabIndex = 9;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(114, 93);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(243, 27);
            txtTitle.TabIndex = 10;
            // 
            // txtAnswerA
            // 
            txtAnswerA.Location = new Point(527, 13);
            txtAnswerA.Name = "txtAnswerA";
            txtAnswerA.Size = new Size(249, 27);
            txtAnswerA.TabIndex = 11;
            // 
            // txtAnswerB
            // 
            txtAnswerB.Location = new Point(527, 62);
            txtAnswerB.Name = "txtAnswerB";
            txtAnswerB.Size = new Size(249, 27);
            txtAnswerB.TabIndex = 12;
            // 
            // txtAnswerC
            // 
            txtAnswerC.Location = new Point(527, 109);
            txtAnswerC.Name = "txtAnswerC";
            txtAnswerC.Size = new Size(249, 27);
            txtAnswerC.TabIndex = 13;
            // 
            // txtAnswerD
            // 
            txtAnswerD.Location = new Point(527, 158);
            txtAnswerD.Name = "txtAnswerD";
            txtAnswerD.Size = new Size(249, 27);
            txtAnswerD.TabIndex = 14;
            // 
            // cbCorrectAnswer
            // 
            cbCorrectAnswer.FormattingEnabled = true;
            cbCorrectAnswer.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cbCorrectAnswer.Location = new Point(138, 133);
            cbCorrectAnswer.Name = "cbCorrectAnswer";
            cbCorrectAnswer.Size = new Size(98, 28);
            cbCorrectAnswer.TabIndex = 15;
            // 
            // dvgQuestion
            // 
            dvgQuestion.AllowUserToAddRows = false;
            dvgQuestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgQuestion.Location = new Point(2, 276);
            dvgQuestion.Name = "dvgQuestion";
            dvgQuestion.RowHeadersWidth = 51;
            dvgQuestion.RowTemplate.Height = 29;
            dvgQuestion.Size = new Size(1090, 246);
            dvgQuestion.TabIndex = 16;
            dvgQuestion.CellDoubleClick += dvgQuestion_CellDoubleClick;
            // 
            // btnCreateQuestion
            // 
            btnCreateQuestion.Location = new Point(825, 13);
            btnCreateQuestion.Name = "btnCreateQuestion";
            btnCreateQuestion.Size = new Size(98, 37);
            btnCreateQuestion.TabIndex = 17;
            btnCreateQuestion.Text = "Create";
            btnCreateQuestion.UseVisualStyleBackColor = true;
            btnCreateQuestion.Click += btnCreateQuestion_Click;
            // 
            // btnSearchQuestion
            // 
            btnSearchQuestion.Location = new Point(292, 219);
            btnSearchQuestion.Name = "btnSearchQuestion";
            btnSearchQuestion.Size = new Size(98, 37);
            btnSearchQuestion.TabIndex = 18;
            btnSearchQuestion.Text = "Search";
            btnSearchQuestion.UseVisualStyleBackColor = true;
            btnSearchQuestion.Click += btnSearchQuestion_Click;
            // 
            // btnUpdateQuestion
            // 
            btnUpdateQuestion.Location = new Point(966, 13);
            btnUpdateQuestion.Name = "btnUpdateQuestion";
            btnUpdateQuestion.Size = new Size(98, 37);
            btnUpdateQuestion.TabIndex = 19;
            btnUpdateQuestion.Text = "Update";
            btnUpdateQuestion.UseVisualStyleBackColor = true;
            btnUpdateQuestion.Click += btnUpdateQuestion_Click;
            // 
            // btnDeleteQuestion
            // 
            btnDeleteQuestion.Location = new Point(966, 62);
            btnDeleteQuestion.Name = "btnDeleteQuestion";
            btnDeleteQuestion.Size = new Size(98, 37);
            btnDeleteQuestion.TabIndex = 20;
            btnDeleteQuestion.Text = "Delete";
            btnDeleteQuestion.UseVisualStyleBackColor = true;
            btnDeleteQuestion.Click += btnDeleteQuestion_Click;
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(23, 224);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(249, 27);
            txtSearchTitle.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 192);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 22;
            label2.Text = "Search Title Question";
            // 
            // Question_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1095, 524);
            Controls.Add(label2);
            Controls.Add(txtSearchTitle);
            Controls.Add(btnDeleteQuestion);
            Controls.Add(btnUpdateQuestion);
            Controls.Add(btnSearchQuestion);
            Controls.Add(btnCreateQuestion);
            Controls.Add(dvgQuestion);
            Controls.Add(cbCorrectAnswer);
            Controls.Add(txtAnswerD);
            Controls.Add(txtAnswerC);
            Controls.Add(txtAnswerB);
            Controls.Add(txtAnswerA);
            Controls.Add(txtTitle);
            Controls.Add(txtCourseID);
            Controls.Add(txtQuestionID);
            Controls.Add(label1);
            Controls.Add(lbTitle);
            Controls.Add(lbAnswerD);
            Controls.Add(lbAnswerC);
            Controls.Add(lbAnswerB);
            Controls.Add(lbAnswerA);
            Controls.Add(lbCourseID);
            Controls.Add(lbQuestionID);
            Name = "Question_Form";
            Text = "Question Form";
            ((System.ComponentModel.ISupportInitialize)dvgQuestion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbQuestionID;
        private Label lbCourseID;
        private Label lbAnswerA;
        private Label lbAnswerB;
        private Label lbAnswerC;
        private Label lbAnswerD;
        private Label lbTitle;
        private Label label1;
        private TextBox txtQuestionID;
        private TextBox txtCourseID;
        private TextBox txtTitle;
        private TextBox txtAnswerA;
        private TextBox txtAnswerB;
        private TextBox txtAnswerC;
        private TextBox txtAnswerD;
        private ComboBox cbCorrectAnswer;
        private DataGridView dvgQuestion;
        private Button btnCreateQuestion;
        private Button btnSearchQuestion;
        private Button btnUpdateQuestion;
        private Button btnDeleteQuestion;
        private TextBox txtSearchTitle;
        private Label label2;
    }
}