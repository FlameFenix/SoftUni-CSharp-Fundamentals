using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            Dictionary<string, string> ownerOfCars = new Dictionary<string, string>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                string command = cmdArgs[0];

                if (command == "register")
                {
                    string username = cmdArgs[1];
                    string licensePlate = cmdArgs[2];

                    if (ownerOfCars.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {ownerOfCars[username]}");
                    }
                    else
                    {
                        ownerOfCars.Add(username, licensePlate);

                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    string username = cmdArgs[1];
                    if (ownerOfCars.ContainsKey(username))
                    {
                        ownerOfCars.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var item in ownerOfCars)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
