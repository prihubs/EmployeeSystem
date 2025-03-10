namespace EmployeeSystem
{
    partial class mainF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainF));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            closebtn1 = new Label();
            panel2 = new Panel();
            logoutt_btn = new Button();
            salary_btn = new Button();
            addEm_btn = new Button();
            dash_btn = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            greet_user = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            control11 = new Control1();
            employee1 = new Employee();
            salary1 = new Salary();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(closebtn1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 45);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PJ_graphics_logo_2021;
            pictureBox2.Location = new Point(9, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins Medium", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(39, 9);
            label9.Name = "label9";
            label9.Size = new Size(78, 28);
            label9.TabIndex = 12;
            label9.Text = "PRIHUBS";
            // 
            // closebtn1
            // 
            closebtn1.AutoSize = true;
            closebtn1.BackColor = Color.FromArgb(255, 128, 0);
            closebtn1.Cursor = Cursors.Hand;
            closebtn1.FlatStyle = FlatStyle.Flat;
            closebtn1.Font = new Font("Poppins Medium", 13F);
            closebtn1.ForeColor = Color.White;
            closebtn1.Location = new Point(1064, 9);
            closebtn1.Name = "closebtn1";
            closebtn1.Size = new Size(26, 31);
            closebtn1.TabIndex = 11;
            closebtn1.Text = "X";
            closebtn1.Click += exitbtn_click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 109, 0);
            panel2.Controls.Add(logoutt_btn);
            panel2.Controls.Add(salary_btn);
            panel2.Controls.Add(addEm_btn);
            panel2.Controls.Add(dash_btn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(greet_user);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 555);
            panel2.TabIndex = 1;
            // 
            // logoutt_btn
            // 
            logoutt_btn.BackColor = Color.Transparent;
            logoutt_btn.BackgroundImageLayout = ImageLayout.None;
            logoutt_btn.Cursor = Cursors.Hand;
            logoutt_btn.FlatAppearance.BorderColor = Color.White;
            logoutt_btn.FlatAppearance.BorderSize = 0;
            logoutt_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            logoutt_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            logoutt_btn.FlatStyle = FlatStyle.Flat;
            logoutt_btn.Font = new Font("Poppins Medium", 11F);
            logoutt_btn.ForeColor = Color.White;
            logoutt_btn.Image = Properties.Resources.Move_Up1;
            logoutt_btn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutt_btn.Location = new Point(3, 505);
            logoutt_btn.Name = "logoutt_btn";
            logoutt_btn.Size = new Size(44, 40);
            logoutt_btn.TabIndex = 12;
            logoutt_btn.UseVisualStyleBackColor = false;
            logoutt_btn.Click += logout_btn;
            // 
            // salary_btn
            // 
            salary_btn.BackColor = Color.Transparent;
            salary_btn.BackgroundImageLayout = ImageLayout.None;
            salary_btn.Cursor = Cursors.Hand;
            salary_btn.FlatAppearance.BorderColor = Color.White;
            salary_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            salary_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            salary_btn.FlatStyle = FlatStyle.Flat;
            salary_btn.Font = new Font("Poppins Medium", 11F);
            salary_btn.ForeColor = Color.White;
            salary_btn.Image = Properties.Resources.Get_Cash;
            salary_btn.ImageAlign = ContentAlignment.MiddleLeft;
            salary_btn.Location = new Point(9, 271);
            salary_btn.Name = "salary_btn";
            salary_btn.Size = new Size(202, 40);
            salary_btn.TabIndex = 12;
            salary_btn.Text = "SALARY";
            salary_btn.UseVisualStyleBackColor = false;
            salary_btn.Click += salaryP_click;
            // 
            // addEm_btn
            // 
            addEm_btn.BackColor = Color.Transparent;
            addEm_btn.BackgroundImageLayout = ImageLayout.None;
            addEm_btn.Cursor = Cursors.Hand;
            addEm_btn.FlatAppearance.BorderColor = Color.White;
            addEm_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            addEm_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            addEm_btn.FlatStyle = FlatStyle.Flat;
            addEm_btn.Font = new Font("Poppins Medium", 11F);
            addEm_btn.ForeColor = Color.White;
            addEm_btn.Image = Properties.Resources.Add_Male_User_Group;
            addEm_btn.ImageAlign = ContentAlignment.MiddleLeft;
            addEm_btn.Location = new Point(9, 225);
            addEm_btn.Name = "addEm_btn";
            addEm_btn.Size = new Size(202, 40);
            addEm_btn.TabIndex = 12;
            addEm_btn.Text = "    ADD EMPLOYEE";
            addEm_btn.UseVisualStyleBackColor = false;
            addEm_btn.Click += addEmpP_click;
            // 
            // dash_btn
            // 
            dash_btn.BackColor = Color.Transparent;
            dash_btn.BackgroundImageLayout = ImageLayout.None;
            dash_btn.Cursor = Cursors.Hand;
            dash_btn.FlatAppearance.BorderColor = Color.White;
            dash_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            dash_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            dash_btn.FlatStyle = FlatStyle.Flat;
            dash_btn.Font = new Font("Poppins Medium", 11F);
            dash_btn.ForeColor = Color.White;
            dash_btn.Image = Properties.Resources.Dashboard_Gauge1;
            dash_btn.ImageAlign = ContentAlignment.MiddleLeft;
            dash_btn.Location = new Point(9, 179);
            dash_btn.Name = "dash_btn";
            dash_btn.Size = new Size(202, 40);
            dash_btn.TabIndex = 12;
            dash_btn.Text = "DASHBOARD";
            dash_btn.UseVisualStyleBackColor = false;
            dash_btn.Click += dashP_click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 515);
            label3.Name = "label3";
            label3.Size = new Size(60, 22);
            label3.TabIndex = 13;
            label3.Text = "Sign Out";
            // 
            // greet_user
            // 
            greet_user.AutoSize = true;
            greet_user.Font = new Font("Poppins Medium", 12F);
            greet_user.ForeColor = Color.White;
            greet_user.Location = new Point(43, 115);
            greet_user.Name = "greet_user";
            greet_user.Size = new Size(133, 28);
            greet_user.TabIndex = 13;
            greet_user.Text = "Welcome, User";
            // 
            // panel3
            // 
            panel3.Location = new Point(733, 198);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 191);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(control11);
            panel4.Controls.Add(employee1);
            panel4.Controls.Add(salary1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(225, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(875, 555);
            panel4.TabIndex = 2;
            // 
            // control11
            // 
            control11.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            control11.Location = new Point(0, 0);
            control11.Margin = new Padding(4, 6, 4, 6);
            control11.Name = "control11";
            control11.Size = new Size(875, 555);
            control11.TabIndex = 2;
            // 
            // employee1
            // 
            employee1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employee1.Location = new Point(0, 0);
            employee1.Margin = new Padding(4, 6, 4, 6);
            employee1.Name = "employee1";
            employee1.Size = new Size(875, 555);
            employee1.TabIndex = 1;
            // 
            // salary1
            // 
            salary1.Font = new Font("Poppins", 12F);
            salary1.Location = new Point(0, 0);
            salary1.Margin = new Padding(4, 6, 4, 6);
            salary1.Name = "salary1";
            salary1.Size = new Size(875, 555);
            salary1.TabIndex = 0;
            // 
            // mainF
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Poppins Medium", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "y";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label9;
        private Label closebtn1;
        private Panel panel2;
        private Panel panel3;
        private Button dash_btn;
        private PictureBox pictureBox1;
        private Label greet_user;
        private Button salary_btn;
        private Button addEm_btn;
        private Button logoutt_btn;
        private Label label3;
        private Panel panel4;
        private Control1 control11;
        private Employee employee1;
        private Salary salary1;
    }
}