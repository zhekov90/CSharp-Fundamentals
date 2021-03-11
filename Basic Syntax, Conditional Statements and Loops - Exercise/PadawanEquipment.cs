using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceSabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());
            double countSabers = Math.Ceiling(students * 1.1);
            int freeBelts = 0;
            for (int i = 6; i <= students; i+=6)
            {
                    freeBelts++;
            }
            double totalPrice = priceSabers * (countSabers) + priceRobes * students + priceBelts * (students - freeBelts);

            if (money>=totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                double newPrice = totalPrice - money;
                Console.WriteLine($"Ivan Cho will need {newPrice:f2}lv more.");
            }
        }
    }
}
