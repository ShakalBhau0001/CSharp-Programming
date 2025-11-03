using System;
using System.Collections.Generic;

namespace GenericLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> l = new LinkedList<int>();
            // Adds at the end
            l.AddLast(3);
            // Adds at the beginning
            l.AddFirst(5);
            // Adds at the end
            l.AddLast(7);
            // Adds at the end
            l.AddLast(0);
            // Display the elements in the LinkedList
            Console.WriteLine("Elements in the LinkedList:");
            foreach (var i in l)
            {
                Console.WriteLine(i);
            }
        }
    }
}
