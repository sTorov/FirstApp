using System;

class Obj
{
    private string name;
    private string description;
    private string type;

    public Obj(string type)
    {
        //Console.WriteLine("Вызван конструктор без параметров");
        this.type = type;
    }
    public Obj(string name, string description) : this("Тип") // this()
    {
        this.name = name;
        this.description = description;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Obj obj = new Obj("Объект", "Нет описания");

        Console.ReadKey();
    }
}