using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 1; i <= numberOfOperations; i++)
            {
                int pressedNumber = int.Parse(Console.ReadLine());
                string pressednumberToString = Convert.ToString(pressedNumber);
                int mainDigit = pressedNumber % 10;
                int offset = (mainDigit - 2) * 3;

                if (mainDigit > 7)
                {
                    offset++;
                }

                int letterIndex = (offset + pressednumberToString.Length - 1);
                int AsciiCode = 97 + letterIndex;

                if (pressedNumber == 0)
                {
                    AsciiCode = 32;
                }

                char symbol = Convert.ToChar(AsciiCode);
                word += symbol;
            }

            Console.WriteLine(word);
        }
    }
}
