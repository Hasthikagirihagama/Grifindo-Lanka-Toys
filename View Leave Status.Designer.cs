namespace Grifindo_Lanka_Toys
{
    partial class View_Leave_Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Leave_Status));
            LeaveRequestsGridView = new DataGridView();
            Approve_btn = new Button();
            Reject_btn = new Button();
            Back_btn = new Button();
            label1 = new Label();
            ID_txt = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)LeaveRequestsGridView).BeginInit();
            SuspendLayout();
            // 
            // LeaveRequestsGridView
            // 
            LeaveRequestsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LeaveRequestsGridView.Location = new Point(95, 82);
            LeaveRequestsGridView.Name = "LeaveRequestsGridView";
            LeaveRequestsGridView.RowHeadersWidth = 51;
            LeaveRequestsGridView.Size = new Size(578, 214);
            LeaveRequestsGridView.TabIndex = 0;
            LeaveRequestsGridView.CellContentClick += LeaveRequestsGridView_CellContentClick;
            // 
            // Approve_btn
            // 
            Approve_btn.BackColor = Color.Black;
            Approve_btn.Font = new Font("Montserrat SemiBold", 11F);
            Approve_btn.ForeColor = Color.White;
            Approve_btn.Location = new Point(95, 380);
            Approve_btn.Name = "Approve_btn";
            Approve_btn.Size = new Size(166, 56);
            Approve_btn.TabIndex = 15;
            Approve_btn.Text = "Approve";
            Approve_btn.UseVisualStyleBackColor = false;
            Approve_btn.Click += Approve_btn_Click;
            // 
            // Reject_btn
            // 
            Reject_btn.BackColor = Color.Black;
            Reject_btn.Font = new Font("Montserrat SemiBold", 11F);
            Reject_btn.ForeColor = Color.White;
            Reject_btn.Location = new Point(297, 380);
            Reject_btn.Name = "Reject_btn";
            Reject_btn.Size = new Size(166, 56);
            Reject_btn.TabIndex = 16;
            Reject_btn.Text = "Reject";
            Reject_btn.UseVisualStyleBackColor = false;
            Reject_btn.Click += Reject_btn_Click_1;
            // 
            // Back_btn
            // 
            Back_btn.BackColor = Color.Black;
            Back_btn.Font = new Font("Montserrat SemiBold", 11F);
            Back_btn.ForeColor = Color.White;
            Back_btn.Location = new Point(507, 380);
            Back_btn.Name = "Back_btn";
            Back_btn.Size = new Size(166, 56);
            Back_btn.TabIndex = 17;
            Back_btn.Text = "Back";
            Back_btn.UseVisualStyleBackColor = false;
            Back_btn.Click += Back_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat Black", 25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(316, 58);
            label1.TabIndex = 18;
            label1.Text = "Leave Status";
            // 
            // ID_txt
            // 
            ID_txt.Font = new Font("Montserrat SemiBold", 10F);
            ID_txt.Location = new Point(255, 337);
            ID_txt.Name = "ID_txt";
            ID_txt.Size = new Size(251, 28);
            ID_txt.TabIndex = 19;
            ID_txt.TextChanged += ID_txt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(255, 310);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 20;
            label2.Text = "Enter ID";
            label2.Click += label2_Click;
            // 
            // View_Leave_Status
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(812, 460);
            Controls.Add(label2);
            Controls.Add(ID_txt);
            Controls.Add(label1);
            Controls.Add(Back_btn);
            Controls.Add(Reject_btn);
            Controls.Add(Approve_btn);
            Controls.Add(LeaveRequestsGridView);
            Name = "View_Leave_Status";
            Text = "View Leave Status";
            Load += View_Leave_Status_Load;
            ((System.ComponentModel.ISupportInitialize)LeaveRequestsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView LeaveRequestsGridView;
        private Button Approve_btn;
        private Button Reject_btn;
        private Button Back_btn;
        private Label label1;
        private TextBox ID_txt;
        private Label label2;
    }
}