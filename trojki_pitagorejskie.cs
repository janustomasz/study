using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, koniec;
            Console.WriteLine("Szukanie trójek pitagorejskich w danym zakresie:");
            Console.WriteLine("Podaj początek zakresu: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj koniec zakresu: ");
            koniec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Trójki pitagorejskie w danym zakresie:");
        
            for(int a = start; a <= koniec; a++)
            {
                for(int b = a; b <= koniec; b++)
                {
                    for(int c = b; c <= koniec; c++)
                    {
                        if(a*a + b*b == c*c)
                        {
                            Console.WriteLine("{0}, {1}, {2}", a, b, c);
                        }
                    }
                }
            }
        }
    }
}