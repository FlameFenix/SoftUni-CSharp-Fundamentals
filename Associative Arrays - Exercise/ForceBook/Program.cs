using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            List<string> users = new List<string>();

            while (command != "Lumpawaroo")
            {
                string[] cmdArgs = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (cmdArgs.Length == 2)
                {
                    string side = cmdArgs[0];
                    string userName = cmdArgs[1];

                    if (users.Contains(userName))
                    {

                    }
                    else
                    {
                        if (sides.ContainsKey(side))
                        {
                            sides[side].Add(userName);
                        }
                        else
                        {
                            sides.Add(side, new List<string>() { userName });
                        }

                        users.Add(userName);
                    }
                }
                else if (cmdArgs.Length < 2)
                {
                    cmdArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string userName = cmdArgs[0];
                    string side = cmdArgs[1];

                    if (users.Contains(userName))
                    {

                        foreach (var item in sides)
                        {
                            foreach (var user in sides[item.Key])
                            {
                                if (user == userName)
                                {
                                    sides[item.Key].Remove(userName);
                                    break;
                                }
                            }
                        }
                        if (sides.ContainsKey(side))
                        {
                            sides[side].Add(userName);
                        }
                        else
                        {
                            sides.Add(side, new List<string>() { userName });
                        }

                    }

                    else
                    {
                        if (sides.ContainsKey(side))
                        {
                            sides[side].Add(userName);
                        }
                        else
                        {
                            sides.Add(side, new List<string>() { userName });
                        }
                        users.Add(userName);
                    }
                    Console.WriteLine($"{userName} joins the {side} side!");
                }

                command = Console.ReadLine();
            }

            foreach (var forceusers in sides.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                if (forceusers.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {forceusers.Key}, Members: {forceusers.Value.Count()}");
                    foreach (var user in sides[forceusers.Key].OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
