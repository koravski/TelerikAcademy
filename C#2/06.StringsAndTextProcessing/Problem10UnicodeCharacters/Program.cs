/*Problem 10. Unicode characters

    Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.

Example:
input 	output
Hi! 	\u0048\u0069\u0021*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            
            string text = Console.ReadLine();
            foreach (var ch in text)
            {
                Console.Write("\\u{0:X4}",Convert.ToUInt16(ch));

                                  
            }
            Console.WriteLine();           
        }

         
    }
}
