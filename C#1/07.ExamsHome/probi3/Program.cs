using System;

namespace probi3
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			int number = int.Parse(Console.ReadLine ());

			int a = number / 1000;
			int b = (number / 100) % 10;
			int c = (number / 10) % 10;
			int d = number % 10;

			bool AA = a % 2 == 0;
			bool BB = b % 2 == 0;
			bool CC = c % 2 == 0;
			bool DD = d % 2 == 0;



			if (AA && BB && CC & DD) {

				int sumE = a + b + c;

				if (sumE > d) {
					Console.WriteLine ("{} right", sumE);
				} else {
					Console.WriteLine ("{} left", d);
				}


			}
		





		}
	}
}
