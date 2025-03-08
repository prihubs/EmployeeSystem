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
            dash = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dash);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 555);
            panel2.TabIndex = 1;
            // 
            // dash
            // 
            dash.BackColor = Color.Transparent;
            dash.BackgroundImageLayout = ImageLayout.None;
            dash.Cursor = Cursors.Hand;
            dash.FlatAppearance.BorderColor = Color.White;
            dash.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            dash.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            dash.FlatStyle = FlatStyle.Flat;
            dash.Font = new Font("Poppins Medium", 11F);
            dash.ForeColor = Color.White;
            dash.Location = new Point(9, 179);
            dash.Name = "dash";
            dash.Size = new Size(202, 40);
            dash.TabIndex = 12;
            dash.Text = "DASHBOARD";
            dash.UseVisualStyleBackColor = false;
            dash.Click += dashbtn_click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 127);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 13;
            label2.Text = "SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 108);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 13;
            label1.Text = "MANAGEMENT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(65, 90);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 13;
            label5.Text = "EMPLOYEE";
            // 
            // panel3
            // 
            panel3.Location = new Point(733, 198);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 191);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins Medium", 11F);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.icons8_add_male_user_group_50;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(9, 225);
            button1.Name = "button1";
            button1.Size = new Size(202, 40);
            button1.TabIndex = 12;
            button1.Text = "    ADD EMPLOYEE";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += dashbtn_click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Poppins Medium", 11F);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.icons8_salary_male_30;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(9, 271);
            button2.Name = "button2";
            button2.Size = new Size(202, 40);
            button2.TabIndex = 12;
            button2.Text = "SALARY";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += dashbtn_click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logout;
            pictureBox3.Location = new Point(85, 490);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // mainF
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Poppins Medium", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainF";
            Text = "y";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label9;
        private Label closebtn1;
        private Panel panel2;
        private Panel panel3;
        private Button dash;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox3;
    }
}