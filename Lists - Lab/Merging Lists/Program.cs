using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstList = Console.ReadLine()
                                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                       .ToList();
            List<string> secondList = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .ToList();
            List<string> result = new List<string>(firstList.Count + secondList.Count);
            bool isFirstEmpty = false;
            bool isSecondEmpy = false;
            int countFirst = 0;
            int countSecond = 0;

            for (int i = 0; i <= firstList.Count + secondList.Count; i++)
            {
                if (!isFirstEmpty)
                {
                    if (countFirst >= firstList.Count)
                    {
                        isFirstEmpty = true;
                        continue;
                    }
                    result.Add(firstList[countFirst]);
                    countFirst++;
                }
                if (!isSecondEmpy)
                {
                    if (countSecond >= secondList.Count)
                    {
                        isSecondEmpy = true;
                        continue;
                    }
                    result.Add(secondList[countSecond]);
                    countSecond++;
                }

            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
