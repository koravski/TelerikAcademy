using System;

class ModifyBitGivenPosition
{
	static void Main()
	{
		Console.Write("Please, enter some number: ");
		int nNumber = int.Parse(Console.ReadLine());
		Console.Write("Please, enter bit position p to modify: ");
		byte position = byte.Parse(Console.ReadLine());
		Console.Write("Please, enter bit value 0 or 1: ");
		byte bitValue = byte.Parse(Console.ReadLine());
		Console.WriteLine("INPUT: " + Convert.ToString(nNumber, 2).PadLeft(16, '0'));
		if (bitValue == 0)
		{

			int mask = ~(1 << position);
			int result = nNumber & mask;
			Console.WriteLine("RESULT:" + Convert.ToString(result, 2).PadLeft(16, '0'));
			Console.WriteLine(result);
		}
		else if (bitValue == 1)
		{

			int mask = 1 << position;
			int result = nNumber | mask;
			Console.WriteLine("RESULT:" + Convert.ToString(result, 2).PadLeft(16, '0'));
			Console.WriteLine(result);
		}
		else
		{
			Console.WriteLine("Wrong input! Try Again.");
		}
	}
}