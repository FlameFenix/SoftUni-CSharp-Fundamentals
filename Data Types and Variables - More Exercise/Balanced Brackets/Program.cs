using System;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            int countOpen = 0;
            int countClosed = 0;
            string output = string.Empty;
            bool isFirstOpenTag = true;
            for (int i = 0; i < numberOfOperations; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    countOpen++;
                }
                else if (input == ")")
                {
                    countClosed++;
                    if (countOpen < countClosed)
                    {
                        isFirstOpenTag = false;
                    }
                }
            }
            if (countOpen == countClosed && isFirstOpenTag)
            {
                output = "BALANCED";
            }
            else
            {
                output = "UNBALANCED";
            }
            Console.WriteLine(output);
        }
    }
}
