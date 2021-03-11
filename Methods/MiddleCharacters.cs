using System;
using System.Linq;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleChar(input);

        }

        private static void PrintMiddleChar(string input)
        {
            if (input.Length % 2 == 1)
            {
                int middleChar = input.Length / 2;
                Console.WriteLine(input[middleChar]);
            }
            else if (input.Length % 2 == 0)
            {
                int middleChar1 = input.Length / 2 - 1;
                int middleChar2 = input.Length / 2;
                Console.WriteLine($"{input[middleChar1]}{input[middleChar2]}");
            }
        }
    }
}
