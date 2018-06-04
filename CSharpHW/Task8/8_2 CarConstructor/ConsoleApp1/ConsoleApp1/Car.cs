using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        public Transmission transmission { set; get; }
        public Color Color { set; get; }
        public Engine Engine { set; get; }

        public void WriteCar()
        {
            Console.WriteLine("Transmission tipe - " + this.transmission.type + ". Number of gears - " + this.transmission.numberOfGears);
            Console.WriteLine("The color of car - " + this.Color.color);
            Console.WriteLine("Model of engine - " + this.Engine.model + ". Volume of engine - " + this.Engine.volume + ". Power of engine - " + this.Engine.power);
        }
    }
}
