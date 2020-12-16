using System;
using System.Linq;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                                          .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                if (text.Contains(bannedWords[i]))
                {
                    string asterisk = string.Empty;
                    for (int j = 0; j < bannedWords[i].Length; j++)
                    {
                        asterisk += "*";
                    }
                    text = text.Replace(bannedWords[i], asterisk);
                }
            }

            Console.WriteLine(text);
        }
    }
}
