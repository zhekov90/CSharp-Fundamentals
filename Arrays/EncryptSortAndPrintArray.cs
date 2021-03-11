using System;
using System.Linq;

namespace Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStrings = int.Parse(Console.ReadLine());
            int[] numbers = new int[numberStrings];
            string vowels = "aAeEiIoOuU";
            char[] vowelsArr = vowels.ToCharArray();
            string consonants = "bBcCdDfFgGhHjJkKlLmMnNpPqQrRsStTvVwWxXzZyY";
            char[] consonantsArr = consonants.ToCharArray();

            for (int i = 0; i < numberStrings; i++)
            {
                string word = Console.ReadLine();
                char[] letters = word.ToCharArray();

                int sum = 0;
                for (int j = 0; j < letters.Length; j++)
                {
                    char currentChar = letters[j];
                    if (vowelsArr.Contains(currentChar))
                    {
                        sum += letters[j] * letters.Length;
                    }
                    else
                    {
                        sum += letters[j] / letters.Length;
                    }
                }
                numbers[i] = sum;
            }
            Array.Sort(numbers);
            foreach (var element in numbers)
            {
                Console.WriteLine($"{element}");
            }
        }
    }
}
