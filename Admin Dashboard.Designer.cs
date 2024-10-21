namespace Grifindo_Lanka_Toys
{
    partial class Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            label1 = new Label();
            Leavestatus_btn = new Button();
            Register_btn = new Button();
            login_btn = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat Black", 27F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(272, 82);
            label1.Name = "label1";
            label1.Size = new Size(468, 62);
            label1.TabIndex = 2;
            label1.Text = "Admin Dashboard";
            label1.Click += label1_Click;
            // 
            // Leavestatus_btn
            // 
            Leavestatus_btn.BackColor = Color.Black;
            Leavestatus_btn.Font = new Font("Montserrat SemiBold", 13F);
            Leavestatus_btn.ForeColor = Color.Transparent;
            Leavestatus_btn.Location = new Point(521, 264);
            Leavestatus_btn.Name = "Leavestatus_btn";
            Leavestatus_btn.Size = new Size(221, 85);
            Leavestatus_btn.TabIndex = 17;
            Leavestatus_btn.Text = "Employee Leave Status";
            Leavestatus_btn.UseVisualStyleBackColor = false;
            Leavestatus_btn.Click += Leavestatus_btn_Click;
            // 
            // Register_btn
            // 
            Register_btn.BackColor = Color.Black;
            Register_btn.Font = new Font("Montserrat SemiBold", 13F);
            Register_btn.ForeColor = Color.White;
            Register_btn.Location = new Point(272, 264);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(221, 85);
            Register_btn.TabIndex = 16;
            Register_btn.Text = "Employee Registration";
            Register_btn.UseVisualStyleBackColor = false;
            Register_btn.Click += Register_btn_Click;
            // 
            // login_btn
            // 
            login_btn.BackColor = SystemColors.ActiveCaption;
            login_btn.FlatAppearance.BorderColor = Color.Black;
            login_btn.FlatAppearance.BorderSize = 3;
            login_btn.Font = new Font("Montserrat ExtraBold", 14F, FontStyle.Bold);
            login_btn.Location = new Point(398, 468);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(171, 76);
            login_btn.TabIndex = 18;
            login_btn.Text = "Logout";
            login_btn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat Black", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(225, 35);
            label2.TabIndex = 19;
            label2.Text = "Welcome Back!";
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(969, 556);
            Controls.Add(label2);
            Controls.Add(login_btn);
            Controls.Add(Leavestatus_btn);
            Controls.Add(Register_btn);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Dashboard";
            Text = "Admin Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Leavestatus_btn;
        private Button Register_btn;
        private Button login_btn;
        private Label label2;
    }
}