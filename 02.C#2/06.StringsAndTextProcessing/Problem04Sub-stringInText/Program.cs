﻿/*Problem 4. Sub-string in text

    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem04Sub_stringInText
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter some text");
            string text = Console.ReadLine();
            Console.Write("Enter word to find: ");
            string find = Console.ReadLine();

            string textToLower = text.ToLower();

            
            int count = 0;
            foreach (Match m in Regex.Matches(textToLower, find))
            {
                count++; 
            
            }

            Console.WriteLine(count);
            
        }
    }
}
