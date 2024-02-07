using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program dodający do siebie liczby(123 => 1+2+3=6).");

            int n;
            Console.Write("Podaj liczbę całkowitą: ");
            n = Convert.ToInt32(Console.ReadLine());

            int x = 0;
            while (n > 0)
            {
                x += n % 10;
                n /= 10;
            }

            Console.WriteLine("Suma liczb: " + x);

            Console.ReadKey(true);
        }
    }
}