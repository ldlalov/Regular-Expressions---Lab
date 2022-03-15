using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");
            string input = Console.ReadLine();
            MatchCollection dates = regex.Matches(input);
            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
