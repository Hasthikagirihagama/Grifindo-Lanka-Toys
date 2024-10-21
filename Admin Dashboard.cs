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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            Register registerpage = new Register();

            registerpage.Show();
            this.Hide();
        }

        private void Leavestatus_btn_Click(object sender, EventArgs e)
        {
            View_Leave_Status view_Leave_Status = new View_Leave_Status();
            view_Leave_Status.Show();
            this.Hide();
        }
    }
}
