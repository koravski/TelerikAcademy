/*Problem 3. Correct brackets

    Write a program to check if in a given expression the brackets are put correctly.

Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03CorrectBrackets
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            if (CheckBrackets(text))
            {
                Console.WriteLine("Brackets are correct!");
            }
            else
            {
                Console.WriteLine("Brackets are NOT corrct!");
            }
        }

       private static bool CheckBrackets(string text)
        {
            int count = 0;
            
            foreach (var item in text)
            {
                if (item == '(')
                {
                    count++;
                }

                if (item==')')
                {
                    count--;
                }
            }
            return count == 0;
        
        }
    }
}
