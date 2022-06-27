abstract class Transport
{
    public abstract void Move();
}
class Boat : Transport
{
    public override void Move()
    {
        //...
    }
}
class Car : Transport
{
    public int Mileage;
    public double Fuel;

    public Car()
    {
        Fuel = 50;
        Mileage = 0;
    }

    public override void Move()
    {
        Mileage++;
        Fuel -= 0.5;
    }
    public void FillTheCar()
    { 
        Fuel = 50;
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

    public void ChangeFuelType(FuelType type)
    {
        FuelType = type;
    }
}
