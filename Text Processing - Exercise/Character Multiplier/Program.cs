using System;
using System.Linq;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            int result = 0;

            if (words[0].Length == words[1].Length)
            {
                string firstWord = words[0];
                string secondWord = words[1];

                for (int i = 0; i < firstWord.Length; i++)
                {
                    result += firstWord[i] * secondWord[i];
                }
            }
            else if (words[0].Length > words[1].Length)
            {
                string firstWord = words[0];
                string secondWord = words[1];

                for (int i = 0; i < firstWord.Length; i++)
                {
                    if (i < secondWord.Length)
                    {
                        result += firstWord[i] * secondWord[i];
                    }
                    else
                    {
                        result += firstWord[i];
                    }
                }
            }
            else if (words[0].Length < words[1].Length)
            {
                string firstWord = words[0];
                string secondWord = words[1];

                for (int i = 0; i < secondWord.Length; i++)
                {
                    if (i < firstWord.Length)
                    {
                        result += firstWord[i] * secondWord[i];
                    }
                    else
                    {
                        result += secondWord[i];
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
