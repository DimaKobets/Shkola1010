using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Photo
    {
        public string PhotoCard;

        public Photo()
        {            
            string[] photo = { "=)", "=(", ":3", "^_^", ":D", "-_-", "0_0", "c(=" };
            Random rnd = new Random();
            this.PhotoCard = photo[rnd.Next(0, photo.Length - 1)];
        }
    }
}
