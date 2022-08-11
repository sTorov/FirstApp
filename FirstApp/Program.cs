using System.Diagnostics;

class Program
{
    static void Main()
    {
       var array = Estimate(20);
        MiddleTime(array);
    } 
    
    static void CreateMatrix(int n)
    {
        var matrix = new int[n][];

        for(int i = 0; i < n; i++)
            matrix[i] = new int[n];

        for(int i = 0; i < n; i++)
            for(int j = 0; j < n; j++)
                matrix[i][j] = i + j;
    }

    static long[] Estimate(int n)
    {
        var timer = new Stopwatch();
        long[] times = new long[n];

        timer.Start();

        for(int i = 0; i < n; i++)
        {
            timer.Restart();

            CreateMatrix(10000);

            timer.Stop();
            times[i] = timer.ElapsedMilliseconds;
        }

        return times;
    }

    static void MiddleTime(long[] array)
    {
        long sum = 0;
        for (int i = 0; i < array.Length; i++)
            sum += array[i];

        Console.WriteLine(sum / array.Length);       
        
    }
}