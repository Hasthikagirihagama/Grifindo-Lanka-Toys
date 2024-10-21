namespace Grifindo_Lanka_Toys
{
    partial class Employee_View_Leave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_View_Leave));
            label1 = new Label();
            EmpID_txt = new TextBox();
            label2 = new Label();
            Back_btn = new Button();
            ViewHistory_btn = new Button();
            label4 = new Label();
            remainingShortLeaves_lbl = new TextBox();
            remainingAnnualLeaves_lbl = new TextBox();
            label3 = new Label();
            remainingCasualLeaves_lbl = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat Black", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(185, 9);
            label1.Name = "label1";
            label1.Size = new Size(446, 47);
            label1.TabIndex = 19;
            label1.Text = "Employee Leave Status";
            // 
            // EmpID_txt
            // 
            EmpID_txt.Font = new Font("Montserrat SemiBold", 10F);
            EmpID_txt.Location = new Point(272, 349);
            EmpID_txt.Name = "EmpID_txt";
            EmpID_txt.Size = new Size(251, 28);
            EmpID_txt.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(272, 322);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 21;
            label2.Text = "Enter ID";
            // 
            // Back_btn
            // 
            Back_btn.BackColor = Color.Black;
            Back_btn.Font = new Font("Montserrat SemiBold", 11F);
            Back_btn.ForeColor = Color.White;
            Back_btn.Location = new Point(687, 384);
            Back_btn.Name = "Back_btn";
            Back_btn.Size = new Size(101, 54);
            Back_btn.TabIndex = 22;
            Back_btn.Text = "Back";
            Back_btn.UseVisualStyleBackColor = false;
            // 
            // ViewHistory_btn
            // 
            ViewHistory_btn.BackColor = SystemColors.ActiveCaption;
            ViewHistory_btn.FlatAppearance.BorderColor = Color.Black;
            ViewHistory_btn.FlatAppearance.BorderSize = 3;
            ViewHistory_btn.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold);
            ViewHistory_btn.Location = new Point(291, 388);
            ViewHistory_btn.Name = "ViewHistory_btn";
            ViewHistory_btn.Size = new Size(199, 50);
            ViewHistory_btn.TabIndex = 23;
            ViewHistory_btn.Text = "View";
            ViewHistory_btn.UseVisualStyleBackColor = false;
            ViewHistory_btn.Click += ViewHistory_btn_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(112, 184);
            label4.Name = "label4";
            label4.Size = new Size(144, 27);
            label4.TabIndex = 26;
            label4.Text = "Short Leaves";
            // 
            // remainingShortLeaves_lbl
            // 
            remainingShortLeaves_lbl.Font = new Font("Montserrat SemiBold", 10F);
            remainingShortLeaves_lbl.Location = new Point(112, 225);
            remainingShortLeaves_lbl.Name = "remainingShortLeaves_lbl";
            remainingShortLeaves_lbl.Size = new Size(147, 28);
            remainingShortLeaves_lbl.TabIndex = 27;
            // 
            // remainingAnnualLeaves_lbl
            // 
            remainingAnnualLeaves_lbl.Font = new Font("Montserrat SemiBold", 10F);
            remainingAnnualLeaves_lbl.Location = new Point(327, 225);
            remainingAnnualLeaves_lbl.Name = "remainingAnnualLeaves_lbl";
            remainingAnnualLeaves_lbl.Size = new Size(163, 28);
            remainingAnnualLeaves_lbl.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(327, 184);
            label3.Name = "label3";
            label3.Size = new Size(163, 27);
            label3.TabIndex = 28;
            label3.Text = "Annual Leaves";
            // 
            // remainingCasualLeaves_lbl
            // 
            remainingCasualLeaves_lbl.Font = new Font("Montserrat SemiBold", 10F);
            remainingCasualLeaves_lbl.Location = new Point(540, 225);
            remainingCasualLeaves_lbl.Name = "remainingCasualLeaves_lbl";
            remainingCasualLeaves_lbl.Size = new Size(157, 28);
            remainingCasualLeaves_lbl.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(540, 184);
            label5.Name = "label5";
            label5.Size = new Size(157, 27);
            label5.TabIndex = 30;
            label5.Text = "Casual Leaves";
            // 
            // Employee_View_Leave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(remainingCasualLeaves_lbl);
            Controls.Add(label5);
            Controls.Add(remainingAnnualLeaves_lbl);
            Controls.Add(label3);
            Controls.Add(remainingShortLeaves_lbl);
            Controls.Add(label4);
            Controls.Add(ViewHistory_btn);
            Controls.Add(Back_btn);
            Controls.Add(label2);
            Controls.Add(EmpID_txt);
            Controls.Add(label1);
            Name = "Employee_View_Leave";
            Text = "Employee View Leave";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox EmpID_txt;
        private Label label2;
        private Button Back_btn;
        private Button ViewHistory_btn;
        private Label label4;
        private TextBox remainingShortLeaves_lbl;
        private TextBox remainingAnnualLeaves_lbl;
        private Label label3;
        private TextBox remainingCasualLeaves_lbl;
        private Label label5;
    }
}