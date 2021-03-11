using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = input; i <= input; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i*j}");
                }
            }
        }
    }
}
