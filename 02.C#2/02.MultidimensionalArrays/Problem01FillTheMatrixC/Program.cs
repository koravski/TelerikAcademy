/*Problem 1. Fill the matrix

    Write a program that fills and prints a matrix of size (n, n) as shown below:

Example for n=4:c)
7 	11 	14 	16
4 	8 	12 	15
2 	5 	9 	13
1 	3 	6 	10
	*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01FillTheMatrixC
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = matrix.GetLength(0) - 1, index = 1; index <= matrix.GetLength(0) * matrix.GetLength(1); row--)
            {
                for (int currCol = (row >= 0 ? 0 : -row), currRow = (row >= 0 ? row : 0);
                currCol < (matrix.GetLength(1) - (row >= 0 ? row : 0)); )
                {
                    matrix[currRow++, currCol++] = index++;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, -5}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
