using System;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            string command = Console.ReadLine();
            Console.WriteLine($"<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine($"</h1>");
            Console.WriteLine($"<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine($"</article>");
            while (command!="end of comments")
            {
                Console.WriteLine($"<div>");
                Console.WriteLine($"    {command}");
                Console.WriteLine($"</div>");

                command = Console.ReadLine();
            }

        }
    }
}
