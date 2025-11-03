using System;
using System.Collections.Generic;

namespace GenericHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hs = new HashSet<int>();

            // Adding elements
            hs.Add(1);
            hs.Add(2);
            hs.Add(3);
            hs.Add(4);
            hs.Add(5);

            // Duplicate element, will not be added
            hs.Add(1);
            hs.Add(2);
            hs.Add(6);

            // Printing the Size and Element of HashSet
            Console.WriteLine("HashSet Size: " + hs.Count);
            Console.WriteLine("Elements in HashSet: " + string.Join(", ", hs));
        }
    }
}
