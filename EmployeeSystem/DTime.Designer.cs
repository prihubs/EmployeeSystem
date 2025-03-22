namespace EmployeeSystem
{
    partial class DTime
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
            timebox = new Label();
            tm1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timebox
            // 
            timebox.AutoSize = true;
            timebox.Font = new Font("Segoe UI", 39F);
            timebox.Location = new Point(89, 46);
            timebox.Name = "timebox";
            timebox.Size = new Size(0, 70);
            timebox.TabIndex = 0;
            // 
            // tm1
            // 
            tm1.Enabled = true;
            tm1.Tick += tm1_Tick;
            // 
            // DTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 162);
            Controls.Add(timebox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DTime";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DTime";
            Load += DTime_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timebox;
        private System.Windows.Forms.Timer tm1;
    }
}