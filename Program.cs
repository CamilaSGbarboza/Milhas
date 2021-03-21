using System;

namespace Milhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---Milhas---");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("digite um número:");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double km = m * 1609;
            Console.WriteLine($"É {km} km");


        }
    }
}
