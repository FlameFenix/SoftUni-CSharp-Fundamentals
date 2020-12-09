using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int countBestSequences = 0;
            int bestBeginIndex = int.MaxValue;
            int bestSum = 0;
            int countPosition = 0;
            int bestPosition = 0;

            int[] currentSequences = new int[dnaLength];

            while (command != "Clone them!")
            {
                int[] sequences = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int countCurrentSequences = 0;
                int countBeginIndex = 0;

                countPosition++;

                for (int i = 0; i < sequences.Length - 1; i++)
                {
                    if (sequences[i] == sequences[i + 1])
                    {
                        if ((sequences[i] + sequences[i + 1]) == 2)
                        {
                            countCurrentSequences++;
                            if (countCurrentSequences == 1)
                            {
                                countBeginIndex = i;
                            }
                        }

                    }
                }

                if (countCurrentSequences > countBestSequences)
                {
                    currentSequences = sequences.ToArray();
                    countBestSequences = countCurrentSequences;
                    bestBeginIndex = countBeginIndex;
                    bestSum = currentSequences.Sum();
                    bestPosition = countPosition;
                }

                else if (countCurrentSequences == countBestSequences)
                {
                    if (countBeginIndex < bestBeginIndex)
                    {
                        currentSequences = sequences.ToArray();
                        countBestSequences = countCurrentSequences;
                        bestBeginIndex = countBeginIndex;
                        bestSum = currentSequences.Sum();
                        bestPosition = countPosition;
                    }

                    else if (countBeginIndex == bestBeginIndex)
                    {

                        if (currentSequences.Sum() > bestSum)
                        {
                            currentSequences = sequences.ToArray();
                            countBestSequences = countCurrentSequences;
                            bestBeginIndex = countBeginIndex;
                            bestSum = currentSequences.Sum();
                            bestPosition = countPosition;
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestPosition} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(" ", currentSequences)}");
        }
    }
}
