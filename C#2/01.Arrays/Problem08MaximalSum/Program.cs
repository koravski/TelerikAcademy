/*Problem 8. Maximal sum

    Write a program that finds the sequence of maximal sum in given array.

Example:
input 	result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	2, -1, 6, 4

    Can you do it with only one loop (with single scan through the elements of the array)?
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08MaximalSum
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4,-8, 8 };
            

            int maxSum = arr[0], currentSum = arr[0];
            int start = 0, startTemp = 0, end = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                currentSum += arr[i];
                if (currentSum < arr[i])
                {
                    currentSum = arr[i];
                    startTemp = i;
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    start = startTemp;
                    end = i;
                }
            }

            Console.Write("The sequence with maximal sum is: ");
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
