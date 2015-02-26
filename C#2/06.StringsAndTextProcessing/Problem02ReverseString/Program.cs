/*Problem 2. Reverse string

    Write a program that reads a string, reverses it and prints the result at the console.

Example:
input 	output
sample 	elpmas*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02ReverseString
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            Console.WriteLine(text.Reverse().ToArray());
        }
    }
}
