using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());
            int result = 0;
            if (sign == "/")
            {
                result = DivideNumbers(first, second);
            }
            else if (sign == "*")
            {
                result = MultiplyNumbers(first, second);
            }
            else if (sign == "+")
            {
                result = SumNumbers(first, second);
            }
            else if (sign == "-")
            {
                result = SubstractNumbers(first, second);
            }
            Console.WriteLine(result);
        }

        private static int DivideNumbers(int first, int second)
        {
            return first / second;
        }
        private static int MultiplyNumbers(int first, int second)
        {
            return first * second;
        }
        private static int SumNumbers(int first, int second)
        {
            return first + second;
        }
        private static int SubstractNumbers(int first, int second)
        {
            return first - second;
        }
    }
}
