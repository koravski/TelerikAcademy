using System;

namespace Problem7PointInACircle
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Start:
			double firstNumber = double.Parse(Console.ReadLine());
			double SecondNumber = double.Parse(Console.ReadLine());
			double r = 2;

			double d = Math.Sqrt ( Math.Pow((firstNumber - 0), 2) + Math.Pow((SecondNumber - 0), 2));

			bool inCircle = d <= r;

			Console.WriteLine (inCircle);
			goto Start;
		}
	}
}
