using System;

class SUMOFNUMBER
{
	static int cal(int n)
	{
		int last,sum=0;
		while(n !=0)
		{
		 last=n%10;
		 sum=sum+last;
		 n/=10;
		}
		return sum;
	}
   public static void Main(String []args)
   {
   	int n;
   	Console.WriteLine("Enter A Number");
   	n=Convert.ToInt32(Console.ReadLine());
   	int sum=cal(n);
   	Console.WriteLine();
   	Console.WriteLine("SUM="+sum);
   	
   }
   
   
}
