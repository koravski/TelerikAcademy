/*Problem 4. Appearance count

    Write a method that counts how many times given number appears in given array.
    Write a test program to check if the method is workings correctly.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04AppearanceCount
{
    class Program
    {
        static void Main()
        {
            int[] array = { 0, 1, 2, 3, 4, 3, 3, 6 };

            int num = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Number {0}, appears {1} time",num, CountNumbers(array, num));
        }

        static int CountNumbers(int[] arr, int number)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==number)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
