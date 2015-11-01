using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceATag
{
    static void Main()
    {
        string input = @"<ul>
                       <li>
                       <a href=http://softuni.bg>SoftUni</a>
                       </li>
                       </ul>";
        string pattern = @"((?<openTagStart><a) href=(?<==).*?(?=>)(?<openTagEnd>>).*?(?=<)(?<closedTag><\/a>))";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        Console.WriteLine(matches);
        foreach (Match match in matches)
        {
            string pattern1 = @"[URL";
            string pattern2 = @"]";
            string pattern3 = @"[/URL]";

            string text = match.ToString();
            text = text.Replace(match.Groups["closedTag"].ToString(), pattern3);
            text = text.Replace(match.Groups["openTagStart"].ToString(), pattern1);
            text = text.Replace(match.Groups["openTagEnd"].ToString(), pattern2);

            Console.WriteLine(text);
        }
    }
}

