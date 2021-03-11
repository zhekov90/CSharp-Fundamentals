using System;

namespace Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintNum(num);
        }

        private static void PrintNum(int num)
        {
            if (num>0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num<0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
