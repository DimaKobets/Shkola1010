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
            MobileAccount user2 = new MobileAccount("Kate", 0674026983);
            MobileAccount user3 = new MobileAccount("Weronika", 0674026984);
            MobileAccount user4 = new MobileAccount("Alex", 0674026985);
            MobileAccount user5 = new MobileAccount("Wadim", 0674026986);
            MobileAccount user6 = new MobileAccount("Serg", 0674026987);

            Life.Registrate(user1);
            Life.Registrate(user2);
            Life.Registrate(user3);
            Life.Registrate(user4);
            Life.Registrate(user5);
            Life.Registrate(user6);

            user2.AddToBook(user1);

            user1.Call(0674026983);
            user1.SendSms(0674026983, "Hello world");
            user1.Call(0674026984);
            user1.Call(0674026984);

            user2.Call(0674026984);
            user2.Call(0674026982);

            user3.Call(0674026984);

            user4.Call(0674026986);
            user4.SendSms(0674026982, "Hello world");

            user5.SendSms(0674026985, "Hello world");

            Life.ShowJornal();
            Life.MostActiveMembers();
            Life.MostPopularNumbers();

            Console.ReadLine();
        }
    }
}
