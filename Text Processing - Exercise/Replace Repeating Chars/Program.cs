using System;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string newText = string.Empty;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] != text[i + 1])
                {
                    newText += (char)text[i];
                }
            }

            newText += (char)text[text.Length - 1];

            Console.WriteLine(newText);
        }
    }
}
