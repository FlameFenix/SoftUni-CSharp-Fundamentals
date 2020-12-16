using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeWord = Console.ReadLine();

            string currentWord = Console.ReadLine();

            while (true)
            {
                int index = currentWord.ToLower().IndexOf(removeWord.ToLower());

                if (index == -1)
                {
                    break;
                }

                currentWord = currentWord.Remove(index, removeWord.Length);

            }

            Console.WriteLine(currentWord);
        }
    }
}
