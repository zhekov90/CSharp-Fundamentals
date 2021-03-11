using System;
using System.Collections.Generic;
using System.Linq;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            string text1 = text[0];
            string text2 = text[1];
            int minLen = Math.Min(text1.Length, text2.Length);
            int maxLen = Math.Max(text1.Length, text2.Length);
            int sum = 0;

            for (int i = 0; i < minLen; i++)
            {
                sum += MultiplyCharsASCII(text1[i], text2[i]);
            }

            if (text1.Length != text2.Length)
            {
                string longerInput = text1.Length > text2.Length ? longerInput = text1 : longerInput = text2;
                for (int i = minLen; i < maxLen; i++)
                {
                    sum += longerInput[i];
                }
            }
            Console.WriteLine(sum);
        }

        static int MultiplyCharsASCII(char let1, char let2)
        {
            int multiply = let1 * let2;
            return multiply;
        }
    }

}

