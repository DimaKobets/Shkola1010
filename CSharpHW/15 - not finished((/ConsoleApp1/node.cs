using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Node<T>
    {
        public Node<T> next;
        public Node<T> prev;
        public T value;
        public static int size;

        public Node (T value)
        {
            this.value = value;
        }
        
    }

    
}
