using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Palindromes
{
    static void Main()
    {
        string text = Console.ReadLine();
        char[] splitters = { ' ', '.', ',', '!', '?' };
        string[] word = text.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
        SortedSet<string> palyndromes = new SortedSet<string>();

        for (int i = 0; i < word.Length; i++)
        {
            string wordToCheck = word[i];
            int len = wordToCheck.Length;
            int halflen = len / 2;
            if (len == 1)
            {
                palyndromes.Add(wordToCheck);
            }
            else
            {
                string firstpart = wordToCheck.Substring(0, halflen);
                char[] temp = wordToCheck.Substring(len - halflen).ToCharArray();
                Array.Reverse(temp);
                string secondpart = new string(temp);

                if (firstpart == secondpart)
                {
                    palyndromes.Add(wordToCheck);
                }
            }
        }
        Console.WriteLine(String.Join(", ", palyndromes));
    }
}



