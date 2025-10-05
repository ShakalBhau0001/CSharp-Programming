namespace MinBetTwo
  {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine("Both Numbers Are Equal");
            }
            else
            {
                int min = (n1 < n2) ? n1 : n2;
                Console.WriteLine("Minimum Number: " + min);
            }
          Console.ReadLine();
        }
    }
}
