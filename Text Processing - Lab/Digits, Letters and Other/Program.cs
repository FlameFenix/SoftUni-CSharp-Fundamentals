using System;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();

            string numbers = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;

            for (int i = 0; i < symbols.Length; i++)
            {
                if (char.IsDigit(symbols[i]))
                {
                    numbers += symbols[i];
                }
                else if (char.IsLetter(symbols[i]))
                {
                    letters += symbols[i];
                }
                else
                {
                    others += symbols[i];
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
