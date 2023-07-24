namespace LMS
{
    partial class ViewBook
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
            btnSearchRefresh = new Button();
            txtBookSearch = new TextBox();
            gridViewBook = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtQuantity = new TextBox();
            txtLocation = new TextBox();
            txtRemQuanity = new TextBox();
            txtPrice = new TextBox();
            txtPublicationName = new TextBox();
            txtAuthorName = new TextBox();
            txtBookName = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewBook).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 120);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(244, 42);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 0;
            label1.Text = "View Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(146, 128);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            // 
            // btnSearchRefresh
            // 
            btnSearchRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchRefresh.Location = new Point(418, 127);
            btnSearchRefresh.Name = "btnSearchRefresh";
            btnSearchRefresh.Size = new Size(81, 23);
            btnSearchRefresh.TabIndex = 2;
            btnSearchRefresh.Text = "Refresh";
            btnSearchRefresh.UseVisualStyleBackColor = true;
            btnSearchRefresh.Click += btnSearchRefresh_Click;
            // 
            // txtBookSearch
            // 
            txtBookSearch.Location = new Point(242, 127);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(170, 23);
            txtBookSearch.TabIndex = 3;
            txtBookSearch.TextChanged += txtBookSearch_TextChanged;
            // 
            // gridViewBook
            // 
            gridViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewBook.Location = new Point(0, 156);
            gridViewBook.Name = "gridViewBook";
            gridViewBook.RowTemplate.Height = 25;
            gridViewBook.Size = new Size(686, 270);
            gridViewBook.TabIndex = 4;
            gridViewBook.CellClick += gridViewBook_CellClick;
            gridViewBook.CellContentClick += gridViewBook_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtLocation);
            panel2.Controls.Add(txtRemQuanity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtPublicationName);
            panel2.Controls.Add(txtAuthorName);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 432);
            panel2.Name = "panel2";
            panel2.Size = new Size(686, 237);
            panel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(551, 186);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 33);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(448, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 33);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(342, 186);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 33);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(470, 17);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(161, 23);
            txtQuantity.TabIndex = 6;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(470, 64);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(161, 23);
            txtLocation.TabIndex = 7;
            // 
            // txtRemQuanity
            // 
            txtRemQuanity.Location = new Point(470, 105);
            txtRemQuanity.Name = "txtRemQuanity";
            txtRemQuanity.Size = new Size(161, 23);
            txtRemQuanity.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(119, 155);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(202, 23);
            txtPrice.TabIndex = 4;
            // 
            // txtPublicationName
            // 
            txtPublicationName.Location = new Point(119, 113);
            txtPublicationName.Name = "txtPublicationName";
            txtPublicationName.Size = new Size(202, 23);
            txtPublicationName.TabIndex = 3;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(119, 60);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(202, 23);
            txtAuthorName.TabIndex = 2;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(120, 17);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(202, 23);
            txtBookName.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(348, 17);
            label9.Name = "label9";
            label9.Size = new Size(62, 17);
            label9.TabIndex = 0;
            label9.Text = "Quantity";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(353, 111);
            label10.Name = "label10";
            label10.Size = new Size(115, 17);
            label10.TabIndex = 0;
            label10.Text = "Remaining Books";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(352, 70);
            label7.Name = "label7";
            label7.Size = new Size(61, 17);
            label7.TabIndex = 0;
            label7.Text = "Location";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 161);
            label6.Name = "label6";
            label6.Size = new Size(38, 17);
            label6.TabIndex = 0;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 119);
            label5.Name = "label5";
            label5.Size = new Size(78, 17);
            label5.TabIndex = 0;
            label5.Text = "Publication";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 66);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 0;
            label4.Text = "Author Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 17);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 0;
            label3.Text = "Book Name";
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(684, 444);
            Controls.Add(panel2);
            Controls.Add(gridViewBook);
            Controls.Add(txtBookSearch);
            Controls.Add(btnSearchRefresh);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ViewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBook";
            Load += ViewBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewBook).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnSearchRefresh;
        private TextBox txtBookSearch;
        private DataGridView gridViewBook;
        private Panel panel2;
        private TextBox txtBookName;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtQuantity;
        private TextBox txtLocation;
        private TextBox txtPrice;
        private TextBox txtPublicationName;
        private TextBox txtAuthorName;
        private TextBox txtRemQuanity;
        private Label label10;
    }
}