using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileOperator Life = new MobileOperator();
            //MobileAccount user1 = new MobileAccount("Dima", "Kobets", new DateTime(1996,12,27), "3fid96@gmail.com");
            //MobileAccount user2 = new MobileAccount("Weronika", "Nikolaeva", new DateTime(1996,2,12), "nika@gmail.com");
            //MobileAccount user3 = new MobileAccount("Kate", "Kos", new DateTime(1996, 12, 2), "kate@gmail.com");


            var user1 = new MobileAccount();
            var user2 = new MobileAccount();
            var user3 = new MobileAccount();

            var Serializator = new MySerializator();
            
            user1 = Serializator.DeSerializationJSON("JSONDima.json");
            user2 = Serializator.DeSerializationJSON("JSONWeronika.json");
            user3 = Serializator.DeSerializationJSON("JSONKate.json");

            if (user1.Validate() && user2.Validate() && user3.Validate())
            {
                Life.Registrate(user1);
                Life.Registrate(user2);
                Life.Registrate(user3);

                user1.AddToBook(user2);
                user1.AddToBook(user3);
                user2.AddToBook(user1);
                user2.AddToBook(user3);
                user3.AddToBook(user1);
                user3.AddToBook(user2);

                user1.Call(user2.Number);
                user2.Call(user1.Number);
            }
            Console.ReadLine();
        }
    }
}
