using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> raceNumbers = Console.ReadLine()
                                           .Split()
                                           .Select(int.Parse)
                                           .ToList();

            int time = raceNumbers[(raceNumbers.Count / 2)];

            double firstRacerTime = 0;

            for (int i = 0; i < (raceNumbers.Count / 2); i++)
            {
                if (raceNumbers[i] > 0)
                {
                    firstRacerTime += raceNumbers[i];
                }
                else if (raceNumbers[i] == 0)
                {
                    firstRacerTime *= 0.80;
                }

            }

            double secondRacerTime = 0;
            for (int i = raceNumbers.Count - 1; i >= (raceNumbers.Count / 2) + 1; i--)
            {
                if (raceNumbers[i] > 0)
                {
                    secondRacerTime += raceNumbers[i];
                }
                else if (raceNumbers[i] == 0)
                {
                    secondRacerTime *= 0.80;
                }

            }

            if (firstRacerTime >= time && firstRacerTime > secondRacerTime)
            {
                Console.WriteLine($"The winner is right with total time: {secondRacerTime}");
            }
            else if (secondRacerTime >= time && firstRacerTime < secondRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {firstRacerTime}");
            }
        }
    }
}
