using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopPart(n);
            PrintBottomPart(n);
        }

        private static void PrintBottomPart(int n)
        {
            for (int counter = n - 1; counter >= 1; counter--)
            {
                for (int i = 1; i <= counter; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintTopPart(int n)
        {
            for (int counter = 0; counter <= n; counter++)
            {
                for (int i = 1; i <= counter; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
