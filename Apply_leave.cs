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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grifindo_Lanka_Toys
{
    public partial class Apply_leave : Form
    {
        public Apply_leave()
        {
            InitializeComponent();
            this.Load += new EventHandler(Apply_leave_Load);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Apply_btn_Click(object sender, EventArgs e)
        { // Get the form data
            int employeeID = int.Parse(Emp_ID.Text);
            string leaveType = Leave_type.SelectedItem.ToString(); // Get the selected leave type
            DateTime startDate = Start_date.Value; // Assuming Start_date is a DateTimePicker
            DateTime endDate = End_date.Value; // Assuming End_date is a DateTimePicker
            TimeSpan leaveDuration = endDate - startDate; // Calculate duration

            // Validation for Short Leave
            if (leaveType == "Short Leave")
            {
                // Check if the leave is less than 90 minutes
                if (leaveDuration.TotalMinutes > 90)
                {
                    MessageBox.Show("Short Leave cannot be more than 90 minutes.");
                    return;
                }
            }

            // Validation for Annual Leave
            if (leaveType == "Annual Leave")
            {
                // Ensure the start date is at least 7 days from today
                if ((startDate - DateTime.Now).TotalDays < 7)
                {
                    MessageBox.Show("Annual Leave must be applied at least 7 days in advance.");
                    return;
                }
            }

            // Connection string to connect to your SQL Server
            string connectionString = @"Server=HASTHIKA;Database=Griffindor Toys;Trusted_Connection=True;"; // Replace with your actual connection string

            // Query to insert the leave application into the database
            string query = "INSERT INTO Apply_Leave (EmpID, LeaveType, StartDate, EndDate, LeaveStatus) " +
                           "VALUES (@EmpID, @LeaveType, @StartDate, @EndDate, @LeaveStatus)";

            // Use a SQL connection to connect to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@EmpID", employeeID);
                        command.Parameters.AddWithValue("@LeaveType", leaveType);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        command.Parameters.AddWithValue("@LeaveStatus", "Pending");

                        // Execute the query
                        command.ExecuteNonQuery();

                        // Notify the user that the application was successful
                        MessageBox.Show("Leave application submitted successfully!");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors (e.g., log them, show a message to the user)
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void LeaveID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLeaveType = Leave_type.SelectedItem.ToString();

            if (selectedLeaveType == "Short Leave")
            {
                // For short leave, show both date and time
                Start_date.Format = DateTimePickerFormat.Custom;
                Start_date.CustomFormat = "MM/dd/yyyy hh:mm tt"; // Date with time
                End_date.Format = DateTimePickerFormat.Custom;
                End_date.CustomFormat = "MM/dd/yyyy hh:mm tt"; // Date with time
            }
            else
            {
                // For other leaves, show only date
                Start_date.Format = DateTimePickerFormat.Custom;
                Start_date.CustomFormat = "MM/dd/yyyy"; // Only date
                End_date.Format = DateTimePickerFormat.Custom;
                End_date.CustomFormat = "MM/dd/yyyy"; // Only date
            }
        }
        private void Apply_leave_Load(object sender, EventArgs e)
        {
            // Populate the ComboBox with leave types when the form loads
            Leave_type.Items.Add("Short Leave");
            Leave_type.Items.Add("Casual Leave");
            Leave_type.Items.Add("Annual Leave");

            // Set default leave type
            //Leave_type.SelectedIndex = 0; // Default selection when form loads
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Employee_Dashboard employee_Dashboard = new Employee_Dashboard();
            employee_Dashboard.Show();
            this.Hide();
        }
    }
}
