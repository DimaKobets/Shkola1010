using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SmsDataType
    {
        public int Number;
        public string Message;

        public SmsDataType(int number, string message)
        {
            this.Number = number;
            this.Message = message;
        }
    }
}
