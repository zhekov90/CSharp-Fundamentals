using System;

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();
                int startName = text.IndexOf('@');
                int endName = text.LastIndexOf('|');
                string name = text.Substring(startName+1, endName - startName - 1);

                int startAge = text.IndexOf('#');
                int endAge = text.LastIndexOf('*');
                string age = text.Substring(startAge+1, endAge-startAge-1);
                Console.WriteLine($"{name} is {age} years old.");
            }

        }
    }
}
