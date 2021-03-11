using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            CharsInRange(one, two);
        }

        private static void CharsInRange(char one, char two)
        {
            if (one < two)
            {
                for (int i = one + 1; i < two; i++)
                {
                    char current = (char)i;
                    Console.Write((char)i + " ");
                }
                Console.WriteLine();
                return;
            }
            else if (one>two)
            {
                for (int i = two + 1; i < one; i++)
                {
                    char current = (char)i;
                    Console.Write((char)i + " ");
                }
                Console.WriteLine();
                return;
            }
          

        }
    }
}
