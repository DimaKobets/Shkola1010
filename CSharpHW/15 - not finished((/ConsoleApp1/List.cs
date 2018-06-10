using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class List <T>
    {
        public Node<T> head;
        public Node<T> last;
        public int size;
        public List()
        {
            size = 0;
        }

        public void AddFirst(Node<T> value)
        {
            if (head == null)
            {
                head = value;
                last = value;
            }
            else
            {
                Node<T> tmp = head;
                head = value;
                tmp.prev = head;
                head.next = tmp;
            }
            size++;
        }

        public void AddLast(Node<T> value)
        {            
            if (head == null)
            {
                head = value;
                last = head;
            }
            else
            {
                value.prev = last;
                last.next = value;
                last = value;
            }
            size++;
        }     


    }
}
