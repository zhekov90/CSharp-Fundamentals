using System;

namespace Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSumOfPreviousThree(num);
            
        }

        private static void PrintSumOfPreviousThree(int num)
        {
            int[] arr = new int[num];
            int sum = 0;
            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;
            int current = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    current = 1;
                    sum += current;
                    firstNum += current;
                    Console.Write(current + " ");
                }

                else if (i == 1)
                {
                    current = 1;
                    sum += current;
                    secondNum += current;
                    Console.Write(current + " ");
                }

                else if (i == 2)
                {
                    current = sum;
                    sum += current;
                    thirdNum = current;
                    Console.Write(current + " ");
                }

                else
                {
                    current = firstNum + secondNum + thirdNum;

                    Console.Write(current + " ");
                    firstNum = secondNum;
                    secondNum = thirdNum;
                    thirdNum = current;
                }

            }
            Console.WriteLine();
        }
    }
}
