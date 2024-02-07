using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdzający liczby pierwsze.");

            int n;
            Console.Write("Podaj liczbę całkowitą: ");
            n = Convert.ToInt32(Console.ReadLine());

            int i = 2;
            while (i <= n/2)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Liczba {0} nie jest liczbą pierwszą.", n);
                    return;
                }
                i++;
            }

            Console.WriteLine("Liczba {0} jest liczbą pierwszą.", n);

            Console.ReadKey(true);
        }
    }
}