namespace Grifindo_Lanka_Toys
{
    partial class Employee_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Login));
            label3 = new Label();
            login_btn = new Button();
            password = new TextBox();
            username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(124, 283);
            label3.Name = "label3";
            label3.Size = new Size(129, 29);
            label3.TabIndex = 12;
            label3.Text = "Passsword";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // login_btn
            // 
            login_btn.BackColor = SystemColors.ActiveCaption;
            login_btn.FlatAppearance.BorderColor = Color.Black;
            login_btn.FlatAppearance.BorderSize = 3;
            login_btn.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold);
            login_btn.Location = new Point(439, 368);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(120, 50);
            login_btn.TabIndex = 11;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 12F);
            password.Location = new Point(334, 279);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(342, 34);
            password.TabIndex = 10;
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 12F);
            username.Location = new Point(334, 185);
            username.Name = "username";
            username.Size = new Size(342, 34);
            username.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(124, 185);
            label2.Name = "label2";
            label2.Size = new Size(123, 29);
            label2.TabIndex = 8;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(275, 24);
            label1.Name = "label1";
            label1.Size = new Size(309, 49);
            label1.TabIndex = 7;
            label1.Text = "Welcome Back!";
            // 
            // Employee_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(874, 461);
            Controls.Add(label3);
            Controls.Add(login_btn);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Employee_Login";
            Text = "Employee_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button login_btn;
        private TextBox password;
        private TextBox username;
        private Label label2;
        private Label label1;
    }
}