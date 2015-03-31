/*Problem 17. Longest string

    Write a program to return the string with maximum length from an array of strings.
    Use LINQ.
*/
using System;
using System.Linq;

namespace Problem17LongestString
{
    class LongestString
    {
        static void Main()
        {
            var text = new string[] 
            {
                "Hello.",
                "Some text here.",
                "Other text",
                "The longest text is here."
            };

            string result = text.OrderByDescending(t => t.Length).First(); 

            Console.WriteLine("The result: {0}", result);


        }
    }
}
