using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(", ");
            Article article = new Article(tokens[0], tokens[1], tokens[2]);
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(": ");
                string command = input[0];
                if (command == "Edit")
                {
                    article.Edit(input[1]);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(input[1]);
                }
                else
                {
                    article.Rename(input[1]);
                }
            }
            Console.WriteLine(article);
        }

        class Article
        {
            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public void Edit(string content)
            {
                this.Content = content;
            }

            public void ChangeAuthor(string author)
            {
                this.Author = author;
            }

            public void Rename(string title)
            {
                this.Title = title;
            }

            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }
    }
}
