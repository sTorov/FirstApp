using System;
using System.IO;
class FileWriter
{
    public static void Main()
    {
        string filePath = @"D:\VisualStudio\repos\FirstApp\FirstApp\Program.cs";
                
        using (StreamReader sr = File.OpenText(filePath))
        {
            string str = "";
            while ((str = sr.ReadLine()) != null)
                Console.WriteLine(str);
        }        

        Console.ReadLine();
    }
}
