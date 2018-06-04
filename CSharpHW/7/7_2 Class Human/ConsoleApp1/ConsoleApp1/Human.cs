using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Human
    {
       
        public string FirstName;
        public string LastName;
        public string BirthDate;
        readonly int Age;

        public Human() : this("Unknown", "Unknown")
        {
        }
        public Human(string FirstName, string LastName) : this (FirstName, LastName, "Unknown", 18)
        {            
        }

        public Human(string FirstName, string LastName, string BirthDate, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.Age = Age;
        }

        public void Equal(Human human)
        {
            if (this.FirstName != human.FirstName)
            {
                Console.WriteLine("First names are not equal");
            }
            else if (this.LastName != human.LastName)
            {
                Console.WriteLine("Last names are not equal");
            }
            else if (this.BirthDate != human.BirthDate)
            {
                Console.WriteLine("Birth dates are not equal");
            }
            else if (this.Age != human.Age)
            {
                Console.WriteLine("Ages are not equal");
            }
            else
            {
                Console.WriteLine("This humans are equal");
            }

        }
    }
}
