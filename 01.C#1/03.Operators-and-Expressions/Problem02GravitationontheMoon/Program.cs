using System;

namespace Problem02GravitationontheMoon
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Start:
			Console.Write ("Weight of a man: ");
			float weight;
			weight = float.Parse(Console.ReadLine());

			float weightMoon;

			weightMoon = weight * 0.17f; 


			Console.WriteLine("Weight on the Moon: " + weightMoon);
			

			goto Start;
		}
	}
}
