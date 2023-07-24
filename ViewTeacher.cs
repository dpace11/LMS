using LMS.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class ViewTeacher : Form
    {
        LmsDataModel datacontext = new();
        Teacher teacher = new();

        int teachid;
        public ViewTeacher()
        {
            InitializeComponent();
        }

        private void ViewTeacher_Load(object sender, EventArgs e)
        {
            panTeacherUpdate.Visible = false;
            gridTeacherDefaultDisplay();
        }

        void clearfunc()
        {
            txtTeachContact.Clear();
            txtTeacherEmail.Clear();
            txtTeacherName.Clear();
            txtTeacherRoll.Clear();
            cmbTeacherDeparment.SelectedItem = null;
        }

        void gridTeacherDefaultDisplay()
        {
            var query = datacontext.Teachers.ToList();

            dataTeachersDetails.DataSource = query;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panTeacherUpdate.Visible = false;
        }

        private void dataTeachersDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panTeacherUpdate.Visible = true;
            if (dataTeachersDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                teachid = Convert.ToInt32(dataTeachersDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            var tclick = datacontext.Teachers.Where(c => c.TeacherId == teachid).FirstOrDefault();

            txtTeacherRoll.Text = tclick.TeacherRollNo.ToString();
            txtTeacherName.Text = tclick.TeacherName;
            txtTeacherEmail.Text = tclick.TeacherEmail;
            cmbTeacherDeparment.SelectedItem = tclick.TeacherDepartment.ToString();
            txtTeachContact.Text = tclick.TeacherContact.ToString();


        }

        private void btnDeleteteTeacher_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("do you want to delete data", "delete alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                var teacherdel = datacontext.Teachers.Where(c => c.TeacherId == teachid).FirstOrDefault();
                datacontext.Remove(teacherdel);
                int a = datacontext.SaveChanges();

                if (a > 0)
                {
                    MessageBox.Show("data deleted successfully!!!", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridTeacherDefaultDisplay();
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

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            if (txtTeacherRoll.Text != "" && txtTeacherName.Text != "" && cmbTeacherDeparment.Text != "" && txtTeachContact.Text != "" && txtTeacherEmail.Text != "")
            {
                int teacherRollNo = Convert.ToInt32(txtTeacherRoll.Text);

                var existingTeacher = datacontext.Teachers.Where(t => t.TeacherRollNo == teacherRollNo).FirstOrDefault();
                if (existingTeacher != null)
                {
                    existingTeacher.TeacherName = txtTeacherName.Text;
                    existingTeacher.TeacherDepartment = cmbTeacherDeparment.SelectedItem.ToString();
                    existingTeacher.TeacherContact = Convert.ToInt64(txtTeachContact.Text);
                    existingTeacher.TeacherEmail = txtTeacherEmail.Text;

                    datacontext.SaveChanges();
                    MessageBox.Show("Data Updated Successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridTeacherDefaultDisplay();
                    clearfunc();
                }
                else
                {
                    MessageBox.Show("Teacher with Roll Number " + teacherRollNo + " not found.", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No Field Can Be Empty", "Information Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                var query = datacontext.Teachers.Where(b => b.TeacherName.Contains(txtSearch.Text)).ToList();
                dataTeachersDetails.DataSource = query;
            }
            else
            {
                gridTeacherDefaultDisplay();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
