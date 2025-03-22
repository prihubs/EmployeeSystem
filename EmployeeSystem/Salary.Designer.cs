namespace EmployeeSystem
{
    partial class Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            addSal_clr = new Button();
            addSal_del = new Button();
            addSal_up = new Button();
            refreshb = new Button();
            addSal_add = new Button();
            addSal_sal = new TextBox();
            label6 = new Label();
            addSal_fn = new TextBox();
            label4 = new Label();
            addSal_id = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            addSal_dg = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addSal_dg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(addSal_clr);
            panel1.Controls.Add(addSal_del);
            panel1.Controls.Add(addSal_up);
            panel1.Controls.Add(refreshb);
            panel1.Controls.Add(addSal_add);
            panel1.Controls.Add(addSal_sal);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(addSal_fn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addSal_id);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(15, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 526);
            panel1.TabIndex = 1;
            // 
            // addSal_clr
            // 
            addSal_clr.BackColor = Color.FromArgb(192, 192, 0);
            addSal_clr.FlatAppearance.BorderColor = Color.White;
            addSal_clr.FlatAppearance.BorderSize = 0;
            addSal_clr.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            addSal_clr.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            addSal_clr.FlatStyle = FlatStyle.Flat;
            addSal_clr.Font = new Font("Poppins Medium", 9F);
            addSal_clr.ForeColor = Color.Black;
            addSal_clr.Location = new Point(154, 366);
            addSal_clr.Name = "addSal_clr";
            addSal_clr.Size = new Size(100, 42);
            addSal_clr.TabIndex = 7;
            addSal_clr.Text = "CLEAR";
            addSal_clr.UseVisualStyleBackColor = false;
            addSal_clr.Click += addSal_clrr;
            // 
            // addSal_del
            // 
            addSal_del.BackColor = Color.FromArgb(192, 0, 0);
            addSal_del.FlatAppearance.BorderColor = Color.White;
            addSal_del.FlatAppearance.BorderSize = 0;
            addSal_del.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            addSal_del.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            addSal_del.FlatStyle = FlatStyle.Flat;
            addSal_del.Font = new Font("Poppins Medium", 9F);
            addSal_del.ForeColor = Color.White;
            addSal_del.Location = new Point(33, 429);
            addSal_del.Name = "addSal_del";
            addSal_del.Size = new Size(100, 42);
            addSal_del.TabIndex = 7;
            addSal_del.Text = "DELETE";
            addSal_del.UseVisualStyleBackColor = false;
            addSal_del.Visible = false;
            // 
            // addSal_up
            // 
            addSal_up.BackColor = Color.FromArgb(255, 128, 0);
            addSal_up.FlatAppearance.BorderColor = Color.White;
            addSal_up.FlatAppearance.BorderSize = 0;
            addSal_up.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            addSal_up.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            addSal_up.FlatStyle = FlatStyle.Flat;
            addSal_up.Font = new Font("Poppins Medium", 9F);
            addSal_up.ForeColor = Color.White;
            addSal_up.Location = new Point(154, 302);
            addSal_up.Name = "addSal_up";
            addSal_up.Size = new Size(100, 42);
            addSal_up.TabIndex = 7;
            addSal_up.Text = "UPDATE";
            addSal_up.UseVisualStyleBackColor = false;
            addSal_up.Click += addSal_add_Click;
            // 
            // refreshb
            // 
            refreshb.BackColor = Color.FromArgb(192, 64, 0);
            refreshb.FlatAppearance.BorderColor = Color.White;
            refreshb.FlatAppearance.BorderSize = 0;
            refreshb.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            refreshb.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            refreshb.FlatStyle = FlatStyle.Flat;
            refreshb.Font = new Font("Poppins Medium", 9F);
            refreshb.ForeColor = Color.White;
            refreshb.Location = new Point(33, 366);
            refreshb.Name = "refreshb";
            refreshb.Size = new Size(100, 42);
            refreshb.TabIndex = 7;
            refreshb.Text = "REFRESH";
            refreshb.UseVisualStyleBackColor = false;
            refreshb.Click += addSal_reff;
            // 
            // addSal_add
            // 
            addSal_add.BackColor = Color.FromArgb(255, 128, 0);
            addSal_add.FlatAppearance.BorderColor = Color.White;
            addSal_add.FlatAppearance.BorderSize = 0;
            addSal_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            addSal_add.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            addSal_add.FlatStyle = FlatStyle.Flat;
            addSal_add.Font = new Font("Poppins Medium", 9F);
            addSal_add.ForeColor = Color.White;
            addSal_add.Location = new Point(33, 302);
            addSal_add.Name = "addSal_add";
            addSal_add.Size = new Size(100, 42);
            addSal_add.TabIndex = 7;
            addSal_add.Text = "ADD";
            addSal_add.UseVisualStyleBackColor = false;
            addSal_add.Click += addSal_add_Click;
            // 
            // addSal_sal
            // 
            addSal_sal.Font = new Font("Poppins", 8F);
            addSal_sal.Location = new Point(14, 201);
            addSal_sal.Multiline = true;
            addSal_sal.Name = "addSal_sal";
            addSal_sal.Size = new Size(262, 29);
            addSal_sal.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 8F);
            label6.Location = new Point(14, 182);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 0;
            label6.Text = "Salary:";
            // 
            // addSal_fn
            // 
            addSal_fn.Font = new Font("Poppins", 8F);
            addSal_fn.Location = new Point(14, 131);
            addSal_fn.Multiline = true;
            addSal_fn.Name = "addSal_fn";
            addSal_fn.Size = new Size(262, 29);
            addSal_fn.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 8F);
            label4.Location = new Point(14, 112);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 0;
            label4.Text = "Full Name:";
            // 
            // addSal_id
            // 
            addSal_id.Font = new Font("Poppins", 8F);
            addSal_id.Location = new Point(14, 65);
            addSal_id.Multiline = true;
            addSal_id.Name = "addSal_id";
            addSal_id.Size = new Size(262, 29);
            addSal_id.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 8F);
            label3.Location = new Point(14, 46);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 0;
            label3.Text = "Employee ID:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(addSal_dg);
            panel2.Location = new Point(328, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 526);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 10F);
            label2.Location = new Point(11, 15);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 0;
            label2.Text = "Employees";
            // 
            // addSal_dg
            // 
            addSal_dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addSal_dg.Location = new Point(15, 46);
            addSal_dg.Name = "addSal_dg";
            addSal_dg.Size = new Size(500, 462);
            addSal_dg.TabIndex = 1;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Poppins", 12F);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Salary";
            Size = new Size(875, 555);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addSal_dg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private DataGridView addSal_dg;
        private TextBox addSal_sal;
        private Label label6;
        private TextBox addSal_fn;
        private Label label4;
        private TextBox addSal_id;
        private Label label3;
        private Button addSal_clr;
        private Button addSal_del;
        private Button addSal_up;
        private Button addSal_add;
        private Button refreshb;
    }
}
