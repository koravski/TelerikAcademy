/*Problem 1. Decimal to binary

    Write a program to convert decimal numbers to their binary representation.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01DecimalToBinary
{
    class DecToBin
    {
        static void Main()
        {
            
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);

        }
    }
}
