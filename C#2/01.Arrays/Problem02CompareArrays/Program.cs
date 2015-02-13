/*Problem 2. Compare arrays

    Write a program that reads two integer arrays from the console and compares them element by element.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02CompareArrays
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the lenght of first the array: ");
            int a = int.Parse(Console.ReadLine());
            int[] arr1 = new int[a];
            Console.WriteLine("Enter the first array: ");

            for (int i = 0; i < a; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the lenght of second the array: ");
            int b = int.Parse(Console.ReadLine());
            int[] arr2 = new int[b];
            Console.WriteLine("Enter the second array: ");

            for (int i = 0; i < a; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            bool isEqual = true;

            if (arr1.Length != arr2.Length)
            {
                isEqual = false;
                
            }else
	        {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        isEqual = false;
                    }

                    
                }

	        }
        
                Console.WriteLine("Are the two arrays equal: {0}", isEqual);
        
        }
    }
}
