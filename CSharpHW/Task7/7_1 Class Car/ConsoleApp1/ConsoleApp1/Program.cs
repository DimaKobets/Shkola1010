using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car();
            TuningAtelier.TuneCar(ford);

            Console.WriteLine(ford.Color);
            Console.ReadLine();
        }
    }
}

