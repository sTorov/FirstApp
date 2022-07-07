using System;
using System.IO;
class FileWriter
{
    const string SettingsFileName = "Settings.cfg";

    static void Main()
    {
        //Пишем
        WriteValues();
        //Считываем
        ReadValues();
    }

    static void WriteValues()
    {
        // Создаем объект BinaryWriter и указываем, куда будет направлен поток данных
        using (BinaryWriter writer = new BinaryWriter(File.Open(SettingsFileName, FileMode.Create)))
        {
            // записываем данные в разном формате
            writer.Write(20.666F);
            writer.Write(@"Тестовая строчка");
            writer.Write(55); 
            writer.Write(false);
        }
    }
    static void ReadValues()
    {
        float FloatValues;
        string StringValues;
        int IntValues;
        bool BoolValues;

        if(File.Exists(SettingsFileName))
        {
            // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open
            using(BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
            {
                // Применяем специализированные методы Read для считывания соответствующего типа данных
                FloatValues = reader.ReadSingle();
                StringValues = reader.ReadString();
                IntValues = reader.ReadInt32();
                BoolValues = reader.ReadBoolean();
            }

            Console.WriteLine("Из файла считано:");

            Console.WriteLine("Дробь " + FloatValues);
            Console.WriteLine("Строка " + StringValues);
            Console.WriteLine("Целое " + IntValues);
            Console.WriteLine("Булево значение " + BoolValues);
        }
    }
}
