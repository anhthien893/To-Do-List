namespace PRN_assignment
{
    partial class Course_Form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCourseId = new TextBox();
            txtCourseName = new TextBox();
            txtSearch = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dgvUserCourses = new DataGridView();
            pictureBox1 = new PictureBox();
            btnQuestion = new Button();
            btntest = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUserCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 116);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Course Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 163);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 1;
            label2.Text = "Course Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 266);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 2;
            label3.Text = "Search by Name";
            // 
            // txtCourseId
            // 
            txtCourseId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCourseId.Location = new Point(164, 113);
            txtCourseId.Margin = new Padding(3, 2, 3, 2);
            txtCourseId.Name = "txtCourseId";
            txtCourseId.Size = new Size(257, 29);
            txtCourseId.TabIndex = 3;
            // 
            // txtCourseName
            // 
            txtCourseName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCourseName.Location = new Point(164, 164);
            txtCourseName.Margin = new Padding(3, 2, 3, 2);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(257, 29);
            txtCourseName.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(164, 266);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(257, 29);
            txtSearch.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(13, 203);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 31);
            button1.TabIndex = 6;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Pink;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(179, 203);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 31);
            button2.TabIndex = 7;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Pink;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(338, 203);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 31);
            button3.TabIndex = 8;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Pink;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(338, 304);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 31);
            button4.TabIndex = 9;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Pink;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(13, 304);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 31);
            button5.TabIndex = 10;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dgvUserCourses
            // 
            dgvUserCourses.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvUserCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserCourses.Location = new Point(480, 22);
            dgvUserCourses.Margin = new Padding(3, 2, 3, 2);
            dgvUserCourses.Name = "dgvUserCourses";
            dgvUserCourses.RowHeadersWidth = 51;
            dgvUserCourses.RowTemplate.Height = 29;
            dgvUserCourses.Size = new Size(263, 311);
            dgvUserCourses.TabIndex = 11;
            dgvUserCourses.CellMouseClick += dgvUserCourses_CellMouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(164, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnQuestion
            // 
            btnQuestion.Location = new Point(14, 16);
            btnQuestion.Name = "btnQuestion";
            btnQuestion.Size = new Size(75, 23);
            btnQuestion.TabIndex = 13;
            btnQuestion.Text = "Question";
            btnQuestion.UseVisualStyleBackColor = true;
            btnQuestion.Click += btnQuestion_Click;
            // 
            // btntest
            // 
            btntest.Location = new Point(13, 56);
            btntest.Name = "btntest";
            btntest.Size = new Size(75, 23);
            btntest.TabIndex = 14;
            btntest.Text = "Test";
            btntest.UseVisualStyleBackColor = true;
            btntest.Click += btntest_Click;
            // 
            // Course_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(754, 349);
            Controls.Add(btntest);
            Controls.Add(btnQuestion);
            Controls.Add(pictureBox1);
            Controls.Add(dgvUserCourses);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSearch);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Course_Form";
            Text = "Course";
            ((System.ComponentModel.ISupportInitialize)dgvUserCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCourseId;
        private TextBox txtCourseName;
        private TextBox txtSearch;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dgvUserCourses;
        private PictureBox pictureBox1;
        private Button btnQuestion;
        private Button btntest;
    }
}