namespace InterfacePractices
{ 
    class Program
    {
        static void Main()
        {
            IFile file = new FileInfo();
            IBinaryFile binaryFile = new FileInfo();
            FileInfo fileInfo = new FileInfo();

            file.ReadFile();

            binaryFile.ReadFile();
            binaryFile.OpenBinaryFile();

            fileInfo.Search("Текст для поиска");
        }
    }

    public interface IFile
    {
        void ReadFile();
    }

    public interface IBinaryFile
    {
        void ReadFile();
        void OpenBinaryFile();
    }

    class FileInfo : IFile, IBinaryFile
    {
        void IBinaryFile.OpenBinaryFile()
        {
            Console.WriteLine("Открываю бинарный файл...");
        }

        void IFile.ReadFile()
        {
            Console.WriteLine("Читаю текстовый файл..");
        }

        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Открываю текстовый файл...");
        }

        public void Search(string text)
        {
            Console.WriteLine("Начался поиск текста в файле...");
        }
    }
}

