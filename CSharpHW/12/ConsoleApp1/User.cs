using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User : IUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime LastVisit;

        public User(string name, string email, string password, DateTime visit)
        {
            Name = name;
            Email = email;
            Password = password;
            LastVisit = visit;
        }
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            LastVisit = DateTime.Now;
        }

        public User()
        {            
        }

        public string GetFullInfo()
        {
            return $"\n{Name}\n{Email}\n{Password}\n{LastVisit}";
        }        
    }

  
}
