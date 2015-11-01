using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixShuffling
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        string command = Console.ReadLine();
        while(command != "END")
        {
            string[] commandArray = command.Split(' ');
            bool isValid = commandArray[0] == "swap";
            if (commandArray.Length == 5 && isValid)
            {
                int x1 = int.Parse(commandArray[1]);
                int y1 = int.Parse(commandArray[2]);
                int x2 = int.Parse(commandArray[3]);
                int y2 = int.Parse(commandArray[4]);
                if (x1 >= 0 && x1 < rows && x2 >= 0 && x2 < rows && y1 >= 0 && y1 < cols && y2 >= 0 && y2 < cols)
                {
                    string temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write("{0,4}", matrix[row, col]);
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            command = Console.ReadLine();
        }
    }
}

