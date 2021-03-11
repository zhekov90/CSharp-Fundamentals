using System;
using System.Linq;
using System.Collections.Generic;
namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "End")
                {
                    break;
                }

                Person myList = new Person(command[0], command[1], int.Parse(command[2]));
                list.Add(myList);
            }

            List<Person> sortedPersons = new List<Person>();
            sortedPersons = list.OrderBy(x => x.Age).ToList();

            foreach (Person x in sortedPersons)
            {
                Console.WriteLine(x);
            }
        }
    }

    class Person
    {
        public Person(string name, string identification, int age)
        {
            Name = name;
            Identification = identification;
            Age = age;
        }
        public string Name { get; set; }
        public string Identification { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Identification} is {this.Age} years old.";
        }
    }
}