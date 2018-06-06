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
            int size = GetSizeOfArray();           

            int[] array = new int[size];

            FillArray(array);
            Console.Write("\n\nArray: ");
            ShowArray(array);

            
            SortArray(array);
            Console.Write("\n\nSorted array: ");
            ShowArray(array);

            Console.Write("\n\nThe unique number of this array is : ");
            Console.WriteLine(FindUniqueNumber(array));
           
            Console.ReadLine();
        }

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\n");
        }

        static void FillArray(int[] array)
        {
            Random random = new Random();
            int repeatCounter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,array.Length/2 + 1);
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        repeatCounter++;
                        if (repeatCounter == 2)
                        {
                            i--;
                            repeatCounter = 0;
                        }
                    }
                }

            }
        }

        static void SortArray(int[] array)
        {
            int tmp;
            bool changeFlag = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (changeFlag)
                {
                    changeFlag = false;
                    for (int j = 0; j < array.Length - 1; j++)
                    { 
                        if (array[j] > array[j + 1])
                        {
                            tmp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = tmp;
                            changeFlag = true;
                        }                        
                    }
                }
                else break;
            }
        }

        static int FindUniqueNumber(int[] sortedArray)
        {         
            for (int i = 0; i < sortedArray.Length - 1; i += 2)
            {
                if (sortedArray[i] != sortedArray[i + 1])
                {
                    return sortedArray[i];
                }                
            }
            return sortedArray[sortedArray.Length - 1];

        }

        static int StringToInt(string str)
        {
            int operand = 0;
            try
            {               
                operand = Convert.ToInt32(str);
            }
            catch (FormatException)
            {
                Console.WriteLine("Values entered incorrectly");
            }
            return operand;
        }

        static int GetSizeOfArray()
        {
            int size = 0;
            while (true)
            {
                Console.WriteLine("Enter the size of array (This should be odd)");
                size = StringToInt(Console.ReadLine());
                if (!(size % 2 == 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Seze should be odd!!!");
                    continue;
                }
            }
            return size;
        }

    }
}
