using System;
using System.Collections.Generic;

namespace Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            List<int> numbers = new List<int>();

            List<string> words = new List<string>();

            List<int> takeList = new List<int>();

            List<int> skipList = new List<int>();

            string finalWord = string.Empty;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] > 47 && word[i] < 58)

                {
                    string number = word[i].ToString();
                    numbers.Add(int.Parse(number));

                }
                else
                {
                    words.Add(word[i].ToString());
                }

            };

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 != 0)
                {
                    skipList.Add(numbers[i]);

                }
                else if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);

                }
            }
            int startIndex = 0;
            int endIndex = 0;

            int countSkip = 0;
            int countTake = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                startIndex = countTake + countSkip;
                endIndex = startIndex + numbers[i];
                if (i % 2 == 0)
                {
                    if (numbers[i] > 0)
                    {
                        for (int j = startIndex; j < endIndex; j++)
                        {
                            if (j > words.Count - 1)
                            {
                                break;
                            }
                            countTake++;
                            finalWord += words[j];
                        }
                    }
                }
                else if (i % 2 != 0)
                {
                    countSkip += numbers[i];
                }
            }
            Console.WriteLine(finalWord);
        }
    }
}
