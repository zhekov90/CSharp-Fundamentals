using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] data = input.Split();
                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string city = data[3];
                Student student = new Student(firstName, lastName, age, city);
             
                students.Add(student);
                input = Console.ReadLine();
            }
            string chosenCity = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.City == chosenCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {

        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age} {City}";
        }
    }
}

