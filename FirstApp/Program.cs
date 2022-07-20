namespace InterfacePractices
{
    class Program
    {
        static void Main()
        {
            IGarageManager<Car, Garage> garageManager1= new GarageManagerBase();            //Обычное объявление
            IGarageManager<Bike, Garage> garageManager2 = new GarageManagerBase();          //Контравариация   (Bike => Car)
            IGarageManager<Car, House> garageManager3 = new GarageManagerBase();            //Ковариация       (House => Garage)

                                                                          // Garage : House       Bike : Car
        }
    }
    
    class Car { }
    class Bike: Car { }

    class House { }
    class Garage : House { }

    public interface IGarageManager<in T, out Z>
    {
        Z GetGarageInfo();
        void Add(T car);
    }

    class GarageManagerBase : IGarageManager<Car, Garage>
    {
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public Garage GetGarageInfo()
        {
            throw new NotImplementedException();
        }
    }
}