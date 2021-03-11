using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNumber(number, number2, number3));
        }

        private static int SmallestNumber(int number, int number2, int number3)
        {
            if (number < number2 && number < number3)
            {
                return number;
            }
            else if (number2 < number3)
            {
                return number2;
            }
            else
            {
                return number3;
            }
        }
    }
}
