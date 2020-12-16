using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                                           .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                           .ToArray();



            Dictionary<string, int> race = new Dictionary<string, int>();

            foreach (var name in participants)
            {
                race.Add(name, 0);
            }
            string command = Console.ReadLine();

            while (command != "end of race")
            {
                string namePattern = @"[\W\d]";
                string distancePattern = @"[\WA-Za-z]";

                string name = Regex.Replace(command, namePattern, "");
                string distance = Regex.Replace(command, distancePattern, "");
                int kilometers = 0;
                foreach (var digit in distance)
                {
                    int currentNumber = int.Parse(digit.ToString());
                    kilometers += currentNumber;
                }

                if (race.ContainsKey(name))
                {
                    race[name] += kilometers;
                }

                command = Console.ReadLine();
            }

            int counter = 0;

            foreach (var item in race.OrderByDescending(x => x.Value))
            {
                counter++;
                string text = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";

                Console.WriteLine($"{counter}{text} place: {item.Key}");
                if (counter == 3)
                {
                    break;
                }
            }
        }
    }
}
