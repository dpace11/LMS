namespace LMS
{
    partial class AddTeachers
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
            label8 = new Label();
            panel2 = new Panel();
            btnTeachSaveInfo = new Button();
            cmbTeacherDepartment = new ComboBox();
            txtTeacherEmail = new TextBox();
            txtTeacherContact = new TextBox();
            txtTeacherRollNo = new TextBox();
            txtTeacherName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 110);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(218, 35);
            label8.Name = "label8";
            label8.Size = new Size(188, 37);
            label8.TabIndex = 0;
            label8.Text = "Add Teachers";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(btnTeachSaveInfo);
            panel2.Controls.Add(cmbTeacherDepartment);
            panel2.Controls.Add(txtTeacherEmail);
            panel2.Controls.Add(txtTeacherContact);
            panel2.Controls.Add(txtTeacherRollNo);
            panel2.Controls.Add(txtTeacherName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(221, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 334);
            panel2.TabIndex = 1;
            // 
            // btnTeachSaveInfo
            // 
            btnTeachSaveInfo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTeachSaveInfo.Location = new Point(317, 267);
            btnTeachSaveInfo.Name = "btnTeachSaveInfo";
            btnTeachSaveInfo.Size = new Size(115, 45);
            btnTeachSaveInfo.TabIndex = 6;
            btnTeachSaveInfo.Text = "Save Info";
            btnTeachSaveInfo.UseVisualStyleBackColor = true;
            btnTeachSaveInfo.Click += btnTeachSaveInfo_Click;
            // 
            // cmbTeacherDepartment
            // 
            cmbTeacherDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTeacherDepartment.FormattingEnabled = true;
            cmbTeacherDepartment.Items.AddRange(new object[] { "Architecture", "Civil", "Computer", "Electronics" });
            cmbTeacherDepartment.Location = new Point(183, 131);
            cmbTeacherDepartment.Name = "cmbTeacherDepartment";
            cmbTeacherDepartment.Size = new Size(249, 23);
            cmbTeacherDepartment.TabIndex = 3;
            // 
            // txtTeacherEmail
            // 
            txtTeacherEmail.Location = new Point(183, 216);
            txtTeacherEmail.Name = "txtTeacherEmail";
            txtTeacherEmail.Size = new Size(250, 23);
            txtTeacherEmail.TabIndex = 5;
            // 
            // txtTeacherContact
            // 
            txtTeacherContact.Location = new Point(183, 176);
            txtTeacherContact.Name = "txtTeacherContact";
            txtTeacherContact.Size = new Size(250, 23);
            txtTeacherContact.TabIndex = 4;
            // 
            // txtTeacherRollNo
            // 
            txtTeacherRollNo.Location = new Point(183, 84);
            txtTeacherRollNo.Name = "txtTeacherRollNo";
            txtTeacherRollNo.Size = new Size(250, 23);
            txtTeacherRollNo.TabIndex = 2;
            // 
            // txtTeacherName
            // 
            txtTeacherName.Location = new Point(183, 46);
            txtTeacherName.Name = "txtTeacherName";
            txtTeacherName.Size = new Size(250, 23);
            txtTeacherName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(36, 219);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 0;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(36, 179);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 0;
            label4.Text = "Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 134);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 0;
            label3.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 87);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 0;
            label2.Text = "Teacher Roll No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 46);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Teacher Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 243);
            label6.Name = "label6";
            label6.Size = new Size(166, 111);
            label6.TabIndex = 7;
            label6.Text = "You can add\r\nTeacher Info\r\nHere!!\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 168);
            label7.Name = "label7";
            label7.Size = new Size(148, 37);
            label7.TabIndex = 2;
            label7.Text = "WELCOME";
            // 
            // AddTeachers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 444);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddTeachers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTeachers";
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
        private Button btnTeachSaveInfo;
        private ComboBox cmbTeacherDepartment;
        private TextBox txtTeacherEmail;
        private TextBox txtTeacherContact;
        private TextBox txtTeacherRollNo;
        private TextBox txtTeacherName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}