/*Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.

Examples:

n	comments
1	0
3	0 1 1
10	0 1 1 2 3 5 8 13 21 34*/

using System;

namespace Problem10FibonacciNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.Write("Enter number n: ");
			int n = int.Parse(Console.ReadLine());
			int num1 = 0, num2 = 1, sum = 0;
			Console.Write(num1 + " " + num2 + " ");
			for (int i = 0; i < n - 2; i++)
			{
				sum = num1 + num2;
				num1 = num2;
				num2 = sum;
				Console.Write(sum + " ");
			}
			Console.WriteLine();
		}
	}
}
