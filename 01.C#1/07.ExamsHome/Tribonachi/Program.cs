using System;

class Tribonacci
{
	static void Main(string[] args)
	{
		long first = long.Parse(Console.ReadLine());
		long second = long.Parse(Console.ReadLine());
		long third = long.Parse(Console.ReadLine());
		int L = int.Parse(Console.ReadLine());

		long fourt = first + second + third;

		if (L == 2)
		{
			Console.WriteLine(first);
			Console.WriteLine(second + " " + third);
		}
		else 
		{
			Console.WriteLine(first);
			Console.WriteLine(second + " " + third);
			Console.Write(fourt + " ");
			for (int k = 0; k < 2; k++)
			{
				first = second;
				second = third;
				third = fourt;
				fourt = first + second + third;
				Console.Write("{0} ", fourt);
			} Console.WriteLine();
			for (int i = 0; i < L - 3; i++)
			{
				for (int j = 0; j < i + 4; j++)
				{
					first = second;
					second = third;
					third = fourt;
					fourt = first + second + third;
					Console.Write("{0} ", fourt);
				} Console.WriteLine();
			}
		}
	}
}
