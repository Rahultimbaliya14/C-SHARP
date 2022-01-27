//CREATED BY RAHUL TIMBALIYA
using System;

	class Base
	{
		public Base()
		{
			Console.WriteLine("BASE CLASS CONSTRUCTOR");
		}
	}
	class Derived1 :Base
	{
		public Derived1()
		{
			Console.WriteLine("DERIVED1 CLASS CONSTRUCTOR");
		}
	}
	class Derived2 :Base
	{
		public Derived2()
		{
			Console.WriteLine("DERIVED2 CLASS CONSTRUCTOR");
		}
	}
   class Derived3 :Base
	{
		public Derived3()
		{
			Console.WriteLine("DERIVED3  CLASS CONSTRUCTOR ");
		}
	}

	class demo
	{

    public static void Main(String []args)
    {
     Derived1 d1=new Derived1();
     Console.WriteLine();
     Derived2 d2=new Derived2();
     Console.WriteLine();
     Derived3 d3=new Derived3();
     Console.WriteLine();
     Console.ReadLine();
     
	
	}
}
