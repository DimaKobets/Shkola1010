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

        public void CallRouting(int to, int from)
        {
            MobileAccount reciverMobileAccount = Accounts.Find(x => x.number == to);
            reciverMobileAccount.GetCall(from);
        }

        public void SmsRouting(SmsDataType sms, int sender)
        {
            MobileAccount reciverMobileAccount = Accounts.Find(x => x.number == sms.Number);
            reciverMobileAccount.GetSms(sms.Message, sender);
        }


    }
}
