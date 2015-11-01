using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ActivityTracker
{
    static void Main()
    {
        int numOfLines = int.Parse(Console.ReadLine());
        SortedDictionary<int, SortedDictionary<string, int>> info = new SortedDictionary<int, SortedDictionary<string, int>>();

        for (int i = 0; i < numOfLines; i++)
        {
            string[] input = Console.ReadLine().Split(new char[] {' ', '/'}, StringSplitOptions.RemoveEmptyEntries);
            int month = int.Parse(input[1]);
            string user = input[3];
            int distance = int.Parse(input[4]);

            if (!info.ContainsKey(month))
            {
                info[month] = new SortedDictionary<string, int>();
            }

            if (!info[month].ContainsKey(user))
            {
                info[month][user] = 0;
            }

            info[month][user] += distance;
        }

        
        foreach (var element in info)
        {
            bool firstElement = true;
            Console.Write(element.Key + ": ");
            foreach (var innerElement in element.Value)
            {
                if (firstElement)
                {
                    Console.Write("{0}({1})", innerElement.Key, innerElement.Value);
                    firstElement = false;
                }
                else
                {
                    Console.Write(", {0}({1})", innerElement.Key, innerElement.Value);
                }
            }
            Console.WriteLine();
        }
    }
}

