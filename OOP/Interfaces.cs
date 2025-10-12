namespace Interfaces
{
  
    interface A
    {
        void show();
    }

    internal class B : A
    {
        public void show()
        {
            Console.WriteLine("I AM [show] Method Of Interface A Derived In Class B");
        }
    }
    
    internal class C : A
    {
        public void show()
        {
            Console.WriteLine("I AM [show] Method Of Interface A Derived In Class C");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("InterFace Demo:- ");
            A a = new B();
            A b = new C();
            a.show();
            b.show();
        }
    }
}
