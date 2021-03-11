using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = 
                new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            MatchCollection matchedNames = regex.Matches(input);
            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
