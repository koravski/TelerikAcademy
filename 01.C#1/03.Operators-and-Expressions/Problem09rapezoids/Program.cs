using System;

namespace Problem9rapezoids
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Start:
			Console.Write ("Side a: ");
			double a = double.Parse (Console.ReadLine ());

			Console.Write ("Side b: ");
			double b = double.Parse (Console.ReadLine ());

			Console.Write ("Height: ");
			double h = double.Parse (Console.ReadLine ());

			double area = ((a + b) / 2) * h;

			Console.WriteLine (area);

			goto Start;
		}
	}
}
