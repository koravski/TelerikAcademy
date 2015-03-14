/*Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
Examples:

n	Catalan(n)
0	1
5	42
10	16796
15	9694845*/

using System;
using System.Numerics;


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer in the range (1 < n < 100):");
            int n = int.Parse(Console.ReadLine());
            BigInteger Factorial2N = 1;
            BigInteger FactorialN = 1;
            BigInteger FacturialNPlus1 = 1;
            if (n == 1 || n >= 100)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            for (int i = 1; i <= 2 * n; i++)
            {
                Factorial2N *= i;
                if (i <= n)
                {
                    FactorialN *= i;
                }
            }
            for (int i = 1; i <= n + 1; i++)
            {
                FacturialNPlus1 *= i;
            }
            Console.WriteLine("{0}", Factorial2N / (FactorialN *
            FacturialNPlus1));
        }
    }

