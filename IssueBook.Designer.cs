namespace LMS
{
    partial class IssueBook
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            cmbBookName = new ComboBox();
            btnIssueDate = new Button();
            dateIssueDate = new DateTimePicker();
            txtDepartment = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtRollNo = new TextBox();
            txtName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSearchRoll = new TextBox();
            btnSearchDetails = new Button();
            btnRefresh = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 121);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(226, 46);
            label1.Name = "label1";
            label1.Size = new Size(154, 37);
            label1.TabIndex = 0;
            label1.Text = "Issue Book";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(cmbBookName);
            panel2.Controls.Add(btnIssueDate);
            panel2.Controls.Add(dateIssueDate);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtRollNo);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(257, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 316);
            panel2.TabIndex = 1;
            // 
            // cmbBookName
            // 
            cmbBookName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBookName.FormattingEnabled = true;
            cmbBookName.Location = new Point(169, 184);
            cmbBookName.Name = "cmbBookName";
            cmbBookName.Size = new Size(229, 23);
            cmbBookName.TabIndex = 9;
            // 
            // btnIssueDate
            // 
            btnIssueDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIssueDate.Location = new Point(146, 254);
            btnIssueDate.Name = "btnIssueDate";
            btnIssueDate.Size = new Size(104, 40);
            btnIssueDate.TabIndex = 11;
            btnIssueDate.Text = "Issue Book";
            btnIssueDate.UseVisualStyleBackColor = true;
            btnIssueDate.Click += btnIssueDate_Click;
            // 
            // dateIssueDate
            // 
            dateIssueDate.Location = new Point(169, 216);
            dateIssueDate.Name = "dateIssueDate";
            dateIssueDate.Size = new Size(229, 23);
            dateIssueDate.TabIndex = 10;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(169, 151);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(229, 23);
            txtDepartment.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(169, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(229, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(169, 81);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(229, 23);
            txtContact.TabIndex = 6;
            // 
            // txtRollNo
            // 
            txtRollNo.Location = new Point(169, 47);
            txtRollNo.Name = "txtRollNo";
            txtRollNo.ReadOnly = true;
            txtRollNo.Size = new Size(229, 23);
            txtRollNo.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(169, 16);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(229, 23);
            txtName.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(28, 219);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 0;
            label9.Text = "Book Issue Date";
            label9.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 187);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 0;
            label8.Text = "Book Name";
            label8.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 154);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 0;
            label7.Text = "Department";
            label7.Click += label6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 117);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 0;
            label6.Text = "Email";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 84);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 0;
            label5.Text = "Contact";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 50);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 0;
            label4.Text = "College Roll No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 19);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 0;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 233);
            label2.Name = "label2";
            label2.Size = new Size(226, 32);
            label2.TabIndex = 2;
            label2.Text = "Enter Roll Number";
            // 
            // txtSearchRoll
            // 
            txtSearchRoll.Location = new Point(44, 281);
            txtSearchRoll.Name = "txtSearchRoll";
            txtSearchRoll.Size = new Size(158, 23);
            txtSearchRoll.TabIndex = 3;
            // 
            // btnSearchDetails
            // 
            btnSearchDetails.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchDetails.Location = new Point(53, 328);
            btnSearchDetails.Name = "btnSearchDetails";
            btnSearchDetails.Size = new Size(140, 37);
            btnSearchDetails.TabIndex = 4;
            btnSearchDetails.Text = "Search RollNo";
            btnSearchDetails.UseVisualStyleBackColor = true;
            btnSearchDetails.Click += btnSearchDetails_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(53, 380);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 34);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 444);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearchDetails);
            Controls.Add(txtSearchRoll);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBook";
            Load += IssueBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSearchRoll;
        private Button btnSearchDetails;
        private Button btnRefresh;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtRollNo;
        private TextBox txtName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnIssueDate;
        private DateTimePicker dateIssueDate;
        private TextBox txtDepartment;
        private ComboBox cmbBookName;
    }
}