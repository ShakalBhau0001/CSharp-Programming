namespace AreaTriangle
  {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base of triangle:");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height of triangle:");
            int Height = Convert.ToInt32(Console.ReadLine());
            int Area = (int)(0.5 * Base * Height);
            Console.WriteLine("Area of a triangle of base " + Base + " height " + Height + ":- " + Area);
            Console.ReadLine();
        }
    }
}
