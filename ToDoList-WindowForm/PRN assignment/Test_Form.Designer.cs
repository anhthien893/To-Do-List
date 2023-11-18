namespace PRN_assignment
{
    partial class Test_Form
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpExamNapBar = new GroupBox();
            btnViewTest = new Button();
            btnUpdateTest = new Button();
            btnDeleteTest = new Button();
            btnCreateTest = new Button();
            grpViewTest = new GroupBox();
            textBox3 = new TextBox();
            lbCorrectAnswer = new Label();
            txtStatus = new TextBox();
            lbStatus = new Label();
            txtCreateDate = new TextBox();
            lbCreateDate = new Label();
            txtTestId = new TextBox();
            lbTestId = new Label();
            dgvTestView = new DataGridView();
            grpExamNapBar.SuspendLayout();
            grpViewTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTestView).BeginInit();
            SuspendLayout();
            // 
            // grpExamNapBar
            // 
            grpExamNapBar.BackColor = SystemColors.ActiveCaption;
            grpExamNapBar.Controls.Add(btnViewTest);
            grpExamNapBar.Controls.Add(btnUpdateTest);
            grpExamNapBar.Controls.Add(btnDeleteTest);
            grpExamNapBar.Controls.Add(btnCreateTest);
            grpExamNapBar.ForeColor = SystemColors.ControlLightLight;
            grpExamNapBar.Location = new Point(0, -2);
            grpExamNapBar.Margin = new Padding(3, 2, 3, 2);
            grpExamNapBar.Name = "grpExamNapBar";
            grpExamNapBar.Padding = new Padding(3, 2, 3, 2);
            grpExamNapBar.Size = new Size(947, 62);
            grpExamNapBar.TabIndex = 0;
            grpExamNapBar.TabStop = false;
            // 
            // btnViewTest
            // 
            btnViewTest.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewTest.ForeColor = SystemColors.ActiveCaptionText;
            btnViewTest.Location = new Point(753, 20);
            btnViewTest.Margin = new Padding(3, 2, 3, 2);
            btnViewTest.Name = "btnViewTest";
            btnViewTest.Size = new Size(152, 31);
            btnViewTest.TabIndex = 4;
            btnViewTest.Text = "View Test";
            btnViewTest.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTest
            // 
            btnUpdateTest.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateTest.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdateTest.Location = new Point(527, 20);
            btnUpdateTest.Margin = new Padding(3, 2, 3, 2);
            btnUpdateTest.Name = "btnUpdateTest";
            btnUpdateTest.Size = new Size(152, 31);
            btnUpdateTest.TabIndex = 3;
            btnUpdateTest.Text = "Update Test";
            btnUpdateTest.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTest
            // 
            btnDeleteTest.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteTest.ForeColor = SystemColors.ActiveCaptionText;
            btnDeleteTest.Location = new Point(276, 20);
            btnDeleteTest.Margin = new Padding(3, 2, 3, 2);
            btnDeleteTest.Name = "btnDeleteTest";
            btnDeleteTest.Size = new Size(152, 31);
            btnDeleteTest.TabIndex = 2;
            btnDeleteTest.Text = "Delete Test";
            btnDeleteTest.UseVisualStyleBackColor = true;
            // 
            // btnCreateTest
            // 
            btnCreateTest.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateTest.ForeColor = SystemColors.ActiveCaptionText;
            btnCreateTest.Location = new Point(40, 20);
            btnCreateTest.Margin = new Padding(3, 2, 3, 2);
            btnCreateTest.Name = "btnCreateTest";
            btnCreateTest.Size = new Size(152, 31);
            btnCreateTest.TabIndex = 1;
            btnCreateTest.Text = "Create Test";
            btnCreateTest.UseVisualStyleBackColor = true;
            // 
            // grpViewTest
            // 
            grpViewTest.BackColor = SystemColors.Menu;
            grpViewTest.Controls.Add(textBox3);
            grpViewTest.Controls.Add(lbCorrectAnswer);
            grpViewTest.Controls.Add(txtStatus);
            grpViewTest.Controls.Add(lbStatus);
            grpViewTest.Controls.Add(txtCreateDate);
            grpViewTest.Controls.Add(lbCreateDate);
            grpViewTest.Controls.Add(txtTestId);
            grpViewTest.Controls.Add(lbTestId);
            grpViewTest.Controls.Add(dgvTestView);
            grpViewTest.Location = new Point(0, 65);
            grpViewTest.Margin = new Padding(3, 2, 3, 2);
            grpViewTest.Name = "grpViewTest";
            grpViewTest.Padding = new Padding(3, 2, 3, 2);
            grpViewTest.Size = new Size(947, 440);
            grpViewTest.TabIndex = 1;
            grpViewTest.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(237, 224);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 23);
            textBox3.TabIndex = 8;
            // 
            // lbCorrectAnswer
            // 
            lbCorrectAnswer.AutoSize = true;
            lbCorrectAnswer.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbCorrectAnswer.Location = new Point(18, 220);
            lbCorrectAnswer.Name = "lbCorrectAnswer";
            lbCorrectAnswer.Size = new Size(183, 26);
            lbCorrectAnswer.TabIndex = 7;
            lbCorrectAnswer.Text = "Correct Answer:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(237, 182);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(216, 23);
            txtStatus.TabIndex = 6;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbStatus.Location = new Point(18, 178);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(94, 26);
            lbStatus.TabIndex = 5;
            lbStatus.Text = "Status: ";
            // 
            // txtCreateDate
            // 
            txtCreateDate.Location = new Point(237, 142);
            txtCreateDate.Margin = new Padding(3, 2, 3, 2);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.Size = new Size(216, 23);
            txtCreateDate.TabIndex = 4;
            // 
            // lbCreateDate
            // 
            lbCreateDate.AutoSize = true;
            lbCreateDate.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateDate.Location = new Point(18, 139);
            lbCreateDate.Name = "lbCreateDate";
            lbCreateDate.Size = new Size(147, 26);
            lbCreateDate.TabIndex = 3;
            lbCreateDate.Text = "Create Date:";
            // 
            // txtTestId
            // 
            txtTestId.Location = new Point(237, 106);
            txtTestId.Margin = new Padding(3, 2, 3, 2);
            txtTestId.Name = "txtTestId";
            txtTestId.Size = new Size(216, 23);
            txtTestId.TabIndex = 2;
            // 
            // lbTestId
            // 
            lbTestId.AutoSize = true;
            lbTestId.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTestId.Location = new Point(18, 102);
            lbTestId.Name = "lbTestId";
            lbTestId.Size = new Size(91, 26);
            lbTestId.TabIndex = 1;
            lbTestId.Text = "Test Id:";
            // 
            // dgvTestView
            // 
            dgvTestView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestView.Location = new Point(479, 20);
            dgvTestView.Margin = new Padding(3, 2, 3, 2);
            dgvTestView.Name = "dgvTestView";
            dgvTestView.RowHeadersWidth = 51;
            dgvTestView.RowTemplate.Height = 29;
            dgvTestView.Size = new Size(453, 362);
            dgvTestView.TabIndex = 0;
            // 
            // Test_Management_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 505);
            Controls.Add(grpViewTest);
            Controls.Add(grpExamNapBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Test_Management_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test_Manager";
            grpExamNapBar.ResumeLayout(false);
            grpViewTest.ResumeLayout(false);
            grpViewTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTestView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpExamNapBar;
        private Button btnCreateTest;
        private Button btnUpdateTest;
        private Button btnDeleteTest;
        private Button btnViewTest;
        private GroupBox grpViewTest;
        private Label lbTestId;
        private DataGridView dgvTestView;
        private TextBox textBox3;
        private Label lbCorrectAnswer;
        private TextBox txtStatus;
        private Label lbStatus;
        private TextBox txtCreateDate;
        private Label lbCreateDate;
        private TextBox txtTestId;

    }
}