using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Lanka_Toys
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;
            string f_name = f_nametxt.Text;
            string l_name = l_nametxt.Text;
            string position = positiontxt.Text;
            string department = departmenttxt.Text;
            //string join_date = joined_datetxt.Text;

            // Get the date directly from DateTimePicker
            DateTime join_date = joined_datetxt.Value;


            // Connection string to your SQL Server
            string connectionString = @"Server=HASTHIKA;Database=Griffindor Toys;Trusted_Connection=True;";

            // SQL Insert Query
            string query = "INSERT INTO employee_details (Username, Password, FirstName, LastName, Position, Department, JoinedDate) " +
                           "VALUES (@Username, @Password, @FirstName, @LastName, @Position, @Department, @DateOfJoining)";

            // Create a connection
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                // Create a command and set its connection
                using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection))
                {
                    // Open the connection
                    connection.Open();

                    // Add the parameters
                    command.Parameters.Add(new System.Data.SqlClient.SqlParameter("Username", username));
                    command.Parameters.Add(new System.Data.SqlClient.SqlParameter("Password", password));
                    command.Parameters.Add(new System.Data.SqlClient.SqlParameter("FirstName", f_name));
                    command.Parameters.Add(new System.Data.SqlClient.SqlParameter("LastName", l_name));
                    command.Parameters.Add(new System.Data.SqlClient.SqlParameter("Position", position));
                    command.Parameters.Add(new System.Data.SqlClient.SqlParameter("Department", department));
                    command.Parameters.Add(new System.Data.SqlClient.SqlParameter("DateOfJoining", join_date));

                    // Execute the query
                    command.ExecuteNonQuery();
                    MessageBox.Show("Employee registered successfully!");

                    // Close the connection
                    connection.Close();

                }
            }

        }
    }
}
