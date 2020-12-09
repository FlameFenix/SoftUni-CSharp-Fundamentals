using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                             .Split(" ")
                                             .Select(int.Parse)
                                             .ToArray();
            int biggestCount = 0;
            int SequenceNumber = 0;
            int[] largestSequence = new int[biggestCount];
            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;
                int currentNumber = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currentNumber == array[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    if (count > biggestCount)
                    {
                        biggestCount = count;
                        SequenceNumber = array[j];
                    }
                }
            }
            for (int i = 0; i < biggestCount; i++)
            {
                Console.Write($"{SequenceNumber} ");
            }
        }
    }
}
