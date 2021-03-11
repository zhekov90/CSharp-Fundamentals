using System;
using System.Numerics;

namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
