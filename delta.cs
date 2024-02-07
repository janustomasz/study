using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Podaj liczbę a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę c: ");
            c = Convert.ToDouble(Console.ReadLine());
            
            double delta = (b * b) - (4 * a * c);
            Console.Write("Delta równa się: "+delta+"\n");

            if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.Write("X = "+x+"\n");
            }
            else if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.Write("X1 = "+x1+"\n");
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.Write("X2 = "+x2+"\n");
            }
            else
            {
                Console.Write("Błąd obliczenia, delta jest ujemna!");
            }

        }
    }
}