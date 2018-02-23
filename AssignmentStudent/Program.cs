using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Task 1
            //StudentDbContext db = new StudentDbContext();
            //int nbrStudents = db.students.Count();
            //Console.WriteLine($"The number of students in this table is: {nbrStudents}");
            ////Task2
            //List<Student> students = db.students.ToList();
            //foreach (Student stu in students)
            //{
            //    string message = $"A student in this list is named: {stu.Name}";
            //    Console.WriteLine(message);
            //}
            ////Task 3
            //List<Student> honorStudents = db.students.Where(stu => stu.GradWithHonors == true).OrderBy(stu => stu.GradYear).ToList();
            //foreach (Student stu in honorStudents)
            //{
            //    Console.WriteLine($"{stu.Name} is an honor student");
            //}








            Console.ReadKey();


        }
    }
}
