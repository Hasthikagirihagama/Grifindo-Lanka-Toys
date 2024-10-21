using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grifindo_Lanka_Toys
{
    public partial class View_Leave_Status : Form
    {
        public View_Leave_Status()
        {
            InitializeComponent();
            this.Load += new EventHandler(View_Leave_Status_Load);
        }

        // Load the pending leave requests into the DataGridView on form load
        private void View_Leave_Status_Load(object sender, EventArgs e)
        {
            LoadPendingLeaveRequests();
        }

        // Function to load pending leave requests into the grid view
        private void LoadPendingLeaveRequests()
        {
            string connectionString = @"Server=HASTHIKA;Database=Griffindor Toys;Trusted_Connection=True;";
            string query = "SELECT LeaveID, EmpID, LeaveType, StartDate, EndDate, LeaveStatus FROM Apply_Leave WHERE LeaveStatus = 'Pending'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable leaveTable = new DataTable();
                    adapter.Fill(leaveTable);
                    LeaveRequestsGridView.DataSource = leaveTable;
                }
            }
        }

        // Approve button click event
        private void Approve_btn_Click(object sender, EventArgs e)
        {
            string leaveID = ID_txt.Text.Trim(); // Get the LeaveID from the textbox
            if (!string.IsNullOrEmpty(leaveID))
            {
                UpdateLeaveStatus(leaveID, "Approved"); // Call to update the leave status to Approved
            }
            else
            {
                MessageBox.Show("Please enter a valid Leave ID.");
            }
        }

        // Reject button click event
        private void Reject_btn_Click(object sender, EventArgs e)
        {
            string leaveID = ID_txt.Text.Trim(); // Get the LeaveID from the textbox
            if (!string.IsNullOrEmpty(leaveID))
            {
                UpdateLeaveStatus(leaveID, "Rejected"); // Call to update the leave status to Rejected
            }
            else
            {
                MessageBox.Show("Please enter a valid Leave ID.");
            }
        }

        // Method to update leave status in the database based on LeaveID
        private void UpdateLeaveStatus(string leaveID, string newStatus)
        {
            string connectionString = @"Server=HASTHIKA;Database=Griffindor Toys;Trusted_Connection=True;";
            string query = "UPDATE Apply_Leave SET LeaveStatus = @LeaveStatus WHERE LeaveID = @LeaveID AND LeaveStatus = 'Pending'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LeaveStatus", newStatus);
                command.Parameters.AddWithValue("@LeaveID", leaveID);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Leave status updated to " + newStatus);
                    LoadPendingLeaveRequests(); // Refresh the DataGridView after the update
                }
                else
                {
                    MessageBox.Show("No pending leave found for Leave ID: " + leaveID);
                }
            }
        }

        // TextChanged event for the Leave ID text box (if needed for future functionality)
        private void ID_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeaveRequestsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reject_btn_Click_1(object sender, EventArgs e)
        {
            string leaveID = ID_txt.Text.Trim(); // Get the LeaveID from the textbox
            if (!string.IsNullOrEmpty(leaveID))
            {
                UpdateLeaveStatus(leaveID, "Rejected"); // Call to update the leave status to Rejected
            }
            else
            {
                MessageBox.Show("Please enter a valid Leave ID.");
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
