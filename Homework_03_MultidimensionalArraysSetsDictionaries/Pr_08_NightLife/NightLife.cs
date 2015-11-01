using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_08_NightLife
{
    class NightLife
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, SortedDictionary<string, SortedSet<string>>> info = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            while (input != "END")
            {
                string[] inputArray = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                string city = inputArray[0];
                string venue = inputArray[1];
                string performer = inputArray[2];

                if (!info.ContainsKey(city))
                {
                    info[city] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!info[city].ContainsKey(venue))
                {
                    info[city][venue] = new SortedSet<string>();
                }

                info[city][venue].Add(performer);
                input = Console.ReadLine();
            }

            foreach (var element in info)
            {
                Console.WriteLine(element.Key);
                foreach (var innerElement in element.Value)
                {
                    Console.WriteLine("->{0}: {1}", innerElement.Key, String.Join(", ", innerElement.Value));
                }
            }
        }
    }
}
