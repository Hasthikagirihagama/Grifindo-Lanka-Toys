using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Lanka_Toys
{
    public partial class Employee_Login : Form
    {
        public Employee_Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            // Connection string to your SQL Server database
            string connectionString = @"Server=HASTHIKA;Database=Griffindor Toys;Trusted_Connection=True;";

            // SQL query to check if the username and password are correct
            string query = "SELECT COUNT(1) FROM employee_details WHERE Username = @Username AND Password = @Password";

            // Use a SQL connection to connect to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create SQL command with parameters to prevent SQL injection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@Username", user);
                        command.Parameters.AddWithValue("@Password", pass);

                        // Execute the query and get the result
                        int result = (int)command.ExecuteScalar();

                        // If the result is 1, the credentials are correct
                        if (result == 1)
                        {
                            // Success: Open employee dashboard or next page
                            MessageBox.Show("Welcome Back " + user + "!");
                            Employee_Dashboard employeeDashboard = new Employee_Dashboard();
                            employeeDashboard.Show();
                            this.Hide(); // Hide the login form
                        }
                        else
                        {
                            // Failure: Show error message
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();
        }
    }
}

