﻿/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
Example 1:

input	output
3 
2 
5 
1	min = 1 
max = 5 
sum = 8 
avg = 2.67
Example 2:

input	output
2 
-1 
4	min = -1 
max = 4 
sum = 3 
avg = 1.50*/
using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter length of loop: ");
            int length = int.Parse(Console.ReadLine());
 
            int min = int.MaxValue;
            int max = int.MinValue;
            double sum = 0;
            double avg = 0;
 
            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(Console.ReadLine());

                min = Math.Min(min, number);

                max = Math.Max(max, number);

                sum += number;

                avg = sum / length;
            }
 
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Avg = {0:F2}", avg);
        }


     }
    
