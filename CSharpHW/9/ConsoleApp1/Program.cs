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
            var car = CarConstructor.Construct(Transmission.AutomaticTransmission, Color.Black, Engine.BMW500);            
            car.WriteCar();;

            CarConstructor.Reconstruct(ref car, Engine.Spotr1);
            car.WriteCar();

            Console.ReadLine();
        }
    }
}
