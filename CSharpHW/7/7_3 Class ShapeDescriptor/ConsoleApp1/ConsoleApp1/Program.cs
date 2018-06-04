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
            Point point1 = new Point(1, 2);
            Point point2 = new Point(2, 3);
            Point point3 = new Point(12, 5);

            ShapeDescriptor shape = new ShapeDescriptor(point1, point2, point3);

            shape.ShapeType();
            Console.ReadLine();
        }
    }
}
