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
            MobileAccount user1 = new MobileAccount("Dima", "Kobets", new DateTime(1996,12,27), "3fid96@gmail.com");
            MobileAccount user2 = new MobileAccount("Weronika", "Nikolaeva", new DateTime(1996,2,12), "nika@gmail.com");
            MobileAccount user3 = new MobileAccount("Kate", "Kos", new DateTime(1996, 12, 2), "kate@gmail.com");

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

                MySerializator.BinarySerialization(user1);
                MySerializator.BinarySerialization(user2);
                MySerializator.BinarySerialization(user3);

                MySerializator.XMLSerialization(user1);
                MySerializator.XMLSerialization(user2);
                MySerializator.XMLSerialization(user3);

                MySerializator.JSONSerialization(user1);
                MySerializator.JSONSerialization(user2);
                MySerializator.JSONSerialization(user3);

                MySerializator.ProtoBufSerialization(user1);
                MySerializator.ProtoBufSerialization(user2);
                MySerializator.ProtoBufSerialization(user3);



            }
            Console.ReadLine();
        }
    }
}
