using System.Collections;
using System.Text;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList { 111, 111, "Hello ", 555, "world ", "again! ", 223, "Yoohoo!!!" };

        var newList = GetList(list);

        foreach(var item in newList)
            Console.WriteLine(item);
    }

    static ArrayList GetList(ArrayList input)
    {
        int sum = 0;
        StringBuilder str = new StringBuilder();

        foreach(var item in input)
        {
            if (item is int)
                sum += (int)item;
            if (item is string)
                str.Append(item);
        }

        return new ArrayList { sum, str.ToString() };
    }
}