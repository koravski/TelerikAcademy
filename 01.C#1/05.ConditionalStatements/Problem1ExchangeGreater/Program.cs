﻿/*Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
Examples:

a	b	result
5	2	2 5
3	4	3 4
5.5	4.5	4.5 5.5*/

using System;

namespace Problem1ExchangeGreater
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());

			if (a>b) {
				Console.WriteLine ("{0} {1}",b,a);

			} else {
				Console.WriteLine ("{0} {1}",a,b);
			}

		}
	}
}
