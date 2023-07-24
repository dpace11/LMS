namespace LMS
{
    partial class AddBooks
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
            label7 = new Label();
            panel2 = new Panel();
            txtRemQuantity = new TextBox();
            label9 = new Label();
            txtBookLoaction = new TextBox();
            label8 = new Label();
            dateBookPurchase = new DateTimePicker();
            btnSave = new Button();
            txtBookQuantity = new TextBox();
            txtPrice = new TextBox();
            txtPublicationName = new TextBox();
            txtAuthorName = new TextBox();
            txtBookName = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 107);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(241, 31);
            label7.Name = "label7";
            label7.Size = new Size(143, 37);
            label7.TabIndex = 0;
            label7.Text = "Add Books";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(txtRemQuantity);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtBookLoaction);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dateBookPurchase);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtBookQuantity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtPublicationName);
            panel2.Controls.Add(txtAuthorName);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 313);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txtRemQuantity
            // 
            txtRemQuantity.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtRemQuantity.Location = new Point(312, 229);
            txtRemQuantity.Name = "txtRemQuantity";
            txtRemQuantity.Size = new Size(259, 22);
            txtRemQuantity.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(124, 229);
            label9.Name = "label9";
            label9.Size = new Size(141, 16);
            label9.TabIndex = 9;
            label9.Text = "Remaining Quantity";
            // 
            // txtBookLoaction
            // 
            txtBookLoaction.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookLoaction.Location = new Point(312, 201);
            txtBookLoaction.Name = "txtBookLoaction";
            txtBookLoaction.Size = new Size(259, 22);
            txtBookLoaction.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(125, 201);
            label8.Name = "label8";
            label8.Size = new Size(106, 16);
            label8.TabIndex = 9;
            label8.Text = "Book Location";
            // 
            // dateBookPurchase
            // 
            dateBookPurchase.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateBookPurchase.Location = new Point(312, 142);
            dateBookPurchase.Name = "dateBookPurchase";
            dateBookPurchase.Size = new Size(261, 22);
            dateBookPurchase.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(312, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtBookQuantity
            // 
            txtBookQuantity.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookQuantity.Location = new Point(312, 170);
            txtBookQuantity.Name = "txtBookQuantity";
            txtBookQuantity.Size = new Size(260, 22);
            txtBookQuantity.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(313, 110);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(260, 22);
            txtPrice.TabIndex = 4;
            // 
            // txtPublicationName
            // 
            txtPublicationName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPublicationName.Location = new Point(313, 82);
            txtPublicationName.Name = "txtPublicationName";
            txtPublicationName.Size = new Size(260, 22);
            txtPublicationName.TabIndex = 3;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthorName.Location = new Point(313, 54);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(260, 22);
            txtAuthorName.TabIndex = 2;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookName.Location = new Point(313, 25);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(260, 22);
            txtBookName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(125, 170);
            label6.Name = "label6";
            label6.Size = new Size(103, 16);
            label6.TabIndex = 1;
            label6.Text = "Book Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(125, 113);
            label4.Name = "label4";
            label4.Size = new Size(83, 16);
            label4.TabIndex = 1;
            label4.Text = "Book Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(125, 60);
            label2.Name = "label2";
            label2.Size = new Size(140, 16);
            label2.TabIndex = 1;
            label2.Text = "Book Author Name ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(125, 142);
            label5.Name = "label5";
            label5.Size = new Size(149, 16);
            label5.TabIndex = 0;
            label5.Text = "Book Purchase Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(125, 88);
            label3.Name = "label3";
            label3.Size = new Size(124, 16);
            label3.TabIndex = 0;
            label3.Text = "Book Publication";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(125, 31);
            label1.Name = "label1";
            label1.Size = new Size(88, 16);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            label1.Click += label1_Click;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 428);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBooks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label7;
        private Button btnSave;
        private TextBox txtBookQuantity;
        private TextBox txtPrice;
        private TextBox txtPublicationName;
        private TextBox txtAuthorName;
        private TextBox txtBookName;
        private DateTimePicker dateBookPurchase;
        private TextBox txtBookLoaction;
        private Label label8;
        private TextBox txtRemQuantity;
        private Label label9;
    }
}