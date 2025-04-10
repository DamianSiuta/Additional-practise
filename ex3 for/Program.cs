using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_for
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczby całkowite a i b (a < b). Oblicz sumę wszystkich liczb podzielnych przez 5 w przedziale [a, b].
            int a, b;
            Console.WriteLine("enter a smaller number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a bigger number: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("error a>b");
                return;
            }

            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
                
            }
            Console.WriteLine($"the sum of all numbers divisible by 5, in the range from {a} to {b} is: {sum}");
        }
        }
    }

