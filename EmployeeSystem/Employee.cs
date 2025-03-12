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
    public partial class Employee : UserControl
    {

        private SqlConnection con;
        myFunc func = new myFunc();
        private string Query, id, fn, gender, pos, contact, status, image, iDate, uDate, dDate = null, pic;
        private int salary;


        public Employee()
        {
            InitializeComponent();
            con = func.db();

            display();
        }

        private void display()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> list = ed.EmpDataa();
            addEmp_dg.DataSource = list;
        }

        private bool Empty()
        {
            if (string.IsNullOrWhiteSpace(addEmp_id.Text)
                || string.IsNullOrWhiteSpace(addEmp_fn.Text)
                || string.IsNullOrWhiteSpace(addEmp_g.Text)
                || string.IsNullOrWhiteSpace(addEmp_pos.Text)
                || string.IsNullOrWhiteSpace(addEmp_pn.Text)
                || string.IsNullOrWhiteSpace(addEmp_status.Text)
                //|| addEmp_pic.Text = null
                //|| addEmp_pic.Image == null
                )
            {
                MessageBox.Show("Kindly Fill all Feilds!", "Empty Feild(s)",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void conn()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private bool Exist()
        {

            Query = "Select Count(*) from employees Where employee_id = @empId";
            SqlCommand cmd = new SqlCommand(Query, con);


            cmd.Parameters.AddWithValue("@empId", addEmp_id.Text);
            int count = (int)cmd.ExecuteScalar();

            if (count >= 1)
            {
                MessageBox.Show($"Can't Add a User with {addEmp_id.Text} ", "User Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void process(string fn)
        {
            MessageBox.Show(fn + " Proccessing your Data...", "Process",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void check(string fn)
        {
            MessageBox.Show(fn + " Verifing your Data...", "Verify",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Insert()
        {

            id = addEmp_id.Text;
            fn = addEmp_fn.Text;
            gender = addEmp_g.Text;
            pos = addEmp_pos.Text;
            contact = addEmp_pn.Text;
            status = addEmp_status.Text;
            iDate = DateTime.Today.ToShortDateString(); //"getDate()";
            //iDate = DateTime.Today.ToShortDateString(); //"getDate()";
            image = "Not Set";
            //image = addEmp_pic.Text;
            //object dDate = DBNull.Value;
            //uDate = "getDate()";
            //salaryy = ;

            Query = $"Insert into employees (employee_id, full_name, gender, position, contact, image, insert_date, status) Values( @id, @fn, @gender, @pos, @contact, @image, @iDate, @status ); ";

            try
            {

                SqlCommand cmd1 = new SqlCommand(Query, con);

                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.Parameters.AddWithValue("@fn", fn);
                cmd1.Parameters.AddWithValue("@gender", gender);
                cmd1.Parameters.AddWithValue("@pos", pos);
                cmd1.Parameters.AddWithValue("@contact", contact);
                cmd1.Parameters.AddWithValue("@image", image);
                cmd1.Parameters.AddWithValue("@status", status);
                cmd1.Parameters.AddWithValue("@iDate", iDate);
                //cmd1.Parameters.AddWithValue("@salary", salary);
                //cmd1.Parameters.AddWithValue("@uDate", uDate);
                //cmd1.Parameters.AddWithValue("@dDate", dDate);

                cmd1.ExecuteNonQuery();

                display();

                MessageBox.Show(fn + " Data Created Successfully!", "Added New Employee Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not create this data at this time! " + ex.Message, "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void addEmp_add_Click(object sender, EventArgs e)
        {
            check(fn);
            conn();
            con.Open();

            if (!Empty() && !Exist())
            {

                process(fn);

                Insert();
            }
            con.Close();
        }

        private void addEmp_reff(object sender, EventArgs e)
        {
            display();
        }

        private void addEmp_clrr(object sender, EventArgs e)
        {
            addEmp_id.Clear();
            addEmp_fn.Clear();
            addEmp_pn.Clear();
            addEmp_pos.Text = null;
            addEmp_g.Text = null;
            addEmp_status.Text = null;
            addEmp_pic = null;
            
        }
    }

}
