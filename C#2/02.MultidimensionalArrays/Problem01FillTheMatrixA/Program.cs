/*Problem 1. Fill the matrix

    Write a program that fills and prints a matrix of size (n, n) as shown below:

Example for n=4: a) 	
1 	5 	9 	13
2 	6 	10 	14
3 	7 	11 	15
4 	8 	12 	16*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01FillTheMatrixA
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int number = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                number = number + row;
              
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = number + 1;
                    number = number + n;
                }
                number = 0;
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
