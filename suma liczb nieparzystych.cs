using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.Write("Podaj wartość n: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i += 2) 
            {
                sum += i;
            }

            Console.WriteLine("Suma pierwszych {0} liczb nieparzystych: {1}", n, sum);   
            Console.ReadKey(true);
        }
    }
}