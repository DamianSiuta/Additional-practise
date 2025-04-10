using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_for
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczbę naturalną n (n > 1). Narysuj na ekranie z gwiazdek odwrócony trójkąt prostokątny. Użyj pętli for. Przykładowo dla n=4 trójkąt powinien wyglądać:
            Console.WriteLine("enter number n>1: ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("error");
                return;
            }
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                { 
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}
