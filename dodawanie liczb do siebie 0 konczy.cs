using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program który dodaje do siebie liczby.("0" kończy liczenie.)");

            int n, x = 0;
            do 
            {
                Console.Write("Podaj liczbę całkowitą: ");
                n = Convert.ToInt32(Console.ReadLine());

                x += n;
            } 
            while (n != 0);
            Console.WriteLine("Suma liczb wynosi: " + x);

            Console.ReadKey(true);
        }
    }
}