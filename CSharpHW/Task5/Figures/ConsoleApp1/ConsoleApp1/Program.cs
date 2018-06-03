using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {
                Console.WriteLine("Enter the information about figure.\nYou can choose: kind (triangle, square, romb) " +
                    "and size (1..10).\nYou can divide parameters by \",\", \"Spase\" or \"/\"  \nIf you want to exit enter \"exit\"");

                string consoleInformation = Console.ReadLine();
                if (consoleInformation != "exit")
                {
                    
                    string shape = GetShape(consoleInformation);
                    int size = GetSize(consoleInformation);

                    if (shape == "triangle")
                    {
                        BuildTriangle(size);
                    }
                    else if (shape == "square")
                    {
                        BuildSquare(size);
                    }
                    else if (shape == "romb")
                    {
                        BuildRombe(size);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Wrong name of figure");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        
                    }
                }
                else
                {
                    break;
                }
            }
        }

        static void BuildTriangle(int size)
        {
            string[,] figure = new string[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    figure[i, j] = "*";
                }
            }
           ShowFigure(figure, size);
        }

        static void BuildSquare(int size)
        {
            string[,] figure = new string[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    figure[i, j] = "*";
                }
            }
            ShowFigure(figure, size);
        }

        static void BuildRombe(int sizeOfFigure)
        {
            int sizeOfMass = sizeOfFigure * 2 - 1;
            string[,] figure = new string[sizeOfMass, sizeOfMass];

            FillMass(figure, sizeOfMass);

            for (int i = 0; i < sizeOfFigure; i++)
            {
                for (int j = sizeOfFigure - 1; j >= sizeOfFigure - 1 - i; j--)
                {
                    figure[i, j] = "*";
                }
            }

            MirrorVertical(figure, sizeOfFigure);
            MirrorHorizont(figure, sizeOfFigure);
            ShowFigure(figure, sizeOfMass);
        }

        static void ShowFigure(string[,] figure, int size)
        {
            Console.Write("\n\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(figure[i, j]);
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");
        }

        static void FillMass(string[,] mass, int sizeOfMass)
        {
            for (int i = 0; i < sizeOfMass; i++)
            {
                for (int j = 0; j < sizeOfMass; j++)
                {
                    mass[i, j] = " ";
                }
            }
        }

        static void MirrorVertical(string[,] mass, int sizeOfFigure)
        {
            int sizeOfMass = sizeOfFigure * 2 - 1;
            for (int i = 0; i < sizeOfMass; i++)
            {
                for (int j = 0; j < sizeOfFigure-1; j++)
                {
                    mass[i,sizeOfMass-1-j]=mass[i, j];
                }
            }
        }

        static void MirrorHorizont(string[,] mass, int sizeOfFigure)
        {
            int sizeOfMass = sizeOfFigure * 2 - 1;
            for (int i = 0; i < sizeOfMass; i++)
            {
                for (int j = 0; j < sizeOfFigure - 1; j++)
                {
                    mass[sizeOfMass - 1 - j,i] = mass[j, i];
                }
            }
        }

        static string GetShape(string consoleInformation)
        {
            string[] options = consoleInformation.Split(new char[] { ',', ' ', '/' });
            return options[0];
        }

        static int GetSize(string consoleInformation)
        {
            try
            {
                string[] options = consoleInformation.Split(new char[] { ',', ' ', '/' });
                int size = Convert.ToInt32(options[1]);
                return size;
            }
            catch (Exception)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Value of size entered incorrectly");
                return 0;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            
        }

    } 
}
