using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            VolewsCounter(word);
        }
        public static void VolewsCounter(string word)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    counter++;
                }
                else if (word[i] == 'e')
                {
                    counter++;
                }
                else if (word[i] == 'i')
                {
                    counter++;
                }
                else if (word[i] == 'o')
                {
                    counter++;
                }
                else if (word[i] == 'u')
                {
                    counter++;
                }
            }
            Console.Write(counter);
        }
    }
}
