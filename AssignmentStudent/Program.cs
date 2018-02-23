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
            StudentDbContext db = new StudentDbContext();

            //// Adding the Math Test
            //db.tests.Add(new Test("Math Test", Convert.ToDecimal(78.0), 1));
            //db.tests.Add(new Test("Math Test", Convert.ToDecimal(98.0), 2));
            //db.tests.Add(new Test("Math Test", Convert.ToDecimal(100.0), 3));
            //db.tests.Add(new Test("Math Test", Convert.ToDecimal(87.5), 4));
            //db.tests.Add(new Test("Math Test", Convert.ToDecimal(41.0), 5));

            ////Adding the History Test
            //db.tests.Add(new Test("History Test", Convert.ToDecimal(95.0), 1));
            //db.tests.Add(new Test("History Test", Convert.ToDecimal(94.0), 2));
            //db.tests.Add(new Test("History Test", Convert.ToDecimal(98.0), 3));
            //db.tests.Add(new Test("History Test", Convert.ToDecimal(89.0), 4));
            //db.tests.Add(new Test("History Test", Convert.ToDecimal(91.0), 5));

            ////Adding the Spanish Test
            //db.tests.Add(new Test("Spanish Test", Convert.ToDecimal(78.0), 1));
            //db.tests.Add(new Test("Spanish Test", Convert.ToDecimal(84.0), 2));
            //db.tests.Add(new Test("Spanish Test", Convert.ToDecimal(90.0), 3));
            //db.tests.Add(new Test("Spanish Test", Convert.ToDecimal(68.0), 4));
            //db.tests.Add(new Test("Spanish Test", Convert.ToDecimal(100.0), 5));

            //db.SaveChanges();

            List<Test> Tests = db.tests.OrderBy(tst => tst.Student.GradYear).ToList();
            foreach (Test test in Tests)
            {
                string message = $"Student: {test.Student.Name}\n Earned a {test.Score}% on the {test.TestName}!";
                Console.WriteLine(message);

            }

            Console.ReadKey();


        }
    }
}
