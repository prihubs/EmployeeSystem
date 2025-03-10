using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace EmployeeSystem
{
    class EmployeeData
    {
        private int id { set; get;}
        private string EmpID { set; get;}
        private string Name { set; get;}
        private string Gender { set; get;}
        private string Contact { set; get;}
        private int Salary { set; get;}
        private string Position { set; get;}
        private string Image { set; get;}
        private string Status { set; get;}
        private string iDate { set; get;}
        private string uDate { set; get;}

        private string Query;

        myFunc func = new myFunc();
        SqlConnection con;

        private void conn()
        {
            con = func.db();

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }
        }

        public List<EmployeeData> EmpDataa()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();
            Query = "Select * from employees WHERE delete_date IS NULL";

            try
            {
                conn();

                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    EmployeeData em = new EmployeeData();

                    em.id = (int)rd["id"];
                    em.EmpID = (string)rd["employee_id"];
                    em.Name = (string)rd["full_name"];
                    em.Salary = (int)rd["salary"];
                    em.Gender = (string)rd["gender"];
                    em.Image = (string)rd["image"];
                    em.Position = (string)rd["position"];
                    em.Status = (string)rd["status"];
                    em.iDate = (string)rd["insert_date"];
                    em.uDate = (string)rd["update_date"];

                    listdata.Add(em);
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Could Not Get Employees!: "+ex.Message, "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           return listdata;
        }
    }
}
