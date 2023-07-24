namespace LMS
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            panel2 = new Panel();
            cmbDepartment = new ComboBox();
            txtStudentEmail = new TextBox();
            txtStudentContact = new TextBox();
            txtSemester = new TextBox();
            txtStudentRollNo = new TextBox();
            txtStudentName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnStudentSave = new Button();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 113);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(192, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(301, 49);
            label7.Name = "label7";
            label7.Size = new Size(177, 37);
            label7.TabIndex = 0;
            label7.Text = "Add Student";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(cmbDepartment);
            panel2.Controls.Add(txtStudentEmail);
            panel2.Controls.Add(txtStudentContact);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtStudentRollNo);
            panel2.Controls.Add(txtStudentName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnStudentSave);
            panel2.Location = new Point(215, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 331);
            panel2.TabIndex = 1;
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Computer", "Civil", "Electronics", "Architecture" });
            cmbDepartment.Location = new Point(192, 104);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(234, 23);
            cmbDepartment.TabIndex = 3;
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.Location = new Point(192, 212);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Size = new Size(234, 23);
            txtStudentEmail.TabIndex = 6;
            // 
            // txtStudentContact
            // 
            txtStudentContact.Location = new Point(192, 177);
            txtStudentContact.Name = "txtStudentContact";
            txtStudentContact.Size = new Size(234, 23);
            txtStudentContact.TabIndex = 5;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(192, 139);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(234, 23);
            txtSemester.TabIndex = 4;
            // 
            // txtStudentRollNo
            // 
            txtStudentRollNo.Location = new Point(192, 73);
            txtStudentRollNo.Name = "txtStudentRollNo";
            txtStudentRollNo.Size = new Size(234, 23);
            txtStudentRollNo.TabIndex = 2;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(192, 36);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(234, 23);
            txtStudentName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(35, 215);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 1;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 176);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 1;
            label5.Text = "Contact";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 142);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 1;
            label4.Text = "Semester";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 107);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 1;
            label3.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 73);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "College Roll No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 39);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "Student Name";
            // 
            // btnStudentSave
            // 
            btnStudentSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentSave.Location = new Point(345, 276);
            btnStudentSave.Name = "btnStudentSave";
            btnStudentSave.Size = new Size(81, 31);
            btnStudentSave.TabIndex = 7;
            btnStudentSave.Text = "Save Info";
            btnStudentSave.UseVisualStyleBackColor = true;
            btnStudentSave.Click += btnStudentSave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(27, 154);
            label8.Name = "label8";
            label8.Size = new Size(131, 32);
            label8.TabIndex = 2;
            label8.Text = "WELCOME\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 222);
            label9.Name = "label9";
            label9.Size = new Size(200, 60);
            label9.TabIndex = 3;
            label9.Text = "You can add\r\nStudent Info Here!!!\r\n";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 444);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label7;
        private Panel panel2;
        private ComboBox cmbDepartment;
        private TextBox txtStudentEmail;
        private TextBox txtStudentContact;
        private TextBox txtSemester;
        private TextBox txtStudentRollNo;
        private TextBox txtStudentName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnStudentSave;
        private Label label8;
        private Label label9;
    }
}