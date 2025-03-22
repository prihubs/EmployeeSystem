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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tm1_Tick(object sender, EventArgs e)
        {
            tm1.Enabled = true;
            pg1.Increment(1);

            if(pg1.Value == 100)
            {
                tm1.Enabled = false;
                Form1 fm1 = new Form1();
                this.Hide();
                fm1.Show();
            }
        }
    }
}
