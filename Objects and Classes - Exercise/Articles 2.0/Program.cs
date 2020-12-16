using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                                          .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();
                string title = cmdArgs[0];
                string content = cmdArgs[1];
                string author = cmdArgs[2];

                Article currentArticle = new Article(title, content, author);

                articles.Add(currentArticle);
            }

            string option = Console.ReadLine();

            if (option == "content")
            {
                foreach (var item in articles.OrderBy(x => x.Content))
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else if (option == "title")
            {
                foreach (var item in articles.OrderBy(x => x.Title))
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else if (option == "author")
            {
                foreach (var item in articles.OrderBy(x => x.Author))
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
