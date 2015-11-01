using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter \"A\" or \"B\" for the pattern: ");
        string pattern = Console.ReadLine();
        Console.Write("Enter a size of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        if (pattern == "A")
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == 0)
                    {
                        matrix[row - 1, col] = row;
                    }
                    else
                    {
                        matrix[row - 1, col] = matrix[row - 1, col - 1] + n;
                    }
                    Console.Write("{0,4}", matrix[row - 1, col]);
                }
                Console.WriteLine();
            }
        }
        else if(pattern == "B")
        {
            int firstConst = 2*n - 1;
            int secondConst = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == 0)
                    {
                        matrix[row - 1, col] = row;
                    }
                    else if (col % 2 == 0)
                    {
                        matrix[row - 1, col] = matrix[row - 1, col - 1] + secondConst;
                    }
                    else
                    {
                        matrix[row - 1, col] = matrix[row - 1, col - 1] + firstConst;
                    }
                    Console.Write("{0,4}", matrix[row - 1, col]);
                }
                firstConst -= 2;
                secondConst += 2;
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid pattern!");
        }

    }
}

