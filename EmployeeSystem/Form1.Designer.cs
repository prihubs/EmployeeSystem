namespace EmployeeSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            signbtn = new Button();
            label1 = new Label();
            closebtn1 = new Label();
            label2 = new Label();
            label3 = new Label();
            user = new TextBox();
            label4 = new Label();
            pass = new TextBox();
            showbtn = new CheckBox();
            logbtn = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label9 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(signbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 425);
            panel1.TabIndex = 0;
            // 
            // signbtn
            // 
            signbtn.BackColor = Color.White;
            signbtn.FlatAppearance.BorderColor = Color.White;
            signbtn.FlatAppearance.BorderSize = 0;
            signbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            signbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            signbtn.FlatStyle = FlatStyle.Flat;
            signbtn.Font = new Font("Poppins Medium", 11F);
            signbtn.ForeColor = Color.FromArgb(255, 128, 0);
            signbtn.Location = new Point(16, 358);
            signbtn.Name = "signbtn";
            signbtn.Size = new Size(272, 39);
            signbtn.TabIndex = 5;
            signbtn.Text = "SIGN UP";
            signbtn.UseVisualStyleBackColor = false;
            signbtn.Click += signbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 9F);
            label1.Location = new Point(71, 336);
            label1.Name = "label1";
            label1.Size = new Size(151, 22);
            label1.TabIndex = 2;
            label1.Text = "Register A New Account";
            // 
            // closebtn1
            // 
            closebtn1.AutoSize = true;
            closebtn1.Font = new Font("Poppins Medium", 11F, FontStyle.Bold);
            closebtn1.ForeColor = Color.FromArgb(255, 128, 0);
            closebtn1.Location = new Point(609, 5);
            closebtn1.Name = "closebtn1";
            closebtn1.Size = new Size(23, 26);
            closebtn1.TabIndex = 1;
            closebtn1.Text = "X";
            closebtn1.Click += closebtn1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 17F);
            label2.Location = new Point(334, 65);
            label2.Name = "label2";
            label2.Size = new Size(183, 40);
            label2.TabIndex = 2;
            label2.Text = "Login Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 9F);
            label3.Location = new Point(334, 143);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // user
            // 
            user.Font = new Font("Poppins Medium", 11F);
            user.Location = new Point(334, 164);
            user.Name = "user";
            user.Size = new Size(272, 29);
            user.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 9F);
            label4.Location = new Point(334, 210);
            label4.Name = "label4";
            label4.Size = new Size(71, 22);
            label4.TabIndex = 2;
            label4.Text = "Password:";
            // 
            // pass
            // 
            pass.Font = new Font("Poppins Medium", 11F);
            pass.Location = new Point(334, 231);
            pass.Name = "pass";
            pass.Size = new Size(272, 29);
            pass.TabIndex = 3;
            // 
            // showbtn
            // 
            showbtn.AutoSize = true;
            showbtn.Font = new Font("Poppins Medium", 9F);
            showbtn.Location = new Point(544, 266);
            showbtn.Name = "showbtn";
            showbtn.Size = new Size(62, 26);
            showbtn.TabIndex = 4;
            showbtn.Text = "Show";
            showbtn.TextAlign = ContentAlignment.MiddleCenter;
            showbtn.UseVisualStyleBackColor = true;
            // 
            // logbtn
            // 
            logbtn.BackColor = Color.FromArgb(255, 128, 0);
            logbtn.FlatAppearance.BorderColor = Color.White;
            logbtn.FlatAppearance.BorderSize = 0;
            logbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            logbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            logbtn.FlatStyle = FlatStyle.Flat;
            logbtn.Font = new Font("Poppins Medium", 9F);
            logbtn.ForeColor = Color.White;
            logbtn.Location = new Point(334, 298);
            logbtn.Name = "logbtn";
            logbtn.Size = new Size(272, 39);
            logbtn.TabIndex = 5;
            logbtn.Text = "LOGIN";
            logbtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PJ_graphics_logo_2021;
            pictureBox2.Location = new Point(9, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(41, 267);
            label6.Name = "label6";
            label6.Size = new Size(79, 28);
            label6.TabIndex = 7;
            label6.Text = "SYSTEM";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins Medium", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(39, 12);
            label9.Name = "label9";
            label9.Size = new Size(78, 28);
            label9.TabIndex = 8;
            label9.Text = "PRIHUBS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 248);
            label5.Name = "label5";
            label5.Size = new Size(224, 28);
            label5.TabIndex = 9;
            label5.Text = "EMPLOYEE MANAGEMENT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 425);
            Controls.Add(logbtn);
            Controls.Add(showbtn);
            Controls.Add(pass);
            Controls.Add(user);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(closebtn1);
            Controls.Add(panel1);
            Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label closebtn1;
        private Label label2;
        private Label label3;
        private TextBox user;
        private Label label4;
        private TextBox pass;
        private CheckBox showbtn;
        private Button logbtn;
        private Button signbtn;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label9;
        private Label label5;
    }
}
