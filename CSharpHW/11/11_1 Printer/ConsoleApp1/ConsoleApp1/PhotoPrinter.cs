using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PhotoPrinter: Printer
    { 
        public override void Print(string text)
        {
            Console.WriteLine(text + " - printed on Photoprinter.");
        }
        public static void Print(Photo photo)
        {
            Console.WriteLine("Photo: " + photo.PhotoCard);
        }
    }
}
