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
            MobileOperator Life = new MobileOperator();
            MobileAccount user1 = new MobileAccount("Dima", 0674026982);
            MobileAccount user2 = new MobileAccount("Kate", 0674026980);
            Life.Registrate(user1);
            Life.Registrate(user2);
            user1.Call(0674026980);
            user1.SendSms(0674026980, "Hello world");
            Console.ReadLine();

        }
    }
}
