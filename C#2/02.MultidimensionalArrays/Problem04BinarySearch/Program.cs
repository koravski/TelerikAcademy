/*Problem 4. Binary search

    Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04BinarySearch
{
    class Program
    {
        static void Main()
        {
            Console.Write("Write the size of array N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("index {0}---->", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
         
            int myIndex = Array.BinarySearch(arr,k);

            if (myIndex < 0)
            {
                int smallerNumber = int.MinValue;
                int number = int.MinValue;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] < k)
                    {
                        number = arr[i];
                    }

                    if (number > smallerNumber)
                    {
                        smallerNumber = number;
                    }
                }

                Console.WriteLine(smallerNumber);
            }
            else 
            {
                Console.WriteLine(arr[myIndex]);
            }

        }
        
    }
}
