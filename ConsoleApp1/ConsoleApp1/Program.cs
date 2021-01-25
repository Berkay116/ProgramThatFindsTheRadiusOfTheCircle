using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1416;
            int r = 50;
            double V = 4 / 3 * pi * (r * r * r);

            Console.WriteLine("Kürenin Hacmi = "+V);
            Console.ReadKey();


        }
    }
}
