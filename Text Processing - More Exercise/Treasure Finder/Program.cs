using System;
using System.Linq;

namespace Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "find")
            {
                string newInput = string.Empty;

                int countKeys = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (countKeys >= numbers.Length)
                    {
                        countKeys = 0;
                    }

                    newInput += (char)(input[j] - numbers[countKeys]);
                    countKeys++;
                }
                string type = string.Empty;
                int startIndex = newInput.IndexOf('&');

                for (int i = startIndex; i < newInput.Length; i++)
                {
                    if(newInput[i + 1] == '&')
                    {
                        break;
                    }

                    type += newInput[i + 1];
                }

                int indexOfCords = newInput.IndexOf('<');
                int endIndexOfCords = newInput.IndexOf('>');

                string coordinates = newInput.Substring(indexOfCords + 1, (endIndexOfCords - indexOfCords) - 1);

                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
