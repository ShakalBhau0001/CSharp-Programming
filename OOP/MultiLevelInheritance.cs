namespace MultiLevelInheritance
{
  
    internal class A
    {
        public void show()
        {
            Console.WriteLine("I AM Main Class A...");
        }
    }

    internal class B : A
    {
        public void display()
        {
            Console.WriteLine("I AM Derived Class B From A");
        }
    }

    internal class C : B
    {
        public void demo()
        {
            Console.WriteLine("I AM Derived Class C From B");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MultiLevel Inheritance:- ");
            C a = new C();
            a.show();
            a.display();
            a.demo();
        }
    }
}
