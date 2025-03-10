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
            salary1.Visible = false;
        }

        private void addEmpP_click(object sender, EventArgs e)
        {
            control11.Visible = false;
            employee1.Visible = true;
            salary1.Visible = false;
        }

        private void salaryP_click(object sender, EventArgs e)
        {
            control11.Visible = false;
            employee1.Visible = false;
            salary1.Visible = true;
        }

    }
}
