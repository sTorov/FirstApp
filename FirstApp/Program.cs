using System;

class Car
{
    public double Fuel;
    public int Mileage;
    public Car()
    {
        Fuel = 50;
        Mileage = 0;
    }

    public void Move()
    {
        //Move a kilometer
        Mileage++;
        Fuel -= 0.5;
    }
    public void ReFuel()
    {
        Fuel = 50;
    }
}

