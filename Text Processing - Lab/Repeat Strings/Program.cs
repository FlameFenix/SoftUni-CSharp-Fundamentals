using System;

namespace Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                               .ToArray();

            string concatenated = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    concatenated += words[i];
                }
            }
            Console.WriteLine(concatenated);
        }
    }
}
