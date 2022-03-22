using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CRUD_Operation
{
    class Program
    {
       


        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Lab\Documents\stud.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataReader rd;
            int no;
            string name=" ", city=" ";
            string quary;
            int ch=1,i;
            while (ch != 5)
            {
                Console.WriteLine("*******MANU********");
                Console.WriteLine("1 : INSERT");
                Console.WriteLine("2 : UPDATE");
                Console.WriteLine("3 : DELETE");
                Console.WriteLine("4 : VIEW");
                Console.WriteLine("5 : EXIT ");
                Console.WriteLine("Enter Your Operation");
                ch = Convert.ToInt16(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter The Number :");
                        no = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter The Name :");
                        name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter The City : ");
                        city = Convert.ToString(Console.ReadLine());
                        con.Open();
                        quary = "insert into stu values('" + no + "','" + name + "','" + city + "')";
                        SqlCommand cmd = new SqlCommand(quary, con);
                        i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            Console.WriteLine("\n***********************");
                            Console.WriteLine("Data added sussesfully");
                            Console.WriteLine("***********************");

                        }
                        else
                        {
                            Console.WriteLine("\n***********************");
                            Console.WriteLine("An Error occured!");
                            Console.WriteLine("\n***********************");
                        }
                        con.Close();
                        break;




                    case 2:
                        Console.WriteLine("Enter The Number you want to update");
                        no = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter The Name ");
                        name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter The City");
                        city = Convert.ToString(Console.ReadLine());
                        quary = "Update stu set name='" + name + "',city='" + city + "' where no='" + no + "'";
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand(quary, con);
                        i = cmd1.ExecuteNonQuery();
                        if (i > 0)
                        {
                            Console.WriteLine("\n***********************");
                            Console.WriteLine("Data Updated Succesfully......");
                            Console.WriteLine("\n***********************");
                        }
                        else
                        {
                            Console.WriteLine("\n***********************");
                            Console.WriteLine("A Problem Is Occure");
                            Console.WriteLine("\n***********************");
                        }
                        con.Close();
                        break;
                    case 3:

                        Console.WriteLine("Enter The Number of You Delete Data");
                        no = Convert.ToInt16(Console.ReadLine());
                        quary = "delete from stu where no='" + no + "'";
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand(quary, con);
                        i = cmd2.ExecuteNonQuery();
                        if (i > 0)
                        {
                            Console.WriteLine("\n***********************");
                            Console.WriteLine("Deleted Succesfully");
                            Console.WriteLine("\n***********************");
                        }
                        else
                        {
                            Console.WriteLine("\n***********************");
                            Console.WriteLine("A Problem Is Occure");
                            Console.WriteLine("\n***********************");
                        }
                        con.Close();
                        break;

                    case 4:
                        quary = "select * from stu ";
                        SqlCommand cmd3 = new SqlCommand(quary, con);
                        con.Open();
                       rd = cmd3.ExecuteReader();
                        int f=1;
                        while (f==1)
                        {
                          
                            if (rd.Read())
                            {
                                Console.WriteLine("\n***********************");
                                Console.WriteLine("No=" + rd["no"].ToString());
                                Console.WriteLine("Name=" + rd["name"].ToString());
                                Console.WriteLine("City=" + rd["city"].ToString());
                                Console.WriteLine("Enter The 1 to Show Next Record");
                                f = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("\n***********************");
                            }
                            else
                            {
                                Console.WriteLine("\n***********************");
                                Console.WriteLine("Data Not Found");
                                Console.WriteLine("\n***********************");
                                f = 0;
                            }
                        }
                        con.Close();
                        break;

                    case 5:
                        Console.WriteLine("Thank You .....");
                        ch = 5;
                        break;

                }
            }
            Console.ReadKey();
        
        }
    }
}
