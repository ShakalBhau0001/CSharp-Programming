namespace ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 6, 12, 23, 45, 8, 67, 31, 19, 50, 27 };
            int sum = 0;
            foreach (var i in numbers)
            {
                if (i > 0)
                {
                    sum = sum + i;
                }
                Console.WriteLine("sum =" + sum);
            }
        }
    }
}
