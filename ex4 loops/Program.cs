using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisz program, który wczytuje liczbę naturalną n i rysuje trójkąt prostokątny z gwiazdek o wysokości n. Użyj pętli while.
            int n;
            Console.WriteLine("set height of triangle:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("error");
                return;
            }
            int i = 1;
            while (i <= n) {
                int j = 1;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                    i++;
            }
            Console.ReadKey();

        }
    }
}
