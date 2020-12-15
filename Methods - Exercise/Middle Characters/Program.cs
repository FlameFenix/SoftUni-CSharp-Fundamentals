using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            MiddleCharacters(word);
        }

        public static void MiddleCharacters(string word)
        {
            int greaterI = 0;
            bool oneChar = false;
            bool twoChars = false;
            char previousChar = ' ';
            char middleChar = ' ';
            for (int i = 0; i <= word.Length / 2; i++)
            {
                if (word.Length % 2 == 1)
                {
                    oneChar = true;
                }
                if (i > greaterI)
                {
                    middleChar = word[i];
                }
                if (word.Length % 2 == 0)
                {
                    if (i == 0)
                    {
                        previousChar = word[i];
                    }
                    else
                    {
                        previousChar = word[i - 1];
                    }
                    twoChars = true;
                }
            }
            if (oneChar)
            {
                Console.WriteLine(middleChar);
            }
            else if (twoChars)
            {
                Console.WriteLine($"{previousChar}{middleChar}");
            }

        }
    }
}
