using System;
using System.Text;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = RepeatString(input, n);
            Console.WriteLine(result);
        }

        private static string RepeatString(string str, int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(str);
            }
            return result.ToString();
        }
    }
}
