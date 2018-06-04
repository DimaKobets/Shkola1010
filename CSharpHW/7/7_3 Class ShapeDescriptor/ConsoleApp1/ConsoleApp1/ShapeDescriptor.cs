using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ShapeDescriptor
    {
        public Point[] Figure = new Point[4];

        public ShapeDescriptor() : this(null)
        {
        }
        public ShapeDescriptor(Point point1) : this (point1, null)
        {
        }
        public ShapeDescriptor(Point point1, Point point2) : this (point1,  point2, null)
        {          
        }
        public ShapeDescriptor(Point point1, Point point2, Point point3) : this ( point1,  point2,  point3, null)
        {     
        }
        public ShapeDescriptor(Point point1, Point point2, Point point3, Point point4)
        {
            Figure[0] = point1;
            Figure[1] = point2;
            Figure[2] = point3;
            Figure[3] = point4;
        }

        public void ShapeType()
        {
            if (Figure[0] == null)
            {
                Console.WriteLine("This is nothing");
            }
            else if (Figure[3] != null)
            {
                Console.WriteLine("This is a quadrangle");
            }
            else if (Figure[2] != null)
            {
                Console.WriteLine("This is a triangle");
            }
            else if (Figure[1] != null)
            {
                Console.WriteLine("This is a line");
            }
            else if (Figure[0] != null)
            {
                Console.WriteLine("This is a dot");
            }
        }

    }
}
