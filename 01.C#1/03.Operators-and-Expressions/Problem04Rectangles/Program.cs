using System;

namespace Problem03Divideby7and5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Start:
			float width;
			float height;
			float perimeter;
			float area;

			Console.Write ("width: ");
			width = float.Parse (Console.ReadLine ());

			Console.Write ("height: ");
			height = float.Parse (Console.ReadLine ());;



			perimeter = 2 * (width + height);
			area = width * height;


			Console.WriteLine ("Perimeer is {0} and the area is {1}", perimeter, area);


			goto Start;
		}
	}
}
