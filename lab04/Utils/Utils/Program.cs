using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Упражнение #1
            Console.Write("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());
            int greater = Utils.Greater(x, y);
            Console.WriteLine("Большим из чисел {0} и {1} является {2}", 
                x, y, greater);
            Console.WriteLine();

            // Упражнение #2
            Console.WriteLine("До swap: \t" + x + " " + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После swap: \t" + x + " " + y);
            Console.WriteLine();

            // Упражнение #3
            int f;
            bool ok;
            // Console.Write("Number for factorial: ");
            // x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok)
                Console.WriteLine("Factorial (" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute factorial of {0}", x);
            
        }
    }
}
