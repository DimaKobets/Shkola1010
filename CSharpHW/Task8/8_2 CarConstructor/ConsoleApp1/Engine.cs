using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Engine
    {
        public string model;
        public int volume;        
        public int power;

        public Engine() : this("Standard")
        {
        }
        public Engine(string model) : this( model, 3)
        {
        }
        public Engine(string model, int volume) : this(model, volume, 100)
        {
        }
        public Engine(string model, int volume, int power)
        {
            this.model = model;
            this.volume = volume;
            this.power = power;
        }

    }
}
