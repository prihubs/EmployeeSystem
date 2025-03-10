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
        private string Query, id, fn, gender, pos, contact, status, image, iDate, uDate, dDate, pic;


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
            if(string.IsNullOrWhiteSpace(addEmp_id.Text)
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
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }
        }

        private bool Exist()
        {
            conn();

            Query = "Select Count(*) from employees Where employee_id = @empId";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@empId", addEmp_id.Text);
            int count = (int)cmd.ExecuteScalar();

            if(count >= 1)
            {
                MessageBox.Show($"Can't Add a User with {addEmp_id.Text} ");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void process(string fn)
        {
            MessageBox.Show(fn + " Proccessing your Data!", "Process",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void check(string fn)
        {
            MessageBox.Show(fn + " Verifing your Data!", "Verify",
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
            //image = addEmp_pic.Text;
            iDate = "getDate()";
            uDate = "getDate()";
            dDate = "";
            image = "Not Set";

            Query = "Insert into employees Values(@id, @fn, @gender, @pos, @contact" +
                ", @status, @image, "+iDate+", "+uDate+", "+dDate+")";

            try
            {
                conn();

                SqlCommand cmd = new SqlCommand(Query, con);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@fn", fn);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@pos", pos);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@image", image);

                cmd.ExecuteNonQuery();

                display();

                MessageBox.Show(fn+" Data Created Successfully!", "Added New Employee Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not create this data at this time! "+ex.Message, "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        

        }

        private void addEmp_add_Click(object sender, EventArgs e)
        {
            check(fn);

            if (!Empty() && !Exist())
            {
                conn();
                process(fn);

                Insert();
            }
        }
    }

}
