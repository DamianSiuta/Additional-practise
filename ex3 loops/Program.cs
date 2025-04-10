using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter number n>1: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine("error");
                return;
            }

            Console.WriteLine($"All prime numbers in the interval [1,{n}]:");

            for (int i = 2; i <= n; i++)  
            {
                bool isPrime = true;

                
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(i + " ");  
                }
            }

            Console.ReadKey();
        }
    }
}