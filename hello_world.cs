using System;

class SINGLEDARRAY
{
	public static void Main(String[] args)
	{
       int n;
       Console.WriteLine("Enter How Many Element");
       n=Convert.ToInt32(Console.ReadLine());
       int []arr=new int[n];
       for(int i=0;i<n;i++)
       {
       	Console.WriteLine("Enter "+i+" Element");
       	arr[i]=Convert.ToInt32(Console.ReadLine());
       }
       Console.WriteLine();
       for(int i=0;i<n;i++)
       {
       	Console.WriteLine(+i+" Element is = "+arr[i]);
       }
       Console.ReadLine();
	}


}
