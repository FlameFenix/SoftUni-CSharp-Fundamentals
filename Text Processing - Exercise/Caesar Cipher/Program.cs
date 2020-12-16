using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string encryptedWord = string.Empty;

            int numberOfSymbol = 0;

            for (int i = 0; i < text.Length; i++)
            {
                numberOfSymbol = text[i] + 3;

                encryptedWord += (char)numberOfSymbol;
            }

            Console.WriteLine(encryptedWord);
        }
    }
}
