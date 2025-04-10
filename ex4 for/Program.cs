using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_for
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczbę naturalną n (n > 3). Narysuj na ekranie ze znaków # kontur kwadratu o boku n. Użyj pętli for. Przykładowo dla n=4 kwadrat powinien wyglądać:
            int n;
            Console.WriteLine("enter number(n>3): ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 3)
            {
                Console.WriteLine("error");
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n)
                    {
                        Console.Write("#");
                    }
                    else
                    { Console.Write(" "); }
                }
                Console.WriteLine();
            }

        }
    }
}
