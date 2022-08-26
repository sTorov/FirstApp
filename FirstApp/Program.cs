using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        var softwareManufacturers = new List<string>()
        {
           "Microsoft", "Apple", "Oracle"
        };

        var hardwareManufacturers = new List<string>()
        {
           "Apple", "Samsung", "Intel"
        };

        var itCompanies = softwareManufacturers.Union(hardwareManufacturers);
        //или
        var itCompanies2 = hardwareManufacturers.Union(softwareManufacturers);

        foreach(var comp in itCompanies)
            Console.WriteLine(comp);
    }    
}
