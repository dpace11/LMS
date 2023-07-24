using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataModel
{
    public class Student
    {
        public int StudentID { get; set; }
        public int StudentRollNo { get; set; }
        public string StudentName { get; set; }
        public string Department  { get; set; }
        public  int Semester { get; set; }
        public long StudentContact { get; set; }
        public string StudentEmail { get; set; }
    }
}
