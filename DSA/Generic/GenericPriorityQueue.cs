using System;
using System.Collections.Generic;

namespace GenericPriorityQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

            // Enqueue elements with their priorities
            pq.Enqueue("Low priority task", 3);
            pq.Enqueue("Medium priority task", 5);
            pq.Enqueue("High priority task", 7);
            pq.Enqueue("Highest priority task", 10);

            // Dequeue elements and print them
            while (pq.Count > 0)
            {
                // Dequeue the highest priority element
                string item = pq.Dequeue();
                Console.WriteLine("Processing: " + item);
            }
        }
    }
}
