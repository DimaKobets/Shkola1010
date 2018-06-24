using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    

    class MobileOperator
    {
        private List <MobileAccount> Accounts = new List<MobileAccount>();
        


        public void Registrate(MobileAccount newAccount)
        {
            Accounts.Add(newAccount);
            newAccount.CallEvent += CallRouting;
            newAccount.SmsEvent += SmsRouting;
        }

        public void CallRouting(int number)
        {
            MobileAccount reciverMobileAccount = Accounts.Find(x => x.number == number);
            reciverMobileAccount.GetCall();
        }

        public void SmsRouting(SmsDataType sms)
        {
            MobileAccount reciverMobileAccount = Accounts.Find(x => x.number == sms.Number);
            reciverMobileAccount.GetSms(sms.Message);
        }


    }
}
