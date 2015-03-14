/*Write a program that finds the biggest of three numbers.
Examples:

a	b	c	biggest
5	2	2	5
-2	-2	1	1
-2	4	3	4
0	-2.5	5	5
-0.1	-0.5	-1.1	-0.1
*/

using System;

namespace Problem05TheBiggest3Numbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.Write("a = ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("b = ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("c = ");
			double c = double.Parse(Console.ReadLine());


		

			if (a>=b && a>=c)
			{
				Console.WriteLine(a);
			}

			else if (b>=a && b>=c)
			{
				Console.WriteLine(b);

			}

			else if (c>=a && c>=b)
			{
				Console.WriteLine(c);
			}

		}
	}
}
