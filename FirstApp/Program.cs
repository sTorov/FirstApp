using System.Collections;

class Program
{
    static void Main()
    {
        var months = new[]
        {
           "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };

        var numbers = new[]
        {
            1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12
        };

        var list = new ArrayList();

        for(int i = 0, j = 0; i < numbers.Length; i++, j++)
        {
            if (months[j] == "Apr")
            {
                list.Add(months[j]);
                j++;
            }
            
            list.Add(months[j]);
            list.Add(numbers[i]);
        }

        foreach(var item in list)
            Console.WriteLine(item);
    }
}