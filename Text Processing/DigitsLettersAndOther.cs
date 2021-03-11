using System;
using System.Collections.Generic;
using System.Text;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> numbers = new List<char>();
            List<char> letters = new List<char>();
            List<char> others  = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (char.IsDigit(current))
                {
                    numbers.Add(current);
                }
                else if (char.IsLetter(current))
                {
                    letters.Add(current);
                }
                else
                {
                    others.Add(current);
                }
            }
            Console.WriteLine(string.Join("", numbers));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", others));
        }
    }
}
