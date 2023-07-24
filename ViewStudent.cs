using LMS.DataModel;
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
    public partial class ViewStudent : Form
    {
        LmsDataModel datacontext = new();
        Student std = new();
        int stdid;
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            panelStudView.Visible = false;
            GridDefault();
        }


        void clearfunc()
        {
            txtStudentName.Clear();
            txtStudentRollNo.Clear();
            txtStudentSemester.Clear();
            txtStudentContact.Clear();
            cmbStudentDepartment.SelectedItem = null;
            txtStudentEmail.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void GridDefault()
        {
            var query = datacontext.Students.ToList();

            gridViewStudent.DataSource = query;
        }

        private void txtStdNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtStdNameSearch.Text != "")
            {
                var query = datacontext.Students.Where(c => c.StudentName.Contains(txtStdNameSearch.Text));
                gridViewStudent.DataSource = query.ToList();
            }
            else
            {
                GridDefault();
            }
        }

        private void gridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelStudView.Visible = true;

            if (gridViewStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                stdid = Convert.ToInt32(gridViewStudent.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            var stdclick = datacontext.Students.Where(c => c.StudentID == stdid).FirstOrDefault();

            txtStudentName.Text = stdclick.StudentName;
            txtStudentRollNo.Text = stdclick.StudentRollNo.ToString();
            cmbStudentDepartment.SelectedItem = stdclick.Department.ToString();
            txtStudentSemester.Text = stdclick.Semester.ToString();
            txtStudentContact.Text = stdclick.StudentContact.ToString();
            txtStudentEmail.Text = stdclick.StudentEmail;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtStdNameSearch.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelStudView.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("do you want to delete data", "delete alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                var stdDel = datacontext.Students.Where(c => c.StudentID == stdid).FirstOrDefault();
                datacontext.Remove(stdDel);
                int a = datacontext.SaveChanges();

                if (a > 0)
                {
                    MessageBox.Show("data deleted successfully!!!", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridDefault();
                    clearfunc();
                }

                else
                {
                    MessageBox.Show("data deletion fail!!!", "Delete Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("you chose no");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text != null && txtStudentRollNo.Text != null && txtStudentSemester.Text != null && txtStudentContact.Text != null && txtStudentEmail.Text != null && cmbStudentDepartment.Text != null)
            {
                int studentRollNo = Convert.ToInt32(txtStudentRollNo.Text);

                var exStd = datacontext.Students.Where(c => c.StudentRollNo == studentRollNo).FirstOrDefault();

                if (exStd != null)
                {
                    exStd.StudentName = txtStudentName.Text;
                    // exStd.StudentName=txtStudentName.Text;
                    exStd.Semester = Convert.ToInt32(txtStudentSemester.Text);
                    exStd.StudentContact = Convert.ToInt64(txtStudentContact.Text);
                    exStd.StudentEmail = txtStudentEmail.Text;
                    exStd.Department = cmbStudentDepartment.SelectedItem.ToString();

                    datacontext.SaveChanges();
                    MessageBox.Show("Data Updated Successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridDefault();
                    clearfunc();
                }
                else
                {
                    MessageBox.Show("Student with Roll Number " + studentRollNo + " not found.", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No Field Can Be Empty", "Information Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
