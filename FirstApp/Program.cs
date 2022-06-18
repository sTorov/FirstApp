﻿using System;

class Company
{
    public string Name;
    public string Type;
}
class City
{
    public string Name;
}
class Department
{
    public Company Company;
    public City City;
}

class Program
{
    static void Main(string[] args)
    {
        var departmet = GetCurrentDepartment();

        if (departmet?.City?.Name == "Санкт-Петербург" && departmet?.Company?.Type == "Банк")
            Console.WriteLine($"У банка {departmet?.Company?.Name ?? "Неизветная компания"} есть отделение в Санкт-Петербурге");
        else
            Console.WriteLine("Error");
        
        Console.ReadKey();
    }

    static Department GetCurrentDepartment()
    {
        City city = new City { Name = "Санкт-Петербург" };
        Company company = new Company { Name = null, Type = "Банк" };
        Department Obj = new Department { City = city, Company = company};
        return Obj;
    }
}