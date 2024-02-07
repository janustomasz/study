using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, i;
            Console.Write("Podaj liczbę x: ");
            x = Convert.ToDouble(Console.ReadLine());

            for (i = 7; i <= x * 7; i+=7)

                Console.Write("{0} ",i);
            Console.ReadKey(true);
        }
    }
}