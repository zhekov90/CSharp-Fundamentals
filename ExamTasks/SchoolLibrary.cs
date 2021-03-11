using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split("&").ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (command[0] == "Done")
                {
                    Console.WriteLine(string.Join(", ", books));
                    break;
                }

                if (command[0] == "Add Book")
                {
                    if (books.Contains(command[1]))
                    {
                        continue;
                    }
                    books.Insert(0, command[1]);
                }
                else if (command[0] == "Take Book" && books.Contains(command[1]))
                {
                    books.Remove(command[1]);
                }
                // swaping two books
                else if (command[0] == "Swap Books" && books.Contains(command[1]) && books.Contains(command[2]))
                {
                    int book1 = books.IndexOf(command[1]);
                    int book2 = books.IndexOf(command[2]);
                    string temp = books[book1];
                    books[book1] = books[book2];
                    books[book2] = temp;
                }
                else if (command[0] == "Insert Book")
                {
                    books.Add(command[1]);
                }
                else if (command[0] == "Check Book" && int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= books.Count)
                {
                    int check = int.Parse(command[1]);
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (i == check)
                        {
                            Console.WriteLine(books[i]);
                            continue;
                        }
                    }
                }

            }

        }
    }
}
