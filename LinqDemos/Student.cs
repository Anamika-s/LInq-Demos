using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemos
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class LinqDemo
    {
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "Ajay", Age = 20 },
                new Student() { StudentId = 2, StudentName = "Moin", Age = 21 },
                new Student() { StudentId = 3, StudentName = "Bill", Age = 18 },
                new Student() { StudentId = 4, StudentName = "Ram", Age = 20 },
                new Student() { StudentId = 5, StudentName = "Ron", Age = 15 }

            };

            //var list = (from temp in listOfStudents
            //            select temp);

            var list = listOfStudents.ToList();
            foreach (Student student in list)
                Console.WriteLine(student.StudentId + " " + student.StudentName + " " + student.Age);

            var listOfStudentsAgeMoreThan20 = listOfStudents.Where(x => x.Age > 20).ToList();
            foreach (Student student in listOfStudentsAgeMoreThan20)
                Console.WriteLine(student.StudentId + " " + student.StudentName + " " + student.Age);
        }
    }
}