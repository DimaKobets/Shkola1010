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
            NumbersIndexator userNumbers = new NumbersIndexator(GetNumbers());
            NumbersIndexator randomNumbers = new NumbersIndexator(GenerateRandomNumbers());

            CheckWin(userNumbers, randomNumbers);

            Console.ReadLine();
        }

        public static int[] GetNumbers()
        {
            while (true)
            {
                Console.WriteLine("Please, enter 6 numbers from 1 to 9 (separate by \"space\", \",\" or \"/\")");
                string consoleInformation = Console.ReadLine();

                int[] userNumbers = new int[6];
                
                string[] numbers = consoleInformation.Split(new char[] { ',', ' ', '/' });

                if (numbers.Length != 6)
                {
                    Console.WriteLine("You should enter 6 numbers.");
                    continue;
                }

                try
                {
                    for (int i = 0; i < 6; i++)
                    {
                        userNumbers[i] = Convert.ToInt32(numbers[i]);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("You should enter only numbers");
                    continue;
                }

                bool flag = false;
                for (int i = 0; i < 6; i++)
                {
                    if (userNumbers[i] > 9 || userNumbers[i] < 1)
                    {
                        Console.WriteLine("All numbers should be between 1 and 9.");
                        flag = true;
                    } 
                }
                if (flag)
                {
                    continue;
                }

                return userNumbers;
            }
        }

        public static void ShowNumbers(NumbersIndexator numbers)
        {
            for(int i = 0; i < 6; i++)
                Console.Write(numbers.Get(i) + " ");
        }

        public static int[] GenerateRandomNumbers()
        {
            int[] output = new int[6];
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                output[i] = rnd.Next(1, 10);
            }
            return output;            
        }

        public static void CheckWin(NumbersIndexator userNumbers, NumbersIndexator randomNumbers)
        {
            bool winFlag = false;
            for (int i = 0; i < 6; i++)
            {
                winFlag = false;
                for (int j = 0; j < 6; j++)
                {
                    if (userNumbers.Get(i) == randomNumbers.Get(j))
                    {
                        winFlag = true;
                        break;
                    }

                }
                if (!winFlag)
                {
                    Console.WriteLine("You didn`t win. Victorious combination was: ");
                    ShowNumbers(randomNumbers);
                    break;
                }              
               
            }
            if (winFlag)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Congratulations you won");
                Console.ResetColor();
            }

        }
    }
}
