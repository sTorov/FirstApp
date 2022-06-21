using System;

class Quadrate
{
    public int a;

    public double Perimeter(int a)
    {
        return a * 4;
    }
    public double Square(int a)
    {
        return a ^ 2;
    }
}

class Triangle
{
    public int a;
    public int b;
    public int c;
    public int ch;

    public double Perimeter(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Square(int c, int ch)
    {
        return (c * ch) / 2;
    }
}

class Circle
{
    public int r;
    double pi = Math.PI;

    public double Perimeter(int r)
    {
        return 2 * pi * r;
    }
    public double Square(int r)
    {
        return pi * (r ^ 2);
    }
}