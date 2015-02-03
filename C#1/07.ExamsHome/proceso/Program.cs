using System;

namespace proceso
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int sum = 0;

			for (int i = 0; i < 1000; i++) {

				for (int j = 0; j < 1000; j++) {
					for (int k = 0; k < 1000; k++) {
						for (int l = 0; l < 1000; l++) {
							sum += (i +j + k + l);
						}
					}

				}
			} 

			Console.WriteLine (sum);
		}
	}
}
