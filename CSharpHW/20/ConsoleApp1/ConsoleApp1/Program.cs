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
            MobileAccount user1 = new MobileAccount("Dima", "Kobets", new DateTime(1996,12,27), "3fid96@gmail.com");
            MobileAccount user2 = new MobileAccount("Weronika", "Nikolaeva", new DateTime(1996,2,12), "nika@gmail.com");
            MobileAccount user3 = new MobileAccount("Kate", "Kos", new DateTime(1996, 12, 2), "kate@gmail.com");

            if (user1.Validate() && user2.Validate() && user3.Validate())
            {

                Life.Registrate(user1);
                Life.Registrate(user2);
                Life.Registrate(user3);

                user1.Call(user2.Number);
                user1.SendSms(user2.Number, "Hello world");
                user1.Call(user3.Number);
                user1.Call(user3.Number);

                user2.Call(user3.Number);
                user2.Call(user1.Number);

                user3.Call(user2.Number);

                Life.ShowJornal();
                Life.MostActiveMembers();
                Life.MostPopularNumbers();
            }
            Console.ReadLine();
        }
    }
}
