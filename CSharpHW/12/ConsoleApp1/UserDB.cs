using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UserDB: IAuthenticator
    {
       public static List<User> UserList = new List<User>()
       {
           new User("dima", "3fid96@gmail.com", "dima", new DateTime(1996,12,27)),
           new User("vadim", "medved@gmail.com", "vadim", new DateTime(2000,02,02)),
           new User("kate", "kos@gmail.com", "kate", new DateTime(2000,02,02)),
       };

        private bool IfUserRegistrate(string nameOrEmail)
        {
            foreach (var users in UserList)
            {
                if (nameOrEmail.Contains("@"))
                {
                    if (users.Email == nameOrEmail)
                    {
                        return true;
                    }
                }
                else
                if (users.Name == nameOrEmail)
                {
                    return true;
                }                               
            }
            return false;
        }

        public  void Authenticate(IUser user)
        {
            if (user.Name == null)
            {
                if (IfUserRegistrate(user.Email))
                {
                    AuthenticateByEmail(user);
                }
                else
                {
                    CreateNewUser();
                }
            }
            else
            if (user.Email == null)
            {
                if (IfUserRegistrate(user.Name))
                {
                    AuthenticateByName(user);
                }
                else
                {
                    CreateNewUser();
                }
            }            
        }

        private void CreateNewUser()
        {
            Console.WriteLine("There are no users with that name or email. Do you want to create an account? (Y/N)");
            while (true)
            {
                string answer = Console.ReadLine();
                if (answer == "Y" || answer == "y")
                {
                    string name, email, password;
                    while (true)
                    {
                        Console.WriteLine("Please, enter your Name: ");
                        name = Console.ReadLine();

                        if (name.Contains("@"))
                        {
                            Console.WriteLine("The name can not contain any characters!");
                        }
                        else
                        {                            
                            break;
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine("Please, enter your Email: ");
                        email = Console.ReadLine();

                        if (!email.Contains("@"))
                        {
                            Console.WriteLine("You entered wrong Email!");
                        }
                        else
                        {                            
                            break;
                        }
                    }

                    Console.WriteLine("Please, enter your password: ");
                    password = Console.ReadLine();

                    UserList.Add(new User(name, email, password));
                    Console.WriteLine("Your account was created successfully.\n");
                    break;

                }
                else if (answer == "N" || answer == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect value! Enter Y or N.");
                }


            }
        }

        private void AuthenticateByEmail(IUser user)
        {
            foreach (var userFromDB in UserList)
            {
                if (userFromDB.Email == user.Email)
                {
                    if (userFromDB.Password == user.Password)
                    {
                        Console.WriteLine("\nYou`w got access");
                        Console.WriteLine("Your last visit was: " + userFromDB.LastVisit);
                        userFromDB.LastVisit = DateTime.Today;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Password entered wrong.");
                        break;
                    }
                }
            }
        }

        private void AuthenticateByName(IUser user)
        {
            foreach (var userFromDB in UserList)
            {
                if (userFromDB.Name == user.Name)
                {
                    if (userFromDB.Password == user.Password)
                    {
                        Console.WriteLine("\nYou`w got access");
                        Console.WriteLine("Your last visit was: " + userFromDB.LastVisit);
                        userFromDB.LastVisit = DateTime.Today;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Password entered wrong.");
                        break;
                    }
                }
            }
        }

        


    }
}
