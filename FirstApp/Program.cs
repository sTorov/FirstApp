using System;

class Car
{
    public int Mileage;
    public Car()
    {
        Mileage = 0;
    }

    public virtual void Move()
    {
        Console.WriteLine("Вызван метод Move класса Car");
        Mileage++;
    }
}

enum FuelType
{
    Gas = 0,
    Electricity
}

class HybridCar : Car
{
    public FuelType FuelType;
    public double Gas;
    public double Electricity;

    public HybridCar()
    {
        Gas = 50;
        Electricity = 50;
    }

    public override void Move()
    {
        Console.WriteLine("Вызван метод Move класса HybridCar");
        Mileage++;

        switch (FuelType)
        {
            case FuelType.Gas:
                Gas -= 0.5;
                break;
            case FuelType.Electricity:
                Electricity -= 0.5;
                break;
        }

    }
    public void ChangeFuelType(FuelType type)
    {
        FuelType = type;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        HybridCar hybridCar = new HybridCar();

        car.Move();             // метод класса Car
        hybridCar.Move();       // метод класса HybridCar
        ((Car)hybridCar).Move();// метод класса HybridCar
        
        hybridCar.Move();       // метод класса HybridCar

        Car newCar = hybridCar as Car;
        newCar.Move();          // метод класса HybridCar
    }
}
