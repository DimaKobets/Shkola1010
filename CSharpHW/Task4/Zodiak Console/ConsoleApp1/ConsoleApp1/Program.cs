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
            ZodiacSign(Console.ReadLine());            
            Console.ReadLine();
        }

        static void ZodiacSign(string dateOfBirth)
        {
            int[] date = StringToInt(SplitString(dateOfBirth));

            if (DateValidation(date))
            {
                if ((date[1] == 3 && date[0] >= 21) || (date[1] == 4 && date[0] <= 19))
                {
                    Console.WriteLine("Your zodiac sign is Ram");
                }
                else if ((date[1] == 4 && date[0] >= 20) || (date[1] == 5 && date[0] <= 20))
                {
                    Console.WriteLine("Your zodiac sign is Bull");
                }
                else if ((date[1] == 5 && date[0] >= 21) || (date[1] == 6 && date[0] <= 20))
                {
                    Console.WriteLine("Your zodiac sign is Twins");
                }
                else if ((date[1] == 6 && date[0] >= 21) || (date[1] == 7 && date[0] <= 22))
                {
                    Console.WriteLine("Your zodiac sign is Crab");
                }
                else if ((date[1] == 7 && date[0] >= 23) || (date[1] == 8 && date[0] <= 22))
                {
                    Console.WriteLine("Your zodiac sign is Lion");
                }
                else if ((date[1] == 8 && date[0] >= 23) || (date[1] == 9 && date[0] <= 22))
                {
                    Console.WriteLine("Your zodiac sign is Maiden");
                }
                else if ((date[1] == 9 && date[0] >= 23) || (date[1] == 10 && date[0] <= 22))
                {
                    Console.WriteLine("Your zodiac sign is Scales");
                }
                else if ((date[1] == 10 && date[0] >= 23) || (date[1] == 11 && date[0] <= 21))
                {
                    Console.WriteLine("Your zodiac sign is Scorpion");
                }
                else if ((date[1] == 11 && date[0] >= 22) || (date[1] == 12 && date[0] <= 21))
                {
                    Console.WriteLine("Your zodiac sign is Archer");
                }
                else if ((date[1] == 12 && date[0] >= 22) || (date[1] == 1 && date[0] <= 19))
                {
                    Console.WriteLine("Your zodiac sign is Mountain Sea-goat");
                }
                else if ((date[1] == 1 && date[0] >= 20) || (date[1] == 2 && date[0] <= 18))
                {
                    Console.WriteLine("Your zodiac sign is Water-bearer");
                }
                else if ((date[1] == 2 && date[0] >= 19) || (date[1] == 3 && date[0] <= 20))
                {
                    Console.WriteLine("Your zodiac sign is The Fish");
                }
            }
            else
            {
                Console.WriteLine("You entered incorrect data");
            }
        }

        static string[] SplitString(string str)
        {
            string[] split = str.Split(new char[] { '/' });
            return split;
        }

        static int[] StringToInt(string[] splitedString)
        {
            int[] operand = new int[splitedString.Length];
            try
            {
                for (int i = 0; i < splitedString.Length; i++)
                    operand[i] = Convert.ToInt32(splitedString[i]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Values entered incorrectly");
            }
            return operand;
        }

        static bool DateValidation(int[] date)
        {
            bool errorFlag = true;
            if (!(0 < date[0] && date[0] < 32))
            {
                Console.WriteLine("The day of your birth date entered wrong.");
                errorFlag = false;
            }
            if (!(0 < date[1] && date[1] < 13))
            {
                Console.WriteLine("The month of your birth date entered wrong.");
                errorFlag = false;
            }
            if (!(date[2] < DateTime.Now.Year))
            {
                Console.WriteLine("The year of your birth date entered wrong.");
                errorFlag = false;
            }
            return errorFlag;
        }
    }
}
