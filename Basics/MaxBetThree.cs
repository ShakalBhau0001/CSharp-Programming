namespace MaxBetThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 == n2 && n2 == n3)
            {
                Console.WriteLine("All Numbers Are Equal");
            }
            else
            {
                int max = Math.Max(n1, Math.Max(n2, n3));
                Console.WriteLine("Maximum Number: " + max);
            }
          Console.ReadLine();
        }
    }
}
