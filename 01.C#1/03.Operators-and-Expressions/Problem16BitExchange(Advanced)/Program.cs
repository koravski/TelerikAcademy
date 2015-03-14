using System;

class BitExchangeAdvanced
{
	static void Main()
	{
		Console.WriteLine("Enter unsigned integer number:");
		uint n = uint.Parse(Console.ReadLine());
		Console.WriteLine("Enter unsigned integer for position:");
		uint p = uint.Parse(Console.ReadLine());
		Console.WriteLine("Enter integer for position:");
		uint q = uint.Parse(Console.ReadLine());
		Console.WriteLine("Enter integer for coefficient:");
		int k = int.Parse(Console.ReadLine());
		uint result = 0;
		int m = 0;      
		int[] bitP = new int[p + k + 1];
		int[] bitQ = new int[q + k + 1];
		if (Math.Max(p, q) + k > 32)
		{
			Console.WriteLine("Out of range");
			return;
		}
		else if (Math.Min(p, q) + k > Math.Max(p, q))
		{
			Console.WriteLine("Overlapping");
			return;
		}
		for (uint i = p, j=q; i<=p+k-1||j<=q+k-1; i++, j++)
		{
			uint nRightP = n >> (int)i;
			bitP[i] = (int)nRightP & 1;
			nRightP = n >>(int)j;
			bitQ[j] =(int)nRightP & 1;
			if (bitP[i] == 0 && bitQ[j] == 1)
			{
				int mask = ~(1 << (int)j);
				if (i == p || m==0)
				{
					result = n & (uint)mask;
					m++; //variable determining the performance of a single line
				}
				else
				{
					result = result & (uint)mask;
				}
				mask = 1 << (int)i;            
				result = result | (uint)mask;
			}
			else if (bitP[i] == 1 && bitQ[j] == 0)
			{
				int mask = 1 << (int)j;
				if (i == p ||m==0)
				{
					result = n | (uint)mask;
					m++;
				}
				else
				{
					result = result | (uint)mask;
				}
				mask = ~(1 << (int)i);         
				result = result & (uint)mask;
			}
		}
		Console.WriteLine(result);
	}
}