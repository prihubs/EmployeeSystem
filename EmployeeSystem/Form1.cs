namespace EmployeeSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closebtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            RegisterForm rgf = new RegisterForm();
            rgf.Show();
            this.Hide();
        }
    }
}
