using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void MobileLineHendler<T> (T arg);

    class MobileAccount
    {
        public string name;
        public int number;

        public event MobileLineHendler <int> CallEvent;
        public event MobileLineHendler <SmsDataType> SmsEvent;

           
        public MobileAccount(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public delegate void SomeEvent();

        public void GetCall()
        {
            Console.WriteLine(this.name + " is getting call.");
        }

        public void GetSms( string text)
        {
            Console.WriteLine(this.name + " got sms: " + text);
        }

        public void Call(int number)
        {
            if (CallEvent != null)
            {
                CallEvent(number);
            }
        }

        public void SendSms(int number, string text)
        {
            if (SmsEvent != null)
            {
                SmsDataType sms = new SmsDataType(number, text);
                SmsEvent(sms);
            }
        }


    }
}
