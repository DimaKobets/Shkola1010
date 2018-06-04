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
            Human Dima = new Human("Dima", "Kobets", "27/12/1996", 21);
            Human Dima2 = new Human("Dima", "Kobets", "27/12/1996", 21);

            Dima.Equal(Dima2);
            Console.ReadLine();
        }

    }
}
