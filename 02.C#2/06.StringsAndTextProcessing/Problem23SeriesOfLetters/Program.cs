/*Problem 23. Series of letters

    Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

Example:
input 	output
aaaaabbbbbcdddeeeedssaa 	abcdedsa*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem23SeriesOfLetters
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int count = 1;
            for (int i = 0; i < text.Length; i++)
            {
                
                if (i==count)
                {
                    if (text[i]!=text[i-1])
                    {
                        Console.Write(text[i]);
                    }
                    count++;
                }
                else
                {
                    if (text[i] == text[i + 1])
                    {
                        Console.Write(text[i + 1]);
                    }
                    else
                    {
                        Console.Write(text[i]);
                    }

                }
                    
                
                
               
                
            }
            Console.WriteLine();
        }
    }
}
