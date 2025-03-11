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
        public int id { set; get; }
        public string Salary { set; get; } 
        public string EmpID { set; get;}
        public string Name { set; get;}
        public string Gender { set; get;}
        public string Contact { set; get;}
        public string Position { set; get;}
        public string Image { set; get;}
        public string Status { set; get;}
        public string iDate { set; get;}
        public string uDate { set; get;}

        public string Query;

        myFunc func = new myFunc();
        SqlConnection con;

        private void conn()
        {
            con = func.db();

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public List<EmployeeData> EmpDataa()
        {
            string queryValue = "NULL";
            List<EmployeeData> listdata = new List<EmployeeData>();
            Query = " Select * from employees WHERE delete_date IS NULL ; ";

            try
            { 
                conn();

                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    EmployeeData em = new EmployeeData();

                    em.Salary = rd["salary"].ToString();
                    em.EmpID = rd["employee_id"].ToString();
                    em.Name = rd["full_name"].ToString();
                    em.Gender = rd["gender"].ToString();
                    em.Contact = rd["contact"].ToString();
                    em.Image = rd["image"].ToString();
                    em.Position = rd["position"].ToString();
                    em.Status = rd["status"].ToString();
                    em.iDate = rd["insert_date"].ToString();
                    em.uDate = rd["update_date"].ToString();
                    em.id = (int)rd["id"];

                    listdata.Add(em);
                }
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Could Not Get Employees!: "+ex.Message, "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           return listdata;
        }

        public List<EmployeeData> EmpDataaS()
        {
            string queryValue = "NULL";
            List<EmployeeData> listdata1 = new List<EmployeeData>();
            Query = " Select * from employees WHERE delete_date IS NULL ; ";

            try
            { 
                conn();

                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                SqlDataReader rd1 = cmd.ExecuteReader();

                while (rd1.Read())
                {
                    EmployeeData em1 = new EmployeeData();

                    
                    em1.EmpID = rd1["employee_id"].ToString();
                    em1.Name = rd1["full_name"].ToString();
                    em1.Salary = rd1["salary"].ToString();
                    em1.Gender = rd1["gender"].ToString();
                    em1.Contact = rd1["contact"].ToString();
                    em1.Position = rd1["position"].ToString();
                    em1.Status = rd1["status"].ToString();
                    em1.iDate = rd1["insert_date"].ToString();
                    em1.uDate = rd1["update_date"].ToString();
                    em1.Image = rd1["image"].ToString();
                    em1.id = (int)rd1["id"];

                    listdata1.Add(em1);
                    //listdata1.Remove(em1.Image)
                }
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Could Not Get Employees!: "+ex.Message, "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           return listdata1;
        }


    }
}
