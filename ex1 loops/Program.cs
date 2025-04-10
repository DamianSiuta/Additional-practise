using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczbę naturalną n>0 i oblicz n^ n. Nie można używać funkcji matematycznych.
            int n;
            Console.WriteLine("enter number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("error");
                return;
            }
            int result =1;
            for (int i = 1; i <n; i++)
            {
                result *= n;
            }
            Console.WriteLine($"number {n} to the power of {n} is {result}");
            Console.ReadKey();
        }
    }
}
