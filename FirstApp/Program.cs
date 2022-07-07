namespace DriverManager
{
    class Program
    {
        public static FileInfo path =new FileInfo("DiskInfo.txt");

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF7;
            Console.InputEncoding = System.Text.Encoding.UTF7;

            DriveInfo[] drives = DriveInfo.GetDrives();

            path.Delete();

            foreach (DriveInfo drive in drives.Where(drive => drive.DriveType == DriveType.Fixed))
            {

                DirectoryInfo root = drive.RootDirectory;
                var folders = root.GetDirectories();

                Console.WriteLine($"Сканирую {drive.Name}");

                using(StreamWriter sw = path.AppendText())
                {
                    WriteDriveInfo(drive, sw);
                    WriteFilesInfo(root, sw);
                    WriteFoldersInfo(folders, sw);
                }

                Console.WriteLine("Завершено");
                Console.WriteLine("__________");
            }

            Console.ReadLine();
        }

        static void WriteDriveInfo(DriveInfo drive, StreamWriter sw)
        {
            sw.WriteLine($"Название: {drive.Name}");
            sw.WriteLine($"Тип: {drive.DriveType}");
            if (drive.IsReady)
            {
                sw.WriteLine($"Объём: {drive.TotalSize}");
                sw.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                sw.WriteLine($"Метка: {drive.VolumeLabel}");
            }
            sw.WriteLine();
        }
        static void WriteFoldersInfo(DirectoryInfo[] folders, StreamWriter sw)
        {
            sw.WriteLine("\nПапки:\n");
            foreach (var folder in folders)
            {
                try
                {
                    sw.WriteLine(folder.Name + $" - {DirectoryExctention.DirSize(folder)} байт");
                }
                catch (Exception e)
                {
                    sw.WriteLine(folder.Name + $" - Не удалось расчитать размер: {e.Message}");
                }                
            }
            sw.WriteLine();
        }

        static void WriteFilesInfo(DirectoryInfo rootFolder, StreamWriter sw)
        {
            sw.WriteLine("\nФайлы:\n");
            foreach (var file in rootFolder.GetFiles())
            {
                sw.WriteLine(file.Name + $" - {file.Length} байт");
            }
        }
    }
}