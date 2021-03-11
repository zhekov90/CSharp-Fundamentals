using System;
using System.Collections.Generic;
using System.Linq;

namespace Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split('|');
            int[] numbers = new int[line.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }
            int iskrenPoints = 0;
            int index = 0;
            int length = 0;

            string command = Console.ReadLine();
            string[] temp;
            string[] indexes;

            while (command != "Game over")
            {
                if (command == "Reverse")
                {
                    Array.Reverse(numbers);
                    command = Console.ReadLine();
                    continue;
                }

                temp = command.Split();
                indexes = temp[1].Split('@');

                if (indexes[0] == "Left")
                {
                    index = int.Parse(indexes[1]);
                    length = int.Parse(indexes[2]);

                    if (index >= 0 && index <= numbers.Length - 1)
                    {

                        while (length != 0)
                        {
                            if (index > 0)
                            {
                                index--;
                                length--;
                            }
                            else if (index == 0)
                            {
                                index = numbers.Length - 1;
                                length--;
                            }
                        }

                        if (numbers[index] >= 5)
                        {
                            numbers[index] -= 5;
                            iskrenPoints += 5;
                        }
                        else
                        {
                            iskrenPoints += numbers[index];
                            numbers[index] = 0;
                        }
                    }

                }
                else if (indexes[0] == "Right")
                {
                    index = int.Parse(indexes[1]);
                    length = int.Parse(indexes[2]);

                    if (index >= 0 && index <= numbers.Length - 1)
                    {
                        while (length != 0)
                        {


                            if (index < numbers.Length - 1)
                            {
                                index++;
                                length--;
                            }
                            else if (index == numbers.Length - 1)
                            {
                                index = 0;
                                length--;
                            }
                        }

                        if (numbers[index] >= 5)
                        {
                            numbers[index] -= 5;
                            iskrenPoints += 5;
                        }
                        else
                        {
                            iskrenPoints += numbers[index];
                            numbers[index] = 0;
                        }
                    }
                }

                command = Console.ReadLine();

            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(numbers[i] + " - ");
            }
            Console.WriteLine(numbers[numbers.Length - 1]);
            Console.WriteLine($"Iskren finished the archery tournament with {iskrenPoints} points!");
        }
    }
}
