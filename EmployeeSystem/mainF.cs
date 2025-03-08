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

        private void dashbtn_click(object sender, EventArgs e)
        {

        }

        private void exitbtn_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
