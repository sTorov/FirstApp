﻿static class StringExtensions
{
    public static char GetLastChar(this string source)
    {
        return source[source.Length - 1];
    }
}

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello";
        Console.WriteLine(str.GetLastChar());

        Console.WriteLine("Строка".GetLastChar());
    }
}