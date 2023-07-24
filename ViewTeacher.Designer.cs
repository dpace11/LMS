namespace LMS
{
    partial class ViewTeacher
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
            dataTeachersDetails = new DataGridView();
            panTeacherUpdate = new Panel();
            cmbTeacherDeparment = new ComboBox();
            txtTeachContact = new TextBox();
            txtTeacherEmail = new TextBox();
            txtTeacherName = new TextBox();
            txtTeacherRoll = new TextBox();
            btnCancel = new Button();
            button3 = new Button();
            btnDeleteteTeacher = new Button();
            btnUpdateTeacher = new Button();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTeachersDetails).BeginInit();
            panTeacherUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(168, 31);
            label1.Name = "label1";
            label1.Size = new Size(282, 37);
            label1.TabIndex = 0;
            label1.Text = "View Teachers Detail";
            // 
            // dataTeachersDetails
            // 
            dataTeachersDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTeachersDetails.Location = new Point(4, 140);
            dataTeachersDetails.Name = "dataTeachersDetails";
            dataTeachersDetails.RowTemplate.Height = 25;
            dataTeachersDetails.Size = new Size(671, 282);
            dataTeachersDetails.TabIndex = 1;
            dataTeachersDetails.CellClick += dataTeachersDetails_CellClick;
            // 
            // panTeacherUpdate
            // 
            panTeacherUpdate.BackColor = SystemColors.ActiveBorder;
            panTeacherUpdate.Controls.Add(cmbTeacherDeparment);
            panTeacherUpdate.Controls.Add(txtTeachContact);
            panTeacherUpdate.Controls.Add(txtTeacherEmail);
            panTeacherUpdate.Controls.Add(txtTeacherName);
            panTeacherUpdate.Controls.Add(txtTeacherRoll);
            panTeacherUpdate.Controls.Add(btnCancel);
            panTeacherUpdate.Controls.Add(button3);
            panTeacherUpdate.Controls.Add(btnDeleteteTeacher);
            panTeacherUpdate.Controls.Add(btnUpdateTeacher);
            panTeacherUpdate.Controls.Add(label5);
            panTeacherUpdate.Controls.Add(label6);
            panTeacherUpdate.Controls.Add(label4);
            panTeacherUpdate.Controls.Add(label3);
            panTeacherUpdate.Controls.Add(label2);
            panTeacherUpdate.Location = new Point(4, 450);
            panTeacherUpdate.Name = "panTeacherUpdate";
            panTeacherUpdate.Size = new Size(674, 224);
            panTeacherUpdate.TabIndex = 2;
            // 
            // cmbTeacherDeparment
            // 
            cmbTeacherDeparment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTeacherDeparment.FormattingEnabled = true;
            cmbTeacherDeparment.Items.AddRange(new object[] { "Architecture", "Civil", "Computer", "Electronics" });
            cmbTeacherDeparment.Location = new Point(146, 124);
            cmbTeacherDeparment.Name = "cmbTeacherDeparment";
            cmbTeacherDeparment.Size = new Size(171, 23);
            cmbTeacherDeparment.TabIndex = 3;
            // 
            // txtTeachContact
            // 
            txtTeachContact.Location = new Point(473, 29);
            txtTeachContact.Name = "txtTeachContact";
            txtTeachContact.Size = new Size(198, 23);
            txtTeachContact.TabIndex = 2;
            // 
            // txtTeacherEmail
            // 
            txtTeacherEmail.Location = new Point(473, 78);
            txtTeacherEmail.Name = "txtTeacherEmail";
            txtTeacherEmail.Size = new Size(198, 23);
            txtTeacherEmail.TabIndex = 2;
            // 
            // txtTeacherName
            // 
            txtTeacherName.Location = new Point(146, 72);
            txtTeacherName.Name = "txtTeacherName";
            txtTeacherName.Size = new Size(171, 23);
            txtTeacherName.TabIndex = 2;
            // 
            // txtTeacherRoll
            // 
            txtTeacherRoll.Location = new Point(146, 24);
            txtTeacherRoll.Name = "txtTeacherRoll";
            txtTeacherRoll.Size = new Size(171, 23);
            txtTeacherRoll.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(460, 180);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 33);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(460, 180);
            button3.Name = "button3";
            button3.Size = new Size(103, 33);
            button3.TabIndex = 1;
            button3.Text = "Save Changes";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnDeleteteTeacher
            // 
            btnDeleteteTeacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteteTeacher.Location = new Point(244, 180);
            btnDeleteteTeacher.Name = "btnDeleteteTeacher";
            btnDeleteteTeacher.Size = new Size(103, 33);
            btnDeleteteTeacher.TabIndex = 1;
            btnDeleteteTeacher.Text = "Delete";
            btnDeleteteTeacher.UseVisualStyleBackColor = true;
            btnDeleteteTeacher.Click += btnDeleteteTeacher_Click;
            // 
            // btnUpdateTeacher
            // 
            btnUpdateTeacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateTeacher.Location = new Point(46, 180);
            btnUpdateTeacher.Name = "btnUpdateTeacher";
            btnUpdateTeacher.Size = new Size(103, 33);
            btnUpdateTeacher.TabIndex = 1;
            btnUpdateTeacher.Text = "Update";
            btnUpdateTeacher.UseVisualStyleBackColor = true;
            btnUpdateTeacher.Click += btnUpdateTeacher_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 123);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 0;
            label5.Text = "Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(323, 77);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 0;
            label6.Text = "Teacher Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(323, 29);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 0;
            label4.Text = "Teacher Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 75);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 0;
            label3.Text = "Teacher Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 27);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 0;
            label2.Text = "Teacher Roll No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(106, 116);
            label7.Name = "label7";
            label7.Size = new Size(95, 17);
            label7.TabIndex = 3;
            label7.Text = "Teacher Name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(207, 114);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(191, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(404, 110);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 27);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ViewTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(684, 444);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearch);
            Controls.Add(label7);
            Controls.Add(panTeacherUpdate);
            Controls.Add(dataTeachersDetails);
            Controls.Add(panel1);
            Name = "ViewTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewTeacher";
            Load += ViewTeacher_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataTeachersDetails).EndInit();
            panTeacherUpdate.ResumeLayout(false);
            panTeacherUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataTeachersDetails;
        private Panel panTeacherUpdate;
        private Button btnCancel;
        private Button button3;
        private Button btnDeleteteTeacher;
        private Button btnUpdateTeacher;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbTeacherDeparment;
        private TextBox txtTeachContact;
        private TextBox txtTeacherEmail;
        private TextBox txtTeacherName;
        private TextBox txtTeacherRoll;
        private Label label6;
        private Label label7;
        private TextBox txtSearch;
        private Button btnRefresh;
    }
}