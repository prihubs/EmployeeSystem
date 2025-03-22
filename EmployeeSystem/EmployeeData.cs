using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
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
        public Image Photo { set; get;}
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

                    //string imggg = rd["image"].ToString();

                    em.Salary = rd["salary"].ToString();
                    em.EmpID = rd["employee_id"].ToString();
                    em.Name = rd["full_name"].ToString();
                    em.Gender = rd["gender"].ToString();
                    em.Contact = rd["contact"].ToString();

                    if (rd["image"] != DBNull.Value)
                    em.Photo = cImage((byte[])rd["image"]);
                    else
                    em.Photo = null;

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

        public void getDatas(DataGridView data)
        {
            Query = "Select * From employees Where delete_date is Null";
            conn();
            con.Open(); 
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            data.DataSource = dt;
            con.Close();
        }
        private Image cImagee(byte[] data)
        {
            
                MemoryStream ms = new MemoryStream(data);
                return Image.FromStream(ms);
        }
        public Image cImage(byte[] data)
        {
            if (data == null || data.Length == 0 || data is DBNull)
            {
                return null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(data);
                return Image.FromStream(ms);
            }
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
                    em1.Photo = cImage((byte[])rd1["image"]);
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
