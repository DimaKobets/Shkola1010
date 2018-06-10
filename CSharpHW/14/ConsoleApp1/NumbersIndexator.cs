using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NumbersIndexator
    {
        public Number[] numbers;

        public int Get(int index)
        {
            return numbers[index].number;
        }
        public void Set(int index, Number num)
        {
            numbers[index] = num;
        }

        public NumbersIndexator(int[] array)
        {
            numbers = new Number[6];
            for (int i = 0; i < 6; i++)
            {
                numbers[i] = new Number(array[i]);
            }
        }
    }  
}
