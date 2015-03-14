/*Problem 2. Maximal sum

    Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02MaximalSum
{
    class Program
    {
        static void Main()
        {
            Console.Write("How many rows? ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("How many columns? ");
            int cols = int.Parse(Console.ReadLine());
            int[,] mat = new int[rows, cols];
            string inputNumber;

           for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    inputNumber = Console.ReadLine();
                    mat[row, col] = int.Parse(inputNumber);

                }
            }

            for (int row = 0; row < mat.GetLength(0); row++)
            {
                for (int col = 0; col < mat.GetLength(1); col++)
                {
                    Console.Write("{0} ", mat[row, col]);
                }
                Console.WriteLine();
            }

          

            int bestSum = int.MinValue;
            int bestCol = 0;
            int bestRow = 0;

            for (int row = 0; row < mat.GetLength(0)-2; row++)
            {
                for (int col = 0; col < mat.GetLength(1)-2; col++)
                {
                    int sum = mat[row, col] + mat[row, col + 1] + mat[row, col + 2] + mat[row + 1, col] + mat[row + 1, col + 1] + mat[row + 1, col + 2] + mat[row + 2, col] + mat[row + 2, col+1] + mat[row + 2, col+2];
                    if (sum>bestSum)
                    {
                        bestSum = sum;
                        bestCol = col;
                        bestRow = row;
                        
                    }
                    
                }
                
            }
            Console.WriteLine("The best platform is:");
            Console.WriteLine(" {0} {1} {2}", mat[bestRow, bestCol], mat[bestRow, bestCol + 1], mat[bestRow, bestCol + 2]);
            Console.WriteLine(" {0} {1} {2}", mat[bestRow + 1, bestCol], mat[bestRow + 1, bestCol + 1], mat[bestRow + 1, bestCol + 2]);
            Console.WriteLine(" {0} {1} {2}", mat[bestRow + 2, bestCol], mat[bestRow + 2, bestCol + 1], mat[bestRow + 2, bestCol + 2]);
            Console.WriteLine("The maximal sum is: {0}", bestSum);

            

        }
    }
}
