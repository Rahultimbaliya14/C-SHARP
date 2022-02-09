using System;

class JAGGEDARRAY
{
	public static void Main(String[] args)
	{
		int r, c;
		Console.WriteLine("Enter Row Size");
		r = Convert.ToInt32(Console.ReadLine());
		int[][] arr = new int[r][];
		for (int i = 0; i < r; i++)
		{
			Console.WriteLine("Enter " + i + " Column Size");
			c = Convert.ToInt32(Console.ReadLine());
			arr[i] = new int[c];
		}
		for (int i = 0; i < r; i++)
		{
			for (int j = 0; j < arr[i].Length; j++)
			{
				Console.WriteLine("Enter [" + i + "][" + j + "] Element");
				arr[i][j] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine();
		}
		for (int i = 0; i < r; i++)
		{
			for (int j = 0; j < arr[i].Length; j++)
			{
				//Console.WriteLine("["+i+"]["+j+"]Element is = "+arr[i][j]);
				Console.Write(+arr[i][j] + " ");
			}
			Console.WriteLine();
		}

		Console.ReadLine();
	}


}
