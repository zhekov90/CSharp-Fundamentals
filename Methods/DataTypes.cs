using System;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GetDataType(input);
            
        }

        private static void GetDataType(string input)
        {
            if (input == "int")
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number * 2);
            }
            else if (input == "real")
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine($"{number * 1.5:f2}");
            }
            else if (input == "string")
            {
                string input2 = Console.ReadLine();
                Console.WriteLine($"${input2}$");
            }
        }
    }
}