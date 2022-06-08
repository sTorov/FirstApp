using System;

class FirstApp
{
    static void Main(string[] args)
    {
        (string Name, string SurName, string Login, int LoginCount, bool Pet, double Age, string[] FavColor) User;

        Console.Write("Введите имя: ");
        User.Name = Console.ReadLine();

        Console.Write("Введите фамилия: ");
        User.SurName = Console.ReadLine();

        Console.Write("Введите логин: ");
        User.Login = Console.ReadLine();
    }
}