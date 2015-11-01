using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountSubstringOccurences
{
    static void Main()
    {
        string text = Console.ReadLine().ToUpper();
        string pattern = Console.ReadLine().ToUpper();
        int pos = text.IndexOf(pattern);
        int numOfAppearance = 0;

        while (pos > -1 && pos <= text.Length)
        {
            numOfAppearance++;
            pos++;
            pos = text.IndexOf(pattern, pos);
        }

        Console.WriteLine(numOfAppearance);
    }
}

