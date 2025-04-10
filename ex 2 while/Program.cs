using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisz program, który wyświetla menu pozwalające obliczać pola powierzchni różnych brył.
            // Program powinien działać do momentu wybrania opcji "0". Użyj pętli do-while.

            int choice;
            do
            {
                Console.WriteLine("1. square");
                Console.WriteLine("2. triangle");
                Console.WriteLine("3. circle");
                Console.WriteLine("0. end");
                Console.Write("your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Length of a= ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"The area of the square is equal to {a * a}");
                        break;

                    case 2:
                        Console.Write("Height h= ");
                        double h = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Length of b= ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"The area of the triangle is equal to {(b * h) / 2}");
                        break;

                    case 3:
                        Console.Write("Length of r= ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"The area of the circle is equal to {Math.PI * r * r}");
                        break;

                    case 0:
                        Console.WriteLine("Closing program");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 0);
            Console.ReadKey();
        }
    }
    }

