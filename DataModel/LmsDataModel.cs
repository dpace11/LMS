using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataModel
{
    public class LmsDataModel:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=DESKTOP-TC9TVPJ\SQLEXPRESS;Database=LMS;Trusted_Connection=True;trustserverCertificate=true;");

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<IssueReturnBook> IssueReturnBooks { get; set; }
    }
}
