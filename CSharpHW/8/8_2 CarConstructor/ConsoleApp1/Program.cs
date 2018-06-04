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
            var car = CarConstructor.Construct(new Transmission(), new Color(), new Engine());            
            car.WriteCar();;

            CarConstructor.Reconstruct(car, new Engine("ModelX", 5, 1000));
            car.WriteCar();

            Console.ReadLine();
        }
    }
}
