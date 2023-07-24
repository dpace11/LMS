namespace LMS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addBooksToolStripMenuItem = new ToolStripMenuItem();
            viewBookDetailsToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentDetailsToolStripMenuItem = new ToolStripMenuItem();
            teachersToolStripMenuItem = new ToolStripMenuItem();
            addTeachersToolStripMenuItem = new ToolStripMenuItem();
            viewTeacherDetailsToolStripMenuItem = new ToolStripMenuItem();
            issueBookToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentToolStripMenuItem, teachersToolStripMenuItem, issueBookToolStripMenuItem, returnBooksToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackColor = Color.LightGray;
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBooksToolStripMenuItem, viewBookDetailsToolStripMenuItem });
            booksToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(114, 54);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addBooksToolStripMenuItem
            // 
            addBooksToolStripMenuItem.Image = (Image)resources.GetObject("addBooksToolStripMenuItem.Image");
            addBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            addBooksToolStripMenuItem.Size = new Size(238, 56);
            addBooksToolStripMenuItem.Text = "Add Books";
            addBooksToolStripMenuItem.Click += addBooksToolStripMenuItem_Click;
            // 
            // viewBookDetailsToolStripMenuItem
            // 
            viewBookDetailsToolStripMenuItem.Image = (Image)resources.GetObject("viewBookDetailsToolStripMenuItem.Image");
            viewBookDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewBookDetailsToolStripMenuItem.Name = "viewBookDetailsToolStripMenuItem";
            viewBookDetailsToolStripMenuItem.Size = new Size(238, 56);
            viewBookDetailsToolStripMenuItem.Text = "View Book Details";
            viewBookDetailsToolStripMenuItem.Click += viewBookDetailsToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.BackColor = Color.LightGray;
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentDetailsToolStripMenuItem });
            studentToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            studentToolStripMenuItem.Image = (Image)resources.GetObject("studentToolStripMenuItem.Image");
            studentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(126, 54);
            studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Image = (Image)resources.GetObject("addStudentToolStripMenuItem.Image");
            addStudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(257, 56);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // viewStudentDetailsToolStripMenuItem
            // 
            viewStudentDetailsToolStripMenuItem.Image = (Image)resources.GetObject("viewStudentDetailsToolStripMenuItem.Image");
            viewStudentDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewStudentDetailsToolStripMenuItem.Name = "viewStudentDetailsToolStripMenuItem";
            viewStudentDetailsToolStripMenuItem.Size = new Size(257, 56);
            viewStudentDetailsToolStripMenuItem.Text = "View Student Details";
            viewStudentDetailsToolStripMenuItem.Click += viewStudentDetailsToolStripMenuItem_Click;
            // 
            // teachersToolStripMenuItem
            // 
            teachersToolStripMenuItem.BackColor = Color.LightGray;
            teachersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTeachersToolStripMenuItem, viewTeacherDetailsToolStripMenuItem });
            teachersToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            teachersToolStripMenuItem.Image = (Image)resources.GetObject("teachersToolStripMenuItem.Image");
            teachersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            teachersToolStripMenuItem.Size = new Size(132, 54);
            teachersToolStripMenuItem.Text = "Teachers";
            // 
            // addTeachersToolStripMenuItem
            // 
            addTeachersToolStripMenuItem.Image = (Image)resources.GetObject("addTeachersToolStripMenuItem.Image");
            addTeachersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addTeachersToolStripMenuItem.Name = "addTeachersToolStripMenuItem";
            addTeachersToolStripMenuItem.Size = new Size(256, 56);
            addTeachersToolStripMenuItem.Text = "Add Teachers";
            addTeachersToolStripMenuItem.Click += addTeachersToolStripMenuItem_Click;
            // 
            // viewTeacherDetailsToolStripMenuItem
            // 
            viewTeacherDetailsToolStripMenuItem.Image = (Image)resources.GetObject("viewTeacherDetailsToolStripMenuItem.Image");
            viewTeacherDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewTeacherDetailsToolStripMenuItem.Name = "viewTeacherDetailsToolStripMenuItem";
            viewTeacherDetailsToolStripMenuItem.Size = new Size(256, 56);
            viewTeacherDetailsToolStripMenuItem.Text = "View Teacher Details";
            viewTeacherDetailsToolStripMenuItem.Click += viewTeacherDetailsToolStripMenuItem_Click;
            // 
            // issueBookToolStripMenuItem
            // 
            issueBookToolStripMenuItem.BackColor = Color.LightGray;
            issueBookToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            issueBookToolStripMenuItem.Image = (Image)resources.GetObject("issueBookToolStripMenuItem.Image");
            issueBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            issueBookToolStripMenuItem.Size = new Size(147, 54);
            issueBookToolStripMenuItem.Text = "Issue Book";
            issueBookToolStripMenuItem.Click += issueBookToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.BackColor = Color.LightGray;
            returnBooksToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(166, 54);
            returnBooksToolStripMenuItem.Text = "Return Books";
            returnBooksToolStripMenuItem.Click += returnBooksToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.LightGray;
            exitToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(97, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addBooksToolStripMenuItem;
        private ToolStripMenuItem viewBookDetailsToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentDetailsToolStripMenuItem;
        private ToolStripMenuItem teachersToolStripMenuItem;
        private ToolStripMenuItem addTeachersToolStripMenuItem;
        private ToolStripMenuItem viewTeacherDetailsToolStripMenuItem;
        private ToolStripMenuItem issueBookToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}