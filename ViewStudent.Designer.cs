namespace LMS
{
    partial class ViewStudent
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
            label2 = new Label();
            txtStdNameSearch = new TextBox();
            btnRefresh = new Button();
            gridViewStudent = new DataGridView();
            panelStudView = new Panel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            cmbStudentDepartment = new ComboBox();
            txtStudentRollNo = new TextBox();
            txtStudentName = new TextBox();
            txtStudentEmail = new TextBox();
            txtStudentContact = new TextBox();
            txtStudentSemester = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewStudent).BeginInit();
            panelStudView.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 105);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(180, 39);
            label1.Name = "label1";
            label1.Size = new Size(271, 37);
            label1.TabIndex = 0;
            label1.Text = "View Student Detail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(143, 122);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // txtStdNameSearch
            // 
            txtStdNameSearch.Location = new Point(244, 120);
            txtStdNameSearch.Name = "txtStdNameSearch";
            txtStdNameSearch.Size = new Size(177, 23);
            txtStdNameSearch.TabIndex = 2;
            txtStdNameSearch.TextChanged += txtStdNameSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(437, 116);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(78, 27);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // gridViewStudent
            // 
            gridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewStudent.Location = new Point(8, 154);
            gridViewStudent.Name = "gridViewStudent";
            gridViewStudent.RowTemplate.Height = 25;
            gridViewStudent.Size = new Size(660, 264);
            gridViewStudent.TabIndex = 4;
            gridViewStudent.CellClick += gridViewStudent_CellClick;
            gridViewStudent.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panelStudView
            // 
            panelStudView.BackColor = SystemColors.ScrollBar;
            panelStudView.Controls.Add(btnCancel);
            panelStudView.Controls.Add(btnDelete);
            panelStudView.Controls.Add(btnUpdate);
            panelStudView.Controls.Add(cmbStudentDepartment);
            panelStudView.Controls.Add(txtStudentRollNo);
            panelStudView.Controls.Add(txtStudentName);
            panelStudView.Controls.Add(txtStudentEmail);
            panelStudView.Controls.Add(txtStudentContact);
            panelStudView.Controls.Add(txtStudentSemester);
            panelStudView.Controls.Add(label7);
            panelStudView.Controls.Add(label8);
            panelStudView.Controls.Add(label6);
            panelStudView.Controls.Add(label5);
            panelStudView.Controls.Add(label4);
            panelStudView.Controls.Add(label3);
            panelStudView.Location = new Point(8, 424);
            panelStudView.Name = "panelStudView";
            panelStudView.Size = new Size(657, 211);
            panelStudView.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(389, 157);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 42);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(232, 157);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 42);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(65, 157);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 42);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbStudentDepartment
            // 
            cmbStudentDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentDepartment.FormattingEnabled = true;
            cmbStudentDepartment.Items.AddRange(new object[] { "Architecture", "Civil", "Computer", "Electronics" });
            cmbStudentDepartment.Location = new Point(112, 103);
            cmbStudentDepartment.Name = "cmbStudentDepartment";
            cmbStudentDepartment.Size = new Size(159, 23);
            cmbStudentDepartment.TabIndex = 3;
            // 
            // txtStudentRollNo
            // 
            txtStudentRollNo.Location = new Point(112, 64);
            txtStudentRollNo.Name = "txtStudentRollNo";
            txtStudentRollNo.Size = new Size(198, 23);
            txtStudentRollNo.TabIndex = 2;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(112, 25);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(198, 23);
            txtStudentName.TabIndex = 1;
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.Location = new Point(440, 103);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Size = new Size(198, 23);
            txtStudentEmail.TabIndex = 6;
            // 
            // txtStudentContact
            // 
            txtStudentContact.Location = new Point(440, 64);
            txtStudentContact.Name = "txtStudentContact";
            txtStudentContact.Size = new Size(198, 23);
            txtStudentContact.TabIndex = 5;
            // 
            // txtStudentSemester
            // 
            txtStudentSemester.Location = new Point(440, 25);
            txtStudentSemester.Name = "txtStudentSemester";
            txtStudentSemester.Size = new Size(198, 23);
            txtStudentSemester.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(342, 109);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 0;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(342, 70);
            label8.Name = "label8";
            label8.Size = new Size(55, 17);
            label8.TabIndex = 0;
            label8.Text = "Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(342, 31);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 0;
            label6.Text = "Semester";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 109);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 0;
            label5.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 70);
            label4.Name = "label4";
            label4.Size = new Size(102, 17);
            label4.TabIndex = 0;
            label4.Text = "Student RollNo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 31);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // ViewStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(684, 444);
            Controls.Add(panelStudView);
            Controls.Add(gridViewStudent);
            Controls.Add(btnRefresh);
            Controls.Add(txtStdNameSearch);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ViewStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudent";
            Load += ViewStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewStudent).EndInit();
            panelStudView.ResumeLayout(false);
            panelStudView.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtStdNameSearch;
        private Button btnRefresh;
        private DataGridView gridViewStudent;
        private Panel panelStudView;
        private ComboBox cmbStudentDepartment;
        private TextBox txtStudentRollNo;
        private TextBox txtStudentName;
        private TextBox txtStudentEmail;
        private TextBox txtStudentContact;
        private TextBox txtStudentSemester;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
    }
}