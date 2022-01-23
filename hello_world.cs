using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

	class University
	{
		public University()
		{
			Console.WriteLine("UNIVERCITY");
		}
	}
	class Collage :University
	{
		public Collage()
		{
			Console.WriteLine("COLLAGE");
		}
	}
	class BCA :Collage
	{
		public BCA()
		{
			Console.WriteLine("BCA");
		}
	}
	class Studant1 :BCA
	{
		public Studant1()
		{
			Console.WriteLine("STUDANT 1");
		}
	}
	class Studant2 :BCA
	{
		public Studant2()
		{
			Console.WriteLine("STUDANT 2");
		}
	}
	class Studant3 :BCA
	{
		public Studant3()
		{
			Console.WriteLine("STUDANT 3");
		}
	}

	class Hybrid
	{

    public static void Main(String []args)
    {
       Studant1 s1=new Studant1();
       Console.WriteLine();
       Studant2 s2=new Studant2();
       Console.WriteLine();
       Studant3 s3=new Studant3();
	}
}
