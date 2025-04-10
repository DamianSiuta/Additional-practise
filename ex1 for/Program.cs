using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_for
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj dwie liczby naturalne m i n, gdzie m < n. Wypisz wszystkie liczby parzyste od m do n włącznie. Użyj pętli for.
            int m, n;
            Console.WriteLine("podaj pierwszą mniejszą liczbę: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj drugą większą liczbę: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (m >= n) {
                Console.WriteLine("błąd, druga liczba jest mniejsza lub równa pierwszej");
                    return;
                    }
            Console.WriteLine($"liczby parzyste od {m} do {n}:", m, n);
            for (int i = m; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
