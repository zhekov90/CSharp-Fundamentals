using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int removedSum = 0;

            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    var numberToBeRemoved = numbers[0];
                    removedSum += numberToBeRemoved;
                    numbers[0] = numbers[numbers.Count - 1];


                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= numberToBeRemoved)
                        {
                            numbers[i] += numberToBeRemoved;
                        }
                        else
                        {
                            numbers[i] -= numberToBeRemoved;
                        }
                    }
                }
                else if (index >= numbers.Count)
                {
                    var numberToBeRemoved = numbers[numbers.Count - 1];
                    removedSum += numberToBeRemoved;
                    numbers[numbers.Count - 1] = numbers[0];
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= numberToBeRemoved)
                        {
                            numbers[i] += numberToBeRemoved;
                        }
                        else
                        {
                            numbers[i] -= numberToBeRemoved;
                        }
                    }
                }
                else
                {
                    var numberToBeRemoved = numbers[index];
                    removedSum += numberToBeRemoved;
                    numbers.RemoveAt(index);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= numberToBeRemoved)
                        {
                            numbers[i] += numberToBeRemoved;
                        }
                        else
                        {
                            numbers[i] -= numberToBeRemoved;
                        }
                    }
                }
            }
            Console.WriteLine(removedSum);
        }

    }
}
