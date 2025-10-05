namespace ArmstrongNumber
  {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, remainder ,temp = num;
            while (num > 0)
            {
                remainder = num % 10;
                sum = sum + remainder * remainder * remainder;
                num = num / 10;
            }
            if (sum == temp)
                Console.WriteLine(temp + " is an Armstrong number.");
            else
                Console.WriteLine(temp + " is Not an Armstrong number.");
        }
    }
}
