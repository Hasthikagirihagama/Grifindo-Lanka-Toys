﻿using System;
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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Login employee_Login = new Employee_Login();
            employee_Login.Show();

            this.Hide();
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            Admin_Login admin_Login = new Admin_Login();
            admin_Login.Show();
            this.Hide();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
