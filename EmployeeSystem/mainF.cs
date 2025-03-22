using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSystem
{
    public partial class mainF : Form
    {
        public mainF()
        {
            InitializeComponent();
        }


        private void exitbtn_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Log Out?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void dashP_click(object sender, EventArgs e)
        {
            control11.Visible = true;
            employee1.Visible = false;
            uDetails1.Visible = false;
            salary1.Visible = false;
        }

        private void addEmpP_click(object sender, EventArgs e)
        {
            control11.Visible = false;
            uDetails1.Visible = false;
            employee1.Visible = true;
            salary1.Visible = false;
        }

        private void salaryP_click(object sender, EventArgs e)
        {
            control11.Visible = false;
            employee1.Visible = false;
            employee1.Visible = false;
            salary1.Visible = true;
        }

        private void tm2_Tick(object sender, EventArgs e)
        {
            //tm2.Enabled = false;
            //DateTime dtt = DateTime.Now;
            //diff.Text += dtt.ToString();

            //tm2.Enabled = true;

            DateTime dt = DateTime.Now;
            tmb1.Text = dt.ToString();
            tm2.Start();
        }

        private void viewEmpb(object sender, EventArgs e)
        {
            //uDetails ud = new uDetails();
            uDetails1.Visible = true;
            control11.Visible = false;
            employee1.Visible = false;
            salary1.Visible = false;
            //ud.Visible = true;
        }
    }
}
