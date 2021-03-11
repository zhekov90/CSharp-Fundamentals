using System;
using System.Linq;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currNum = input[i];
                if (currNum%2==0)
                {
                    sumEven += input[i];
                }
                else
                {
                    sumOdd += input[i];
                }
            }
            Console.WriteLine(sumEven-sumOdd);
            
        }
    }
}
