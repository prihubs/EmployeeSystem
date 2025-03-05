namespace EmployeeSystem
{
    partial class RegisterForm
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            logbtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            signbtn = new Button();
            showbtn = new CheckBox();
            pass = new TextBox();
            user = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            closebtn1 = new Label();
            label7 = new Label();
            cpass = new TextBox();
            label8 = new Label();
            email = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PJ_graphics_logo_2021;
            pictureBox1.Location = new Point(44, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(logbtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 430);
            panel1.TabIndex = 6;
            // 
            // logbtn
            // 
            logbtn.BackColor = Color.White;
            logbtn.FlatAppearance.BorderColor = Color.White;
            logbtn.FlatAppearance.BorderSize = 0;
            logbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            logbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            logbtn.FlatStyle = FlatStyle.Flat;
            logbtn.Font = new Font("Poppins Medium", 11F);
            logbtn.ForeColor = Color.FromArgb(255, 128, 0);
            logbtn.Location = new Point(16, 358);
            logbtn.Name = "logbtn";
            logbtn.Size = new Size(272, 39);
            logbtn.TabIndex = 5;
            logbtn.Text = "LOGIN";
            logbtn.UseVisualStyleBackColor = false;
            logbtn.Click += logbtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(44, 279);
            label6.Name = "label6";
            label6.Size = new Size(79, 28);
            label6.TabIndex = 2;
            label6.Text = "SYSTEM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(44, 260);
            label5.Name = "label5";
            label5.Size = new Size(224, 28);
            label5.TabIndex = 2;
            label5.Text = "EMPLOYEE MANAGEMENT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 9F);
            label1.Location = new Point(84, 333);
            label1.Name = "label1";
            label1.Size = new Size(129, 22);
            label1.TabIndex = 2;
            label1.Text = "Log in your Account";
            // 
            // signbtn
            // 
            signbtn.BackColor = Color.FromArgb(255, 128, 0);
            signbtn.FlatAppearance.BorderColor = Color.White;
            signbtn.FlatAppearance.BorderSize = 0;
            signbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            signbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            signbtn.FlatStyle = FlatStyle.Flat;
            signbtn.Font = new Font("Poppins Medium", 9F);
            signbtn.ForeColor = Color.White;
            signbtn.Location = new Point(342, 309);
            signbtn.Name = "signbtn";
            signbtn.Size = new Size(272, 39);
            signbtn.TabIndex = 14;
            signbtn.Text = "SIGNUP";
            signbtn.UseVisualStyleBackColor = false;
            // 
            // showbtn
            // 
            showbtn.AutoSize = true;
            showbtn.Font = new Font("Poppins Medium", 9F);
            showbtn.Location = new Point(552, 266);
            showbtn.Name = "showbtn";
            showbtn.Size = new Size(62, 26);
            showbtn.TabIndex = 13;
            showbtn.Text = "Show";
            showbtn.TextAlign = ContentAlignment.MiddleCenter;
            showbtn.UseVisualStyleBackColor = true;
            // 
            // pass
            // 
            pass.Font = new Font("Poppins Medium", 11F);
            pass.Location = new Point(342, 231);
            pass.Name = "pass";
            pass.Size = new Size(133, 29);
            pass.TabIndex = 11;
            // 
            // user
            // 
            user.Font = new Font("Poppins Medium", 11F);
            user.Location = new Point(342, 164);
            user.Name = "user";
            user.Size = new Size(133, 29);
            user.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 9F);
            label4.Location = new Point(342, 210);
            label4.Name = "label4";
            label4.Size = new Size(71, 22);
            label4.TabIndex = 8;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 9F);
            label3.Location = new Point(342, 143);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 9;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 17F);
            label2.Location = new Point(342, 65);
            label2.Name = "label2";
            label2.Size = new Size(201, 40);
            label2.TabIndex = 10;
            label2.Text = "Create Account";
            // 
            // closebtn1
            // 
            closebtn1.AutoSize = true;
            closebtn1.Font = new Font("Poppins Medium", 11F, FontStyle.Bold);
            closebtn1.ForeColor = Color.FromArgb(255, 128, 0);
            closebtn1.Location = new Point(617, 5);
            closebtn1.Name = "closebtn1";
            closebtn1.Size = new Size(23, 26);
            closebtn1.TabIndex = 7;
            closebtn1.Text = "X";
            closebtn1.Click += closebtn1_click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins Medium", 9F);
            label7.Location = new Point(481, 210);
            label7.Name = "label7";
            label7.Size = new Size(123, 22);
            label7.TabIndex = 8;
            label7.Text = "Confirm Password:";
            // 
            // cpass
            // 
            cpass.Font = new Font("Poppins Medium", 11F);
            cpass.Location = new Point(481, 231);
            cpass.Name = "cpass";
            cpass.Size = new Size(133, 29);
            cpass.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins Medium", 9F);
            label8.Location = new Point(481, 143);
            label8.Name = "label8";
            label8.Size = new Size(45, 22);
            label8.TabIndex = 9;
            label8.Text = "Email:";
            // 
            // email
            // 
            email.Font = new Font("Poppins Medium", 11F);
            email.Location = new Point(481, 164);
            email.Name = "email";
            email.Size = new Size(133, 29);
            email.TabIndex = 12;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 430);
            Controls.Add(panel1);
            Controls.Add(signbtn);
            Controls.Add(showbtn);
            Controls.Add(cpass);
            Controls.Add(pass);
            Controls.Add(email);
            Controls.Add(user);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(closebtn1);
            Font = new Font("Poppins Medium", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button logbtn;
        private Label label6;
        private Label label5;
        private Label label1;
        private Button signbtn;
        private CheckBox showbtn;
        private TextBox pass;
        private TextBox user;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label closebtn1;
        private Label label7;
        private TextBox cpass;
        private Label label8;
        private TextBox email;
    }
}