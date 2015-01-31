/*Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
Examples:

n	k	n! / (k! * (n-k)!)
3	2	3
4	2	6
10	6	210
52	5	2598960*/
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
            BigInteger factorialNK = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i <= k)
                {
                    factorialK *= i;
                }
            }
            for (int i = 1; i <= n - k; i++)
            {
                factorialNK *= i;
            }
            Console.WriteLine("{0}", factorialN /
            (factorialK * (factorialNK)));

            

        }
    }

