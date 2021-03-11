using System;
using System.Collections.Generic;
using System.Linq;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            decimal result = 0;
            for (int i = 0; i < input.Count; i++)
            {
                string text = input[i];
                char firstLetter = text[0];
                char secondLetter = text[text.Length - 1];
                text = text.Remove(0, 1);
                text = text.Remove(text.Length - 1, 1);
                decimal number = decimal.Parse(text);
                decimal sum = 0;
                if ((decimal)firstLetter >= 65 && (decimal)firstLetter <= 90)
                {
                    sum += number / ((decimal)firstLetter - 64);
                }
                else if ((decimal)firstLetter >= 97 && (decimal)firstLetter <= 122)
                {
                    sum += number * ((decimal)firstLetter - 96);
                }

                if ((decimal)secondLetter >= 65 && (decimal)secondLetter <= 90)
                {
                    sum -= ((decimal)secondLetter - 64);
                }
                else if ((decimal)secondLetter >= 97 && (decimal)secondLetter <= 122)
                {
                    sum += ((decimal)secondLetter - 96);
                }
                result += sum;
            }
            Console.WriteLine($"{result:f2}");

        }

    }
}
