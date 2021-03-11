using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int tempNum = number;
            int totalFactorialSum = 0;
            while (tempNum > 0)
            {
                int digit = tempNum % 10;
                tempNum /= 10;
                int currentFactorialSum = 1;
                for (int i = 1; i <= digit; i++)
                {
                    currentFactorialSum *= i;
                }
                totalFactorialSum += currentFactorialSum;
            }
            if (number==totalFactorialSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
