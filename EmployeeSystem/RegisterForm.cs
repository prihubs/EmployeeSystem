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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void closebtn1_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            Form1 logform = new Form1();
            logform.Show();
            this.Hide();
        }
    }
}
