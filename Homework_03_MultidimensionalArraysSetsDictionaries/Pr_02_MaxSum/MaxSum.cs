using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxSum
{
    static void Main()
    {
        string[] inputSize = Console.ReadLine().Split(' ');
        int[] size = Array.ConvertAll(inputSize, int.Parse);
        int[,] matrix = new int[size[0], size[1]];
        long maxSum = long.MinValue;
        int maxRow = 0;
        int maxCol = 0;

        for (int row = 0; row < size[0]; row++)
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] nums = Array.ConvertAll(line, int.Parse);

            for (int col = 0; col < size[1]; col++)
            {
                matrix[row, col] = nums[col];
            }
        }

        for (int row = 1; row < size[0] - 1; row++)
        {
            for (int col = 1; col < size[1] - 1; col++)
            {
                long sum = matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row - 1, col + 1] +
                    matrix[row, col - 1] + matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col - 1] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }

        Console.WriteLine("Sum = " + maxSum);

        for (int row = maxRow - 1; row <= maxRow + 1; row++)
        {
            for (int col = maxCol - 1; col <= maxCol + 1; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }



    }
}

