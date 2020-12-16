using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine()
                                      .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();
            int numberOfOperations = int.Parse(Console.ReadLine());

            string title = article[0];
            string content = article[1];
            string author = article[2];

            Article articles = new Article(title, content, author);

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                                          .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();
                string currentCommand = cmdArgs[0];
                string option = cmdArgs[1];

                if (currentCommand == "Edit")
                {
                    articles.Edit(option);
                }
                else if (currentCommand == "ChangeAuthor")
                {
                    articles.ChangeAuthor(option);
                }
                else if (currentCommand == "Rename")
                {
                    articles.Rename(option);
                }

            }
            Console.WriteLine(articles.ToString());

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
        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAuthor(string author)
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
