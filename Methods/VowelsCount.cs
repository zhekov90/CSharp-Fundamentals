using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Console.WriteLine(VowelCounter(input));
        }

        private static int VowelCounter(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];

                if (current == 'A' || current == 'E' || current == 'I' || current == 'O' || current == 'U' || current == 'a' || current == 'e' || current == 'i' || current == 'o' || current == 'u')
                {
                    counter++;
                }

            }
            return counter;
        }
    }
}
