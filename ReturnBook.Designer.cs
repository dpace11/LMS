namespace LMS
{
    partial class ReturnBook
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
            gridBookDetails = new DataGridView();
            txtNameReturn = new TextBox();
            txtViewHistory = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panelBookReturnDetail = new Panel();
            button2 = new Button();
            btnReturnBook = new Button();
            txtIssueDate = new TextBox();
            txtBookName = new TextBox();
            txtName = new TextBox();
            txtTxnId = new TextBox();
            txtRollNo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridBookDetails).BeginInit();
            panelBookReturnDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 109);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(362, 41);
            label1.Name = "label1";
            label1.Size = new Size(176, 37);
            label1.TabIndex = 0;
            label1.Text = "Return Book";
            label1.Click += label1_Click;
            // 
            // gridBookDetails
            // 
            gridBookDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridBookDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBookDetails.Location = new Point(3, 146);
            gridBookDetails.Name = "gridBookDetails";
            gridBookDetails.RowTemplate.Height = 25;
            gridBookDetails.Size = new Size(629, 295);
            gridBookDetails.TabIndex = 1;
            gridBookDetails.CellClick += gridBookDetails_CellClick;
            gridBookDetails.CellContentClick += gridBookDetails_CellContentClick;
            // 
            // txtNameReturn
            // 
            txtNameReturn.Location = new Point(101, 118);
            txtNameReturn.Name = "txtNameReturn";
            txtNameReturn.Size = new Size(166, 23);
            txtNameReturn.TabIndex = 2;
            txtNameReturn.TextChanged += txtRollNoReturn_TextChanged;
            // 
            // txtViewHistory
            // 
            txtViewHistory.Location = new Point(442, 118);
            txtViewHistory.Name = "txtViewHistory";
            txtViewHistory.Size = new Size(203, 23);
            txtViewHistory.TabIndex = 2;
            txtViewHistory.TextChanged += txtViewHistory_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 118);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(324, 118);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 3;
            label3.Text = "View History ";
            // 
            // panelBookReturnDetail
            // 
            panelBookReturnDetail.BackColor = Color.PowderBlue;
            panelBookReturnDetail.Controls.Add(button2);
            panelBookReturnDetail.Controls.Add(btnReturnBook);
            panelBookReturnDetail.Controls.Add(txtIssueDate);
            panelBookReturnDetail.Controls.Add(txtBookName);
            panelBookReturnDetail.Controls.Add(txtName);
            panelBookReturnDetail.Controls.Add(txtTxnId);
            panelBookReturnDetail.Controls.Add(txtRollNo);
            panelBookReturnDetail.Controls.Add(label7);
            panelBookReturnDetail.Controls.Add(label6);
            panelBookReturnDetail.Controls.Add(label8);
            panelBookReturnDetail.Controls.Add(label5);
            panelBookReturnDetail.Controls.Add(label4);
            panelBookReturnDetail.Location = new Point(638, 146);
            panelBookReturnDetail.Name = "panelBookReturnDetail";
            panelBookReturnDetail.Size = new Size(373, 295);
            panelBookReturnDetail.TabIndex = 4;
            panelBookReturnDetail.Paint += panelBookReturnDetail_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(229, 259);
            button2.Name = "button2";
            button2.Size = new Size(117, 33);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnReturnBook
            // 
            btnReturnBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturnBook.Location = new Point(21, 259);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(137, 33);
            btnReturnBook.TabIndex = 2;
            btnReturnBook.Text = "Return Book";
            btnReturnBook.UseVisualStyleBackColor = true;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // txtIssueDate
            // 
            txtIssueDate.Location = new Point(135, 217);
            txtIssueDate.Name = "txtIssueDate";
            txtIssueDate.ReadOnly = true;
            txtIssueDate.Size = new Size(211, 23);
            txtIssueDate.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(135, 166);
            txtBookName.Name = "txtBookName";
            txtBookName.ReadOnly = true;
            txtBookName.Size = new Size(211, 23);
            txtBookName.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 115);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(211, 23);
            txtName.TabIndex = 1;
            // 
            // txtTxnId
            // 
            txtTxnId.Location = new Point(135, 18);
            txtTxnId.Name = "txtTxnId";
            txtTxnId.ReadOnly = true;
            txtTxnId.Size = new Size(211, 23);
            txtTxnId.TabIndex = 1;
            // 
            // txtRollNo
            // 
            txtRollNo.Location = new Point(135, 69);
            txtRollNo.Name = "txtRollNo";
            txtRollNo.ReadOnly = true;
            txtRollNo.Size = new Size(211, 23);
            txtRollNo.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(21, 118);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 0;
            label7.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(21, 219);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 0;
            label6.Text = "Issue Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(21, 16);
            label8.Name = "label8";
            label8.Size = new Size(58, 21);
            label8.TabIndex = 0;
            label8.Text = "Txn ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 168);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 0;
            label5.Text = "Book Name";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 67);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 0;
            label4.Text = "Roll No";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(900, 116);
            button1.Name = "button1";
            button1.Size = new Size(102, 25);
            button1.TabIndex = 5;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 443);
            Controls.Add(button1);
            Controls.Add(panelBookReturnDetail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtViewHistory);
            Controls.Add(txtNameReturn);
            Controls.Add(gridBookDetails);
            Controls.Add(panel1);
            Name = "ReturnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBook";
            Load += ReturnBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridBookDetails).EndInit();
            panelBookReturnDetail.ResumeLayout(false);
            panelBookReturnDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView gridBookDetails;
        private TextBox txtNameReturn;
        private TextBox txtViewHistory;
        private Label label2;
        private Label label3;
        private Panel panelBookReturnDetail;
        private Button button2;
        private Button btnReturnBook;
        private TextBox txtIssueDate;
        private TextBox txtBookName;
        private TextBox txtName;
        private TextBox txtTxnId;
        private TextBox txtRollNo;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label5;
        private Label label4;
        private Button button1;
    }
}