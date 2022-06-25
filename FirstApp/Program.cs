class A
{
    public virtual void Display()
    {
        Console.WriteLine("Вызван метод класса A");
    }
}
class B : A
{
    public override void Display()
    {
        Console.WriteLine("Вызван метод класса B");
    }
}
class C : B
{
    public new void Display()
    {
        Console.WriteLine("Вызван метод класса C");
    }
}

class Program
{
    static void Main(string[] args)
    {
        A a = new A();
        B b = new B();
        C c = new C();

        a.Display();        // метод класса A
        b.Display();        // метод класса B
        ((A)b).Display();   // метод класса B

        c.Display();        // метод класса C
        ((A)c).Display();   // метод класса B
        ((B)c).Display();	// метод класса B
    }
}