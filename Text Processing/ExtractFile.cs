using System;
using System.Collections.Generic;
using System.Linq;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int startIndex = path.LastIndexOf('\\');
            int endIndex = path.IndexOf('.');

            string file = path.Substring(startIndex + 1, endIndex - startIndex - 1);
            string extension = path.Substring(endIndex + 1);

            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
