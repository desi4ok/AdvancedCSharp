using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CollectTheCoins
{
    static void Main()
    {
        char[][] matrix = new char[4][];
        char[] moves;
        int row = 0;
        int col = 0;
        int coinsCount = 0;
        int wallsCount = 0;

        for (int i = 0; i < 4; i++)
        {
            string line = Console.ReadLine();
            matrix[i] = line.ToCharArray();
        }

        moves = Console.ReadLine().ToCharArray();
        int len = moves.Length;

        for (int move = 0; move < len; move++)
        {
            char currentMove = moves[move];

            if (currentMove == 'V')
            {
                if (row == 3 || col > matrix[row+1].Length)
                {
                    wallsCount++;
                }
                else
                {
                    row++;
                }
            }
            else if (currentMove == '^')
            { 
                if (row == 0 || col > matrix[row - 1].Length)
                {
                    wallsCount++;
                }
                else
                {
                    row--;
                }
            }
            else if (currentMove == '>')
            {
                if (col == matrix[row].Length - 1)
                {
                    wallsCount++;
                }
                else
                {
                    col++;
                }
            }
            else if (currentMove == '<')
            {
                if (col == 0)
                {
                    wallsCount++;
                }
                else
                {
                    col--;
                }
            }

            char currentChar = matrix[row][col];

            if (currentChar == '$')
            {
                coinsCount++;
            }

        }
        Console.WriteLine("Coins collected: " + coinsCount);
        Console.WriteLine();
        Console.WriteLine("Walls hit: " + wallsCount);
    }
}

