namespace EmployeeSystem
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pg1 = new ProgressBar();
            panel1 = new Panel();
            tm1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.grouping;
            pictureBox1.Location = new Point(144, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pg1
            // 
            pg1.BackColor = Color.Red;
            pg1.ForeColor = Color.Black;
            pg1.Location = new Point(0, 6);
            pg1.Name = "pg1";
            pg1.Size = new Size(284, 10);
            pg1.Step = 2;
            pg1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Controls.Add(pg1);
            panel1.Location = new Point(129, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 22);
            panel1.TabIndex = 2;
            // 
            // tm1
            // 
            tm1.Enabled = true;
            tm1.Tick += tm1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(536, 294);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            TransparencyKey = Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar pg1;
        private Panel panel1;
        private System.Windows.Forms.Timer tm1;
    }
}