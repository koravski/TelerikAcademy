/*Problem 1. Fill the matrix

    Write a program that fills and prints a matrix of size (n, n) as shown below:

Example for n=4: d)*
1 	12 	11 	10
2 	13 	16 	9
3 	14 	15 	8
4 	5 	6 	7*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01FillTheMatrixD
{
    class Program
    {
        static bool IsTraversable(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLongLength(0) &&
            col >= 0 && col < matrix.GetLongLength(1) && matrix[row, col] == 0;
        }

        static void Main()
        {
            Console.Write("Enter the size of the matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            string direction = "down";
            int row = -1, col = 0;
            for (int index = 1; index <= matrix.GetLength(0) * matrix.GetLength(1); index++)
            {
                if (direction == "down")
                {
                    if (matrix[++row, col] == 0) matrix[row, col] = index;
                    if (!IsTraversable(matrix, row + 1, col)) direction = "right";
                }
                else if (direction == "right")
                {
                    if (matrix[row, ++col] == 0) matrix[row, col] = index;
                    if (!IsTraversable(matrix, row, col + 1)) direction = "up";
                }
                else if (direction == "up")
                {
                    if (matrix[--row, col] == 0) matrix[row, col] = index;
                    if (!IsTraversable(matrix, row - 1, col)) direction = "left";
                }
                else if (direction == "left")
                {
                    if (matrix[row, --col] == 0) matrix[row, col] = index;
                    if (!IsTraversable(matrix, row, col - 1)) direction = "down";
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write("{0, -5}", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    }
}
