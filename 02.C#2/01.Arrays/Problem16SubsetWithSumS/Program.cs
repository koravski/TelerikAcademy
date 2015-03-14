/*Problem 16.* Subset with sum S

    We are given an array of integers and a number S.
    Write a program to find if there exists a subset of the elements of the array that has a sum S.

Example:
input array 	S 	result
2, 1, 2, 4, 3, 5, 2, 6 	14 	yes*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16SubsetWithSumS
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the sum: ");
            long s = long.Parse(Console.ReadLine());
            Console.Write("Enter the number of elements:");
            long N = long.Parse(Console.ReadLine());
            long[] arr = new long[N];
            int counter = 0;
            string subset = "";
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element {0} ---> ", i + 1);
                arr[i] = long.Parse(Console.ReadLine());
            }
            int maxSubsets = (int)Math.Pow(2, N) - 1;
            for (int i = 1; i <= maxSubsets; i++)
            {
                subset = "";
                long checkingSum = 0;
                for (int j = 0; j <= N; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        checkingSum = checkingSum + arr[j];
                        subset = subset + " " + arr[j];
                    }
                }
                if (checkingSum == s)
                {
                    Console.WriteLine("Number of subest that have the sum of {0}", s);
                    counter++;
                    Console.WriteLine("This subset has a sum of {0} : {1} ", s, subset);
                }
            }
            Console.WriteLine(counter);



        }
    }
}
