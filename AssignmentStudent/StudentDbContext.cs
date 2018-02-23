using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AssignmentStudent
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext() : base()
        {

        }
        public virtual DbSet<Student> students { get; set; }
        public virtual DbSet<Test> tests { get; set; }
    }
}
