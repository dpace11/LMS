using LMS.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataModel
{
    public class IssueReturnBook
    {
        [Key]
        public int IRid { get; set; }

        [Required]
        public int RollNo { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public long Contact  { get; set; }

        [Required]
        public  string  Email    { get; set; }

        [Required]
        public string Book_Name { get; set; }

        [Required]
        public string Book_Issue_Date  { get; set; }

       
        public string Book_Return_Date  { get; set; }
    }
}
