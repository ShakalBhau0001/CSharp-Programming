namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string result = (num % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine("The number is: " + result);
        }
    }
}
