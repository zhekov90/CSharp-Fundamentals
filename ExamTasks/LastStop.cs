using System;
using System.Collections.Generic;
using System.Linq;

namespace Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "END")
            {
                if (command[0] == "Change")
                {
                    int paintingNumber = int.Parse(command[1]);
                    int changedNumber = int.Parse(command[2]);
                   if(numbers.Contains(paintingNumber))
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == paintingNumber)
                            {
                                numbers[i] = changedNumber;
                                break;
                            }
                        }
                    }
                }
                else if (command[0] == "Hide" && numbers.Contains(int.Parse(command[1])))
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == int.Parse(command[1]))
                        {
                            numbers.RemoveAt(i);
                            break;
                        }
                    }
                }
                else if (command[0] == "Switch")
                {
                    int paintingNumber1 = int.Parse(command[1]);
                    int paintingNumber2 = int.Parse(command[2]);
                    if (numbers.Contains(paintingNumber1) && numbers.Contains(paintingNumber2))
                    {
                        int index1ToChange = 0;
                        int index2ToChange = 0;
                        int temp = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == paintingNumber1)
                            {
                                index1ToChange = i;
                                break;
                            }
                        }
                        for (int i = 0; i < numbers.Count; i++)
                        {

                            if (numbers[i] == paintingNumber2)
                            {
                                index2ToChange = i;
                                break;
                            }
                        }
                        temp = numbers[index1ToChange];
                        numbers[index1ToChange] = numbers[index2ToChange];
                        numbers[index2ToChange] = temp;
                    }
                    

                }
                else if (command[0] == "Insert")
                {
                    int place = int.Parse(command[1]);
                    if (place >= 0 && place <= numbers.Count)
                    {
                        numbers.Insert(place + 1, int.Parse(command[2]));
                    }

                }
                else if (command[0] == "Reverse")
                {
                    numbers.Reverse();
                }

                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
