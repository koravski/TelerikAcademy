/*Problem 6. Divisible by 7 and 3

    Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
*/
using System;
using System.Linq;

namespace Problem06DivisibleBy7And3
{
    class DivisibleBy7And3
    {
        static void Main()
        {
            var numbers = new int[] { 7, 8, 21, 9, 2, 3, 4, 10, 49, 63 };
           
            
            var resutLinq = numbers.Where(n => n % 7 == 0 && n % 3 == 0).ToArray();
            Console.WriteLine(string.Join(", ", resutLinq));

            Console.WriteLine(new string('-', 50));
            
           var resultMethod =
                from number in numbers
                where number % 7 == 0 && number % 3 == 0
                select number;
            Console.WriteLine(string.Join(", ", resultMethod)); 
            
        }
    }
}
