using LMS.DataModel;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace LMS
{
    public partial class IssueBook : Form
    {
        LmsDataModel datacontext = new();

        
        public IssueBook()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            var query = datacontext.Books.Select(c => c.BookName);
            var result = query.ToList();
            cmbBookName.DataSource = result;
        }

        void clearfunc()
        {
            txtName.Clear();
            txtRollNo.Clear();
            txtEmail.Clear();
            txtDepartment.Clear();
            txtContact.Clear();
            cmbBookName.SelectedItem = null;
            txtSearchRoll.Clear();
            //dateIssueDate.Value = null;
        }

        private void btnSearchDetails_Click(object sender, EventArgs e)
        {
            var roll = Convert.ToInt32(txtSearchRoll.Text);

            var searchedStudent = datacontext.Students.Where(c => c.StudentRollNo == roll).FirstOrDefault();
            var searchedTeacher = datacontext.Teachers.Where(d => d.TeacherRollNo == roll).FirstOrDefault();

            if (searchedStudent != null || searchedTeacher != null)
            {
                bool isStdPresent = datacontext.Students.Any(c => c.StudentRollNo == roll);
                bool isTeacherPresent = datacontext.Teachers.Any(c => c.TeacherRollNo == roll);
                if (isStdPresent)
                {
                    txtName.Text = searchedStudent.StudentName;
                    txtContact.Text = searchedStudent.StudentContact.ToString();
                    txtEmail.Text = searchedStudent.StudentEmail;
                    txtRollNo.Text = searchedStudent.StudentRollNo.ToString();
                    txtDepartment.Text = searchedStudent.Department;
                }
                else if (isTeacherPresent)
                {
                    txtName.Text = searchedTeacher.TeacherName;
                    txtContact.Text = searchedTeacher.TeacherContact.ToString();
                    txtEmail.Text = searchedTeacher.TeacherEmail;
                    txtRollNo.Text = searchedTeacher.TeacherRollNo.ToString();
                    txtDepartment.Text = searchedTeacher.TeacherDepartment;
                }
            }
            else
            {
                clearfunc();
                MessageBox.Show("Roll no indvalid\n Insert Information Into Database First\nHint:Go to Add Section", "Invalid ROll No", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearfunc();
        }

        private void btnIssueDate_Click(object sender, EventArgs e)
        {
            
            
            int bookIssueRoll = Convert.ToInt32(txtRollNo.Text);

            string selectedbook = cmbBookName.SelectedItem.ToString();

            var duplicate_Book = datacontext.IssueReturnBooks.Where(b => b.RollNo == bookIssueRoll && b.Book_Name == selectedbook && b.Book_Return_Date == "n/a").FirstOrDefault();

            int bookcount = datacontext.IssueReturnBooks.Where(b => b.RollNo == bookIssueRoll && b.Book_Return_Date == "n/a").Count();

            var remainingQuantityQuery = datacontext.Books.Where(b=>b.BookName==selectedbook).Select(b=>b.RemainingQuantity).FirstOrDefault();

            int remaininyQuantiy = Convert.ToInt32(remainingQuantityQuery);

            if (remaininyQuantiy != 0)
            {


                if (bookcount <= 5)
                {
                    if (duplicate_Book != null)
                    {
                        MessageBox.Show(selectedbook + " already issued to " + bookIssueRoll, "book already issued", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        IssueReturnBook bk = new()
                        {
                            RollNo = Convert.ToInt32(txtRollNo.Text),
                            Name = txtName.Text,
                            Department = txtDepartment.Text,
                            Contact = Convert.ToInt64(txtContact.Text),
                            Email = txtEmail.Text,
                            Book_Name = cmbBookName.SelectedItem.ToString(),
                            Book_Issue_Date = dateIssueDate.Value.ToString(),
                            Book_Return_Date = "n/a"
                        };

                        datacontext.IssueReturnBooks.Add(bk);


                        int a = datacontext.SaveChanges();

                        int remqty = datacontext.Books.Where(b => b.BookName == selectedbook).Select(b => b.RemainingQuantity).FirstOrDefault();
                        remqty = remqty - 1;

                        var updatebookqty = datacontext.Books.Where(b => b.BookName == selectedbook);
                        foreach (var r in updatebookqty)
                        {
                            r.RemainingQuantity = remqty;
                        }
                        datacontext.SaveChanges();

                        if (a > 0)
                        {
                            MessageBox.Show(selectedbook + " issued to " + bookIssueRoll + " sucessfully", "Book Issue Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearfunc();
                        }
                        else
                        {
                            MessageBox.Show("Book Issue Failed", "Book Issue Eror", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Exceeded Book Limit of 6 Books Per Person", "Book Limit Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //clearfunc();
            }
            else
            {
                MessageBox.Show(selectedbook+" Out Of Stock \n Cannot Issue This Book ", "Out Of Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }



}

