using System;

namespace Unit4
{
    class Logic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя:");
            string Name = Console.ReadLine();
           
            Console.WriteLine("Ваше имя по буквам: ");

            foreach (char ch in Name)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine("Последняя буква вашего имени: {0}", Name[Name.Length - 1]);

            //Задание 4.3.7

            char[] chars = new char [Name.Length];
                       
            for (int k = Name.Length - 1, i = 0; i < chars.Length; i++, k--)
            {
                chars[i] = Name[k];
                Console.Write(chars[i] + " ");
            }

            //Правильный вариант

            Console.WriteLine("\n");

            for (int i = Name.Length - 1; i >= 0; i--)
            {
                Console.Write(Name[i] + " ");
            }

            Console.ReadKey();
        }
    }
}