//Сильно упрощает рефакторинг при изменении функционала интерфейса

public interface ICalculator                     
{
    //void Solve(int number);
    void Solve(int numberOme, int numberTwo);
}

public class BaseCalculator : ICalculator
{
    void ICalculator.Solve(int number)
    {

    }

    void ICalculator.Solve(int numberOme, int numberTwo)
    {

    }
}

