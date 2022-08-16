using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList { 111, 111, "Hello", 555, "world", "again!", 52354, "Yoohoo!!!" };

        var newList = GetList(list);

        foreach(var item in newList)
            Console.WriteLine(item);
    }

    static ArrayList GetList(ArrayList input)
    {
        ArrayList result = new ArrayList();
        int sum = 0;
        string str = string.Empty;

        foreach(var item in input)
        {
            if (item is int)
                sum += (int)item;
            if (item is string)
                str += (string)item + " ";
        }
        str = str.Trim();

        result.Add(sum);
        result.Add(str);

        return result;
    }
}