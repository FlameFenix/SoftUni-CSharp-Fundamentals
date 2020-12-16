using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            Dictionary<char, int> occurences = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                char[] currentWords = words[i].ToArray();

                for (int j = 0; j < currentWords.Length; j++)
                {
                    char currentChar = currentWords[j];
                    if (occurences.ContainsKey(currentChar))
                    {
                        occurences[currentChar]++;
                    }
                    else
                    {
                        occurences.Add(currentChar, 1);
                    }
                }
            }

            foreach (var item in occurences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
