using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        string letters = Console.ReadLine() + "\n";
        string pattern = @"([a-z])\1*";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(letters);

        foreach (Match match in matches)
        {
            string matchString = match.ToString();
            char letter = matchString[0];
            Console.Write(letter);
        }
        Console.WriteLine("\n");
    }
}
