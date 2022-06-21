using System;

class Quadrate
{
    public int a;

    public Quadrate()
    {
        a = 3;
    }

    public double Perimeter(int a)
    {
        return a * 4;
    }
    public double Square(int a)
    {
        return a * a;
    }
}

class Triangle
{
    public int a;
    public int b;
    public int c;

    public Triangle()
    {
        a = 2; b = 3; c = 4;
    }

    public double Perimeter(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Square(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}

class Circle
{
    public int r;
    double pi = Math.PI;

    public Circle()
    {
        r = 3;
    }
    public double Perimeter(int r)
    {
        return 2 * pi * r;
    }
    public double Square(int r)
    {
        return pi * Math.Pow(r, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF7;
        Console.InputEncoding = System.Text.Encoding.UTF7;

        Quadrate quadrate = new Quadrate();
        Console.WriteLine("Сторона квадрата равна " + quadrate.a);
        Console.WriteLine("P = " + quadrate.Perimeter(quadrate.a));
        Console.WriteLine("S = " + quadrate.Square(quadrate.a) + "\n");

        Triangle triangle = new Triangle();
        Console.WriteLine("Стороны разностороннего треунольника равны " + triangle.a + " " + triangle.b + " " + triangle.c);
        Console.WriteLine("P = " + triangle.Perimeter(triangle.a, triangle.b, triangle.c));
        Console.WriteLine("S = {0:0.000} (формула Герона){1}", triangle.Square(triangle.a, triangle.b, triangle.c),"\n");

        Circle circle = new Circle();
        Console.WriteLine("Радиус круга равен " + circle.r);
        Console.WriteLine("P = {0:0.00}", circle.Perimeter(circle.r));
        Console.WriteLine("S = {0:0.00}{1}", circle.Square(circle.r), "\n");

        Console.ReadLine();
    }
}