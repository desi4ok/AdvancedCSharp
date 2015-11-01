using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class ExtractEmails
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(?<=\s|^)[A-Za-z0-9]+[.\-_]{0,1}[A-Za-z0-0]*@([A-Za-z]+\-{0,1}[A-Za-z]*)(\.[A-Za-z]+\-{0,1}[A-Za-z]*)+";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

