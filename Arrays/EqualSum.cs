using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isFound = false;

            for (int current = 0; current < arr.Length; current++)
            {
                int sumRight = 0;
                
                for (int i = current + 1; i < arr.Length; i++)
                {
                    sumRight += arr[i];
                }

                int sumLeft = 0;
                for (int i = current - 1; i >= 0; i--)
                {
                    sumLeft += arr[i];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(current);
                    isFound = true;
                }

            }
            if (isFound == false)
            {
                Console.WriteLine("no");
            }

        }
    }
}
