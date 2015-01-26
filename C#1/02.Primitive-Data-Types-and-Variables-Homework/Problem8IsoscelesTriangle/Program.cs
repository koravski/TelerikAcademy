using System;

namespace IsoscelesTriangle
{
	class Triangle
	{
		static void Main()
		{
			char copyright = '\u00A9';
			Console.WriteLine(" " + " " + " " + copyright);
			Console.WriteLine(" " + " " + copyright + " " + copyright);
			Console.WriteLine(" " + copyright + " " + " " + " " + copyright);
			Console.WriteLine(copyright + " " + copyright + " " + copyright + " " + copyright);
		}
	}
}