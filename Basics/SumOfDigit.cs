namespace SumOfDigit
  {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0,remainder;
            while (num > 0)
            {
                remainder = num % 10;
                sum = sum + remainder;
                num = num / 10;
            }
            Console.WriteLine("Sum of digits is: " + sum);
            Console.ReadLine();
        }
    }
}
