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
            Photo photo = new Photo();

            ColorPrinter.Print("Some message", Color.Yellow );            
            PhotoPrinter.Print(photo);

            PhotoPrinter photoPrinter = new PhotoPrinter();
            photoPrinter.Print("qwe");

            ColorPrinter colorPrinter = new ColorPrinter();
            colorPrinter.Print("123");       

            Console.ReadLine();

        }
    }
}
