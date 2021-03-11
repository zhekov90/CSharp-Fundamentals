using System;

namespace Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[3];
            FindPositiveOrNegativeMultiplication(numbers);

        }

        private static void FindPositiveOrNegativeMultiplication(int[] numbers)
        {
            bool isZero = false;
            bool isNegative = false;
            bool isPositive = false;
            int negativeNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    isZero = true;

                }
                else if (num < 0)
                {
                    negativeNumbers++;

                }

                else
                {
                    isPositive = true;
                }

                if (negativeNumbers % 2 == 0)
                {
                    isNegative = false;
                }
                else if (negativeNumbers % 2 == 1)
                {
                    isNegative = true;
                }

            }
            if (isZero)
            {
                Console.WriteLine("zero");
                return;
            }
            else if (isNegative)
            {
                Console.WriteLine("negative");
                return;
            }
            else if (isPositive)
            {
                Console.WriteLine("positive");
                return;
            }


        }
    }
}
