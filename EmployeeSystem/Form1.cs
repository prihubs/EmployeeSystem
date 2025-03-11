using Microsoft.Data.SqlClient;
using System.Data;

namespace EmployeeSystem
{
    public partial class Form1 : Form
    {
        private string userr, passr, emailr, Query;
        SqlConnection con;

        public Form1()
        {
            InitializeComponent();
            myFunc myFunc = new myFunc();
            con = myFunc.db();
        }

        private void closebtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register()
        {
            RegisterForm reg = new RegisterForm();
            reg.Show();
            this.Hide();
        }

        private void dash()
        {
            mainF dash = new mainF();
            dash.Show();
            this.Hide();
        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            register();
        }

        private void showbtn_CheckedChanged(object sender, EventArgs e)
        {
            pass.PasswordChar = showbtn.Checked ? '\0' : '*';
        }

        private bool Empty()
        {
            if (
                string.IsNullOrWhiteSpace(userr)
                || string.IsNullOrWhiteSpace(passr)
                )
            {

                // MessageBox.Show("Enter Your Credentials! ", "Incomplete!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void logbtnn_click(object sender, EventArgs e)
        {
            conn();
            userr = user.Text;
            passr = pass.Text;

            try
            {
                if (!Empty())
                {
                    con.Open();
                    Query = "Select * From Users Where username = @user OR email = @user AND pass = @pass";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.Parameters.AddWithValue("@user", userr.Trim());
                    cmd.Parameters.AddWithValue("@pass", passr.Trim());

                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    MessageBox.Show("Connecting to Your Account... " + userr, "Connecting!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dt.Rows.Count >= 1)
                    {
                        MessageBox.Show("Logged in Successfully... ", "Logged in!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dash();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Credentials... ", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    con.Close();

                }
                else
                {

                    MessageBox.Show("Enter Your Credentials! ", "Incomplete!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // MessageBox.Show("Connecting to Your Account... " + userr, "Connecting!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed!...: " + ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
