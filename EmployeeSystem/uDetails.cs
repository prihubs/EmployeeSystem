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
    public partial class uDetails : UserControl
    {
        myFunc db = new myFunc();
        SqlConnection con;
        private string Query, idd;
        private int id;
        
        public uDetails()
        {
            InitializeComponent();
            con = db.db();
        }

        private void conn()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void Emp_searchbtn(object sender, EventArgs e)
        {
            idd = Emps_id.Text;

            id = int.Parse(idd);

            conn();
            Query = "Select * From employees Where employee_id = @id";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();

            //SqlDataAdapter sd = new SqlDataAdapter(cmd);
            SqlDataReader rd = cmd.ExecuteReader();
            //sd.Fill(dt);

            if(!rd.Read())
            {
                MessageBox.Show("Employee Data was not found", "Not Found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                Emp_idb.Text = rd["id"].ToString();
                Emp_fnb.Text = rd["full_name"].ToString();
                Emp_gdb.Text = rd["gender"].ToString();
                Emp_ptb.Text = rd["position"].ToString();
                Emp_pnb.Text = rd["contact"].ToString();
                Emp_stb.Text = rd["status"].ToString();
                Emp_slb.Text = rd["salary"].ToString();
                Emp_pbb.Image = pic((byte[])rd["image"]);
            }

        }

        private Image pic(byte[] data)
        {
            if(data is DBNull || data.Length == 0)
            {
                return null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(data);
                return Image.FromStream(ms);
            }
        }
    }
}
