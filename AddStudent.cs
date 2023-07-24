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
    public partial class AddStudent : Form
    {


        LmsDataModel datacontext = new();
        Student std = new();

        public AddStudent()
        {
            InitializeComponent();
        }

        void clearfunc()
        {
            txtStudentName.Clear();
            txtStudentRollNo.Clear();
            txtSemester.Clear();
            txtSemester.Clear();
            txtStudentContact.Clear();
            txtStudentEmail.Clear();
            cmbDepartment.SelectedItem = null;
        }

        private void btnStudentSave_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text != "" && cmbDepartment.Text != "" && txtSemester.Text != "" && txtStudentRollNo.Text != "" && txtStudentContact.Text != "" && txtStudentEmail.Text != "")
            {
                Student student = new Student()
                {
                    StudentName = txtStudentName.Text,
                    StudentRollNo = Convert.ToInt32(txtStudentRollNo.Text),
                    Department = cmbDepartment.SelectedItem.ToString(),
                    Semester = Convert.ToInt32(txtSemester.Text),
                    StudentContact = Convert.ToInt64(txtStudentContact.Text),
                    StudentEmail = txtStudentEmail.Text

                };

                bool ispresent = datacontext.Students.Any(c => c.StudentRollNo == student.StudentRollNo);

                if (ispresent)
                {
                    MessageBox.Show("Student Roll Number Already Used\n Assign new Roll number", "Roll Number conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    datacontext.Students.Add(student);
                    int a = datacontext.SaveChanges();
                    if (a > 0)
                    {
                        MessageBox.Show("Student Data Saved Sucessfull!!", "Student Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearfunc();
                    }
                    else
                    {
                        MessageBox.Show("Student Data Save Unsucessfull!!", "Student Save Eror", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Field Can Be Empty", "Information Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
