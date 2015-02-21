/*Problem 7. Reverse number

    Write a method that reverses the digits of given decimal number.

Example:
input 	output
256 	652
123.45 	54.321*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07ReverseNumber
{
    class Program
    {
        static void Main()
        {
            decimal num = decimal.Parse(Console.ReadLine());

            string numToString = Convert.ToString(num);

            string answer = ReverseNumber(numToString);

            Console.WriteLine(Convert.ToDecimal(answer));

        }

       private static string ReverseNumber (string number)
        {
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            return new string(array);

        }
    }
}
