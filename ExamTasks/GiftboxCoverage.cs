using System;

namespace Giftbox_Coverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeOfSide = double.Parse(Console.ReadLine());
            int sheetsOfPaper = int.Parse(Console.ReadLine());
            double areaOfSheet = double.Parse(Console.ReadLine());
            double areaGiftBox = sizeOfSide * sizeOfSide * 6.00;
            double thirds = Math.Floor((double)sheetsOfPaper / 3.00);
            double sheetsArea = (sheetsOfPaper * areaOfSheet) - (thirds * areaOfSheet * 0.75);
            double result = (sheetsArea / areaGiftBox) * 100;
            Console.WriteLine($"You can cover {result:f2}% of the box.");
        }
    }
}
