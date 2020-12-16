using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string command = string.Empty;

            List<string> employees = new List<string>();

            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (command != "End")
            {
                string employee = input[1];
                string company = input[0];

                if (companies.ContainsKey(company))
                {
                    if (!companies[company].Contains(employee))
                    {
                        companies[company].Add(employee);
                    }
                }
                else
                {
                    companies.Add(company, new List<string> { employee });
                }
                input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                command = input[0];
            }

            foreach (var item in companies.OrderBy(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine($"{item.Key}");

                foreach (var employess in companies[item.Key])
                {
                    Console.WriteLine($"-- {employess}");
                }

            }
        }
    }
}
