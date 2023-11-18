namespace PRN_assignment
{
    partial class Task_Form
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
            TitleTextbox = new TextBox();
            DescriptionTextbox = new TextBox();
            label4 = new Label();
            ScheduleDate = new DateTimePicker();
            SaveButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            NewButton = new Button();
            Done = new CheckBox();
            CompleteDate = new DateTimePicker();
            txtTaskID = new TextBox();
            dvgTask = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgTask).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(970, 84);
            label1.TabIndex = 0;
            label1.Text = "TO DO LIST";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 83);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 135);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // TitleTextbox
            // 
            TitleTextbox.Location = new Point(11, 105);
            TitleTextbox.Name = "TitleTextbox";
            TitleTextbox.Size = new Size(970, 27);
            TitleTextbox.TabIndex = 3;
            // 
            // DescriptionTextbox
            // 
            DescriptionTextbox.Location = new Point(11, 157);
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.Size = new Size(970, 27);
            DescriptionTextbox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 188);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 5;
            label4.Text = "Schedule Date";
            // 
            // ScheduleDate
            // 
            ScheduleDate.Location = new Point(11, 211);
            ScheduleDate.Name = "ScheduleDate";
            ScheduleDate.Size = new Size(250, 27);
            ScheduleDate.TabIndex = 6;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(743, 244);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(239, 47);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(498, 244);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(239, 47);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(253, 244);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(239, 47);
            EditButton.TabIndex = 12;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(11, 244);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(235, 47);
            NewButton.TabIndex = 13;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // Done
            // 
            Done.AutoSize = true;
            Done.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Done.Location = new Point(861, 203);
            Done.Name = "Done";
            Done.Size = new Size(121, 35);
            Done.TabIndex = 15;
            Done.Text = "Finished";
            Done.UseVisualStyleBackColor = true;
            Done.CheckedChanged += Done_CheckedChanged_1;
            // 
            // CompleteDate
            // 
            CompleteDate.Location = new Point(605, 208);
            CompleteDate.Name = "CompleteDate";
            CompleteDate.Size = new Size(250, 27);
            CompleteDate.TabIndex = 17;
            CompleteDate.Value = new DateTime(2023, 11, 2, 7, 25, 32, 0);
            // 
            // txtTaskID
            // 
            txtTaskID.Location = new Point(449, 208);
            txtTaskID.Name = "txtTaskID";
            txtTaskID.Size = new Size(141, 27);
            txtTaskID.TabIndex = 18;
            // 
            // dvgTask
            // 
            dvgTask.AllowUserToAddRows = false;
            dvgTask.BackgroundColor = Color.White;
            dvgTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTask.Location = new Point(7, 297);
            dvgTask.Name = "dvgTask";
            dvgTask.RowHeadersWidth = 51;
            dvgTask.RowTemplate.Height = 29;
            dvgTask.Size = new Size(975, 360);
            dvgTask.TabIndex = 19;
            dvgTask.CellDoubleClick += dvgTask_CellDoubleClick;
            // 
            // Task_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1026, 669);
            Controls.Add(dvgTask);
            Controls.Add(txtTaskID);
            Controls.Add(CompleteDate);
            Controls.Add(Done);
            Controls.Add(NewButton);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(ScheduleDate);
            Controls.Add(label4);
            Controls.Add(DescriptionTextbox);
            Controls.Add(TitleTextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Task_Form";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvgTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TitleTextbox;
        private TextBox DescriptionTextbox;
        private Label label4;
        private DateTimePicker ScheduleDate;
        private Button SaveButton;
        private Button DeleteButton;
        private Button EditButton;
        private Button NewButton;
        private CheckBox Done;
        private DateTimePicker CompleteDate;
        private TextBox txtTaskID;
        private DataGridView dvgTask;
    }
}