using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                                   .Split()
                                                   .Select(int.Parse)
                                                   .ToList();

            string message = Console.ReadLine();

            List<string> messageToList = new List<string>(message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                messageToList.Insert(i, message[i].ToString());
            }

            string currentNumberToString = string.Empty;
            string newMessage = string.Empty;

            for (int i = 0; i <= numbers.Count - 1; i++)
            {
                int currentNumber = numbers[i];
                currentNumberToString = numbers[i].ToString();
                int currentSum = 0;
                for (int j = 0; j < currentNumberToString.Length; j++)
                {
                    currentSum += currentNumber % 10;
                    currentNumber /= 10;
                }
                int counter = 0;
                for (int k = 0; k <= messageToList.Count; k++)
                {
                    if (k >= messageToList.Count)
                    {
                        k = 0;
                    }
                    if (counter == currentSum)
                    {
                        newMessage += messageToList[k];

                        messageToList.RemoveAt(k);
                        break;
                    }
                    counter++;
                }
            }
            Console.WriteLine(newMessage);
        }
    }
}
