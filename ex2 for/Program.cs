using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_for
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczbę naturalną n (n ≥ 0) i oblicz wartość 3^n (3 do potęgi n) przy pomocy pętli for.
            int n;
            Console.WriteLine("set number (n>=0): ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("error, number lower than 0");
                return;
            }
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                result *=3;
            }
            Console.WriteLine($"3 to the power of {n} is: {result}");


        }
    }
}
