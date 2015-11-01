using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_06_CountSymbols
{
    class CountSymbols
    {
        static void Main()
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> pairs = new SortedDictionary<char, int>();

            foreach (char letter in text)
            {
                if (!pairs.ContainsKey(letter))
                {
                    pairs.Add(letter, 1);
                }
                else
                {
                    pairs[letter]++;
                }
            }

            foreach (KeyValuePair<char, int> pair in pairs)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
            }
        }
    }
}
