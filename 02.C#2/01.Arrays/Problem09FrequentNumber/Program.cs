/*Problem 9. Frequent number

    Write a program that finds the most frequent number in an array.

Example:
input 	result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	4 (5 times)*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09FrequentNumber
{
    class Program
    {
        static void Main()
        {
            int[] arr = {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};

            Array.Sort(arr);
            int number = 0;
            int prev = 0;
            int maxNumber = int.MinValue;
            int index = 0;

            for (int i = 1; i < arr.Length; i++)
			{
                prev = i - 1;

                    

                    if (arr[i] == arr[prev])
                    {
                        number++;

                    }
                    else
                    {
                        number = 0;
                    }

                    if (number > maxNumber)
                    {
                        maxNumber = number;
                        index = arr[i];
                    }
               
			}

            Console.WriteLine("{0} ({1} times)", index, maxNumber+1);
        }
    }
}
