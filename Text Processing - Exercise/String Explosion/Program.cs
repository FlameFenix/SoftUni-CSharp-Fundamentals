using System;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string newText = string.Empty;

            int explosion = 0;

            for (int i = 0; i < text.Length; i++)
            {
                string currentSymbol = text[i].ToString();
                if (currentSymbol == ">")
                {
                    explosion += int.Parse(text[i + 1].ToString());
                }
                else
                {
                    if (explosion > 0)
                    {
                        text = text.Remove(i, 1);
                        explosion--;
                        i--;
                    }
                }

            }
            Console.WriteLine(text);
        }
    }
}
