using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User dima = new User("Dima", 21);
            User unknown = new User();

            Console.WriteLine("Object dima: " + dima.Name + " " + dima.Age);
            Console.WriteLine("Object unknown: " + unknown.Name + " " + unknown.Age);

            unknown = dima.Clone();
            Console.WriteLine("\nAfter cloning\n");
            Console.WriteLine("Object dima: " + dima.Name + " " + dima.Age);
            Console.WriteLine("Object unknown: " + unknown.Name + " " + unknown.Age);



            Console.ReadLine();

        }


    }

}
