using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program do liczenia silni.");

            int n;
            Console.Write("Podaj liczbę = ");
            n = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            int i = 1;
            while (i <= n)
            {
                x *= i;
                i++;
            }
            Console.WriteLine("{0}! = {1}", n, x);
            Console.ReadKey(true);
        }
    }
}