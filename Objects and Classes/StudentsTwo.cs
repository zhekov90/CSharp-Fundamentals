using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Student> list = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] line = Console.ReadLine().Split();

                Student myList = new Student(line[0], line[1], double.Parse(line[2]));
                list.Add(myList);
            }

            List<Student> sortedStudents = new List<Student>();
            sortedStudents = list.OrderByDescending(a => a.Grade).ToList();

            sortedStudents.ForEach(x => Console.WriteLine(x));
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:F2}";
        }
    }
}

