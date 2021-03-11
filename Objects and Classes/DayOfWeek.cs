using System;
using System.Globalization;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime dateTime = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dateTime.DayOfWeek);
        }
    }
}
