using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(1);

            if (number == 1)
            {
                return;
            }

            int[] arr = new int[] { 1, 1 };
            Console.WriteLine(string.Join(" ", arr));

            if (number == 2)
            {
                return;
            }

            else
            {
                for (int i = 0; i < arr.Length + 1; i++)
                {
                    int[] array = new int[arr.Length + 1];
                    array[0] = 1;
                    array[array.Length - 1] = 1;

                    for (int j = 1; j < array.Length - 1; j++)
                    {
                        array[j] = arr[j - 1] + arr[j];
                    }
                    Console.WriteLine(string.Join(" ", array));

                    arr = array;

                    if (arr.Length == number)
                    {
                        break;
                    }
                }
            }
        }
    }
}
