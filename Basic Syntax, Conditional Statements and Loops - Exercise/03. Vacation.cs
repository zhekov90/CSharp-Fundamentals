using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            decimal price = 0;
            switch (group)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45M;
                            break;
                        case "Saturday":
                            price = 9.80M;
                            break;
                        case "Sunday":
                            price = 10.46M;
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90M;
                            break;
                        case "Saturday":
                            price = 15.60M;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50M;
                            break;
                    }
                    break;
            }
            decimal totalPrice = number * price;
            if (group=="Students" && number>=30)
            {
                totalPrice *= 0.85M;
            }
            if (group=="Business" && number>=100)
            {
                number -= 10;
                totalPrice = number * price;
            }
            if (group=="Regular" && number>=10 && number<=20)
            {
                totalPrice *= 0.95M;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
