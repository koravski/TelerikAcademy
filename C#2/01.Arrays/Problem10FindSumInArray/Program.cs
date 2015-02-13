/*Problem 10. Find sum in array

    Write a program that finds in given array of integers a sequence of given sum S (if present).

Example:
array 	S 	result
4, 3, 1, 4, 2, 5, 8 	11 	4, 2, 5*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10FindSumInArray
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
            int s = 11;
            int sum = 0;
            bool solution = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum == s)
                    {
                        solution = true;
                        Console.Write("The following sequence has the sum of {0}: ", s);
                        for (int print = i; print <= j; print++)
                        {
                            Console.Write("{0} ", arr[print]);
                        }
                        Console.WriteLine();
                    }
                }
                sum = 0;
            }
            if (!solution)
            {
                Console.WriteLine("Ain't no sequnce with the sum of {0}!", s);
            }
        }
    }
}
