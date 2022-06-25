using System;
class Vector
{
    public int Y;
    public int X;

    public Vector Add(Vector second)
    {
        return new Vector 
        { 
            X = this.X + second.X, 
            Y = this.Y + second.Y 
        };
    }

    //Реализация перегрузки оператора "+"
    //1
    public static Vector operator + (Vector A, Vector B)
    {
        return new Vector
        {
            X = A.X + B.X,
            Y = A.Y + B.Y
        };
    }
    //2
    public static Vector operator + (Vector A)
    {
        return new Vector
        {
            X = A.X,
            Y = A.Y
        };
    }
    //3
    public static Vector operator + (Vector A, (int X, int Y) B)
    {
        return new Vector
        {
            X = A.X + B.X,
            Y = A.Y + B.Y
        };
    }

}
class Program
{
    static void Main(string[] args)
    {
        Vector A = new Vector { X = 3, Y = 5 };
        Vector B = new Vector { X = 7, Y = 13 };

        Vector C = new Vector { X = A.X + B.X, Y = A.Y + B.Y };

        Vector D = A.Add(B);

        //Сложение векторов для типа Vector
        //1
        Vector E = A + B;
        //2
        Vector F = + A;
        //3
        Vector G = A + (3, 3);

        Console.ReadLine();
    }
}