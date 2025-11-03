using System;
using System.Collections;

namespace NonGenArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            // Adding elements
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            al.Add(5);

            // Iterating and printing elements
            foreach (var item in al)
                Console.WriteLine(item);
        }
    }
}
