using System;
using System.Collections.Generic;

namespace GenericDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sub = new Dictionary<int, string>();

            // Adding elements
            sub.Add(1, "One");
            sub.Add(2, "Two");
            sub.Add(3, "Three");

            // Displaying dictionary
            foreach (var ele in sub)
            {
                Console.WriteLine($"Key: {ele.Key}, Value: {ele.Value}");
            }
        }
    }
}
