using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string stringToRetyrnInUnicode = Console.ReadLine();
        string unicodeString = String.Empty;
                
        StringBuilder sb = new StringBuilder();
        foreach (char ch in stringToRetyrnInUnicode)
        {
            sb.Append("\\u");
            sb.Append(String.Format("{0:x4}", (int)ch));
        }
        unicodeString = sb.ToString();
        Console.WriteLine(unicodeString);
    }
}

