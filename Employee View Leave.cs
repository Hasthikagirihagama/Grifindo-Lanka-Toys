using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grifindo_Lanka_Toys
{
    public partial class Employee_View_Leave : Form
    {
        public Employee_View_Leave()
        {
            InitializeComponent();
        }

        // Button click event to calculate and display remaining leaves
        private void ViewHistory_btn_Click(object sender, EventArgs e)
        {
            CalculateRemainingLeaves(); // Calculate remaining leaves on button click
            MessageBox.Show("Button clicked!");
        }

        // Function to calculate remaining leaves and display in text boxes or labels
        private void CalculateRemainingLeaves()
        {
            string connectionString = @"Server=HASTHIKA;Database=Griffindor Toys;Trusted_Connection=True;";
            string query = "SELECT LeaveType, COUNT(*) AS LeavesTaken FROM Apply_Leave WHERE EmpID = @EmpID AND LeaveStatus = 'Approved' GROUP BY LeaveType";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string empID = EmpID_txt.Text.Trim();
                    command.Parameters.AddWithValue("@EmpID", empID);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Define total leaves for each type
                    int totalAnnualLeaves = 14;
                    int totalCasualLeaves = 7;
                    int totalShortLeaves = 2; // Per month

                    int annualLeavesTaken = 0;
                    int casualLeavesTaken = 0;
                    int shortLeavesTaken = 0;

                    // Read the number of leaves taken for each type
                    while (reader.Read())
                    {
                        string leaveType = reader["LeaveType"].ToString();
                        int leavesTaken = Convert.ToInt32(reader["LeavesTaken"]);

                        switch (leaveType)
                        {
                            case "Annual Leave":
                                annualLeavesTaken = leavesTaken;
                                break;
                            case "Casual Leave":
                                casualLeavesTaken = leavesTaken;
                                break;
                            case "Short Leave":
                                shortLeavesTaken = leavesTaken;
                                break;
                        }
                    }

                    reader.Close();

                    // Calculate remaining leaves
                    int remainingAnnualLeaves = totalAnnualLeaves - annualLeavesTaken;
                    int remainingCasualLeaves = totalCasualLeaves - casualLeavesTaken;
                    int remainingShortLeaves = totalShortLeaves - shortLeavesTaken;

                    // Display the results in labels (ensure each label is unique)
                    //remainingAnnualLeaves_lbl.Text = $"Remaining Annual: {remainingAnnualLeaves}";
                    //remainingCasualLeaves_lbl.Text = $"Remaining Casual: {remainingCasualLeaves}";
                    //remainingShortLeaves_lbl.Text = $"Remaining Short: {remainingShortLeaves}";

                    remainingAnnualLeaves_lbl.Text = remainingAnnualLeaves.ToString();
                    remainingCasualLeaves_lbl.Text = remainingCasualLeaves.ToString();
                    remainingShortLeaves_lbl.Text = remainingShortLeaves.ToString();
                }
            }
        }

        private void ViewHistory_btn_Click_1(object sender, EventArgs e)
        {
            CalculateRemainingLeaves(); // Calculate remaining leaves on button click

        }
    }
}
