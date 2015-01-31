/*Problem 19.** Spiral Matrix

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
Examples:

n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1  2  3  4
        4 3                 8 9 4               12 13 14 5
                            7 6 5               11 16 15 6
                                                10 9  8  7*/
using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer in the range(1<=n<=20):");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 20)
            {
                Console.WriteLine("Invalid range!");
                return;
            }
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            string direction = "right";
            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;

                }
                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }
                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }
                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }
            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    if (matrix[row, col] < 10)
                    {
                        Console.Write("{0}  ", matrix[row, col]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }

