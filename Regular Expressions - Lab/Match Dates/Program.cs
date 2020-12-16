using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();

            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})";

            MatchCollection matchdates = Regex.Matches(dates, pattern);

            foreach (Match item in matchdates)
            {
                string day = item.Groups["day"].ToString();
                string month = item.Groups["month"].ToString();
                string year = item.Groups["year"].ToString();

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
