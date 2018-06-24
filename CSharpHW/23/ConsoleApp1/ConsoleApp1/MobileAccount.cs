using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using ProtoBuf;

namespace ConsoleApp1
{
    delegate void MobileLineHendler<T, A> (T arg, A sender);

    [Serializable]
    [DataContract]
    [ProtoContract]
    public class MobileAccount : IValidatableObject
    {
        [DataMember]
        [ProtoMember(1)]
        public string Name { get; set; }
        [DataMember]
        [ProtoMember(2)]
        public string LastName { get; set; }
        [DataMember]
        [ProtoMember(3)]
        public DateTime BirthDate { get; set; }
        [DataMember]
        [ProtoMember(4)]
        public string Email { get; set; }
        [DataMember]
        [ProtoMember(5)]
        public int Number { get; set; }
        [DataMember]
        [ProtoMember(6)]
        public List<Contacts> PhoneBook { get; set; }

        [field: NonSerialized]        
        internal event MobileLineHendler <int, int> CallEvent;

        [field: NonSerialized]        
        internal event MobileLineHendler <SmsDataType, int> SmsEvent;

        public MobileAccount(string name, string lastName, DateTime birthDate, string email)
        {
            this.Name = name;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Email = email;
            PhoneBook = new List<Contacts>();
        }

        public MobileAccount()
        {
        }        
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (string.IsNullOrWhiteSpace(this.Name))
                errors.Add(new ValidationResult("Name is not entered"));
            if (string.IsNullOrWhiteSpace(this.LastName))
                errors.Add(new ValidationResult("Last name is not entered"));
            if (this.BirthDate < DateTime.Now.AddYears(-110) || this.BirthDate > DateTime.Now)
                errors.Add(new ValidationResult("Incorrect birth date"));
            if(!this.Email.Contains('@'))
                errors.Add(new ValidationResult("Email entered wrong"));
            return errors;
        }

        public bool Validate()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            if (!Validator.TryValidateObject(this, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public void GetCall(int sender)
        { 
            if (PhoneBook.Exists(x => x.Number == sender))
            {
                Console.WriteLine(this.Name + " is getting call from: " + PhoneBook.Where(x => x.Number == sender).First().Name);
            }
            else
            {
                Console.WriteLine(this.Name + " is getting call from: " + sender);
            }
        }
        
        public void GetSms( string text, int sender)
        {
            if (PhoneBook.Exists(x => x.Number == sender))
            {
                Console.WriteLine(this.Name + " got sms from " + PhoneBook.Where(x => x.Number == sender).First().Name + ": " + text);
            }
            else
            {
                Console.WriteLine(this.Name + " got sms from " + sender + ": " + text);
            }            
        }
        
        public void Call(int number)
        {
            if (CallEvent != null)
            {
                CallEvent(number, this.Number);
            }
        }
        
        public void SendSms(int number, string text)
        {
            if (SmsEvent != null)
            {
                SmsDataType sms = new SmsDataType(number, text);
                SmsEvent(sms, this.Number);
            }
        }
        
        public void AddToBook(MobileAccount newContact)
        {

            PhoneBook.Add(new Contacts (newContact.Name, newContact.LastName, newContact.BirthDate, newContact.Email, newContact.Number ));
        }
    }
}
