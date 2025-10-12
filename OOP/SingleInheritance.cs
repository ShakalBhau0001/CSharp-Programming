namespace SingleInheritance
{
    
    internal class A
    {
        public void show()
        {
            Console.WriteLine(" I AM Main Class A ");
        }
    }
    
    internal class B : A
    {
        public void display()
        {
            Console.WriteLine(" I AM Derived Class B From A ");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Single Inheritance:- ");
            B a = new B();
            a.show();
            a.display();
        }
    }
}
