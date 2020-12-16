using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)";

            Regex user = new Regex(pattern);

            MatchCollection matches = Regex.Matches(names, pattern);

            foreach (Match item in matches)
            {
                Console.Write($"{item.Value} ");
            }
        }
    }
}
