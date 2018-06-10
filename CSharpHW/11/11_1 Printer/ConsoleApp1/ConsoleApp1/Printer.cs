using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Printer
    {
        
        public  virtual void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
} 
