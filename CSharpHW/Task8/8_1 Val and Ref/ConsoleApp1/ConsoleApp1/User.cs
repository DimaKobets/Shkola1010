using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public string Name;
        public int Age;

        public User() : this("Unknown")
        {
        }
        public User(string name) : this(name, 0)
        {
        }
        public User(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public User Clone()
        {
            return new User(this.Name, this.Age);
        }
    }
}
