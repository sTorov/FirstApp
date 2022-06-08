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
        User.LoginCount = User.Login.Length;

        Console.WriteLine("Есть ли у вас животное (да/нет) : ");
        string PetAnswer = Console.ReadLine();
        if (PetAnswer == "да" || PetAnswer == "Да")
            User.Pet = true;
        else
            User.Pet = false;

    }
}