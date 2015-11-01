using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TextFilter
{
    static void Main()
    {
        string temp = "Linux, Windows";
        string text = "It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client";
        string[] bannedWords = temp.Replace(", ", ",").Split(',');
        StringBuilder output = new StringBuilder(text);

        for (int i = 0; i < bannedWords.Length; i++)
        {
            string wordToReplace = bannedWords[i];
            string replacement = new string('*', wordToReplace.Length);
            
            output.Replace(wordToReplace, replacement);
        }
        Console.WriteLine(output);
        



    }
}

