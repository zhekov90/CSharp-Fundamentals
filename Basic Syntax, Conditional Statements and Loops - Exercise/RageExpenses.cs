using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            double lostGames = double.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            double headsetCounter = 0;
            double mouseCounter = 0;
            double keyboardCounter = 0;
            double displayCounter = 0;
            bool crashedHeadset = false;
            bool crashedMouse = false;
            bool crashedKeyboard = false;
            bool crashedDisplay = false;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    crashedHeadset = true;
                    headsetCounter++;
                }
                if (i % 3 == 0)
                {
                    crashedMouse = true;
                    mouseCounter++;
                }
                if (crashedHeadset && crashedMouse)
                {
                    crashedKeyboard = true;
                    keyboardCounter++;
                    if (keyboardCounter % 2 == 0)
                    {
                        crashedDisplay = true;
                        displayCounter++;
                    }
                }


                crashedHeadset = false;
                crashedMouse = false;
                crashedKeyboard = false;
                crashedDisplay = false;
            }
            double rageExpenses = displayCounter * priceDisplay + keyboardCounter * priceKeyboard + mouseCounter * priceMouse + headsetCounter * priceHeadset;
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
