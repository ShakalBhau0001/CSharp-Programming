namespace PalindromeNumber
  {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, remainder, temp = num;
            while (num > 0)
            {
                remainder = num % 10;
                sum = sum * 10 + remainder;
                num = num / 10;
            }
            if (sum == temp)
                Console.WriteLine(temp + " is a Palindrome Number");
            else
                Console.WriteLine(temp + " is a Not Palindrome Number");
        }
    }
}
