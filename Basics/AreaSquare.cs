namespace AreaSquare
  {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side of Square: ");
            int side = Convert.ToInt32(Console.ReadLine());
            int area = side * side;
            Console.WriteLine("Area of a Square of " + side + ":- " + area);
            Console.ReadLine();
        }
    }
}
