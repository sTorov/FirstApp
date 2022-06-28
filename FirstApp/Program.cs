/*
 * Статические конструкторы имеют следующие отличительные черты:


Статические конструкторы не могут иметь модификатора доступа.

Статические конструкторы не могут принимать параметры.

Статические конструкторы не могут использовать нестатические поля (и не могут 
использовать и ключевое слово this).

Статический конструктор невозможно вызвать в коде.

Статический конструктор выполняется при первом создании экземпляра данного класса, 
либо при первом обращении к статическим членам класса.
 */

class Car
{
    public static int MinPrice = 100_000;
    public static int MaxPrice;

    static Car()
    {
        Console.WriteLine("Вызван статический конструктор класса Car");
        MaxPrice = 1_000_000;
    }

    public int Price;
}
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();

        Console.WriteLine(Car.MinPrice);
        Console.WriteLine(Car.MaxPrice);

        Console.ReadLine();
    }
}