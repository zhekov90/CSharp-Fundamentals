using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            while (input!="Start")
            {
                if (input == "0.1")
                {
                    sum += 0.1;

                }
                else if (input == "0.2")
                {
                    sum += 0.2;
                  
                }
                else if (input == "0.5")
                {
                    sum += 0.5;
                   
                }
                else if (input == "1")
                {
                    sum += 1.0;
                  
                }
                else if (input == "2")
                {
                    sum += 2.0;
                   
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                   
                }
                input = Console.ReadLine();
            }
            if (input == "Start")
            {
               
                while (input!="End")
                {
                     input = Console.ReadLine();
                    if (input == "Nuts" || input == "Water" || input == "Crisps" || input == "Soda" || input == "Coke")
                    {
                        if (input == "Nuts" && sum >= 2.0)
                        {
                            sum -= 2.0;
                            Console.WriteLine("Purchased nuts");
                        }
                        else if (input == "Water" && sum >= 0.7)
                        {
                            sum -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        else if (input == "Crisps" && sum >= 1.5)
                        {
                            sum -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                        else if (input == "Soda" && sum >= 0.8)
                        {
                            sum -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        else if (input == "Coke" && sum >= 1.0)
                        {
                            sum -= 1.0;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    if (input == "End")
                    {
                        if (sum >= 0)
                        {
                            Console.WriteLine($"Change: {sum:f2}");
                            return;
                        }
                    }

                    else if (input != "Nuts" && input != "Water" && input != "Crisps" && input != "Soda" && input != "Coke")
                    {
                        Console.WriteLine("Invalid product");
                        

                    }
                   
                    
                }

                
            }

        }
    }
}
