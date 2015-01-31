/*Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.

Examples:

a	b	c	result
5	1	2	5 2 1
-2	-2	1	1 -2 -2
-2	4	3	4 3 -2
0	-2.5	5	5 0 -2.5
-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
10	20	30	30 20 10
1	1	1	1 1 1*/

using System;

namespace Problem07Sort3NumbersNestedIfs
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Enter three number:");
			Console.Write("a: ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("b: ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("c: ");
			double c = double.Parse(Console.ReadLine());


			if (a > b)
			{
				if (a > c)
				{
					if (b > c)
					{
						Console.WriteLine("Result --> {0} {1} {2}", a, b, c);
					}
					else
					{
						Console.WriteLine("Result --> {0} {1} {2}", a, c, b);
					}
				}
				else
				{
					Console.WriteLine("Result --> {0} {1} {2}", c, a, b);
				}
			}
			else
			{
				if (b > c)
				{
					if (a > c)
					{
						Console.WriteLine("Result --> {0} {1} {2}", b, a, c);
					}
					else
					{
						Console.WriteLine("Result --> {0} {1} {2}", b, c, a);
					}
				}
				else
				{
					Console.WriteLine("Result --> {0} {1} {2}", c, b, a);
				}
			}
		}
	}
}
