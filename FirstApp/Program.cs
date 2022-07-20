namespace InterfacePractices
{ 
    class Program
    {
        static void Main()
        {
            
        }
    }

    public interface IWriter
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail();
    }

    class FileManager : IWriter, IReader, IMailer
    {
        void IReader.Read()
        {
            throw new NotImplementedException();
        }

        void IMailer.SendEmail()
        {
            throw new NotImplementedException();
        }

        void IWriter.Write()
        {
            throw new NotImplementedException();
        }
    }
}

