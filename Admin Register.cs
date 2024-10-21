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
    public partial class Admin_Roaster : Form
    {
        public Admin_Roaster()
        {
            InitializeComponent();
        }

        private void Admin_Roaster_Load(object sender, EventArgs e)
        {
            Start_time.Format = DateTimePickerFormat.Custom;
            Start_time.CustomFormat = "hh:mm tt";
            End_time.Format = DateTimePickerFormat.Custom;
            End_time.CustomFormat = "hh:mm tt";

        }

        private void Apply_btn_Click(object sender, EventArgs e)
        {
            // Get form data
            int employeeID = int.Parse(Emp_ID.Text); // Assuming Emp_ID is the TextBox for Employee ID
            DateTime roasterStartTime = Start_time.Value; // Assuming RoasterStartTime is a DateTimePicker
            DateTime roasterEndTime = End_time.Value; // Assuming RoasterEndTime is a DateTimePicker

            // Validation: Roaster start time must be earlier than end time
            if (roasterStartTime >= roasterEndTime)
            {
                MessageBox.Show("Roaster start time must be earlier than end time.");
                return;
            }

            // Connection string to connect to your SQL Server
            string connectionString = @"Server=HASTHIKA;Database=Griffindor Toys;Trusted_Connection=True;";

            // Query to update the roaster times for the employee
            string query = "UPDATE Apply_Leave SET RoasterStartTime = @RoasterStartTime, RoasterEndTime = @RoasterEndTime WHERE EmpID = @EmpID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create the SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@EmpID", employeeID);
                        command.Parameters.AddWithValue("@RoasterStartTime", roasterStartTime);
                        command.Parameters.AddWithValue("@RoasterEndTime", roasterEndTime);

                        // Execute the update query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Notify the admin of success or failure
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Roaster time added/updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Error: Employee not found or could not update the roster.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
