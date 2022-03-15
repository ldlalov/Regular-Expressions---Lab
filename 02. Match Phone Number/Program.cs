using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b");
            string phones = Console.ReadLine();
            MatchCollection matches = regex.Matches(phones);
            var matchedPhones = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
                Console.Write(string.Join(", ",matches));
        }
    }
}
