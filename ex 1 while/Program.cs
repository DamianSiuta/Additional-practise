using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1_while
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisz program, który wczytuje dwie liczby całkowite a i b (a < b) i oblicza sumę kwadratów kolejnych liczb całkowitych od a do b. Użyj pętli while.
            int a, b;
            Console.WriteLine("enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a >= b)
            {
                Console.WriteLine("error");
                return;
            }
            int suma = 0;
            int i = a;
            while (i <= b)
            {
                suma += i * i;
                i++;
            }
            Console.WriteLine($"result= {suma}");
            Console.ReadKey();

        }
    }
}
