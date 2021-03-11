using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrCondensed = new int[arr.Length - 1];

            if (arr.Length==1)
            {
                Console.WriteLine(arr[0]);
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arrCondensed.Length-i; j++)
                {
                    arrCondensed[j] = arr[j] + arr[j + 1];
                }
                arr = arrCondensed;
            }
            Console.WriteLine(arrCondensed[0]);
        }
    }
}
