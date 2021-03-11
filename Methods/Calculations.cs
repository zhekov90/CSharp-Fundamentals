using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = 0;
            switch (command)
            {
                case "add":
                    result = Add(num1, num2);
                    break;
                case "multiply":
                    result = Multiply(num1, num2);
                    break;
                case "substract":
                    result = Substract(num1, num2);
                    break;
                case "divide":
                    result = Divide(num1, num2);
                    break;
            }
            Console.WriteLine(result);
        }

        private static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        private static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        private static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
        private static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
