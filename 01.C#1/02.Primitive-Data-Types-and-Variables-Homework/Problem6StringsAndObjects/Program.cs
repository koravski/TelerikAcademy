using System;

namespace Problem6StringsAndObjects
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string FisrtStringHello = "Hello";
			string SecondStringWorld = "World";
			object ConcatenationHelloWorld = FisrtStringHello + " " + SecondStringWorld;
			string HelloWorldCast = (string)ConcatenationHelloWorld;


			Console.WriteLine (HelloWorldCast);
		}
	}
}
