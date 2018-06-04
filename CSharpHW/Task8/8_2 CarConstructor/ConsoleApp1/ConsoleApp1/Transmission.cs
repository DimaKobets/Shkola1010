using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Transmission
    {
        public string type;
        public int numberOfGears;

        public Transmission() : this("Mechanical")
        {
        }
        public Transmission(string type) : this(type, 6)
        {
        }
        public Transmission(string type, int numberOfGears)
        {
            this.type = type;
            this.numberOfGears = numberOfGears;
        }
    }
}
