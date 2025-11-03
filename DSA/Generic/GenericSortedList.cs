using System;
using System.Collections.Generic;

namespace GenericSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();

            // Adding key-value pairs
            sl.Add(3, "Three");
            sl.Add(1, "One");
            sl.Add(2, "Two");
            sl.Add(4, "Four");

            // Displaying elements in sorted by key
            foreach (var item in sl)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
}
