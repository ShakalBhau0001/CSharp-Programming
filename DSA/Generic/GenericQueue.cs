using System;
using System.Collections.Generic;

namespace GenericQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a Queue of object type to hold different data types
            Queue<object> q = new Queue<object>();

            // Adding elements to the Queue
            q.Enqueue("GFG");
            q.Enqueue(10);
            q.Enqueue(null);
            q.Enqueue(3.5);
            q.Enqueue("Geeks123");

            // Display the first element dequeued from the queue
            Console.WriteLine(q.Dequeue());

            // Accessing the elements of q Queue using foreach loop
            foreach (var i in q)
            {
                Console.WriteLine("Elements of Queue: " + i);
            }
        }
    }
}
