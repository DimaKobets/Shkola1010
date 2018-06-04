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
            Console.WriteLine("Введите выражение и нажмите Enter");
            String expression = Console.ReadLine();
            Calculate(expression);
            Console.ReadKey();            
        }

        static void Calculate(string str)
        {            
            string[] splitedString = SplitString(str);
            double[] operands = SringToDouble(splitedString);            
            
            if (str.Contains('+'))
            {
                Console.WriteLine(operands[0] + operands[1]);
            }
            else if (str.Contains('-'))
            {
                Console.WriteLine(operands[0] - operands[1]);
            }
            else if (str.Contains('*'))
            {
                Console.WriteLine(operands[0] * operands[1]);
            }
            else if (str.Contains('/'))
            {
                Console.WriteLine(operands[0] / operands[1]);
            } 

        }


        static string[] SplitString(string str)
        {
            string[] split = str.Split(new char[] { '+', '-', '*', '/' });
            return split;
        }

        static double[] SringToDouble(string[] splitedString)
        {
            double[] operand = new double[2]; 
            try
            {
                operand[0] = Convert.ToDouble(splitedString[0]);
                operand[1] = Convert.ToDouble(splitedString[1]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено неправильное выражение");                
            }
            return operand;
        }

    }
}
