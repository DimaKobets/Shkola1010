using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Car
    {
        public Transmission Transmission;
        public Color Color;
        public Engine Engine;

        public void WriteCar()
        {
            Console.WriteLine("Transmission tipe - " + this.Transmission);
            Console.WriteLine("The color of car - " + this.Color);
            Console.WriteLine("Model of engine - " + this.Engine);
        }
    }
}
