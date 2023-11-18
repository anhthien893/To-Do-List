namespace PRN_assignment
{
    partial class Application_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application_Form));
            sidebar = new FlowLayoutPanel();
            panel8 = new Panel();
            btnMenu = new Button();
            panel6 = new Panel();
            btnTodo = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel3 = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel4 = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            panel5 = new Panel();
            panel2 = new Panel();
            btnTimer = new Button();
            panel7 = new Panel();
            panel9 = new Panel();
            button1 = new Button();
            btnCourse = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            timerStartBtn = new Button();
            resetBtn = new Button();
            timerGroup = new GroupBox();
            timeLabel = new Label();
            panel1 = new Panel();
            closeBtn = new Button();
            textBox1 = new TextBox();
            longBtn = new Button();
            shortBtn = new Button();
            promodoroBtn = new Button();
            timerMinimize = new Label();
            panel_body = new Panel();
            btnLogout = new Button();
            sidebar.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            timerGroup.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.GradientActiveCaption;
            sidebar.Controls.Add(panel8);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(flowLayoutPanel2);
            sidebar.Controls.Add(flowLayoutPanel3);
            sidebar.Controls.Add(flowLayoutPanel4);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel7);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(190, 1000);
            sidebar.MinimumSize = new Size(78, 1000);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(190, 1000);
            sidebar.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnMenu);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(185, 66);
            panel8.TabIndex = 6;
            // 
            // btnMenu
            // 
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(-9, -12);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(13, 10, 0, 10);
            btnMenu.Size = new Size(231, 92);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "            Menu";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnTodo);
            panel6.Location = new Point(3, 75);
            panel6.Name = "panel6";
            panel6.Size = new Size(185, 66);
            panel6.TabIndex = 5;
            // 
            // btnTodo
            // 
            btnTodo.FlatStyle = FlatStyle.Flat;
            btnTodo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTodo.Image = (Image)resources.GetObject("btnTodo.Image");
            btnTodo.ImageAlign = ContentAlignment.MiddleLeft;
            btnTodo.Location = new Point(-9, -12);
            btnTodo.Name = "btnTodo";
            btnTodo.Padding = new Padding(10, 10, 0, 10);
            btnTodo.Size = new Size(231, 92);
            btnTodo.TabIndex = 3;
            btnTodo.Text = "             Todo";
            btnTodo.TextAlign = ContentAlignment.MiddleLeft;
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.GradientActiveCaption;
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(3, 147);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(211, 0);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 75);
            panel3.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = SystemColors.GradientActiveCaption;
            flowLayoutPanel3.Controls.Add(panel4);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(3, 153);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(211, 0);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(206, 75);
            panel4.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = SystemColors.GradientActiveCaption;
            flowLayoutPanel4.Controls.Add(panel5);
            flowLayoutPanel4.Dock = DockStyle.Left;
            flowLayoutPanel4.Location = new Point(3, 159);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(211, 0);
            flowLayoutPanel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(206, 75);
            panel5.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTimer);
            panel2.Location = new Point(3, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 66);
            panel2.TabIndex = 4;
            // 
            // btnTimer
            // 
            btnTimer.FlatStyle = FlatStyle.Flat;
            btnTimer.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimer.Image = (Image)resources.GetObject("btnTimer.Image");
            btnTimer.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimer.Location = new Point(-9, -12);
            btnTimer.Name = "btnTimer";
            btnTimer.Padding = new Padding(10, 10, 0, 10);
            btnTimer.Size = new Size(231, 92);
            btnTimer.TabIndex = 3;
            btnTimer.Text = "             Timer";
            btnTimer.TextAlign = ContentAlignment.MiddleLeft;
            btnTimer.UseVisualStyleBackColor = true;
            btnTimer.Click += btnTimer_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(btnCourse);
            panel7.Location = new Point(3, 237);
            panel7.Name = "panel7";
            panel7.Size = new Size(185, 66);
            panel7.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.Controls.Add(button1);
            panel9.Location = new Point(3, 309);
            panel9.Name = "panel9";
            panel9.Size = new Size(185, 66);
            panel9.TabIndex = 6;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-9, -12);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 10, 0, 10);
            button1.Size = new Size(231, 92);
            button1.TabIndex = 3;
            button1.Text = "             Course";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCourse
            // 
            btnCourse.FlatStyle = FlatStyle.Flat;
            btnCourse.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCourse.Image = (Image)resources.GetObject("btnCourse.Image");
            btnCourse.ImageAlign = ContentAlignment.MiddleLeft;
            btnCourse.Location = new Point(-9, -12);
            btnCourse.Name = "btnCourse";
            btnCourse.Padding = new Padding(10, 10, 0, 10);
            btnCourse.Size = new Size(231, 92);
            btnCourse.TabIndex = 3;
            btnCourse.Text = "             Course";
            btnCourse.TextAlign = ContentAlignment.MiddleLeft;
            btnCourse.UseVisualStyleBackColor = true;
            btnCourse.Click += btnCourse_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 1000;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // timerStartBtn
            // 
            timerStartBtn.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            timerStartBtn.Location = new Point(154, 54);
            timerStartBtn.Name = "timerStartBtn";
            timerStartBtn.Size = new Size(75, 31);
            timerStartBtn.TabIndex = 2;
            timerStartBtn.Text = "Start";
            timerStartBtn.UseVisualStyleBackColor = true;
            timerStartBtn.Click += timerStartBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.Location = new Point(235, 54);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(75, 31);
            resetBtn.TabIndex = 3;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // timerGroup
            // 
            timerGroup.BackColor = Color.White;
            timerGroup.Controls.Add(timeLabel);
            timerGroup.Controls.Add(panel1);
            timerGroup.Controls.Add(longBtn);
            timerGroup.Controls.Add(shortBtn);
            timerGroup.Controls.Add(promodoroBtn);
            timerGroup.Controls.Add(resetBtn);
            timerGroup.Controls.Add(timerStartBtn);
            timerGroup.Location = new Point(564, 12);
            timerGroup.Name = "timerGroup";
            timerGroup.Size = new Size(333, 154);
            timerGroup.TabIndex = 4;
            timerGroup.TabStop = false;
            timerGroup.Text = "groupBox1";
            timerGroup.Visible = false;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.BackColor = Color.Gainsboro;
            timeLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            timeLabel.Location = new Point(25, 55);
            timeLabel.Name = "timeLabel";
            timeLabel.Padding = new Padding(20, 0, 20, 0);
            timeLabel.Size = new Size(106, 30);
            timeLabel.TabIndex = 6;
            timeLabel.Text = "00:00";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 34);
            panel1.TabIndex = 7;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.LightGray;
            closeBtn.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            closeBtn.Location = new Point(286, -1);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(46, 34);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "-";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(-1, -1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(291, 34);
            textBox1.TabIndex = 0;
            textBox1.Text = "Timer";
            // 
            // longBtn
            // 
            longBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            longBtn.Location = new Point(219, 102);
            longBtn.Name = "longBtn";
            longBtn.Size = new Size(91, 33);
            longBtn.TabIndex = 6;
            longBtn.Text = "Long break";
            longBtn.UseVisualStyleBackColor = true;
            longBtn.Click += longBtn_Click;
            // 
            // shortBtn
            // 
            shortBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            shortBtn.Location = new Point(122, 102);
            shortBtn.Name = "shortBtn";
            shortBtn.Size = new Size(91, 33);
            shortBtn.TabIndex = 5;
            shortBtn.Text = "Short break";
            shortBtn.UseVisualStyleBackColor = true;
            shortBtn.Click += shortBtn_Click;
            // 
            // promodoroBtn
            // 
            promodoroBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            promodoroBtn.Location = new Point(25, 102);
            promodoroBtn.Name = "promodoroBtn";
            promodoroBtn.Size = new Size(91, 33);
            promodoroBtn.TabIndex = 4;
            promodoroBtn.Text = "Promodoro";
            promodoroBtn.UseVisualStyleBackColor = true;
            promodoroBtn.Click += promodoroBtn_Click;
            // 
            // timerMinimize
            // 
            timerMinimize.AutoSize = true;
            timerMinimize.BackColor = SystemColors.ActiveCaption;
            timerMinimize.Dock = DockStyle.Right;
            timerMinimize.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            timerMinimize.Location = new Point(1023, 0);
            timerMinimize.Name = "timerMinimize";
            timerMinimize.Size = new Size(121, 54);
            timerMinimize.TabIndex = 5;
            timerMinimize.Text = "00:00";
            // 
            // panel_body
            // 
            panel_body.BackColor = Color.Transparent;
            panel_body.Location = new Point(196, 172);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(1035, 597);
            panel_body.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Location = new Point(190, 726);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(833, 23);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Application_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1144, 749);
            Controls.Add(btnLogout);
            Controls.Add(panel_body);
            Controls.Add(timerMinimize);
            Controls.Add(timerGroup);
            Controls.Add(sidebar);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Application_Form";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            sidebar.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            timerGroup.ResumeLayout(false);
            timerGroup.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel4;
        private Panel panel5;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel panel2;
        private Button btnTimer;
        private Button timerStartBtn;
        private Button resetBtn;
        private GroupBox timerGroup;
        private Button longBtn;
        private Button shortBtn;
        private Button promodoroBtn;
        private Panel panel1;
        private Button closeBtn;
        private TextBox textBox1;
        private Label timerMinimize;
        private Label timeLabel;
        private Panel panel8;
        private Button btnMenu;
        private Panel panel6;
        private Button btnTodo;
        private Panel panel_body;
        private Panel panel7;
        private Button btnCourse;
        private Panel panel9;
        private Button button1;
        private Button btnLogout;
    }
}