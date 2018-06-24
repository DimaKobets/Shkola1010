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
        private List<Operation> Jornal = new List<Operation>();
        


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
            Jornal.Add(new Operation(1, Accounts.Find(x => x.number == from), Accounts.Find(x => x.number == to)));
        }

        public void SmsRouting(SmsDataType sms, int from)
        {
            MobileAccount reciverMobileAccount = Accounts.Find(x => x.number == sms.Number);
            reciverMobileAccount.GetSms(sms.Message, from);
            Jornal.Add(new Operation(0.5, Accounts.Find(x => x.number == from), Accounts.Find(x => x.number == sms.Number)));

        }

        public void ShowJornal()
        {
            Console.WriteLine("\nJorlan:");
            foreach (var record in Jornal)
            {
                Console.WriteLine(@"Ratio: {0}. From: {1}. To: {2}.", record.Ratio, record.Sender.name, record.Resiver.name);
            }
        }

        public void MostPopularNumbers()
        {
            var mostPopularNumbers = Jornal.GroupBy(x => x.Resiver).OrderByDescending(x => x.Count()).Take(5);
            Console.WriteLine("\nMost popular numbers:");
            foreach (var number in mostPopularNumbers)
            {
                Console.WriteLine(number.First().Resiver.number);
            }
        }

        public void MostActiveMembers()
        {
            var mostActiveMembers = Jornal.GroupBy(x => x.Sender).OrderByDescending(x => x.Sum(n => n.Ratio)).Take(5);
            Console.WriteLine("\nMost active members:");
            foreach (var member in mostActiveMembers)
            {
                Console.WriteLine(@" Name - {0}, number - {1}",member.First().Sender.name, member.First().Sender.number);
            }
        }


    }
}
