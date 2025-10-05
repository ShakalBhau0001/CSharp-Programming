namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is an Even Number");
            }
            else
            {
                Console.WriteLine(num + " is an Odd Number");
            }
            Console.ReadLine();
        }
    }
}
