using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EmployeeSystem
{
    public partial class RegisterForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-JI1O5MO;Initial Catalog=EmployeeM1;Persist Security Info=True;User ID=sa;Password=pjpj;Encrypt=True;Trust Server Certificate=True");
        private String Query, Query1, ddate = "getDate()", userr, passr, emailr, cpassr;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void closebtn1_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login()
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void showbtn_CheckedChanged(object sender, EventArgs e)
        {
            pass.PasswordChar = showbtn.Checked ? '\0' : '*';
            cpass.PasswordChar = showbtn.Checked ? '\0' : '*';
        }

        private bool Empty()
        {
            if (
                string.IsNullOrWhiteSpace(user.Text)
                || string.IsNullOrWhiteSpace(email.Text)
                || string.IsNullOrWhiteSpace(pass.Text)
                )
            {
                MessageBox.Show("Kindly Fill All Feilds!", "Incomplete Entries", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        // MessageBox.Show("Check the Password Again!!", "Password Mismatch!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private bool vPass()
        {
            if(pass.Text != cpass.Text)
            {
                MessageBox.Show("Check the Password Again!!", "Password Mismatch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void conn()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        // private bool

        private void signbtn_click(object sender, EventArgs e)
        {
            if (!Empty() && vPass())
            {
                userr = user.Text;
                passr = pass.Text;
                cpassr = cpass.Text;
                emailr = email.Text;

                conn();
                try
                {
                    con.Open();

                    Query1 = "Select Count(id) From Users Where username = @userr AND email = @emailr ";
                    SqlCommand cmd1 = new SqlCommand(Query1, con);
                    cmd1.Parameters.AddWithValue("@userr", userr.Trim());
                    cmd1.Parameters.AddWithValue("@emailr", emailr.Trim());
                    int count = (int)cmd1.ExecuteScalar();

                    if (count >= 1)
                    {
                        MessageBox.Show($"User Account Exist, Login with your User Details! {userr} ..", "Exist!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Creating your Account...", "Creating.. "+userr, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Query = "Insert Into Users VALUES('"+userr+ "','"+passr+ "',"+ddate+",'"+emailr+"');";
                        SqlCommand cmd = new SqlCommand(Query, con);
                        cmd.Parameters.AddWithValue("@userr", userr.Trim());
                        cmd.Parameters.AddWithValue("@passr", passr.Trim());
                        cmd.Parameters.AddWithValue("@emailr", emailr.Trim());
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You have Successfully Created an Account "+emailr, "Account Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con.Close();

                        login();
                        //
                    }

                    // SqlDataAdapter sd = new SqlDataAdapter(cmd1);
                    // SqlDataReader sr = new SqlDataReader(sd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not Successfully Complete the Registration "+ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
