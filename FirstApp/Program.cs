﻿using System;

namespace Unit4
{
    class Logic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой ваш любимый цвет?");
                        
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Itration " + i);
                
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;         //Цвет фона текста в консоли
                        Console.ForegroundColor = ConsoleColor.White;       //Цвет шрифта
                        Console.WriteLine("Ваш любимый цвет красный!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет зеленый!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет бирюзовый!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ваш любимый цвет желтый!");
                        break;
                }
            }
            
            

            Console.ReadLine();
        }
    }
}