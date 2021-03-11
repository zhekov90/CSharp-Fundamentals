using System;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
           PrintPointClosestToCenter(x1, y1, x2, y2);
        }

        private static void PrintPointClosestToCenter(double x1, double y1, double x2, double y2)
        {
            double firstPair = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double secondPair = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            if (firstPair<=secondPair)
            {
                Console.WriteLine($"({x1}, {y1})");
              
            }
            else if (secondPair<firstPair)
            {
                Console.WriteLine($"({x2}, {y2})");
                
            }
          
        }
    }
}
