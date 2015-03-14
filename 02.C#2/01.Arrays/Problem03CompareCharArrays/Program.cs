/*Problem 3. Compare char arrays

    Write a program that compares two char arrays lexicographically (letter by letter).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03CompareCharArrays
{
    class Program
    {
        static void Main()
        {

            Console.Write("Enter first array length: ");
            int length1 = int.Parse(Console.ReadLine());
            char[] arr1 = new char[length1];
            for (int i = 0; i < length1; i++)
            {
                Console.Write("Enter Arr1[{0}]: ", i);
                arr1[i] = char.Parse(Console.ReadLine());
            }

            Console.Write("Enter second array length: ");
            int length2 = int.Parse(Console.ReadLine());
            char[] arr2 = new char[length2];
            for (int i = 0; i < length2; i++)
            {
                Console.Write("Enter Arr2[{0}]: ", i);
                arr2[i] = char.Parse(Console.ReadLine());
            }

            bool areEqual = true;

            if (length1 != length2)
            {
                areEqual = false;
            }
            else
            {

                for (int i = 0; i < length1; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        areEqual = false;
                    } 


                }


            }
            Console.WriteLine("Are the two arrays equal: {0}", areEqual);
        }
    }
}
