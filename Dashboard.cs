using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks addbook = new();
            addbook.ShowDialog();
        }

        private void viewBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook viewBook = new ViewBook();
            viewBook.ShowDialog();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addstudent = new();
            addstudent.ShowDialog();
        }

        private void addTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeachers addteachers = new();
            addteachers.ShowDialog();
        }

        private void viewStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent stdview = new();
            stdview.ShowDialog();
        }

        private void viewTeacherDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTeacher teacherview = new();
            teacherview.ShowDialog();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook issuebook = new();
            issuebook.ShowDialog();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.ShowDialog();

        }
    }
}
