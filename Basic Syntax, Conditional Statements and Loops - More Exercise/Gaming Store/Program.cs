using System;

namespace Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string nameOfGame = Console.ReadLine();
            double boughtGames = 0;
            double boughtGamesSum = 0;
            while (nameOfGame != "Game Time")
            {
                boughtGames = 0;
                if (nameOfGame == "OutFall 4")
                {
                    boughtGames += 39.99;
                }
                else if (nameOfGame == "CS: OG")
                {
                    boughtGames += 15.99;
                }
                else if (nameOfGame == "Zplinter Zell")
                {
                    boughtGames += 19.99;
                }
                else if (nameOfGame == "Honored 2")
                {
                    boughtGames += 59.99;
                }
                else if (nameOfGame == "RoverWatch")
                {
                    boughtGames += 29.99;
                }
                else if (nameOfGame == "RoverWatch Origins Edition")
                {
                    boughtGames += 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    nameOfGame = Console.ReadLine();
                    continue;
                }
                if (budget < boughtGames)
                {
                    Console.WriteLine("Too Expensive");
                    nameOfGame = Console.ReadLine();
                    continue;
                }
                else
                {
                    budget -= boughtGames;
                    if (budget < 0)
                    {
                        break;
                    }
                    else
                    {
                        boughtGamesSum += boughtGames;
                        Console.WriteLine($"Bought {nameOfGame}");
                    }
                }
                nameOfGame = Console.ReadLine();
            }
            if (budget > 0)
            {
                Console.WriteLine($"Total spent: ${boughtGamesSum:f2}. Remaining: ${budget:f2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}
