using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmployeeSystem
{
    class myFunc
    {
        //private SqlConnection con = new SqlConnection("Data Source=DESKTOP-JI1O5MO;Initial Catalog=EmployeeM1;Persist Security Info=True;User ID=sa;Password=pjpj;Encrypt=True;Trust Server Certificate=True");
        private SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\EmployeeDB\EmpAttached.mdf;Integrated Security = True; Connect Timeout = 30");
        
        //private SqlConnection econ = new SqlConnection("Data Source=DESKTOP-JI1O5MO;Initial Catalog=EmployeeM1;Persist Security Info=True;User ID=sa;Password=pjpj;Encrypt=True;Trust Server Certificate=True");
        //private SqlConnection con = new SqlConnection("");

        public SqlConnection db()
        {
            return con;
        }
    }


}
