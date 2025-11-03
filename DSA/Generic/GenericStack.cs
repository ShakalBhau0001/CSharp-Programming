namespace GenericStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            // Push elements onto the stack
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);

            // Peek element
            Console.WriteLine("Peek element of stack: " + s.Peek());

            // Pop elements from the stack
            while (s.Count > 0)
            {
                Console.WriteLine("Elements of Stack: " + s.Pop());
            }
        }
    }
}
