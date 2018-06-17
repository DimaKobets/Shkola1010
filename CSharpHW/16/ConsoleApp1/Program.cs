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
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Working with queue\n");
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("Size of queue: " + queue.GetLength());
            Console.WriteLine("Adding 4 elements:");
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);           
            queue.ShowAllElements();
            Console.WriteLine("Size of queue: " + queue.GetLength());
            Console.WriteLine("Value " + queue.Dequeue() + " processed.");
            Console.WriteLine("Value " + queue.Dequeue() + " processed.");
            Console.WriteLine("Size of queue: " + queue.GetLength());
            queue.Clear();
            Console.WriteLine("Queue was cleaned");
            Console.WriteLine("Size of queue: " + queue.GetLength());

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWorking with stack\n");
            Stack <string> stack  = new Stack<string>();
            Console.WriteLine("Adding 3 elements:");
            stack.Push("dima");
            stack.Push("kate");
            stack.Push("alex");
            stack.ShowAllElements();
            Console.WriteLine("Size of stack: " + stack.GetLength());
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Stack after pop:");
            stack.ShowAllElements();
            stack.Clear();
            Console.WriteLine("Stack was cleaned");
            Console.WriteLine("Size of stack: " + stack.GetLength());

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nWorking with dictionary\n");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Console.WriteLine("Adding 3 elements:");
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            dictionary.Show();
            Console.Write("getting value by key \"3\": ");
            Console.WriteLine(dictionary.GetByKey(3));
            Console.WriteLine("check if dictionary contains \"3\"");
            if (dictionary.ConteinsKey(1))
            {
                Console.WriteLine("dictionary contains 3");
            }
            dictionary.RemoveByKey(2);
            dictionary.Show();
            Console.WriteLine("getting by value \"Two\"");
            if (!dictionary.ConteinsValue("Two"))
            {
                Console.WriteLine("dictionary don`t contains \"Two\"");
            }

            Console.ReadLine();
            
        }
    }
}
