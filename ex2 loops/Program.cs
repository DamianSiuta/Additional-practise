using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący współrzędne dwóch punktów A=(x1,y1) i B=(x2,y2) oraz
         //wypisujący na ekranie wzór funkcji liniowej przechodzącej przez te dwa punkty.
         // Wskazówka: Równanie prostej przechodzącej przez dwa punkty:
            Console.WriteLine("Podaj współrzędne punktu A=(x1,y1):");
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współrzędne punktu B=(x2,y2):");
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            if (x1 == x2 && y1 == y2)
            {
                Console.WriteLine("Punkty są identyczne - nieskończenie wiele prostych.");
                return;
            }

            if (x1 == x2)
            {
                Console.WriteLine($"Równanie prostej: x = {x1}");
                return;
            }

            
            double a = (y2 - y1) / (x2 - x1);

            
            double b = y1 - a * x1;

            
            Console.Write("Równanie prostej: y = ");

            if (a == 1)
                Console.Write("x");
            else if (a == -1)
                Console.Write("-x");
            else
                Console.Write($"{a}x");

            if (b > 0)
                Console.Write($" + {b}");
            else if (b < 0)
                Console.Write($" - {-b}");

            Console.ReadKey();
        }
    }
}