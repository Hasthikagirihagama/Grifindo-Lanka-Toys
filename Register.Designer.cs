namespace Grifindo_Lanka_Toys
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            joined_datetxt = new DateTimePicker();
            label7 = new Label();
            Register_btn = new Button();
            button2 = new Button();
            label8 = new Label();
            usernametxt = new TextBox();
            passwordtxt = new TextBox();
            f_nametxt = new TextBox();
            l_nametxt = new TextBox();
            positiontxt = new TextBox();
            departmenttxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 90);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat Black", 25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(358, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 58);
            label1.TabIndex = 1;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(214, 89);
            label2.Name = "label2";
            label2.Size = new Size(119, 26);
            label2.TabIndex = 2;
            label2.Text = "Username ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(214, 137);
            label3.Name = "label3";
            label3.Size = new Size(108, 26);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(214, 185);
            label4.Name = "label4";
            label4.Size = new Size(119, 26);
            label4.TabIndex = 6;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(214, 235);
            label5.Name = "label5";
            label5.Size = new Size(117, 26);
            label5.TabIndex = 8;
            label5.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(214, 284);
            label6.Name = "label6";
            label6.Size = new Size(91, 26);
            label6.TabIndex = 10;
            label6.Text = "Position";
            // 
            // joined_datetxt
            // 
            joined_datetxt.Location = new Point(407, 377);
            joined_datetxt.Name = "joined_datetxt";
            joined_datetxt.Size = new Size(342, 27);
            joined_datetxt.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(214, 378);
            label7.Name = "label7";
            label7.Size = new Size(130, 26);
            label7.TabIndex = 13;
            label7.Text = "Joined Date";
            // 
            // Register_btn
            // 
            Register_btn.BackColor = Color.Black;
            Register_btn.Font = new Font("Montserrat SemiBold", 11F);
            Register_btn.ForeColor = Color.White;
            Register_btn.Location = new Point(214, 437);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(121, 45);
            Register_btn.TabIndex = 14;
            Register_btn.Text = "Register";
            Register_btn.UseVisualStyleBackColor = false;
            Register_btn.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Montserrat SemiBold", 11F);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(628, 437);
            button2.Name = "button2";
            button2.Size = new Size(121, 45);
            button2.TabIndex = 15;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(214, 330);
            label8.Name = "label8";
            label8.Size = new Size(134, 26);
            label8.TabIndex = 16;
            label8.Text = "Department";
            // 
            // usernametxt
            // 
            usernametxt.Font = new Font("Segoe UI", 12F);
            usernametxt.Location = new Point(407, 89);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(342, 34);
            usernametxt.TabIndex = 18;
            // 
            // passwordtxt
            // 
            passwordtxt.Font = new Font("Segoe UI", 12F);
            passwordtxt.Location = new Point(407, 137);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '*';
            passwordtxt.Size = new Size(342, 34);
            passwordtxt.TabIndex = 19;
            // 
            // f_nametxt
            // 
            f_nametxt.Font = new Font("Segoe UI", 12F);
            f_nametxt.Location = new Point(407, 185);
            f_nametxt.Name = "f_nametxt";
            f_nametxt.Size = new Size(342, 34);
            f_nametxt.TabIndex = 20;
            // 
            // l_nametxt
            // 
            l_nametxt.Font = new Font("Segoe UI", 12F);
            l_nametxt.Location = new Point(407, 235);
            l_nametxt.Name = "l_nametxt";
            l_nametxt.Size = new Size(342, 34);
            l_nametxt.TabIndex = 21;
            // 
            // positiontxt
            // 
            positiontxt.Font = new Font("Segoe UI", 12F);
            positiontxt.Location = new Point(407, 284);
            positiontxt.Name = "positiontxt";
            positiontxt.Size = new Size(342, 34);
            positiontxt.TabIndex = 22;
            // 
            // departmenttxt
            // 
            departmenttxt.Font = new Font("Segoe UI", 12F);
            departmenttxt.Location = new Point(407, 330);
            departmenttxt.Name = "departmenttxt";
            departmenttxt.Size = new Size(342, 34);
            departmenttxt.TabIndex = 23;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(851, 490);
            Controls.Add(departmenttxt);
            Controls.Add(positiontxt);
            Controls.Add(l_nametxt);
            Controls.Add(f_nametxt);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(Register_btn);
            Controls.Add(label7);
            Controls.Add(joined_datetxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker joined_datetxt;
        private Label label7;
        private Button Register_btn;
        private Button button2;
        private Label label8;
        private TextBox usernametxt;
        private TextBox passwordtxt;
        private TextBox f_nametxt;
        private TextBox l_nametxt;
        private TextBox positiontxt;
        private TextBox departmenttxt;
    }
}