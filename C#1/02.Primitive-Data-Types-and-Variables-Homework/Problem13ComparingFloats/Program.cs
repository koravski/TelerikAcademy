namespace _13.ComparingFloats
{
	using System;

	class ComparingFloats
	{
		static void Main()
		{
			Console.Write("Enter first number : ");
			double firstNumber = double.Parse(Console.ReadLine());

			Console.Write("Enter second number : ");
			double secondNumber = double.Parse(Console.ReadLine());

			double difference = Math.Abs(firstNumber - secondNumber);

			double threshold = 0.000001; // doubles are equal if their difference is less than this value - you choose this value based on your needs
			bool areEqual = difference < threshold;

			Console.WriteLine(areEqual);
		}
	}
}