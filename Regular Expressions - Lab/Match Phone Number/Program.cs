using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = Console.ReadLine();

            string pattern = @"(?<space>\+359 2 \d{3}\b \d{4}\b)|(?<hyphen>\+359-2-\d{3}\b-\d{4}\b)";

            Regex match = new Regex(pattern);

            MatchCollection matches = Regex.Matches(phoneNumber, pattern);

            List<string> matchedPhones = new List<string>();

            foreach (var item in matches)
            {
                matchedPhones.Add(item.ToString());
            }

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
