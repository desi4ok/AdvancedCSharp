using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static void Main()
    {
        string str = Console.ReadLine();
        string reversedStr =  String.Empty;

        for (int i = 0; i < str.Length; i++)
        {
            reversedStr += str[str.Length - i - 1];
        }
        Console.WriteLine(reversedStr);
    }
}

