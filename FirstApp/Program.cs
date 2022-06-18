using System;

class Rectangle
{
    public int a;
    public int b;
    
    public void Params()
    {
        Console.WriteLine($"a = {a}, b = {b}");
    }
    public int Square()
    {
        return a * b;
    }

    public Rectangle(int x, int y)
    {
        a = x;
        b = y;
    }
    public Rectangle(int x)
    {
        a = b = x;
    }
    public Rectangle()
    {
        a = 6;
        b = 4;
    }
}
class General
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(5);
        rect.Params();
        Console.WriteLine(rect.Square());
    }
}