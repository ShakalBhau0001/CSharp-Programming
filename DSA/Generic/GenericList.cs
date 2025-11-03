namespace GenericList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> l = new List<string> { "C#", "Java", "Javascript","HTML","CSS","Python"};
            foreach (string name in l)
            {
                Console.WriteLine(name);
            }
        }
    }
}
