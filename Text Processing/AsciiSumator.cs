using System;

namespace Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];
                if ((int)current>(int)first && (int)current<second)
                {
                    sum += (int)current;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
