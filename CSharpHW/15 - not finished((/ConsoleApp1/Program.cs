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
            Node<int> node1 = new Node<int>(1);            
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Node<int> node4 = new Node<int>(4);

            List<int> list = new List<int>();
            list.AddFirst(node1);
            list.AddLast(node2);
            list.AddLast(node3);
            list.AddLast(node4);



        }
    }
}
