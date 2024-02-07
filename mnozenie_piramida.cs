using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.Write("Podaj wysokość piramidy h>1: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i ; j++)
                    Console.Write("{0,3} ", i * j);
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}