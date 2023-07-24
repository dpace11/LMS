using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataModel
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int TeacherRollNo { get; set; }
        public string TeacherName { get; set; }
        public string TeacherDepartment { get; set; }
        public long TeacherContact { get; set; }
        public string TeacherEmail { get; set; }
    }
}
