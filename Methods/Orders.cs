using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
           
            switch (product)
            {
                case "coffee":
                    price = GetCoffeePrice(price);
                    break;
                case "water":
                    price = GetWaterPrice(price);
                    break;
                case "coke":
                    price = GetCokePrice(price);
                    break;
                case "snacks":
                    price = GetSnacksPrice(price);
                    break;
            }
            double result = quantity * price;
            Console.WriteLine($"{result:f2}");
        }
        private static double GetCoffeePrice(double price)
        {
            return price = 1.50;
        }
        private static double GetWaterPrice(double price)
        {
            return price = 1.00;
        }
        private static double GetCokePrice(double price)
        {
            return price = 1.40;
        }
        private static double GetSnacksPrice(double price)
        {
            return price = 2.00;
        }
    }
}
