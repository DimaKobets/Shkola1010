using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using ProtoBuf;

namespace ConsoleApp1
{
    class MySerializator
    {
        public static void BinarySerialization(MobileAccount user)
        {
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Binaty" + user.Name + ".dat", FileMode.OpenOrCreate))
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                formatter.Serialize(fs, user);
                watch.Stop();
                Console.WriteLine("The object is serialized by Binary serialization");
                Console.WriteLine("It takes " + watch.Elapsed + "\n");
            }
        }

        public static void XMLSerialization(MobileAccount user)
        {
            var formatter = new XmlSerializer(typeof(MobileAccount));
            using (FileStream fs = new FileStream("XML" + user.Name + ".xml", FileMode.OpenOrCreate))
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                formatter.Serialize(fs, user);
                watch.Stop();
                Console.WriteLine("The object is serialized by XML serialization");
                Console.WriteLine("It takes " + watch.Elapsed + "\n");
            }
        }

        public static void JSONSerialization(MobileAccount user)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(MobileAccount));

            using (FileStream fs = new FileStream("JSON" + user.Name + ".json", FileMode.OpenOrCreate))
            {                
                var watch = System.Diagnostics.Stopwatch.StartNew();
                jsonFormatter.WriteObject(fs, user);
                watch.Stop();
                Console.WriteLine("The object is serialized by JSON serialization");
                Console.WriteLine("It takes " + watch.Elapsed + "\n");
            }
        }

        public static void ProtoBufSerialization(MobileAccount user)
        {
            using (var file = File.Create("ProtoBuf" + user.Name + ".bin"))
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Serializer.Serialize(file, user);
                watch.Stop();
                Console.WriteLine("The object is serialized by Protobuf serialization");
                Console.WriteLine("It takes " + watch.Elapsed + "\n");
            }
        }
    }
}
