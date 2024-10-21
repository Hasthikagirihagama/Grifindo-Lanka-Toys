namespace Grifindo_Lanka_Toys
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            emp_btn = new Button();
            admin_btn = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat Black", 25F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(290, 147);
            label1.Name = "label1";
            label1.Size = new Size(253, 58);
            label1.TabIndex = 1;
            label1.Text = "Welcome!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(315, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 130);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat ExtraBold", 15F);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(335, 224);
            label2.Name = "label2";
            label2.Size = new Size(166, 35);
            label2.TabIndex = 3;
            label2.Text = "Are You an ";
            // 
            // emp_btn
            // 
            emp_btn.BackColor = SystemColors.ActiveCaption;
            emp_btn.Font = new Font("Montserrat ExtraBold", 13F, FontStyle.Bold);
            emp_btn.Location = new Point(210, 290);
            emp_btn.Name = "emp_btn";
            emp_btn.Size = new Size(149, 54);
            emp_btn.TabIndex = 4;
            emp_btn.Text = "Employee";
            emp_btn.UseVisualStyleBackColor = false;
            emp_btn.Click += button1_Click;
            // 
            // admin_btn
            // 
            admin_btn.BackColor = SystemColors.ActiveCaption;
            admin_btn.Font = new Font("Montserrat ExtraBold", 13F);
            admin_btn.Location = new Point(485, 290);
            admin_btn.Name = "admin_btn";
            admin_btn.Size = new Size(133, 54);
            admin_btn.TabIndex = 5;
            admin_btn.Text = "Admin";
            admin_btn.UseVisualStyleBackColor = false;
            admin_btn.Click += admin_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat ExtraBold", 15F);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(388, 309);
            label3.Name = "label3";
            label3.Size = new Size(54, 35);
            label3.TabIndex = 6;
            label3.Text = "OR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat Black", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(315, 379);
            label4.Name = "label4";
            label4.Size = new Size(204, 27);
            label4.TabIndex = 7;
            label4.Text = "Choose Your Role";
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(846, 481);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(admin_btn);
            Controls.Add(emp_btn);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Start";
            Text = "Start";
            Load += Start_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button emp_btn;
        private Button admin_btn;
        private Label label3;
        private Label label4;
    }
}