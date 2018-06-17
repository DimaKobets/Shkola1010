using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IAuthenticator Authenticator = new UserDB();
            IDisposable userDispose = new UserDB();
            IUserDataBase userDB = new UserDB();

            userDispose.Dispose();
            Console.Write("\nEnter the name of the user you want to find: ");
            userDB.FindByName(Console.ReadLine());

            Console.WriteLine("\nCreating of new account.");
            userDB.AddNewUser();

            Console.ReadLine();
        }
    }
}
