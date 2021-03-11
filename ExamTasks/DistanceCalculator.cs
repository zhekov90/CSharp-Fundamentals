using System;

namespace Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double stepsMade = double.Parse(Console.ReadLine());
            double lengthOfStep = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double result = 0;
            
            for (int i = 1; i <= stepsMade; i++)
            {
                if (i % 5 == 0)
                {
                    double shortStep = lengthOfStep * 0.70;
                    result += shortStep;
                }
                else
                {
                    result += lengthOfStep;
                }
            }

            Console.WriteLine($"You travelled {result/distance:f2}% of the distance!");
        }
    }
}
