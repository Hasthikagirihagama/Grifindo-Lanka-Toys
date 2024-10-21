namespace Grifindo_Lanka_Toys
{
    partial class Admin_Roaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Roaster));
            Emp_ID = new TextBox();
            label5 = new Label();
            label1 = new Label();
            End_time = new DateTimePicker();
            Start_time = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            Back_btn = new Button();
            Apply_btn = new Button();
            SuspendLayout();
            // 
            // Emp_ID
            // 
            Emp_ID.Location = new Point(307, 146);
            Emp_ID.Name = "Emp_ID";
            Emp_ID.Size = new Size(210, 27);
            Emp_ID.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat SemiBold", 15F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(347, 97);
            label5.Name = "label5";
            label5.Size = new Size(117, 35);
            label5.TabIndex = 16;
            label5.Text = "Emp. ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat Black", 25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(208, 9);
            label1.Name = "label1";
            label1.Size = new Size(430, 58);
            label1.TabIndex = 15;
            label1.Text = "Add Roaster Time";
            // 
            // End_time
            // 
            End_time.CalendarFont = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            End_time.CustomFormat = "yyyy-MM-dd HH:mm";
            End_time.Location = new Point(208, 324);
            End_time.Name = "End_time";
            End_time.Size = new Size(383, 27);
            End_time.TabIndex = 21;
            // 
            // Start_time
            // 
            Start_time.CalendarFont = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Start_time.CustomFormat = "yyyy-MM-dd HH:mm";
            Start_time.Location = new Point(208, 249);
            Start_time.Name = "Start_time";
            Start_time.Size = new Size(383, 27);
            Start_time.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(347, 295);
            label4.Name = "label4";
            label4.Size = new Size(104, 26);
            label4.TabIndex = 19;
            label4.Text = "End Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(347, 208);
            label3.Name = "label3";
            label3.Size = new Size(113, 26);
            label3.TabIndex = 18;
            label3.Text = "Start Time";
            // 
            // Back_btn
            // 
            Back_btn.BackColor = Color.Black;
            Back_btn.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_btn.ForeColor = Color.White;
            Back_btn.Location = new Point(461, 382);
            Back_btn.Name = "Back_btn";
            Back_btn.Size = new Size(130, 56);
            Back_btn.TabIndex = 23;
            Back_btn.Text = "Back";
            Back_btn.UseVisualStyleBackColor = false;
            Back_btn.Click += Back_btn_Click;
            // 
            // Apply_btn
            // 
            Apply_btn.BackColor = Color.Black;
            Apply_btn.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Apply_btn.ForeColor = Color.White;
            Apply_btn.Location = new Point(208, 382);
            Apply_btn.Name = "Apply_btn";
            Apply_btn.Size = new Size(130, 56);
            Apply_btn.TabIndex = 22;
            Apply_btn.Text = "Apply";
            Apply_btn.UseVisualStyleBackColor = false;
            Apply_btn.Click += Apply_btn_Click;
            // 
            // Admin_Roaster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Back_btn);
            Controls.Add(Apply_btn);
            Controls.Add(End_time);
            Controls.Add(Start_time);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Emp_ID);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Admin_Roaster";
            Text = "Admin Add Roaster";
            Load += Admin_Roaster_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Emp_ID;
        private Label label5;
        private Label label1;
        private DateTimePicker End_time;
        private DateTimePicker Start_time;
        private Label label4;
        private Label label3;
        private Button Back_btn;
        private Button Apply_btn;
    }
}