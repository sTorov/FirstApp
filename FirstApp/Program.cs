class Citizen
{
    public virtual double Age { get; set; }     //Виртуальное свойство

    public void SayYourAge()
    {
        Console.WriteLine("Мне {0}", Age);
    }
}
class CivilServant : Citizen
{
    private double age;
    public override double Age                  //Переопределённое свойство
    { 
        get
        {
            return age;
        }
        set 
        { 
            if(value < 18)
                Console.WriteLine("Для работы госсслужащим гражданин должен быть не младше 18 лет");
            else
                age = value;
        }
    }
}
class Presedent : Citizen                       
{
    private double age;
    public override double Age                     //Переопределённое свойство
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 35)
                Console.WriteLine("Для работы презедентом гражданин должен быть не младше 35 лет");
            else
                age = value;
        }
    }
}