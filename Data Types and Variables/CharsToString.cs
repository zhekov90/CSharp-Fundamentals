using System;

namespace Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                char current = char.Parse(Console.ReadLine());
                result+= current;
            }
            Console.WriteLine(result);
        }
    }
}
