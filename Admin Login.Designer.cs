namespace Grifindo_Lanka_Toys
{
    partial class Admin_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            label1 = new Label();
            label2 = new Label();
            username = new TextBox();
            password = new TextBox();
            login_btn = new Button();
            label3 = new Label();
            Adminregister_btn = new Button();
            Back_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(324, 53);
            label1.Name = "label1";
            label1.Size = new Size(309, 49);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(114, 205);
            label2.Name = "label2";
            label2.Size = new Size(123, 29);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 12F);
            username.Location = new Point(324, 205);
            username.Name = "username";
            username.Size = new Size(342, 34);
            username.TabIndex = 2;
            username.TextChanged += username_TextChanged;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 12F);
            password.Location = new Point(324, 299);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(342, 34);
            password.TabIndex = 4;
            // 
            // login_btn
            // 
            login_btn.BackColor = SystemColors.ActiveCaption;
            login_btn.FlatAppearance.BorderColor = Color.Black;
            login_btn.FlatAppearance.BorderSize = 3;
            login_btn.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold);
            login_btn.Location = new Point(429, 388);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(120, 50);
            login_btn.TabIndex = 5;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(114, 303);
            label3.Name = "label3";
            label3.Size = new Size(129, 29);
            label3.TabIndex = 6;
            label3.Text = "Passsword";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Adminregister_btn
            // 
            Adminregister_btn.BackColor = Color.Black;
            Adminregister_btn.FlatAppearance.BorderColor = Color.Black;
            Adminregister_btn.FlatAppearance.BorderSize = 3;
            Adminregister_btn.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold);
            Adminregister_btn.ForeColor = Color.White;
            Adminregister_btn.Location = new Point(12, 442);
            Adminregister_btn.Name = "Adminregister_btn";
            Adminregister_btn.Size = new Size(120, 50);
            Adminregister_btn.TabIndex = 7;
            Adminregister_btn.Text = "Register";
            Adminregister_btn.UseVisualStyleBackColor = false;
            Adminregister_btn.Click += Adminregister_btn_Click;
            // 
            // Back_btn
            // 
            Back_btn.BackColor = Color.Transparent;
            Back_btn.FlatAppearance.BorderColor = Color.Black;
            Back_btn.FlatAppearance.BorderSize = 3;
            Back_btn.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold);
            Back_btn.ForeColor = Color.Black;
            Back_btn.Location = new Point(835, 455);
            Back_btn.Name = "Back_btn";
            Back_btn.Size = new Size(97, 37);
            Back_btn.TabIndex = 8;
            Back_btn.Text = "Back";
            Back_btn.UseVisualStyleBackColor = false;
            Back_btn.Click += Back_btn_Click;
            // 
            // Admin_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(944, 504);
            Controls.Add(Back_btn);
            Controls.Add(Adminregister_btn);
            Controls.Add(label3);
            Controls.Add(login_btn);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Login";
            Text = "Admin | Welcome Back!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username;
        private TextBox password;
        private Button login_btn;
        private Label label3;
        private Button Adminregister_btn;
        private Button Back_btn;
    }
}
