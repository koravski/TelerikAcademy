﻿/*Problem 20. Palindromes

    Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem20Palindromes
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            MatchCollection words = Regex.Matches(text, @"\b\w+\b");
            Console.WriteLine("Extracted palindromes from the sample text: ");
            foreach (var word in words)
            {
                if (IsPalindrome(word.ToString()))
                {
                    Console.WriteLine("- " + word);
                }
            }
            Console.WriteLine();
        }
        static bool IsPalindrome(string word)
        {
            return word.ToCharArray().SequenceEqual(word.ToCharArray().Reverse());
        }
    }
}
