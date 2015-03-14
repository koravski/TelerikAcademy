/*Problem 2. Get largest number

    Write a method GetMax() with two parameters that returns the larger of two integers.
    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02GetLargestNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third integer: ");
            int num3 = int.Parse(Console.ReadLine());

            int max = GetMax(GetMax(num1, num2), num3);
            Console.WriteLine("The largest number is: {0}", max);
        }

        private static int GetMax(int num1, int num2)
        {
            if (num1>num2)
            {
               return num1;
            }
            else
            {
               return num2;
            }
           
        }
    }
}
