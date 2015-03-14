/*Problem 6. String length

    Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
    Print the result string into the console.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06StringLength
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write a string of maximum 20 characters:");
            string text = Console.ReadLine();

            char pad = '*';

            if (text.Length<=20)
            {
                Console.WriteLine(text.PadRight(20,pad));
            }
            else
            {
                Console.WriteLine("The string should be maximum 20 characters.");
            }
            
        }
    }
}
