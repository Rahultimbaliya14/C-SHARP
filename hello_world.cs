using System;

class REVERCEANUMBER
{   
	
     static void reverse(int n)
     {
     	int temp=n,length=0,last,i=0;
     	do
     	{
     	length++;
     	temp/=10;
     	}
     	while(temp !=0);
     	int []a=new int[length];
     	while(n !=0)
     	{
     		last=n%10;
     		a[i]=last;
     		n=n/10;
     		i++;
     	}
     	for(int j=0;j<=length;j++)
     	{
     		Console.Write(+a[j]);
     	}
     
     }

   public static void Main(String []args)
   {
   	int n;
   	Console.WriteLine("Enter A Number");
   	n=Convert.ToInt32(Console.ReadLine());
   	Console.WriteLine();
   	Console.Write("REVERSE=");
   	reverse(n);
   	Console.ReadLine();
   }
   
   
}
