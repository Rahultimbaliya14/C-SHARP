using System;

class MULTIDARRAY
{
	public static void Main(String[] args)
	{
		int r, c;
		Console.WriteLine("Enter How Many Row");
		r = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter How Many Column");
		c = Convert.ToInt32(Console.ReadLine());
		int[,] arr = new int[r, c];
		for (int i = 0; i < r; i++)
		{
			for (int j = 0; j < c; j++)
			{
				Console.WriteLine("Enter [" + i + "][" + j + "] Element");
				arr[i, j] = Convert.ToInt32(Console.ReadLine());
			}
		}
		Console.WriteLine();
		for (int i = 0; i < r; i++)
		{
			for (int j = 0; j < c; j++)
			{
				Console.WriteLine("[" + i + "][" + j + "] Element is = " + arr[i, j]);
			}
		}
		Console.ReadLine();
	}


}
