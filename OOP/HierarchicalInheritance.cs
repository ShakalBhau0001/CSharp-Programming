namespace HierarchicalInheritance
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

    internal class C : A
    {
        public void demo()
        {
            Console.WriteLine("I AM Derived Class C From A");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hierarchical Inheritance:- ");
            B a = new B();
            C b = new C();
            a.display();
            b.show();
            b.demo();
        }
    }
}
