using System;

namespace Unit4
{
    class Logic
    {
        static void Main(string[] args)
        {
            int A = 3;
            int B = 4;
            double X = 0.1;
            double Y = 1.3;

            bool C = (A < B) || (X > Y);

            Console.WriteLine(C);
            Console.ReadKey();
        }
    }
}