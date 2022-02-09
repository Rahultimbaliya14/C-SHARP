//CREATED BY RAHUL TIMBALIYA 
using System;

class MULTIDARRAY
{
	public static void Main(String[] args)
	{
		int r, c, n;
		Console.WriteLine("Enter How Many Row");
		r = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter How Many Column");
		c = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter The How Many Data In Particular Column");
		n = Convert.ToInt32(Console.ReadLine());
		int[,,] arr = new int[r, c, n];
		for (int i = 0; i < r; i++)
		{
			for (int j = 0; j < c; j++)
			{
				for (int k = 0; k < n; k++)
				{
					Console.WriteLine("Enter [" + i + "][" + j + "][" + k + "] Element");
					arr[i, j, k] = Convert.ToInt32(Console.ReadLine());
				}
			}
		}
		Console.WriteLine();
		for (int i = 0; i < r; i++)
		{
			for (int j = 0; j < c; j++)
			{
				for (int k = 0; k < n; k++)
				{
					Console.WriteLine("[" + i + "][" + j + "][" + k + "] Element is = " + arr[i, j, k]);
				}
			}
		}
		Console.ReadLine();
	}


}
