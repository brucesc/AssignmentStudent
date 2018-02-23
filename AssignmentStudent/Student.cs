using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AssignmentStudent
{
    public class Student
    {
        public Student() { }
        
        public Student(string name, string major, string college, int gradyear, bool gradwithhonors)
        {
            Name = name;
            Major = major;
            College = college;
            GradYear = gradyear;
            GradWithHonors = gradwithhonors;

        }
        public Student(string name, string major, string college, int gradyear, bool gradwithhonors, bool alumnidoner)
        {
            Name = name;
            Major = major;
            College = college;
            GradYear = gradyear;
            GradWithHonors = gradwithhonors;
            AlumniDoner = alumnidoner;
        }

        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Major { get; set; }
        [Required]
        [MaxLength(30)]
        public string College { get; set; }
        public int GradYear { get; set; }
        public bool GradWithHonors { get; set; }
        public bool? AlumniDoner { get; set; }
    }
}
