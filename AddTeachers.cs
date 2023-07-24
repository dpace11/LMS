using LMS.DataModel;
using System.Text.RegularExpressions;

namespace LMS
{
    public partial class AddTeachers : Form
    {
        LmsDataModel datacontext = new();
        Teacher teacher = new();

        public AddTeachers()
        {
            InitializeComponent();
        }

        void clearfunc()
        {
            txtTeacherRollNo.Clear();
            txtTeacherName.Clear();
            cmbTeacherDepartment.SelectedItem = null;
            txtTeacherContact.Clear();
            txtTeacherEmail.Clear();
        }

        private void btnTeachSaveInfo_Click(object sender, EventArgs e)
        {
            //string rollPattern = @"^7505__$";
            if (txtTeacherRollNo.Text != "" && txtTeacherName.Text != "" && cmbTeacherDepartment.Text != "" && txtTeacherContact.Text != "" && txtTeacherEmail.Text != "")
            {
                Teacher teacher = new()
                {
                    TeacherRollNo = Convert.ToInt32(txtTeacherRollNo.Text),
                    TeacherName = txtTeacherName.Text,
                    TeacherDepartment = cmbTeacherDepartment.SelectedItem.ToString(),
                    TeacherContact = Convert.ToInt64(txtTeacherContact.Text),
                    TeacherEmail = txtTeacherEmail.Text

                };
                bool ispresrnt = datacontext.Teachers.Any(c => c.TeacherRollNo == teacher.TeacherRollNo);


                if (ispresrnt)

                {
                    MessageBox.Show("Teacher Roll Number Already Used\n Assign new Roll number", "Roll Number conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    /* if (Regex.IsMatch(txtTeacherRollNo.Text, rollPattern))
                     {*/
                    datacontext.Teachers.Add(teacher);
                    int a = datacontext.SaveChanges();
                    if (a > 0)
                    {
                        MessageBox.Show("Teacher Data Saved Sucessfull!!", "Student Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearfunc();
                    }
                    else
                    {
                        MessageBox.Show("Teacher Data Save Unsucessfull!!", "Student Save Eror", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    /* }
                     else
                     {
                         MessageBox.Show("Invalid Teacher Roll no Format must be __05__", "Invalid Roll Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }*/
                }

            }
            else
            {
                MessageBox.Show("No Field Can Be Empty", "Information Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
