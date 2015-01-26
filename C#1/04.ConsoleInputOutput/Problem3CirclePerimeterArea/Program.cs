/*Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
Examples:

r	perimeter	area
2	12.57	12.57
3.5	21.99	38.48
*/

using System;

namespace Problem3CirclePerimeterArea
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("r: ");
			double r = double.Parse (Console.ReadLine ());

			double c = 2 * Math.PI * r;

			double a = Math.PI * Math.Pow (r, 2);

			Console.WriteLine ("Perimeter = {0:F2} \nArea = {1:F2}", c, a);

		}
	}
}
