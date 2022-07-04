using System;
using System.IO;
class FileWriter
{
    public static void Main()
    {
        var fileInfo = new FileInfo(@"D:\VisualStudio\repos\FirstApp\FirstApp\Program.cs");
                
        using (StreamWriter sw = fileInfo.AppendText())
        {
            sw.WriteLine($"//Время запуска: {DateTime.Now}");
        }
        
        using (StreamReader sr = fileInfo.OpenText())
        {
            string str = "";
            while ((str = sr.ReadLine()) != null)
                Console.WriteLine(str);
        }        

        Console.ReadLine();
    }
}
