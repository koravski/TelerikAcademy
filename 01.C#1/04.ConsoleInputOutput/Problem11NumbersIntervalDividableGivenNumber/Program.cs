/*Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
Examples:

start	end	p	comments
17	25	2	20, 25
5	30	6	5, 10, 15, 20, 25, 30
3	33	6	5, 10, 15, 20, 25, 30
3	4	0	-
99	120	5	100, 105, 110, 115, 120
107	196	18	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195*/


using System;
using System.Collections.Generic;

namespace Problem11NumbersIntervalDividableGivenNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write("Type first number: ");
			int numFirst = int.Parse(Console.ReadLine());
			Console.Write("Type last number: ");
			int numLast = int.Parse(Console.ReadLine());
			int sum = 0;
			var deck = new List<int>();
			for (int i = numFirst; i <= numLast; i++) {
				int divider = i % 5;

				if (divider == 0) {
					sum = sum + 1;
					deck.Add(i);

				}
			}
			Console.Write("Divisible on 5 numbers: {0} // {1} \n\n", sum, string.Join(", ", deck));
		}
	}
}
