using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main (string[] args)
        {
            int a, b;
            Console.Write("Podaj a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}/{1}={2}r{3}", a, b, a/b, a%b);
            Console.ReadKey(true); //pauza
        }
    }
}