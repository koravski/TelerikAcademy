﻿/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
Examples:

n	x	S
3	2	2.75000
4	3	2.07407
5	-4	0.75781*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two whole numbers n and x:");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int Factorial = 1;
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            Factorial *= i;
            sum += (Factorial / Math.Pow(x, i));
        }
        Console.WriteLine("{0:F5}", sum);
    }
}