using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Queue<T>
    {
        private int Count = 0;
        private T[] Elements = new T[0];

        public T Dequeue()
        {
            T tmp = Elements[Elements.Length - 1];
            T[] newArray = new T[Elements.Length - 1];
            for (int i = 0; i < Elements.Length - 1; i++)
            {
                newArray[i] = Elements[i];
            }
            Elements = newArray;
            Count--;
            return tmp;
        }

        public void Enqueue(T newElement)
        {
            
            T[] newArray = new T[Elements.Length + 1];
            newArray[0] = newElement;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                newArray[i + 1] = Elements[i];
            }
            Elements = newArray;
            Count++;
        }

        public void Clear()
        {
            Elements = new T[0];
            Count = 0;
        }

        public int GetLength()
        {
            return Count;
        }

        public void ShowAllElements()
        {
            foreach (var element in Elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
