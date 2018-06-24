using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void MobileLineHendler<T, A> (T arg, A sender);

    class MobileAccount
    {
        public string name;
        public int number;
        public List<MobileAccount> PhoneBook =  new List<MobileAccount>();

        public event MobileLineHendler <int, int> CallEvent;
        public event MobileLineHendler <SmsDataType, int> SmsEvent;

           
        public MobileAccount(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public void GetCall(int sender)
        {
            foreach (var account in PhoneBook)
            {
                if (account.number == sender)
                {
                    Console.WriteLine(this.name + " is getting call from: " + account.name);
                    return;
                }
            }
            Console.WriteLine(this.name + " is getting call from: " + sender);
        }

        public void GetSms( string text, int sender)
        {
            foreach (var account in PhoneBook) 
            {
                if (account.number == sender)
                {
                    Console.WriteLine(this.name + " got sms from " + account.name + ": " + text);
                    return;
                }
            }           
            Console.WriteLine(this.name + " got sms from " + sender + ": " + text);
        }

        public void Call(int number)
        {
            if (CallEvent != null)
            {
                CallEvent(number, this.number);
            }
        }

        public void SendSms(int number, string text)
        {
            if (SmsEvent != null)
            {
                SmsDataType sms = new SmsDataType(number, text);
                SmsEvent(sms, this.number);
            }
        }

        public void AddToBook(MobileAccount newContact)
        {
            PhoneBook.Add(newContact);
        }
    }
}
