namespace MinBetThree
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
                int min = Math.Min(n1, Math.Min(n2, n3));
                Console.WriteLine("Minimum Number: " + min);
            }
          Console.ReadLine();
        }
    }
}
