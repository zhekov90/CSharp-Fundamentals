using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            
            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                int counter = 1;

                for (int currentIndex = i + 1; currentIndex < arr.Length; currentIndex++)
                {
                    if (currentElement == arr[currentIndex])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > bestCount)
                {
                    bestCount = counter;
                    bestIndex = i;
                }
            }
            string result = "";
            for (int i = 0; i < bestCount; i++)
            {
                result += arr[bestIndex] + " ";
            }
            Console.WriteLine(result);
        }
    }
}
