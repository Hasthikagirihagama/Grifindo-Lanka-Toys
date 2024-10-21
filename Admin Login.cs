namespace Grifindo_Lanka_Toys
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string correctUsername = "admin";
            string correctPassword = "admin123";

            string user = username.Text;
            string pass = password.Text;

            if (user == correctUsername && pass == correctPassword)
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Register f2 = new Register();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adminregister_btn_Click(object sender, EventArgs e)
        {
            Admin_Roaster admin_Register = new Admin_Roaster();
            admin_Register.Show();
            this.Hide();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();
        }
    }
}
