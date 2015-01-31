/*Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
Examples:

n	min	max	random numbers
5	0	1	1 0 0 1 1
10	10	15	12 14 12 15 10 12 14 13 13 11
Note: The above output is just an example. Due to randomness, your program most probably will produce different results.*/

using System;

namespace Problem11RandomNumbersInGivenRange
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            if (min > max)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int randomNumber = rnd.Next(min, max + 1);
                Console.Write("{0} ", randomNumber);
            }
            Console.WriteLine();



        }
    }
}
