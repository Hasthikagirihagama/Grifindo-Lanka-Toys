namespace Grifindo_Lanka_Toys
{
    partial class Employee_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Dashboard));
            label2 = new Label();
            Logout_btn = new Button();
            Viewleave_btn = new Button();
            Applyleave_btn = new Button();
            label1 = new Label();
            Leavehistory_btn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat Black", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 15);
            label2.Name = "label2";
            label2.Size = new Size(225, 35);
            label2.TabIndex = 24;
            label2.Text = "Welcome Back!";
            // 
            // Logout_btn
            // 
            Logout_btn.BackColor = SystemColors.ActiveCaption;
            Logout_btn.FlatAppearance.BorderColor = Color.Black;
            Logout_btn.FlatAppearance.BorderSize = 3;
            Logout_btn.Font = new Font("Montserrat ExtraBold", 14F, FontStyle.Bold);
            Logout_btn.Location = new Point(419, 463);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(171, 76);
            Logout_btn.TabIndex = 23;
            Logout_btn.Text = "Logout";
            Logout_btn.UseVisualStyleBackColor = false;
            // 
            // Viewleave_btn
            // 
            Viewleave_btn.BackColor = Color.Black;
            Viewleave_btn.Font = new Font("Montserrat SemiBold", 13F);
            Viewleave_btn.ForeColor = Color.Transparent;
            Viewleave_btn.Location = new Point(394, 266);
            Viewleave_btn.Name = "Viewleave_btn";
            Viewleave_btn.Size = new Size(221, 85);
            Viewleave_btn.TabIndex = 22;
            Viewleave_btn.Text = "View Leave Status";
            Viewleave_btn.UseVisualStyleBackColor = false;
            // 
            // Applyleave_btn
            // 
            Applyleave_btn.BackColor = Color.Black;
            Applyleave_btn.Font = new Font("Montserrat SemiBold", 13F);
            Applyleave_btn.ForeColor = Color.White;
            Applyleave_btn.Location = new Point(173, 266);
            Applyleave_btn.Name = "Applyleave_btn";
            Applyleave_btn.Size = new Size(196, 85);
            Applyleave_btn.TabIndex = 21;
            Applyleave_btn.Text = "Apply for Leave";
            Applyleave_btn.UseVisualStyleBackColor = false;
            Applyleave_btn.Click += Register_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat Black", 27F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(237, 91);
            label1.Name = "label1";
            label1.Size = new Size(545, 62);
            label1.TabIndex = 20;
            label1.Text = "Employee Dashboard";
            label1.Click += label1_Click;
            // 
            // Leavehistory_btn
            // 
            Leavehistory_btn.BackColor = Color.Black;
            Leavehistory_btn.Font = new Font("Montserrat SemiBold", 13F);
            Leavehistory_btn.ForeColor = Color.White;
            Leavehistory_btn.Location = new Point(644, 266);
            Leavehistory_btn.Name = "Leavehistory_btn";
            Leavehistory_btn.Size = new Size(196, 85);
            Leavehistory_btn.TabIndex = 25;
            Leavehistory_btn.Text = "Leave History";
            Leavehistory_btn.UseVisualStyleBackColor = false;
            // 
            // Employee_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(989, 593);
            Controls.Add(Leavehistory_btn);
            Controls.Add(label2);
            Controls.Add(Logout_btn);
            Controls.Add(Viewleave_btn);
            Controls.Add(Applyleave_btn);
            Controls.Add(label1);
            Name = "Employee_Dashboard";
            Text = "Employee_Dashboard";
            Load += Employee_Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button Logout_btn;
        private Button Viewleave_btn;
        private Button Applyleave_btn;
        private Label label1;
        private Button Leavehistory_btn;
    }
}