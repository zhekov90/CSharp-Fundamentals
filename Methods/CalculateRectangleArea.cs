using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalcRectangleArea(width, height);
            Console.WriteLine(area);

        }

        private static double CalcRectangleArea(double width, double height)
        {
            return width * height;       
        }
    }
}
