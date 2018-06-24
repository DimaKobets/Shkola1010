using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    [ProtoContract]
    public class Contacts
    {
        [ProtoMember(1)]
        public string Name { get; set; }
        [ProtoMember(2)]
        public string LastName { get; set; }
        [ProtoMember(3)]
        public DateTime BirthDate { get; set; }
        [ProtoMember(4)]
        public string Email { get; set; }
        [ProtoMember(5)]
        public int Number { get; set; }

        public Contacts(string name, string lastName, DateTime birthDate, string email, int number)
        {
            this.Name = name;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Email = email;
            this.Number = number;
        }
        public Contacts()
        {
        }
    }    
}
