using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //[Serializable]
    class Operation
    {
        public double Ratio;
        public MobileAccount Sender;
        public MobileAccount Resiver;

        public Operation(double Ratio, MobileAccount Sender, MobileAccount Resiver)
        {
            this.Ratio = Ratio;
            this.Resiver = Resiver;
            this.Sender = Sender;
        }
    }
}
