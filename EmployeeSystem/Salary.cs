using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EmployeeSystem
{
    public partial class Salary : UserControl
    {

        string fn, salary, pos, ids, Query, uDate;
        int idi, salary2;
        SqlConnection con;
        myFunc func = new myFunc();

        public Salary()
        {
            InitializeComponent();
            con = func.db();
            uDate = "getDate()";
            display();
        }

        private void display()
        {
            EmployeeData ed = new EmployeeData();
            ed.getDatas(addSal_dg);
            addSal_dg.Columns["image"].Visible = false;
            //addEmp_dg.DataSource = list;
            //addEmp_dg.Columns.Add("Photo", typeof(byte[]));
        }
        private void displayt()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> list = ed.EmpDataaS();
            addSal_dg.DataSource = list;
            conn();
        }

        private void conn()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private bool Empty(string fn, string pos, string salary, string ids)
        {
            if (
                   string.IsNullOrWhiteSpace(fn)
                || string.IsNullOrWhiteSpace(ids)
                || string.IsNullOrWhiteSpace(pos)
                || string.IsNullOrWhiteSpace(salary)
                )
            {
                MessageBox.Show("Kindly Fill All Fields!", "Empty Fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidSal(string ids, string salary)
        {
            if (
                !int.TryParse(ids, out int idd)
                || !int.TryParse(salary, out int salaryy)
                )
            {
                MessageBox.Show("Invalid ID or SALARY", "Invalid Entries",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool Exist(string ids, string fn)
        {
            conn();
            Query = "Select Count(*) from employees Where employee_id = @emp_id AND full_name = @fn ";
            SqlCommand cmd = new SqlCommand(Query, con);

            cmd.Parameters.AddWithValue("@emp_id", ids);
            cmd.Parameters.AddWithValue("@fn", fn);
            con.Open();
            //SqlDataReader rrd = cmd.ExecuteReader();
            int count = (int)cmd.ExecuteScalar();

            if (count < 1)
            {
                MessageBox.Show("Employee Data(s) do not match!", "Data MisMatch",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn();
                return false;

            }
            else
            {
                conn();
                MessageBox.Show("Found!.........", "Data Found!",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            conn();

        }

        private void Update(string ids, string fn, string uDate, int salary2)
        {
            con.Open();
            Query = "Update employees Set salary = @salary, update_date = getDate() Where employee_id = @emp_id AND full_name = @fn  ";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@emp_id", ids);
            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@salary", salary2);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void check()
        {
            MessageBox.Show("Verifing your Entries...", "Verifing...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void process()
        {
            MessageBox.Show("Processing your request...", "Processing...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addSal_add_Click(object sender, EventArgs e)
        {

            //int.TryParse(addSal_id.Text, out int idd);
            fn = addSal_fn.Text;
            pos = addSal_fn.Text;
            salary = addSal_sal.Text;
            ids = addSal_id.Text;

            check();

            try
            {
                if (!Empty(ids, fn, pos, salary) && Exist(ids, fn) && ValidSal(ids, salary))
                {
                    conn();
                    process();

                    salary2 = int.Parse(salary);
                    Update(ids, fn, uDate, salary2);

                    display();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(fn + " Salary was not Updated: " + ex.Message, "Not Updated!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void addSal_reff(object sender, EventArgs e)
        {
            display();
        }

        private void addSal_clrr(object sender, EventArgs e)
        {
            addSal_fn.Clear();
            addSal_fn.Clear();
            addSal_sal.Clear();
            addSal_id.Clear();
        }
    }
}
