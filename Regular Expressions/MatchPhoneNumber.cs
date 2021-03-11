using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var pattern = @"( ?\+359 2 \d{3} \d{4})|(\+ ?359-2-\d{3}-\d{4})";
            var phones = Console.ReadLine();

            var matches = Regex.Matches(phones, pattern);
            var list = new List<string>();
            foreach (Match match in matches)
            {
                list.Add(match.Value.Trim());
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
