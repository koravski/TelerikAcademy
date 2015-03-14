using System;

class BitwiseExtractBit3
{
	static void Main()
	{
		Console.Write("Please, enter some number: ");
		int iNumber = int.Parse(Console.ReadLine());
		//int iNumber = 5;
		int bBitNumber = 3;
		byte value = 1;
		int newNumber = (iNumber >> bBitNumber) & 1;
		if (newNumber == 0)
		{
			value = 0;
		}
		else
		{
			value = 1;
		}
		Console.WriteLine(Convert.ToString(iNumber, 2).PadLeft(16, '0'));
		Console.WriteLine("The value of the bit #{0} is {1}", bBitNumber, value);
	}
}
