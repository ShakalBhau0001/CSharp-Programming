namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            int temp = 0;
            if (num <= 1)
            {
                Console.WriteLine(num + " is not a prime number");
            }
            else
            {
                while (i <= num / 2)
                {
                    if (num % i == 0)
                    {
                        temp = 1;
                        break;
                    }
                    i++;
                }

                if (temp == 0)
                {
                    Console.WriteLine(num + " is prime number");
                }
                else
                {
                    Console.WriteLine(num + " is not a prime number");
                }
                Console.ReadLine();
            }
        }
    }
}
