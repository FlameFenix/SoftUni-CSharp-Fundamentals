using System;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            RepeatString(word, count);
        }

        static void RepeatString(string word, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{word}");
            }
        }
    }
}
