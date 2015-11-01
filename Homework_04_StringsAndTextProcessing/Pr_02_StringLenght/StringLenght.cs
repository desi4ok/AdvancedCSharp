using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLenght
{
    static void Main()
    {
        Console.WriteLine("Enter a string of maximum 20 characters");
        string str = Console.ReadLine();
        int strLength = str.Length;
        int diff = 20 - strLength;
        string output = String.Empty;

        if (diff <= 0)
        {
            output = str.Substring(0, 20);
        }
        else
        {
            output = str + new String('*', diff);
        }
        Console.WriteLine(output);

    }
}

