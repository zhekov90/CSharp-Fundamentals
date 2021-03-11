using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double sum1 = CalcFactorial(num1);
            double sum2 = CalcFactorial(num2);
            double result = DivideTwoNumbers(sum1, sum2);
            Console.WriteLine($"{result:f2}");
        }

        private static double DivideTwoNumbers(double number1, double number2)
        {
            return number1 / number2;
        }

        private static double CalcFactorial(double number)
        {
            double index = number;
            for (double i = 1; i < index; i++)
            {
                number *= i;
            }
            return number;
        }
    }
}
