/*Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Examples:

a	b	c	roots
2	5	-3	x1=-3; x2=0.5
-1	3	0	x1=3; x2=0
-0.5	4	-8	x1=x2=4
5	2	8	no real roots*/

using System;

namespace Problem06QuadraticEquation
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("a = ");
			double a = double.Parse (Console.ReadLine ());
			Console.Write ("b = ");
			double b = double.Parse (Console.ReadLine ());
			Console.Write ("c = ");
			double c = double.Parse (Console.ReadLine ());

			if (a == 0) {
				Console.WriteLine ("a cannot be 0");
				return;
			} else {
				if ((Math.Pow(b, 2)-4*a*c) > 0) {
					double x1 = (-1*b - Math.Sqrt (Math.Pow (b, 2) - 4 * a * c)) / (2 * a);
					double x2 = (-1*b + Math.Sqrt (Math.Pow (b, 2) - 4 * a * c)) / (2 * a);
					Console.WriteLine ("x1 = {0}; x2 = {1}",x1,x2 );

				}
				else if  ((Math.Pow(b, 2)-4*a*c)==0) {
					double x1 = (-b + Math.Sqrt (Math.Pow (b, 2) - 4 * a * c)) / (2 * a);
					Console.WriteLine ("x1 = x2 = {0}",x1 );
				}
				else if ((Math.Pow(b, 2)-4*a*c) < 0) {
					Console.WriteLine ("no real roots");

				}
			}
		
		}
	}
}
