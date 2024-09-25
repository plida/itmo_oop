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
        {
            Console.Write("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());
            int greater = Utils.Greater(x, y);
            Console.WriteLine("Большим из чисел {0} и {1} является {2}", 
                x, y, greater);
        }
    }
}
