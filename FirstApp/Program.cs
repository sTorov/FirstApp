class Car<TEngine> where TEngine : Engine
{
    public TEngine Engine;

    public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart 
    {
        
    } 
}

abstract class CarPart { }
abstract class Engine { }

class Battery : CarPart { }
class Differential : CarPart { }
class Wheel : CarPart { }
class ElectricEngine : Engine{ }
class GasEngine : Engine{ }