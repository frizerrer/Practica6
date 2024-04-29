using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double x = Convert.ToDouble(Console.ReadLine());
            double F = Math.Sin(x) - 2 * Math.Cos(x);
            Console.WriteLine($" {F} {x}");
        }
    }
}