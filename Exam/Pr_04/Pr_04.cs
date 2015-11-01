using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pr_04
{
    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, SortedSet<string>> info = new Dictionary<string, SortedSet<string>>();
        Dictionary<string, int> winsInfo = new Dictionary<string, int>();

        while (true)
        {
            if (input == "report")
            {
                break;
            }

            if (string.IsNullOrEmpty(input) != true)
            {
                string[] temp = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string athlete = temp[0].Trim();
                athlete = string.Join(" ", athlete.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                string country = temp[1].Trim();

                if (!info.ContainsKey(country))
                {
                    info[country] = new SortedSet<string>();
                    winsInfo[country] = 0;
                }

                info[country].Add(athlete);
                winsInfo[country]++;
            }
            input = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        var items = from pair in winsInfo
                    orderby pair.Value descending
                    select pair;

        foreach (var win in items)
        {
            foreach (var element in info)
            {
                int count = 0;
                foreach (var innerElement in element.Value)
                {
                    count++;
                }

                if (element.Key == win.Key)
                {
                    Console.WriteLine(element.Key + " (" + count + " participants): " + win.Value + " wins");
                }
            }
        }
    }
}

