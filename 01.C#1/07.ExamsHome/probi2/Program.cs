using System;

namespace probi2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++) {


				for (int k = 0; k < n; k++) {

					if (k==i) {
						Console.Write ("*");
					} else {
						Console.Write (".");
					}








				}


				for (int m = 0; m < n; m++) {

					if (m==i) {
						Console.Write ("*");
					} else {
						Console.Write (".");
					}}

				Console.WriteLine ();
			}
		}
	}
}
