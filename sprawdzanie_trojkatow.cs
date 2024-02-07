using System;  

namespace ConsoleApplication1 
{  
    class Program
    {
        static void Main(string[] args)
        {  
            int a, b, c; 
            Console.Write("Sprawdzanie czy trójkąt istnieje:\n");

            Console.Write("Podaj bok 1 trójkąta: ");
            a= Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj bok 2 trójkąta: ");
            b= Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Podaj bok 3 trójkąta: ");
            c= Convert.ToInt32(Console.ReadLine());  

            if(a + b > c && a + c > b && b + c > a)

            {  
                Console.Write("Trójkąt istnieje.");  
            }
            else 
            {  
                Console.Write("Trójkąt nie istnieje!.");  
            }  
        } 
    }
} 