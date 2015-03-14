/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
Examples:

n	k	n! / k!
5	2	60
6	5	6
8	3	6720*/

using System;
using System.Numerics;


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter two integers n and k in the range (1 < k < n < 100):");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (k <= 1 || k > n || n <= 1 || n >= 100 || k >= 100)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            BigInteger factorialN = 1;
            int factorialK = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i <= k)
                {
                    factorialK *= i;
                }
            }
           
            Console.WriteLine("{0}", factorialN / factorialK);
        }
    }

