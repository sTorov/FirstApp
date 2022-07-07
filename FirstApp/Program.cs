using System;
using System.IO;
class FileWriter
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF7;
        Console.InputEncoding = System.Text.Encoding.UTF7;

        string FileName = @"C:\Users\1357680\Desktop\BinaryFile.bin";

        WriteValues(FileName);
        ReadValues(FileName);
    }

    static void WriteValues(string path)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
        {
            writer.Write("Файл изменён " + DateTime.Now + " на компьютере ОС " + Environment.OSVersion);
        }
    }
    static void ReadValues(string path)
    {
        string StringValues;

        if(File.Exists(path))
        {
            using(BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                StringValues = reader.ReadString();
            }

            Console.WriteLine(StringValues);
        }
    }
}
