using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deckOne = Console.ReadLine()
                                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                   .Select(int.Parse)
                                                   .ToList();

            List<int> deckTwo = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
            int countBattle = 0;
            List<int> winnersDeck = new List<int>(countBattle);
            while (deckTwo.Count != 0 && deckOne.Count != 0)
            {
                if (deckOne[countBattle] > deckTwo[countBattle])
                {
                    deckOne.Add(deckOne[countBattle]);
                    deckOne.Add(deckTwo[countBattle]);

                    deckTwo.Remove(deckTwo[countBattle]);
                    deckOne.Remove(deckOne[countBattle]);
                }
                else if (deckOne[countBattle] < deckTwo[countBattle])
                {
                    deckTwo.Add(deckTwo[countBattle]);
                    deckTwo.Add(deckOne[countBattle]);

                    deckTwo.Remove(deckTwo[countBattle]);
                    deckOne.Remove(deckOne[countBattle]);
                }
                else if (deckOne[countBattle] == deckTwo[countBattle])
                {
                    deckOne.Remove(deckOne[countBattle]);
                    deckTwo.Remove(deckTwo[countBattle]);
                }
            }

            if (deckOne.Count > deckTwo.Count)
            {
                Console.WriteLine($"First player wins! Sum: {deckOne.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {deckTwo.Sum()}");
            }
        }
    }
}
