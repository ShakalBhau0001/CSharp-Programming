namespace ObjectCreationDemo
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public Student(int ID, string Name)
        {
            StudentId = ID;
            StudentName = Name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student ID:-{StudentId}, Student Name:-{StudentName}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Object Creation Using C# ");
            Student std = new Student(1, "Aisha");
            Student std1 = new Student(2, "Shayara");
            std.DisplayInfo();
            std1.DisplayInfo();
        }
    }
}
