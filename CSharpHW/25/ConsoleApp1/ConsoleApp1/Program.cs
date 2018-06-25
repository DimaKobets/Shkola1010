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
            string adress = @"ArhivateTest";

            Arhivator.Zip(adress);
            //Arhivator.UnZip(adress);
            Console.ReadLine();
        }
    }
}
