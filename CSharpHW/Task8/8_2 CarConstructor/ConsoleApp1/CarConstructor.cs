using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CarConstructor
    {
        public static Car Construct(Transmission transmission, Color color, Engine engine)
        {
            Car car = new Car();
            car.transmission = transmission;
            car.Color = color;
            car.Engine = engine;
            return car;
        }
        public static void Reconstruct(Car car, Engine engine)
        {
            car.Engine = engine;
            Console.WriteLine("\nCar engine was changed!\n");
        }
    }
}
