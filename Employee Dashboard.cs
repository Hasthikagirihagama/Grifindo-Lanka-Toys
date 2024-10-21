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
    public partial class Employee_Dashboard : Form
    {
        public Employee_Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            Apply_leave apply_Leave = new Apply_leave();
            apply_Leave.Show();
            this.Hide();
        }

        private void Employee_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
