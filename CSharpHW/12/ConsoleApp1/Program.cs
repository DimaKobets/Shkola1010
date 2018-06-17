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
            string nameOrEmail, password;



            while (true)
            {
                IUser user = new User();
                Console.WriteLine("\nAuthentication\nPlease enter you name or email (if you want to exit print \"exit\")");
                nameOrEmail = Console.ReadLine();                

                if (nameOrEmail.Contains("@"))
                {
                    user.Email = nameOrEmail;
                }
                else
                {
                    user.Name = nameOrEmail;
                }

                Console.WriteLine("Please enter you password");
                password = Console.ReadLine();
                user.Password = password;

                if (nameOrEmail == "exit" && password == "exit")
                {
                    break;
                }
                else
                {
                    Authenticator.Authenticate(user);
                }
            }
        }
    }
}
