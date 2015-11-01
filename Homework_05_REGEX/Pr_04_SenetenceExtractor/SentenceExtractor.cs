using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        string keyword = Console.ReadLine();
        string text = Console.ReadLine();
        string pattern = @"((?<innerGroup>[A-Z].*?(?=\!|\?|\.))[?!.])";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);

        foreach (Match match in matches)
        {
            string sentence = match.Groups["innerGroup"].ToString();
            string patt = String.Format(@"\b{0}\b", keyword);
            Regex reg = new Regex(patt);
            bool containsValidDate = reg.IsMatch(sentence);
            if (containsValidDate == true)
            {
                Console.WriteLine(match);
            }
        }
    }
}

