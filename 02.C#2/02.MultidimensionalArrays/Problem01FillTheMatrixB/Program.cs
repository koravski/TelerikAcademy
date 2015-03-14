/*Problem 1. Fill the matrix

    Write a program that fills and prints a matrix of size (n, n) as shown below:

Example for n=4:b) 	
1 	8 	9 	16
2 	7 	10 	15
3 	6 	11 	14
4 	5 	12 	13
	
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01FillTheMatrixB
{
    class Program
    {
        static void Main()
        {

            Console.Write("Enter the size of the matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            bool isDirDown = true;
            for (int col = 0, row = 0, index = 1; col < matrix.GetLength(1); col++)
            {
                while (row >= 0 && row < matrix.GetLength(0))
                {
                    matrix[row, col] = index++;
                    row += isDirDown ? +1 : -1; // Change 'row' value
                }
                // Change direction and change 'row' value
                isDirDown = !isDirDown;
                row += isDirDown ? +1 : -1;
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
