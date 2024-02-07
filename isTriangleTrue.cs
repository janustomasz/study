using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj wysokość trójkąta (n>4): ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if(j == 1 || j == i || i == n)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}