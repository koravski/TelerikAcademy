using System;

	class Exchange
	{
		static void Main()
		{
			int a = 5;
			int b = 10;
			Console.WriteLine("Before exchange it {0}, {1}", a, b);

			int c = a;
			a = b;
			b = c;
			Console.WriteLine("After exchange it {0}, {1}", a, b);
		}
	}
