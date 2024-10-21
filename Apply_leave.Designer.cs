namespace Grifindo_Lanka_Toys
{
    partial class Apply_leave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apply_leave));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Start_date = new DateTimePicker();
            End_date = new DateTimePicker();
            Leave_type = new ComboBox();
            Apply_btn = new Button();
            label5 = new Label();
            Emp_ID = new TextBox();
            Back_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat Black", 25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(198, 9);
            label1.Name = "label1";
            label1.Size = new Size(381, 58);
            label1.TabIndex = 2;
            label1.Text = "Apply for Leave";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(198, 160);
            label2.Name = "label2";
            label2.Size = new Size(127, 27);
            label2.TabIndex = 4;
            label2.Text = "Leave Type";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(198, 232);
            label3.Name = "label3";
            label3.Size = new Size(113, 26);
            label3.TabIndex = 6;
            label3.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(198, 307);
            label4.Name = "label4";
            label4.Size = new Size(104, 26);
            label4.TabIndex = 8;
            label4.Text = "End Date";
            // 
            // Start_date
            // 
            Start_date.CalendarFont = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Start_date.Location = new Point(198, 261);
            Start_date.Name = "Start_date";
            Start_date.Size = new Size(383, 27);
            Start_date.TabIndex = 9;
            // 
            // End_date
            // 
            End_date.CalendarFont = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            End_date.Location = new Point(198, 336);
            End_date.Name = "End_date";
            End_date.Size = new Size(383, 27);
            End_date.TabIndex = 10;
            // 
            // Leave_type
            // 
            Leave_type.AllowDrop = true;
            Leave_type.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Leave_type.FormattingEnabled = true;
            Leave_type.Location = new Point(198, 190);
            Leave_type.Name = "Leave_type";
            Leave_type.Size = new Size(383, 32);
            Leave_type.TabIndex = 11;
            Leave_type.SelectedIndexChanged += LeaveID_SelectedIndexChanged;
            // 
            // Apply_btn
            // 
            Apply_btn.BackColor = Color.Black;
            Apply_btn.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Apply_btn.ForeColor = Color.White;
            Apply_btn.Location = new Point(198, 382);
            Apply_btn.Name = "Apply_btn";
            Apply_btn.Size = new Size(130, 56);
            Apply_btn.TabIndex = 12;
            Apply_btn.Text = "Apply";
            Apply_btn.UseVisualStyleBackColor = false;
            Apply_btn.Click += Apply_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(198, 93);
            label5.Name = "label5";
            label5.Size = new Size(94, 27);
            label5.TabIndex = 13;
            label5.Text = "Emp. ID";
            // 
            // Emp_ID
            // 
            Emp_ID.Location = new Point(198, 129);
            Emp_ID.Name = "Emp_ID";
            Emp_ID.Size = new Size(127, 27);
            Emp_ID.TabIndex = 14;
            // 
            // Back_btn
            // 
            Back_btn.BackColor = Color.Black;
            Back_btn.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_btn.ForeColor = Color.White;
            Back_btn.Location = new Point(451, 382);
            Back_btn.Name = "Back_btn";
            Back_btn.Size = new Size(130, 56);
            Back_btn.TabIndex = 15;
            Back_btn.Text = "Back";
            Back_btn.UseVisualStyleBackColor = false;
            Back_btn.Click += Back_btn_Click;
            // 
            // Apply_leave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(Back_btn);
            Controls.Add(Emp_ID);
            Controls.Add(label5);
            Controls.Add(Apply_btn);
            Controls.Add(Leave_type);
            Controls.Add(End_date);
            Controls.Add(Start_date);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Apply_leave";
            Text = "Apply Leave";
            Load += Apply_leave_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker Start_date;
        private DateTimePicker End_date;
        private ComboBox Leave_type;
        private Button Apply_btn;
        private Label label5;
        private TextBox Emp_ID;
        private Button Back_btn;
    }
}