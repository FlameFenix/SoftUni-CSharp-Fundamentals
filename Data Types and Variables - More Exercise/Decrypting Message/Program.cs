using System;

namespace Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfOperations = int.Parse(Console.ReadLine());
            string newWord = string.Empty;
            for (int i = 1; i <= numberOfOperations; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                currentChar += (char)key;
                newWord += currentChar;
            }
            Console.WriteLine(newWord);
        }
    }
}
