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
                
                user1.Call(user2.Number);
                user2.Call(user1.Number);

                XMLOperations.FindByName("XMLMobileOperator.xml","Dima");

                MobileAccount user4 = XMLOperations.GetByName("XMLMobileOperator.xml", "Dima");
                Console.WriteLine(user4.Name);

                List<string> sample = XMLOperations.Sample("XMLMobileOperator.xml", "Name");
                foreach (var number in sample)
                {
                    Console.WriteLine(number);
                }
                //XMLOperations.AddElementToXML("XMLMobileOperator.xml", user1);
                XMLOperations.RemuveByName("XMLMobileOperator.xml", "Kate");
            }
            Console.ReadLine();
        }
    }
}
