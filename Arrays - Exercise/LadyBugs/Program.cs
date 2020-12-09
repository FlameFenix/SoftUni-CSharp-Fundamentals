using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] indexes = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            int[] field = new int[fieldSize];

            foreach (var item in indexes)
            {
                if (item >= 0 && item < fieldSize)
                {
                    field[item] = 1;
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int currentIndex = int.Parse(elements[0]);

                string direction = elements[1];

                int indexToFly = int.Parse(elements[2]);



                if (currentIndex < 0 || currentIndex > field.Length - 1 || field[currentIndex] == 0)
                {
                    continue;
                }

                field[currentIndex] = 0;



                if (direction == "right")
                {
                    int landIndex = currentIndex + indexToFly;

                    if (landIndex > field.Length - 1 || landIndex < 0)
                    {
                        continue;
                    }

                    while (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        if (field[landIndex] == 0)
                        {
                            field[landIndex] = 1;
                            break;
                        }
                        else if (field[landIndex] == 1)
                        {
                            landIndex += indexToFly;
                        }
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = currentIndex - indexToFly;

                    if (landIndex > field.Length - 1 || landIndex < 0)
                    {
                        continue;
                    }

                    while (landIndex >= 0)
                    {
                        if (field[landIndex] == 0)
                        {
                            field[landIndex] = 1;
                            break;
                        }
                        else if (field[landIndex] == 1)
                        {
                            landIndex -= indexToFly;
                        }
                    }
                }


            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
