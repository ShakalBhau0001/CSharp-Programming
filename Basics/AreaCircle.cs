namespace AreaCircle
  {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of circle: ");
            float radius = float.Parse(Console.ReadLine());
            float area = (float)(Math.PI * Math.Pow(radius, 2));
            Console.WriteLine("Area of a circle of radius " + radius + " is: " + area);
            Console.ReadLine(); 
        }c
    }
}
