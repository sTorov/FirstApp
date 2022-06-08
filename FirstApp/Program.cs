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
        User.Pet = PetAnswer == "Да" || PetAnswer == "да" ? true : false;

        Console.WriteLine("Введите возраст: ");
        User.Age = double.Parse(Console.ReadLine());

        User.FavColor = new string[3]; 
        Console.WriteLine("Введите 3 любимых цвета: ");
        for (int i = 0; i < User.FavColor.Length; i++)
        {
            Console.Write($"{i + 1} Цвет: ");
            User.FavColor[i] = Console.ReadLine();
        }
                
    }
}