/*Problem 24. Order words

    Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem24OrderWords
{
    class Program
    {
        static void Main()
        {
            Console.Write("Write words separeted by space: ");
            string text = Console.ReadLine();

            string[] textArr = text.Split(new char[] { ' ' });

            var result = textArr.OrderBy(x => x);

            Console.WriteLine(string.Join(", ", result));


        }
    }
}
