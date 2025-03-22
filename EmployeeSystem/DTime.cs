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
    public partial class DTime : Form
    {
        public DTime()
        {
            InitializeComponent();
        }

        private void DTime_Load(object sender, EventArgs e)
        {

        }

        private void tm1_Tick(object sender, EventArgs e)
        {
            DateTime dd = DateTime.Now;
            timebox.Text = dd.ToString();
            tm1.Start();
        }
    }
}
