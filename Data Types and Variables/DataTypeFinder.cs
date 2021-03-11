using System;

namespace Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a;
            double b;
            char c;
            bool d;
            while (input != "END")
            {
                bool isInteger = int.TryParse(input, out a);
                bool isDouble = double.TryParse(input, out b);
                bool isChar = char.TryParse(input, out c);
                bool isBool = bool.TryParse(input, out d);
                string result = string.Empty;

                if (isInteger)
                {
                    result = input + " is integer type";
                }
                else if (isDouble)
                {
                    result = input + " is floating point type";
                }
                else if (isChar)
                {
                    result = input + " is character type";
                }
                else if (isBool)
                {
                    result = input + " is boolean type";
                }
                else
                {
                    result = input + " is string type";
                }

                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
