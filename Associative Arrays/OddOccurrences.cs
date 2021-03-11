using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (count.ContainsKey(wordInLowerCase))
                {
                    count[wordInLowerCase]++;
                }
                else
                {
                    count.Add(wordInLowerCase, 1);
                }
            }
            foreach (var element in count)
            {
                if (element.Value % 2 == 1)
                {
                    Console.Write(element.Key + " ");
                }
            }
        }
    }
}
