using BenchmarkDotNet.Running;
using FirstApp;

class Program
{
    static void Main()
    {
        var summary = BenchmarkRunner.Run<Testing>();
    }      
}