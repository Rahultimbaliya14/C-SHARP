//CREATED BY RAHUL TIMBALIYA 

using System;

class FINDSECONDLARGEFROMARRAY
{   
   public static void Main(String []args)
   {
   	int n,large=0,large2=0,large3=0;
   	Console.WriteLine("ENTER LENGTH OF ARRAY");
   	n=Convert.ToInt32(Console.ReadLine());
   	int []a=new int[n];
   	for(int i=0;i<n;i++)
   	{
   		Console.WriteLine("Enter"+(i+1)+"Number");
   		a[i]=Convert.ToInt32(Console.ReadLine());
   		if(large<a[i])
   		{
   			large=a[i];
   		}
   	
   	}
   	for(int j=0;j<n;j++)
   	{
   		if(a[j] !=large && a[j]>large2)
   		{
   			large2=a[j];
   		}
   	}
   	Console.WriteLine();
   	Console.WriteLine("FIRST LARGE NUBER= "+large);
   	Console.WriteLine();
   	Console.WriteLine("SECOND LARGE NUMBER= "+large2);
   	Console.ReadLine();
   }
   
   
}
