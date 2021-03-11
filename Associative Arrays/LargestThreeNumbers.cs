using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sorted = arr.OrderByDescending(n => n).ToArray();
            if (sorted.Length<3)
            {
                foreach (var number in sorted)
                {
                    Console.Write(number + " ");
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sorted[i] + " ");
                }
            }
            
        }
    }
}
