using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę arabską od 1 do 1000000: ");
            a = Convert.ToInt32(Console.ReadLine());
            //milion
            if      (a >= 1000000)  { a -= 1000000; Console.Write("jeden milion"); }
            //setki tys
            if (a >= 900000)   { a -= 900000; Console.Write(" dziewięćset"); }
            else if (a >= 800000)   { a -= 800000; Console.Write(" osiemset"); }
            else if (a >= 700000)   { a -= 700000; Console.Write(" siedemset"); }
            else if (a >= 600000)   { a -= 600000; Console.Write(" sześćset"); }
            else if (a >= 500000)   { a -= 500000; Console.Write(" pięćset"); }
            else if (a >= 400000)   { a -= 400000; Console.Write(" czterysta"); }
            else if (a >= 300000)   { a -= 300000; Console.Write(" trzysta"); }
            else if (a >= 200000)   { a -= 200000; Console.Write(" dwieście"); }
            else if (a >= 100000)   { a -= 100000; Console.Write(" sto"); }
            //dziesiątki tys
            if      (a >= 90000)    { a -= 90000; Console.Write(" dziewięćdziesiąt"); }
            else if (a >= 80000)    { a -= 80000; Console.Write(" osiemdziesiąt"); }
            else if (a >= 70000)    { a -= 70000; Console.Write(" siedemdziesiąt"); }
            else if (a >= 60000)    { a -= 60000; Console.Write(" sześćdziesiąt"); }
            else if (a >= 50000)    { a -= 50000; Console.Write(" pięćdziesiąt"); }
            else if (a >= 40000)    { a -= 40000; Console.Write(" czterdzieści"); }
            else if (a >= 30000)    { a -= 30000; Console.Write(" trzydzieści"); }
            else if (a >= 20000)    { a -= 20000; Console.Write(" dwadzieścia"); }
            else if (a >= 10000)    { a -= 10000; Console.Write(" dziesięć"); }
            //tysiace
            if      (a >= 9000)    { a -= 9000; Console.Write(" dziewięć tysięcy"); }
            else if (a >= 8000)    { a -= 8000; Console.Write(" osiem tysięcy"); }
            else if (a >= 7000)    { a -= 7000; Console.Write(" siedem tysięcy"); }
            else if (a >= 6000)    { a -= 6000; Console.Write(" sześć tysięcy"); }
            else if (a >= 5000)    { a -= 5000; Console.Write(" pięć tysięcy"); }
            else if (a >= 4000)    { a -= 4000; Console.Write(" cztery tysiące"); }
            else if (a >= 3000)    { a -= 3000; Console.Write(" trzy tysiące"); }
            else if (a >= 2000)    { a -= 2000; Console.Write(" dwa tysiące"); }
            else if (a >= 1000)    { a -= 1000; Console.Write(" jeden tysiąc"); }
            else if (a >= 0000)    { a -= 0000; Console.Write(" tysięcy"); }
                
            //setki
            if      (a >= 900)     { a -= 900; Console.Write(" dziewiecset"); }
            else if (a >= 800)     { a -= 800; Console.Write(" osiemset"); }
            else if (a >= 700)     { a -= 700; Console.Write(" siedemset"); }
            else if (a >= 600)     { a -= 600; Console.Write(" sześćset"); }
            else if (a >= 500)     { a -= 500; Console.Write(" pięćset"); }
            else if (a >= 400)     { a -= 400; Console.Write(" czerysta"); }
            else if (a >= 300)     { a -= 300; Console.Write(" trzysta"); }
            else if (a >= 200)     { a -= 200; Console.Write(" dwieście"); }
            else if (a >= 100)     { a -= 100; Console.Write(" sto"); }
            //dziesiatki
            if      (a >= 90)     { a -= 90; Console.Write(" dziewięćdziesiąt"); }
            else if (a >= 80)     { a -= 80; Console.Write(" osiemdziesiąt"); }
            else if (a >= 70)     { a -= 70; Console.Write(" siedemdziesiąt"); }
            else if (a >= 60)     { a -= 60; Console.Write(" sześćdziesiąt"); }
            else if (a >= 50)     { a -= 50; Console.Write(" pięćdziesiąt"); }
            else if (a >= 40)     { a -= 40; Console.Write(" czterdzieści"); }
            else if (a >= 30)     { a -= 30; Console.Write(" trzydzieści"); }
            else if (a >= 20)     { a -= 20; Console.Write(" dwadzieścia"); }
            else if (a >= 19)     { a -= 19; Console.Write(" dziewiętnaście"); }
            else if (a >= 18)     { a -= 18; Console.Write(" osiemnaście"); }
            else if (a >= 17)     { a -= 17; Console.Write(" siedemnaście"); }
            else if (a >= 16)     { a -= 16; Console.Write(" szesnaście"); }
            else if (a >= 15)     { a -= 15; Console.Write(" piętnaście"); }
            else if (a >= 14)     { a -= 14; Console.Write(" czernaście"); }
            else if (a >= 13)     { a -= 13; Console.Write(" trzynaście"); }
            else if (a >= 12)     { a -= 12; Console.Write(" dwanaście"); }
            else if (a >= 11)     { a -= 11; Console.Write(" jedenaście"); }
            else if (a >= 10)     { a -= 10; Console.Write(" dziesięć"); }
            //jedynki
            switch (a)
            {
                case 1:             Console.Write(" jeden"); break;
                case 2:             Console.Write(" dwa"); break;
                case 3:             Console.Write(" trzy"); break;
                case 4:             Console.Write(" cztery"); break;
                case 5:             Console.Write(" pięć"); break;
                case 6:             Console.Write(" sześć"); break;
                case 7:             Console.Write(" siedem"); break;
                case 8:             Console.Write(" osiem"); break;
                case 9:             Console.Write(" dziewięć"); break;
                default:            Console.Write(""); break;
            }
            Console.ReadKey(true); //pauza
        }
    }
}