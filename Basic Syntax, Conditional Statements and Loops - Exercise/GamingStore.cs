using System;

namespace Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            bool notValid = false;
            double price = 0;
            double sum = 0;
            while (command != "Game Time")
            {

                string game = command;
                if (game != "OutFall 4" && game != "CS: OG" && game != "Zplinter Zell" && game != "Honored 2" && game != "RoverWatch" && game != "RoverWatch Origins Edition")
                {
                    notValid = true;
                }
                if (notValid)
                {
                    Console.WriteLine("Not Found");
                    notValid = false;
                    command = Console.ReadLine();
                    continue;
                }

                

                if (game == "OutFall 4")
                {
                    price = 39.99;
                    if (currentBalance >= price)
                    {
                        Console.WriteLine($"Bought {game}");
                        sum += price;
                        currentBalance -= price;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                      
                    }
                    if (currentBalance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }

                }
                else if (game == "CS: OG")
                {
                    price = 15.99;
                    if (currentBalance >= price)
                    {
                        Console.WriteLine($"Bought {game}");
                        sum += price;
                        currentBalance -= price;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                     
                    }
                    if (currentBalance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    price = 19.99;
                    if (currentBalance >= price)
                    {
                        Console.WriteLine($"Bought {game}");
                        sum += price;
                        currentBalance -= price;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                      
                    }
                    if (currentBalance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else if (game == "Honored 2")
                {
                    price = 59.99;
                    if (currentBalance >= price)
                    {
                        Console.WriteLine($"Bought {game}");
                        sum += price;
                        currentBalance -= price;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                       
                    }
                    if (currentBalance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else if (game == "RoverWatch")
                {
                    price = 29.99;
                    if (currentBalance >= price)
                    {
                        Console.WriteLine($"Bought {game}");
                        sum += price;
                        currentBalance -= price;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        
                    }
                    if (currentBalance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                    if (currentBalance >= price)
                    {
                        Console.WriteLine($"Bought {game}");
                        sum += price;
                        currentBalance -= price;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        
                    }
                    if (currentBalance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }


                command = Console.ReadLine();
            }
            if (command == "Game Time")
            {
                Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }
}
